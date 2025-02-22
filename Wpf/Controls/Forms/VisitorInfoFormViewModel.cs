using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using Wpf.Extentions;

namespace Wpf.Controls.Forms
{
    /// <summary>
    /// 
    /// </summary>
    internal sealed partial class VisitorInfoFormViewModel : INotifyPropertyChanged
    {
        #region Data

        private string _secondName;
        private string _firstName;
        private string _patronumic;
        private string _phone;
        private string _email;
        private string _organization;
        private string _addition;
        private string _passportSeria;
        private string _passportNumber;
        private DateTime? _dateBorn;
        private BitmapImage _personalBitmapImage;

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties
        public string SecondName
        {
            get => _secondName;
            set
            {
                _secondName = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }
        public string Patronumic
        {
            get => _patronumic;
            set
            {
                _patronumic = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }
        public string Organization
        {
            get => _organization;
            set
            {
                _organization = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }
        public string Addition
        {
            get => _addition;
            set
            {
                _addition = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }
        public string PassportSeria
        {
            get => _passportSeria;
            set
            {
                _passportSeria = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }
        public string PassportNumber
        {
            get => _passportNumber;
            set
            {
                _passportNumber = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }
        public DateTime? DateBorn
        {
            get => _dateBorn;
            set
            {
                _dateBorn = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }
        public BitmapImage PersonalBitmapImage
        {
            get => _personalBitmapImage;
            set
            {
                _personalBitmapImage = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }
        #endregion

        #region Methods

        private void UploadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Выберите изображение, где четко видно ваше лицо";
            openFileDialog.Filter = "Рисунки (jpg, png, jpeg)|*.jpg;*.png;*.jpeg";
            if (openFileDialog.ShowDialog() == true)
                PersonalBitmapImage = File.ReadAllBytes(openFileDialog.FileName).ToBitmapImage();
        }

        #endregion

    }
}
