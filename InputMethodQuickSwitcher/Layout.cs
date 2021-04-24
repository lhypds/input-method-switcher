using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputMethodQuickSwitcher
{
    public class Layout
    {
        // Windows API to get and set keyboard layout
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hwnd, IntPtr proccess);

        [DllImport("user32.dll")]
        static extern IntPtr GetKeyboardLayout(uint thread);

        [DllImport("user32.dll")]
        private static extern long LoadKeyboardLayout(string pwszKLID, uint Flags);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        const int WM_INPUTLANGCHANGEREQUEST = 0x0050;
        const uint KLF_ACTIVATE = 1;

        public static long SetKeyboardLayout(string layoutToLoad)
        {
            int layout = (int)LoadKeyboardLayout(layoutToLoad, KLF_ACTIVATE);
            IntPtr foregroundWindowHandel = GetForegroundWindow();
            PostMessage(foregroundWindowHandel, WM_INPUTLANGCHANGEREQUEST, 2, layout);
            return layout;
        }

        public static int GetSystemKeyboardLayout()
        {
            try
            {
                IntPtr foregroundWindowHandel = GetForegroundWindow();
                uint foregroundProcessId = GetWindowThreadProcessId(foregroundWindowHandel, IntPtr.Zero);
                return GetKeyboardLayout(foregroundProcessId).ToInt32() & 0xFFFF;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Get current keyboard layout error. " + ex.Message, "Message");
                return -1;
            }
        }
    }
}
