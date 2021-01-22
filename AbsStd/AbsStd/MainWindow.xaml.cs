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
using System.Data.SqlClient;
using System.Configuration;

namespace AbsStd
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

        String connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DG_Zone_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_appr_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connect;

            String query = "SELECT * FROM Apprenant";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();

            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows == true)
            {
                while (read.Read())
                {
                    //MessageBox.Show(read[1].ToString());

                }
            }
            else
            {
                MessageBox.Show("table vide");
            }
        }
    }
}
