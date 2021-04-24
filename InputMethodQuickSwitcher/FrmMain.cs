using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputMethodQuickSwitcher
{
    public partial class FrmMain : Form
    {
        bool _StatusOnOff = false;
        List<Hook> _KeyboardHookList = new List<Hook>();

        public FrmMain()
        {
            InitializeComponent();
            if (!File.Exists(Consts.CONFIG_FILE)) File.Create(Consts.CONFIG_FILE).Close();
            if (!File.Exists(Consts.KEY_BIND_LIST)) File.Create(Consts.KEY_BIND_LIST).Close();

            // Load input method list
            foreach (InputLanguage iL in InputLanguage.InstalledInputLanguages)
            { LstInputMethod.Items.Add(iL.LayoutName + "," + iL.Culture.Name); }

            if (LstInputMethod.Items.Count > 0)
            { LstInputMethod.SelectedItem = LstInputMethod.Items[0]; }

            // Set auto start
            string onAtStartValue = Config.Read("OnAtStart");
            if (onAtStartValue.Equals(string.Empty))
            {
                Config.Save("OnAtStart", "False");
                ChkOnAtStart.Checked = false;
                _StatusOnOff = false;
            }
            else if (onAtStartValue.Equals("True"))
            {
                ChkOnAtStart.Checked = true;
                _StatusOnOff = true;
                TurnOn();
            }
            else if (onAtStartValue.Equals("False"))
            {
                ChkOnAtStart.Checked = false;
                _StatusOnOff = false;
            }
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            // Set minimize
            string minimizeValue = Config.Read("MinimizeAtStart");
            if (minimizeValue.Equals(string.Empty))
            {
                Config.Save("MinimizeAtStart", "True");
                ChkStartMinimize.Checked = true;
            }
            else if (minimizeValue.Equals("True"))
            {
                ChkStartMinimize.Checked = true;
                WindowState = FormWindowState.Minimized;
                Hide();
            }
            else if (minimizeValue.Equals("False"))
            {
                ChkStartMinimize.Checked = false;
            }
        }

        private void BtnOnOff_Click(object sender, EventArgs e)
        {
            if (!_StatusOnOff) { TurnOn(); }
            else { TurnOff(); }
        }

        private void TurnOn()
        {
            List<string> keyBindList = KeyBind.GetKeyBindList();
            foreach (string keyBind in keyBindList)
            {
                string[] lineStrs = keyBind.Split(',');
                string inputMethod = lineStrs[0];
                string culture = lineStrs[1];
                string keyStr = lineStrs[2];

                Hook keyboardHook = new Hook();
                keyboardHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(Hook_KeyPressed);

                // Register hotkey
                try { keyboardHook.RegisterHotKey(InputMethodQuickSwitcher.ModifierKeys.None, (Keys)Enum.Parse(typeof(Keys), keyStr)); }
                catch(Exception ex) { MessageBox.Show(ex.Message, "Message"); TurnOff(); return; }

                _KeyboardHookList.Add(keyboardHook);
                _StatusOnOff = true;
            }
        }

        private void TurnOff()
        {
            // Unregister all hotkeys
            foreach (Hook keyboardHook in _KeyboardHookList)
            { keyboardHook.Dispose(); }
            _StatusOnOff = false;
        }

        // Hotkey triggered
        void Hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            List<string> keyBindList = KeyBind.GetKeyBindList();
            foreach (string keyBind in keyBindList)
            {
                string[] lineStrs = keyBind.Split(',');
                string inputMethod = lineStrs[0];
                string culture = lineStrs[1];
                string key = lineStrs[2];
                if (key.Equals(e.Key.ToString()))
                {
                    ChangeInputMethod(inputMethod, culture);
                }
            }
        }

        // Change input method
        private void ChangeInputMethod(string inputMethod, string culture)
        {
            foreach (InputLanguage iL in InputLanguage.InstalledInputLanguages)
            {
                if (iL.LayoutName.Equals(inputMethod) && iL.Culture.Name.Equals(culture))
                {
                    InputLanguage.CurrentInputLanguage = iL;
                    string layoutBuf = iL.Handle.ToString("x8");
                    string layout = "0000" + layoutBuf.Substring(layoutBuf.Length - 4, 4);
                    InputMethodQuickSwitcher.Layout.SetKeyboardLayout(layout);
                    break;
                }
            }
        }

        #region Windows Form Events

        private void LstInputMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lstInputMethod = sender as ListBox;
            string[] selectedItem = LstInputMethod.SelectedItem.ToString().Split(',');
            string layoutName = selectedItem[0];
            string culture = selectedItem[1];

            foreach (InputLanguage iL in InputLanguage.InstalledInputLanguages)
            {
                if (iL.LayoutName.Equals(layoutName) && iL.Culture.Name.Equals(culture))
                {
                    LblLayoutNameValue.Text = iL.LayoutName;
                    LblNameValue.Text = iL.Culture.Name;
                    LblEnlgishNameValue.Text = iL.Culture.EnglishName;
                    LblDisplayNameValue.Text = iL.Culture.DisplayName;
                    LblKeyboardLayoutIdValue.Text = iL.Culture.KeyboardLayoutId.ToString();
                    LblCurrentKeyBindValue.Text = KeyBind.GetKeyBind(layoutName, culture);
                    break;
                }
            }
        }

        private void BtnRebind_Click(object sender, EventArgs e)
        {
            string[] inputMethodStrs = LstInputMethod.SelectedItem.ToString().Split(',');
            string inputMethodStr = inputMethodStrs[0];
            string cultureStr = inputMethodStrs[1];
            FrmRebind frmRebind = new FrmRebind(inputMethodStr, cultureStr);
            frmRebind.ShowDialog();
            LblCurrentKeyBindValue.Text = KeyBind.GetKeyBind(inputMethodStr, cultureStr);
        }

        private void LblCurrentBandingValue_Click(object sender, EventArgs e)
        {
            KeyBind.OpenKeyBindWithNotepad();
        }

        private void NoiMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) Hide();
        }

        private void ChkOnAtStart_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkOnAtStart.Checked) Config.Save("OnAtStart", "True");
            else { Config.Save("OnAtStart", "False"); }
        }

        private void ChkStartMinimize_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkStartMinimize.Checked) Config.Save("MinimizeAtStart", "True");
            else { Config.Save("MinimizeAtStart", "False"); }
        }

        private void TimRefresh_Tick(object sender, EventArgs e)
        {
            if (_StatusOnOff)
            {
                BtnOnOff.ForeColor = Color.Green;
                LblStatus.Text = "ON";
            }
            else
            {
                BtnOnOff.ForeColor = Color.Black;
                LblStatus.Text = "OFF";
            }
        }

        private void BtnUnbind_Click(object sender, EventArgs e)
        {
            string[] inputMethodStrs = LstInputMethod.SelectedItem.ToString().Split(',');
            string inputMethodStr = inputMethodStrs[0];
            string cultureStr = inputMethodStrs[1];
            KeyBind.RemoveKeyBind(inputMethodStr, cultureStr);
            LblCurrentKeyBindValue.Text = string.Empty;
        }

        private void toolStripMenuItemShow_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        #endregion Windows Form Events
    }
}
