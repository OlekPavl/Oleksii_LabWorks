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
using System.Data;
using System.Data.SqlClient;

namespace LabWork_4_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        public MainWindow()
        {
            InitializeComponent();
            button1.Background = new SolidColorBrush(Colors.Blue);

        }

        private void button1_Click()
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            table.Clear();
            
            adapter.Fill(table);
            grid1.ItemsSource = table.DefaultView;
        }

        private void anotherWindow_Click(object sender, RoutedEventArgs e)
        {
            Window1 wind1 = new Window1();
            wind1.Owner = this;
            wind1.Show();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = TECT_DATASETS_DB.MDF;Integrated Security=True;";
            string sql = "SELECT * FROM courses";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            
                table = new DataTable();

                adapter.Fill(table);
                grid1.AutoGenerateColumns = true;
                grid1.DataContext = table.DefaultView;
            }
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=localhost;Initial Catalog = TECT_DATASETS_DB.MDF;Integrated Security=True;";
            string sql = "SELECT * FROM courses";
            // Создание подключения
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                table = new DataTable();

                adapter.Fill(table);
                grid1.AutoGenerateColumns = true;
                grid1.DataContext = table.DefaultView;
            }
        }
    }
}
