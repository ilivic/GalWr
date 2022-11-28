using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Rostr
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// This Block Connection fo DataBase SQl 
        /// </summary>
        public static EntitiesMF Connection = new EntitiesMF();
        
        /// <summary>
        /// this Block converter Byte to Image (Bitmap) 
        /// </summary>
        /// <param name="Bytes">byte Array from DataBase</param>
        /// <returns></returns>
        public static BitmapImage ByteToImage(byte[] Bytes)
        {
            using (MemoryStream memoryStream = new MemoryStream(Bytes))
            {
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = memoryStream;
                image.EndInit();
                return image;
            }
        }

    }
}
