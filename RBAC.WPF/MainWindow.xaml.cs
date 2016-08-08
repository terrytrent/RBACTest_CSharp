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
using RBAC.Biz;
using RBAC.Common;

namespace RBAC.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SimulateLogin simulatedLogin = new SimulateLogin();
        
        public MainWindow()
        {
            InitializeComponent();
            populateDropDown();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void viewAllButton_Click(object sender, RoutedEventArgs e)
        {
            showCorrectMessageBox(simulatedLogin.ReadPermission);
        }

        private void createNewButton_Click(object sender, RoutedEventArgs e)
        {
            showCorrectMessageBox(simulatedLogin.CreatePermission);
        }

        private void editSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            showCorrectMessageBox(simulatedLogin.WritePermission);
        }

        private void deleteSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            showCorrectMessageBox(simulatedLogin.DeletePermission);
        }

        private void populateDropDown()
        {
            List<string> users = new List<string>();
            foreach (KeyValuePair<string, User> userDictionary in simulatedLogin.SimulatedUsers)
            {
                User user = userDictionary.Value;
                users.Add(user.Username);
            }

            comboBox.ItemsSource = users;
        }

        private void showDeniedMsgBox()
        {
            MessageBox.Show("DENIED", "Denied", MessageBoxButton.OK, MessageBoxImage.Stop);
        }

        private void showApprovedMsgBox()
        {
            MessageBox.Show("APPROVED", "Approved", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void showCorrectMessageBox(bool rightPermission)
        {
            if (rightPermission)
            {
                showApprovedMsgBox();
            }
            else
            {
                showDeniedMsgBox();
            }
        }

        private void setLabelcontent(Label label, string content)
        {
            label.Content = content;
        }

        private void enableButton(bool permission, Button button)
        {
            if (!permission)
            {
                button.IsEnabled = false;
                button.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                button.IsEnabled = true;
                button.Visibility = System.Windows.Visibility.Visible;
            }
        }

    }
}
