using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
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
    /// Логика взаимодействия для ListFIgterPage.xaml
    /// </summary>
    public partial class ListFIgterPage : Page
    {
        public static byte[] ImageForDB { get; set; }
        public ListFIgterPage()
        {
            InitializeComponent();
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
        private void SaveNewWrFoDataBase(object sender, RoutedEventArgs e)
        {
            if ((TxtInfo.Text != "") && (TxtName.Text != "") && (TxtParam.Text != "") && (ImageForDB != null))
            {

                Items NewItem = new Items()
                {
                    Name = TxtName.Text,
                    Infos = TxtInfo.Text,
                    Param = TxtParam.Text,
                    facePhoto = ImageForDB
                };
                App.Connection.Items.Add(NewItem);
                App.Connection.SaveChanges();
                MessageBox.Show("Warior Add is OK)) ", "Infomation", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
