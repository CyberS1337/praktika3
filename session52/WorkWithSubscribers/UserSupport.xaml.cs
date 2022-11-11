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

namespace WorkWithSubscribers
{
    /// <summary>
    /// Логика взаимодействия для UserSupport.xaml
    /// </summary>
    public partial class UserSupport : Page
    {
        List<Application> users = new List<Application>();
        List<Sub> items = new List<Sub>();

        public UserSupport()
        {
            InitializeComponent();
            users = TeleconNevaEntities.GetContext().Applications.ToList();
            items = TeleconNevaEntities.GetContext().Subs.ToList();
            DGridAp.ItemsSource = users;
            foreach (var item in items)
            {
                UsersComboBox.Items.Add(item.ФИО);
            }
        }

        private void UsersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Работа с заявкой пользователя " + Convert.ToString(items[UsersComboBox.SelectedIndex].ФИО) + " проведена");
        }

        private void DataGridCell_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Выбранны работник отправлен на выезд");
        }
    }
}
