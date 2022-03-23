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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class sevice : Window
    {
        pizzq1Entities context;
        private Client currentRental;

        public sevice(pizzq1Entities context, pizzq1Entities newClient)
        {
            InitializeComponent();
            this.context = context;
            CmbClient.ItemsSource = context.Client.ToList();
            CmbService.ItemsSource = context.Post.ToList();
            this.DataContext = newClient;
        }

        public sevice(pizzq1Entities context, Client currentRental)
        {
            this.context = context;
            this.currentRental = currentRental;
        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }

        private void qweqwe(object sender, RoutedEventArgs e)
        {

        }
    }
}
