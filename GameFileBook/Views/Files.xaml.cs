using System.Diagnostics;
using BookHandlers.FileHandler;
using BookHandlers.FileHandler.UsnOperation;
using GameFileBook.Domain;

namespace GameFileBook.Views
{
    public partial class Files
    {
        long LastUsn = 0;
        ulong LastFrn = 0;
        public Files()
        {
            DataContext = new FilesViewModel();
            InitializeComponent();

            FileBox.Text = $"{"Usn",-10}\t{"ReferenceNumber",-20}\t{"ParentReferenceNumber",-20}\t{"FileName",-50}{"ParentFileName",-50}";
            FileBox.AppendText(Environment.NewLine);
        }
        private void GetFile_Click(object sender, EventArgs e)
        {
            GetFileListBtn.IsEnabled = false;
            //获取上次Usn
            long.TryParse(FileBox.Text, out LastUsn);
            //获取上次FileRefNumber
            ulong.TryParse(FileBox.Text, out LastFrn);

            var usnHandler = new USNHandler();
            var usnData = usnHandler.GetFileList(usnHandler.Drives.FirstOrDefault());

            foreach (var d in usnData)
            {
                FileBox.AppendText(string.Format($"{d.Usn,-10}\t{d.FileReferenceNumber,-20}\t{d.ParentFileReferenceNumber,-20}\t{d.FileName,-50}{usnData.FirstOrDefault(p => p.FileReferenceNumber == d.ParentFileReferenceNumber)?.FileName ?? "",-50}"));
                FileBox.AppendText(Environment.NewLine);
            }
            GetFileListBtn.IsEnabled = true;
        }

    }
}
