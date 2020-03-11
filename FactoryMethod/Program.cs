using System;

namespace FactoryMethod
{
    interface ImageReader
    {
        DecodedImage getDecodeImage();
    }

    class DecodedImage
    {
        private string image;

        public DecodedImage(string image)
        {
            this.image = image;
        }

        public string toString()
        {
            return image + ": is decoded";
        }
    }

    class GifReader : ImageReader
    {
        private DecodedImage decodedImage;

        public GifReader(string image)
        {
            this.decodedImage = new DecodedImage(image);
        }

        public DecodedImage getDecodeImage()
        {
            return decodedImage;
        }
    }

    class JpegReader : ImageReader
    {
        private DecodedImage decodedImage;

        public JpegReader(string image)
        {
            decodedImage = new DecodedImage(image);
        }

        public DecodedImage getDecodeImage()
        {
            return decodedImage;
        }
    }

    public class FactoryMethodDemo
    {
        public static void Main(string[] args)
        {
            DecodedImage decodedImage;
            ImageReader reader = null;
            string image = args[0];
            string format = image.Substring(image.IndexOf('.') + 1);

            if (format.Equals("gif"))
            {
                reader = new GifReader(image);
            }
            if (format.Equals("jpeg"))
            {
                reader = new JpegReader(image);
            }
            if (reader != null)
            {
                decodedImage = reader.getDecodeImage();
                Console.WriteLine(decodedImage);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }

}
