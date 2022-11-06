using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Media.Imaging;

namespace Wpf_Kasse_App.DB
{
    public class Helper
    {
        public static Byte[] ImageToByte(Image img)
        {
            Byte[] result = null;
            using (MemoryStream ms = new MemoryStream()) 
            {

                img.Save(ms, ImageFormat.Png);
                result = ms.ToArray();
            }
            return result;

        }

        public static Image ByteToImage ( object bobj)
        {
             Byte[] myImage = (Byte[])bobj;  
             Image image = null;
             using(MemoryStream ms = new MemoryStream(myImage,0,myImage.Length))
             {
                 ms.Write(myImage,0,myImage.Length); 
                 image = Image.FromStream(ms,true);
             }
             return image;

            
        }

        public byte[] getJPGFromImageControl(BitmapImage imageC)
        {
            MemoryStream memStream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);
            return memStream.ToArray();
        }

        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
    }
}
