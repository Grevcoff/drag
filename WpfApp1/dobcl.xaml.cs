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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        pizzq1Entities context;
        private Client newClient;
        private main newData;

        public Window2(pizzq1Entities context, pizzq1Entities NewData)
        {
            InitializeComponent();
            this.context = context;
            CmbClient.ItemsSource = context.Client.ToList();
            CmbService.ItemsSource = context.Post.ToList();
            this.DataContext = NewData;
        }



        public Window2(pizzq1Entities context, main newData)
        {
            this.context = context;
            this.newData = newData;
        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }
    }
}
