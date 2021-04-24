using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputMethodQuickSwitcher
{
    public partial class FrmRebind : Form
    {
        string _InputMethodStr;
        string _CultureStr;

        public FrmRebind(string inputMethodStr, string cultureStr)
        {
            InitializeComponent();
            _InputMethodStr = inputMethodStr;
            _CultureStr = cultureStr;
        }

        private void FrmRebind_KeyUp(object sender, KeyEventArgs e)
        {
            KeyBind.SaveKeyBind(_InputMethodStr, _CultureStr, e.KeyCode.ToString());
            Dispose();
        }
    }
}
