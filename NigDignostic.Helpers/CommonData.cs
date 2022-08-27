using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NigDignostic.Helpers
{
    public class CommonData
    {
        public static void ClearExistingData()
        {
            string fileName = "ReceivedData.txt";
            string folderName = "NigDignosticSolutionManager";
            string GuarnteedWritePath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string folder = Path.Combine(GuarnteedWritePath, folderName);
            string file = Path.Combine(GuarnteedWritePath, folderName, fileName);
            FileInfo info = new FileInfo(file);
            try
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                if (!File.Exists(file))
                {
                    File.Create(file);
                }
                info.Refresh();
                if (info.CreationTime <= DateTime.Now.AddDays(-1))
                {
                    info.Delete();
                    Directory.Delete(folder);
                    Directory.CreateDirectory(folder);
                    File.Create(file);
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

    }
}
