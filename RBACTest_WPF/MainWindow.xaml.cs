using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace RBACTest_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User activeUser = new User();

        User terry = new User("ttrent", (userRights.rights)15);
        User joe = new User("jjoe", userRights.rights.ReadOnly);
        User brian = new User("bbrian", userRights.rights.ReadWrite);
        User chris = new User("cchris", userRights.rights.none);

        private bool readPermission;
        private bool writePermission;
        private bool deletePermission;
        private bool createPermission;

        public MainWindow()
        {
            InitializeComponent();
            populateDropDown();
        }

        private void populateDropDown()
        {
            List<string> users = new List<string>();
            users.Add(terry.Username);
            users.Add(joe.Username);
            users.Add(brian.Username);
            users.Add(chris.Username);

            comboBox.ItemsSource = users;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();
            users.Add("ttrent", terry);
            users.Add("jjoe", joe);
            users.Add("bbrian", brian);
            users.Add("cchris", chris);


            string item = (string) comboBox.SelectedItem;
            activeUser = users[item];

            int activeUserRights = userRights.getRightsNumericvalue(activeUser.Rights);

            readPermission = userRights.checkRights(userRights.rights.read, activeUser.Rights);
            writePermission = userRights.checkRights(userRights.rights.write, activeUser.Rights);
            createPermission = userRights.checkRights(userRights.rights.create, activeUser.Rights);
            deletePermission = userRights.checkRights(userRights.rights.delete, activeUser.Rights);

            setLabelcontent(ReadResults, readPermission.ToString());
            setLabelcontent(WriteResults, writePermission.ToString());
            setLabelcontent(CreateResults, createPermission.ToString());
            setLabelcontent(DeleteResults, deletePermission.ToString());
            setLabelcontent(enumLabel, activeUserRights.ToString());

            enableButton(readPermission, viewAllButton);
            enableButton(writePermission, editSelectedButton);
            enableButton(createPermission, createNewButton);
            enableButton(deletePermission, deleteSelectedButton);


        }

       private void viewAllButton_Click(object sender, RoutedEventArgs e)
        {
            showCorrectMessageBox(readPermission);
        }

        private void createNewButton_Click(object sender, RoutedEventArgs e)
        {
            showCorrectMessageBox(createPermission);
        }

        private void editSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            showCorrectMessageBox(writePermission);
        }

        private void deleteSelectedButton_Click(object sender, RoutedEventArgs e)
        {
            showCorrectMessageBox(deletePermission);
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
