using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf.Controls.Forms;

namespace Wpf.Controls.Pages
{
    internal sealed partial class VisitingGroupViewModel
    {
        internal sealed class VisitingGroupCommands
        {
            public ICommand ClearForms { get; }

            public ICommand OrderForms { get; }

            public VisitingGroupCommands(VisitingGroupViewModel vm)
            {
                ClearForms = new DelegateCommand(vm.ClearForms);
                OrderForms = new DelegateCommand(vm.OrderForms);
            }
        }

        private VisitingGroupCommands _commands;

        public VisitingGroupCommands Commands => _commands ?? new VisitingGroupCommands(this);
    }
}
