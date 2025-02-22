using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Wpf.Controls.Pages;
using Wpf.Extentions;

namespace Wpf.Controls
{
    internal sealed partial class MainWindowViewModel : INotifyPropertyChanged
    {
        private object _content;
        private VisitingGroupViewModel _visitingGroupViewModel;

        public object Content
        {
            get => _content;
            set
            {
                if (_content != value)
                {
                    _content = value;
                    PropertyChanged.OnPropertyChanged(this);
                }

            }
        }

        public MainWindowViewModel()
        {
            _visitingGroupViewModel = new VisitingGroupViewModel();
            _content = new VisitingGroup().WithViewModel(_visitingGroupViewModel);
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
