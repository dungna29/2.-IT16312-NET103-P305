using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using BAI_1_2_CRUD_ACCOUNT.IServices;

namespace BAI_1_2_CRUD_ACCOUNT.Services
{
    class FileService:IFileService
    {
        private FileStream _fs;
        private BinaryFormatter _bf;

        public string saveFile<T>(string path, T lstTemp)
        {
            try
            {
                _fs = new FileStream(path, FileMode.OpenOrCreate);
                _bf = new BinaryFormatter();
                _bf.Serialize(_fs,lstTemp);
                _fs.Close();
                return "Ghi file thành công";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _fs.Close();
                return "Ghi file thất bại";
            }

        }

        public List<T> openFile<T>(string path)
        {
            try
            {
                List<T> lstTemp = new List<T>();
                _fs = new FileStream(path, FileMode.Open);
                _bf = new BinaryFormatter();
                var data = _bf.Deserialize(_fs);
                lstTemp = (List<T>) data;
                _fs.Close();
                return lstTemp;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _fs.Close();
                return null;
            }
        }
    } 
}
