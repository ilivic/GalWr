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

namespace Rostr
{
    /// <summary>
    /// Логика взаимодействия для AddNewPage.xaml
    /// </summary>
    public partial class AddNewPage : Page
    {
        public AddNewPage()
        {
            InitializeComponent();
            ListWr.ItemsSource = App.Connection.Items.ToList();
        }
        /// <summary>
        /// Open Info fo Selecter Warior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAndOpenInfo(object sender, SelectionChangedEventArgs e)
        {
            if (ListWr.SelectedItem != null)
            {
                var DataSelectWr = (ListWr.SelectedItem as Items);
                NavigationService.Navigate(new GalWrPage(DataSelectWr));
            }
        }
    }
}
