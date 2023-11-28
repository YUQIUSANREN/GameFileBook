using BookHandlers.FileHandler.QueryEngine;
using BookHandlers.FileHandler.UsnOperation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static BookHandlers.FileHandler.UsnReader;

namespace BookHandlers.FileHandler
{
    public class USNHandler
    {
        //获取所有NTFS磁盘
        public List<DriveInfo> Drives { get; } = FileQueryEngine.GetReadyNtfsDrives().Where(a => !a.Name.Contains("C")).ToList();
        private List<UsnEntry> usnData = new List<UsnEntry>();
        public List<UsnEntry> GetFileList(DriveInfo driver)
        {
            long LastUsn = 0;
            ulong LastFrn = 0;
            using (UsnOperator uo = new UsnOperator(driver))
            {
                uo.GetEntries(LastUsn, LastFrn, ShowEntries, 3);
            }
            return usnData;
        }
        private void ShowEntries(DriveInfo drive, List<UsnEntry> data)
        {
            if (data != null && data.Count() > 0)
            {
                usnData.AddRange(data);
            }
        }
    }
}
