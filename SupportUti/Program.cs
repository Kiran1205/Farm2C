using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SupportUti
{
    class Program
    {
        static void Main(string[] args)
        {
            string imagepasth = @"E:\Farm2CApi\Farm2CIonic\src\assets\images\chicken.jpg";
           
            using (Image image = Image.FromFile(imagepasth))
            {
                using(MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imagebytes = m.ToArray();

                    string base64 = Convert.ToBase64String(imagebytes);
                }
            }

            Console.ReadKey();
        }
       
    }
}
