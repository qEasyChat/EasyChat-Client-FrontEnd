using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EasyChat_Client_FrontEnd
{
    class SafeGUI
    {
        public static void safeAppendText(TextBox textBox, string str)
        {
            if (textBox.Dispatcher.CheckAccess())
            {
                textBox.AppendText(str);
                textBox.AppendText(Environment.NewLine);
                textBox.ScrollToEnd();
            }
            else textBox.Dispatcher.Invoke(new Action<TextBox, string>(safeAppendText), textBox, str);
        }

    }
}
