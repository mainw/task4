using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Extentions;

namespace Wpf.Controls.Forms
{
    internal sealed partial class PassInfoFormViewModel: INotifyPropertyChanged
    {
        #region Data

        private DateTime? _dateStart;
        private DateTime? _dateEnd;
        private List<string> _visitPurpose;
        private string _selectedVisitPurpose;

        #endregion

        #region Property

        public DateTime? DateStart
        {
            get => _dateStart;
            set
            {
                _dateStart = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }
        public DateTime? DateEnd
        {
            get => _dateEnd;
            set
            {
                _dateEnd = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }

        public List<string> VisitPurpose
        {
            get => _visitPurpose;
            set
            {
                _visitPurpose = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }
        public string SelectedVisitPurpose
        {
            get => _selectedVisitPurpose;
            set
            {
                _selectedVisitPurpose = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
