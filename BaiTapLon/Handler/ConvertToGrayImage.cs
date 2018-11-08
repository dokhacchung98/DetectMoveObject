using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.Handler
{
    public class ConvertToGrayImage{
        public static Bitmap ConvertToGrayScaleImage(Bitmap originalBitmap)
        {

            // A blank bitmap is created having same size as original bitmap image.

            Bitmap GrayScaleBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);



            // Initializing a graphics object from the new image bitmap.

            Graphics graphics = Graphics.FromImage(GrayScaleBitmap);



            // Creating the Grayscale ColorMatrix whose values are determined by

            // calculating the luminosity of a color, which is a weighted average of the

            // RGB color components. The average is weighted according to the sensitivity

            // of the human eye to each color component. The weights used here are as

            // given by the NTSC (North America Television Standards Committee)

            // and are widely accepted.

            ColorMatrix colorMatrix = new ColorMatrix(new float[][]

            {

                new float[] { 0.299f, 0.299f, 0.299f, 0, 0 },

                new float[] { 0.587f, 0.587f, 0.587f, 0, 0 },

                new float[] { 0.114f, 0.114f, 0.114f, 0, 0 },

                new float[] { 0,      0,      0,      1, 0 },

                new float[] { 0,      0,      0,      0, 1 }

            });



            // Creating image attributes.

            ImageAttributes attributes = new ImageAttributes();



            // Setting the color matrix attribute.

            attributes.SetColorMatrix(colorMatrix);



            // Drawing the original bitmap image on the new bitmap image using the

            // Grayscale color matrix.

            graphics.DrawImage(originalBitmap, new Rectangle(0, 0, originalBitmap.Width,

                originalBitmap.Height), 0, 0, originalBitmap.Width,

                originalBitmap.Height, GraphicsUnit.Pixel, attributes);



            // Disposing the Graphics object.

            graphics.Dispose();

            return GrayScaleBitmap;

        }
    }
}
