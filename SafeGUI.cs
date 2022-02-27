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
            else
            {
                textBox.Dispatcher.Invoke(new Action<TextBox, string>(safeAppendText), textBox, str);
            }
        }

        public static void safeAppendText(Label label, string str)
        {
            if (label.Dispatcher.CheckAccess())
            {
                label.Content += str;
                label.Content += Environment.NewLine;
            }
            else
            {
                label.Dispatcher.Invoke(new Action<TextBox, string>(safeAppendText), label, str);
            }
        }

        
        public static void safeSetText(Label label, string str)
        {
            if (label.Dispatcher.CheckAccess())
            {
                label.Content = str;
            }
            else
            {
                label.Dispatcher.Invoke(new Action<TextBox, string>(safeAppendText), label, str);
            }
        }

        public static void safeRemoveText(Label label, string str)
        {
            if (label.Dispatcher.CheckAccess())
            {
                string content = label.Content.ToString();
                string newContent = content.Replace(str, "");
                label.Content = newContent;
            }
            else
            {
                label.Dispatcher.Invoke(new Action<TextBox, string>(safeAppendText), label, str);
            }
        }

    }
}
