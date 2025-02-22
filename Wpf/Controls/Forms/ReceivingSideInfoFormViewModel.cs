using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Extentions;

namespace Wpf.Controls.Forms
{
    internal sealed partial class ReceivingSideInfoFormViewModel : INotifyPropertyChanged
    {
        #region Data

        private string _fio;
        private string _selectedDivision;
        private List<string> _divisions;

        #endregion

        #region Property

        public string FIO
        {
            get => _fio;
            set
            {
                _fio = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }

        public List<string> Divisions
        {
            get => _divisions;
            set
            {
                _divisions = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }

        public string SelectedDivision
        {
            get => _selectedDivision;
            set
            {
                _selectedDivision = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        private void LoadImage()
        {

        }
    }
}
