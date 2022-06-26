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
                Bitmap temp = new Bitmap(fullImgPath);
                Bitmap img = (Bitmap)temp.Clone(); // tạo bản sao
                temp.Dispose();
                string shortImgPath = "Images\\" + ID + ".jpg"; // lưu ảnh định dạng ID.jpg
                if (System.IO.File.Exists(shortImgPath))
                    File.Delete(shortImgPath);
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
                return new Bitmap(imgPath);
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
