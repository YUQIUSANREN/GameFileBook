using BookHandlers.FileHandler.UsnOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHandlers.FileHandler
{
    public class FileHandler : BaseHandler
    {
        USNHandler usnHandler = new();
        DriveInfo chooseDrive;
        List<UsnEntry> usnData = new();
        public FileHandler()
        {
            usnData = usnHandler.GetFileList(usnHandler.DrivesNotContainC?.FirstOrDefault()!);
        }
        public FileHandler(string driveName)
        {
            usnData = usnHandler.GetFileList(usnHandler.Drives?.FirstOrDefault(d => d.Name.Contains(driveName))!);
        }
        public void GetAllFilePath() { }
    }
}
