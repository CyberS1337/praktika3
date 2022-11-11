using Session1;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sessia1
{
    /// <summary>
    /// Логика взаимодействия для Autorizacia.xaml
    /// </summary>
    public partial class Autorizacia : Page
    {
        public MainWindow mainWindow;
        string code;
        bool flag = true;

        public Autorizacia(MainWindow _mainwindow)
        {
            InitializeComponent();

            mainWindow = _mainwindow;
        }

        
		private void Number_TextChanged(object sender, TextChangedEventArgs e)
		{
            if (Number.Text.Length > 10)
            {
                DataTable dt_user = mainWindow.Select("SELECT * FROM [User] WHERE [Number] = '" + Number.Text + "'");
                if (dt_user.Rows.Count > 0)
                {
                    Password.IsEnabled = true;
                    Code.IsEnabled = true;
                    SignIn.IsEnabled = true;
                }
				else
				{
                    MessageBox.Show("Данный номер отсутствует в базе данных");
				}
            }
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Password.Text.Length > 0)
            {
                DataTable dt_user = mainWindow.Select("SELECT * FROM [User] WHERE [Number] = '" + Number.Text + "' AND Password = '" + Password.Text + "'");
                if (dt_user.Rows.Count > 0)
                {

                }
            }
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
		{
            if (Password.Text.Length > 0)
			{
                DataTable dt_user = mainWindow.Select("SELECT * FROM [User] WHERE [Number] = '" + Number.Text + "' AND Password = '" + Password.Text + "'");
                if (dt_user.Rows.Count > 0)
				{
                    if (Code.Text == Update(sender, e))
                    {
                        
                        MessageBox.Show("Авторизация прошла успешно");        
					}
                }
            }
        }

        private string Update(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                int[] arr = new int[8];
                Random rnd = new Random();
                string msgcode = "";

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(33, 125);
                    msgcode += (char)arr[i];
                }
                MessageBox.Show(msgcode);
                Clipboard.SetText(msgcode);
                code = msgcode;
                flag = false;
                return code;
            }
			else
			{
                return code;
            }
        }

		private void Cancel_Click(object sender, RoutedEventArgs e)
		{
            Number.Clear();
            Password.Clear();
            Code.Clear();
            SignIn.IsEnabled = false;
		}

		private void Update_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
