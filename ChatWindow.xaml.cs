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
                SafeGUI.safeAppendText(chatBox, message);
            }
        }

        private void sendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            string message = sendMessageBox.Text;
            client.send_message(message);
            string ownMessage = username + ": " + message;
            SafeGUI.safeAppendText(chatBox, ownMessage);
        }
    }
}
