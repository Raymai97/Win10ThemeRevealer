using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Win10ThemeRevealer
{
    class Win32
    {

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetProcessDPIAware();

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern uint ExtractIconEx(string szFileName, int nIconIndex,
           IntPtr[] phiconLarge, IntPtr[] phiconSmall, uint nIcons);

        #region SendMessage API

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, ref COPYDATASTRUCT lParam);
        [DllImport("user32.dll")]
        public static extern bool InSendMessage();
        [DllImport("user32.dll")]
        public static extern bool ReplyMessage(IntPtr lResult);

        public const int WM_COPYDATA = 0x004A;

        [StructLayout(LayoutKind.Sequential)]
        public struct COPYDATASTRUCT
        {
            /// <summary>
            /// Pointer of sender (so receiver can send back)
            /// </summary>
            public IntPtr dwData;
            /// <summary>
            /// Count of Bytes
            /// </summary>
            public int cbData;
            /// <summary>
            /// Pointer of a byte array
            /// </summary>
            public IntPtr lpData;
        }

        public static void _SendMessage(string msg, IntPtr target)
        {
            byte[] b = Encoding.UTF8.GetBytes(msg);
            IntPtr hLog = Marshal.AllocHGlobal(b.Length);
            Marshal.Copy(b, 0, hLog, b.Length);
            COPYDATASTRUCT data = new COPYDATASTRUCT();
            data.cbData = b.Length;
            data.lpData = hLog;
            SendMessage(target, WM_COPYDATA, 0, ref data);
        }

        public static string _GetMessage(System.Windows.Forms.Message m)
        {
            string msg = null;
            if (m.Msg == Win32.WM_COPYDATA)
            {
                if (InSendMessage()) ReplyMessage(IntPtr.Zero);
                COPYDATASTRUCT data = (COPYDATASTRUCT)m.GetLParam(typeof(COPYDATASTRUCT));
                byte[] b = new byte[data.cbData];
                Marshal.Copy(data.lpData, b, 0, data.cbData);
                msg = Encoding.UTF8.GetString(b);
            }
            return msg;
        }

        #endregion

        #region Set form's large and small icon explicitly

        const int WM_SETICON = 0x80;
        const int ICON_SMALL = 0;
        const int ICON_BIG = 1;

        public static void SetFormIcon(IntPtr hWnd, string IconPath, int IconIndex = 0)
        {
            uint IconCount = (uint)(IconIndex) + 1;
            IntPtr[] hSmallIcon = new IntPtr[IconCount];
            IntPtr[] hLargeIcon = new IntPtr[IconCount];
            ExtractIconEx(IconPath, IconIndex, hLargeIcon, hSmallIcon, IconCount);
            SendMessage(hWnd, WM_SETICON, ICON_BIG, hLargeIcon[IconIndex]);
            SendMessage(hWnd, WM_SETICON, ICON_SMALL, hSmallIcon[IconIndex]);
        }

        #endregion
    }
}
