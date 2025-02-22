using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf.Controls.Forms
{
    internal sealed partial class VisitorsListInfoFormViewModel
    {
        private List<object> _items;

        public List<object> Items
        {
            get => _items;
            set
            {
                if (_items != value)
                {
                    _items = value;
                }
            }
        }
    }
}
