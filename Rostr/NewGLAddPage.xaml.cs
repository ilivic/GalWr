using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для NewGLAddPage.xaml
    /// </summary>
    public partial class NewGLAddPage : Page
    {
        public static byte[] ImageForDB { get; set; }
        public NewGLAddPage()
        {
            InitializeComponent();
            CMBListWr.ItemsSource = App.Connection.Items.ToList();
        }
        /// <summary>
        /// Select New Photo And COnfirt to Byte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectNewImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != null)
            {
                ImageForDB = File.ReadAllBytes(dialog.FileName);
                MessageBox.Show("Photo Add is OK)) ", "Infomation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        /// <summary>
        /// Save New Photo Items Fo DataBase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveNewImageFoDB(object sender, RoutedEventArgs e)
        {
            if ((TxtTitle.Text != "") && (ImageForDB != null))
            {

                GaleItem NewItem = new GaleItem()
                {
                    Title = TxtTitle.Text,
                    Photo = ImageForDB,
                    User_id = (CMBListWr.SelectedItem as Items).id_item
                };
                App.Connection.GaleItem.Add(NewItem);
                App.Connection.SaveChanges();
                MessageBox.Show("Warior Photo Add is OK)) ", "Infomation", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }
    }
}
