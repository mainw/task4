using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf.Controls.Forms;
using Wpf.Extentions;

namespace Wpf.Controls.Pages
{
    internal sealed partial class VisitingIndividualViewModel : INotifyPropertyChanged
    {
        #region Data

        private AddDocsFormViewModel _addDocsFormViewModel;
        private VisitorInfoFormViewModel _visitorInfoFormViewModel;
        private PassInfoFormViewModel _passInfoFormViewModel;
        private ReceivingSideInfoFormViewModel _receivingSideInfoFormViewModel;

        #endregion

        #region Properties

        public AddDocsFormViewModel AddDocsFormViewModel
        {
            get => _addDocsFormViewModel;
            set
            {
                _addDocsFormViewModel = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }

        public VisitorInfoFormViewModel VisitorInfoFormViewModel
        {
            get => _visitorInfoFormViewModel;
            set
            {
                _visitorInfoFormViewModel = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }

        public PassInfoFormViewModel PassInfoFormViewModel
        {
            get => _passInfoFormViewModel;
            set
            {
                _passInfoFormViewModel = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }

        public ReceivingSideInfoFormViewModel ReceivingSideInfoFormViewModel
        {
            get => _receivingSideInfoFormViewModel;
            set
            {
                _receivingSideInfoFormViewModel = value;
                PropertyChanged.OnPropertyChanged(this);
            }
        }

        #endregion

        #region .ctor

        public VisitingIndividualViewModel()
        {
            AddDocsFormViewModel = new AddDocsFormViewModel();
            VisitorInfoFormViewModel = new VisitorInfoFormViewModel();
            PassInfoFormViewModel = new PassInfoFormViewModel();
            ReceivingSideInfoFormViewModel = new ReceivingSideInfoFormViewModel();
        }

        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        private void ClearForms()
        {

        }
        private void OrderForms()
        {

        }

        #endregion
    }
}
