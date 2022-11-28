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
    /// Логика взаимодействия для GalWrPage.xaml
    /// </summary>
    public partial class GalWrPage : Page
    {
        /// <summary>
        /// Init Data Fo Info form
        /// </summary>
        /// <param name="items"></param>
        public GalWrPage(Items items)
        {
            InitializeComponent();
            ImageWr.Source = App.ByteToImage(items.facePhoto);
            TxtInfoWr.Text = items.Infos;
            TxtNameWr.Text = items.Name;
            TxtParamWr.Text = items.Param;
            ListWr.ItemsSource = App.Connection.GaleItem.Where(z => z.User_id == items.id_item).ToList();
        }
    }
}
