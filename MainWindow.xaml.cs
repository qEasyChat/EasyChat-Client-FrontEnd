using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EasyChat_Client_FrontEnd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void runServerButton_Click(object sender, RoutedEventArgs e)
        {
            welcomeGrid.Visibility = Visibility.Hidden;
            startServerGrid.Visibility = Visibility.Visible;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/qEasyChat");
        }

        private void serverNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            serverNameTextBox.Text = "";
        }

        private void portNumberTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            portNumberTextBox.Text = "";
        }

        private void connectButton_Click(object sender, RoutedEventArgs e)
        {
            string serverIP = serverNameTextBox.Text;
            string portString = portNumberTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            int port = Int32.Parse(portString);
            try
            {
                Client client = new Client(port, serverIP);
                client.connect_and_auth(username, password);
                MessageBox.Show(client.recive_message());
                client.send_message("asd");

                MessageBox.Show("Server started successfully.");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                MessageBox.Show(exception.InnerException.Message);
            }
        }
    }
}
