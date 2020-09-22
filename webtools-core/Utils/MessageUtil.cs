using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebToolsCore.Utils
{
    public static class MessageUtil
    {
        public static DialogResult ShowMessage(string message, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
            => MessageBox.Show(message, "W3b L1nk", buttons, icon);
    }
}
