using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL
{
    internal class ImageHandle
    {
        // copy ảnh vào bin và trả về short path
        public static string SaveImage(string fullImgPath, string ID)
        {
            try
            {
                if (fullImgPath == null)
                    return null;
                Image temp = GetImage(fullImgPath);
                string shortImgPath = "Images\\" + ID + ".jpg"; // lưu ảnh định dạng ID.jpg
                Bitmap img = new Bitmap(temp); // lưu bằng bitmap để tránh lỗi GDI+
                img.Save(shortImgPath);
                return shortImgPath;
            }
            catch (System.ArgumentException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // lấy ảnh từ path
        public static Image GetImage(string imgPath)
        {
            try
            {
                Image image = null;
                using (FileStream fs = new FileStream(imgPath, FileMode.Open))
                {
                    image = Image.FromStream(fs);
                    fs.Close();
                }
                return image;
            }
            catch (System.ArgumentException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        // Xóa ảnh
        public static bool DeleteImage(string imgPath)
        {
            bool result = false;
            try
            {
                System.IO.File.Delete(imgPath);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
