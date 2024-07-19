using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYeni.İmage
{
    public class imgClass
    {
        public static byte[] ImageToByteArray(Image theImage)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                theImage.Save(memoryStream, theImage.RawFormat);
                return memoryStream.ToArray();
            }
        }

        public static byte[] ImageToByteArray2(List<Image> images)
        {
            List<byte[]> imageByteList = new List<byte[]>();
            foreach (var image in images)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    imageByteList.Add(ms.ToArray());
                }
            }
            return imageByteList.SelectMany(byteArray => byteArray).ToArray();
        }

        public static Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
    }
}
