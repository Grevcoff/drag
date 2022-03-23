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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        pizzq1Entities context;
        public Window1()
        {
            InitializeComponent();
            context = new pizzq1Entities();
            ShowTable();
        }

        private void ShowTable()
        {
            DataGridMain.ItemsSource = context.main.ToList();
        }

        private void BtnAddData_Click_1(object sender, RoutedEventArgs e)
        {
            var NewData = new main();
            context.main.Add(NewData);
            var btnAddClientServ2 = new Window2(context, NewData);
            btnAddClientServ2.ShowDialog();
        }

        private void BtnDeleteData_Click_1(object sender, RoutedEventArgs e)
        {
            var currentMain = DataGridMain.SelectedItem as main;
            if (currentMain == null)
            {
                MessageBox.Show("Выберите строку!");
                return;

            }
            MessageBoxResult messageBoxResult = MessageBox.Show("удалить?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                context.main.Remove(currentMain);
                context.SaveChanges();
                ShowTable();
            }
        }

        private void BtnEditData_Click_1(object sender, RoutedEventArgs e)
        {
            Button BtnEdit = sender as Button;
            var currentRental = BtnEdit.DataContext as Client;
            var EdiWindow = new sevice(context, currentRental);
            EdiWindow.ShowDialog();
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            var RentalSel = new addcl();
            RentalSel.ShowDialog();
        }

        private void DataGridClientService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGridClientService_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGridMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
