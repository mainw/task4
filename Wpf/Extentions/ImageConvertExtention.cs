using System.IO;
using System.Windows.Media.Imaging;

namespace Wpf.Extentions
{
    /// <summary>
    /// Расширение классов BitmapImage и byte[] для конвертации между типами.
    /// </summary>
    public static class ImageConvertExtention
    {
        /// <summary>
        /// Преобразует массив байтов в BitmapImage.
        /// </summary>
        /// <param name="data">Массив байтов, содержащий данные изображения.</param>
        /// <returns>Изображение в формате BitmapImage.</returns>
        public static BitmapImage ToBitmapImage(this byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            BitmapImage bitmapImage = new BitmapImage();
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.EndInit();
            }
            return bitmapImage;
        }

        /// <summary>
        /// Преобразует BitmapImage в массив байтов.
        /// </summary>
        /// <param name="bitmapImage">Изображение в формате BitmapImage.</param>
        /// <returns>Массив байтов, содержащий данные изображения.</returns>
        public static byte[] ToByteArray(this BitmapImage bitmapImage)
        {
            if (bitmapImage == null)
                return null;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                encoder.Save(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
