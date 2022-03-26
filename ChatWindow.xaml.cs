using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EasyChat_Client_FrontEnd
{
    /// <summary>
    /// Interaction logic for ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Window
    {
        private const string CHECK_ONLINE_USERS_STRING = "ONLINE USERS";
        private const string CHECK_USER_LIST_CHANGE_STRING = " has";

        private string username;

        private Client client;

        public ChatWindow(Client client, string username)
        {
            InitializeComponent();
            this.username = username;
            this.client = client;
            serverNameLabel.Content = client.get_server_name();
            Thread updateChatBoxWorker = new Thread(updateChatBox);
            updateChatBoxWorker.Start();
        }


        private void updateChatBox()
        {
            while (true)
            {
                string message = this.client.recive_message();
                if (checkOnlineUserList(message) || checkUserListChange(message))
                {
                    continue;
                }
                SafeGUI.safeAppendText(chatBox, message);
            }
        }

        private bool checkOnlineUserList(string message)
        {
            if (message.Contains(CHECK_ONLINE_USERS_STRING))
            {
                int userListStartPosition = CHECK_ONLINE_USERS_STRING.Length + 3;
                string userList = message.Substring(userListStartPosition);
                SafeGUI.safeSetText(userListLabel, userList);
                return true;
            }

            return false;
        }

        private bool checkUserListChange(string message)
        {
            if (message.Contains(CHECK_USER_LIST_CHANGE_STRING))
            {
                int usernameEndPosition = message.IndexOf(CHECK_USER_LIST_CHANGE_STRING);
                string username = message.Substring(0, usernameEndPosition);
                SafeGUI.safeAppendText(userListLabel, username);
                return true;
            }

            return false;
        }

        private void sendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            string message = sendMessageBox.Text;
            client.send_message(message);
            string ownMessage = username + ": " + message;
            SafeGUI.safeAppendText(chatBox, ownMessage);
            sendMessageBox.Text = "";
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
    }
}
