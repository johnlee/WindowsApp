using Services;
using System;
using System.ComponentModel;

namespace WindowsApp
{
    public class FileModel
    {
        private string _filePath;

        public FileModel(string filePath)
        {
            _filePath = filePath;
            if(FileService.Exists(filePath))
            {
                FileContents = FileService.GetNonBinaryContents(filePath);
                ModifiedDate = FileService.GetModifiedTime(filePath);
            }
        }
        
        public string FileContents { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
