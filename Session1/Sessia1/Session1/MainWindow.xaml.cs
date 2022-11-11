using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Sessia1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenPage(pages.Autorizacia);
            //MainFrame.Navigate(new Autorizacia());
            Manager.MainFrame = MainFrame;
        }

        public enum pages
		{
            Autorizacia
		}

        void OpenPage (pages pages)
		{
            if (pages == pages.Autorizacia)
			{
                MainFrame.Navigate(new Autorizacia(this));
			}
		}

        public DataTable Select(string selectSQL)
		{
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("server=KHOROSSHEV; Trusted_Connection=Yes; DataBase=NevaTelecom;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
		}
    }
}
