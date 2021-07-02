using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1_2_CRUD_ACCOUNT.IServices
{
    public interface IFileService
    {
        //Phương thức lưu file
        string saveFile<T>(string path,T lstTemp);
        //Phương thức đọc file
        List<T> openFile<T>(string path);
    }
}
