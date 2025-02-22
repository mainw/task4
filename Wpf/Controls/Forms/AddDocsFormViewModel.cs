using Microsoft.Win32;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Wpf.Controls.Forms
{
    internal sealed partial class AddDocsFormViewModel
    {
        struct FileStory
        {
            public FileInfo FileInfo;
            public byte[] FileData;
        }

        private FileStory _fileStory;

        private void LoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите прикрепляемый файл";
            openFileDialog.Filter = "Pdf файлы (*.pdf)|*.pdf | All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                var fileInfo = new FileInfo(openFileDialog.FileName);
                long fileSizeInBytes = fileInfo.Length;
                string fileSizeInKB = (fileSizeInBytes / 1024).ToString("N2");

                if (true)
                {
                    _fileStory = new FileStory()
                    {
                        FileInfo = fileInfo,
                        FileData = File.ReadAllBytes(openFileDialog.FileName)
                    };
                }
            }
        }
    }
}
