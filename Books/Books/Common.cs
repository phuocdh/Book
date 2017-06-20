using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Common
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public static string GetNextID(string id)
        {
            return id.Substring(0, 2) + (int.Parse(id.Substring(2)) + 1).ToString("D3");
        }
    }
}
