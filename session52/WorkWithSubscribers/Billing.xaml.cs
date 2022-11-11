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
    /// Логика взаимодействия для Billing.xaml
    /// </summary>
    public partial class Billing : Page
    {
        public Billing()
        {
            InitializeComponent();
            DGridTariff.ItemsSource = TeleconNevaEntities.GetContext().Тарифы2_.ToList();
            DGridPayment.ItemsSource = TeleconNevaEntities.GetContext().Payments.ToList();
            Serch.Items.Add("Интернет");
            Serch.Items.Add("Видеонаблюдение");
            Serch.Items.Add("Телевидение");
            Serch.Items.Add("Мобильная связь");
            Serch.Items.Add("Интернет и телефидение");
            Serch.Items.Add("Интернет, телефидение и видео наблюдение");
            DateNow.Items.Add("5.17.2022");
            DateNow.Items.Add("6.17.2022");
            DateNow.Items.Add("7.17.2022");
            DateNow.Items.Add("8.17.2022");
            DateNow.Items.Add("9.17.2022");
            DateNow.Items.Add("10.17.2022");
        }

        private void Otchet_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Отчет свормирован");
        }
    }
}
