using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf.Controls.Pages
{
    internal sealed partial class VisitingIndividualViewModel
    {
        internal sealed class VisitingIndividualCommands
        {
            public ICommand ClearForms { get; }

            public ICommand OrderForms { get; }

            public VisitingIndividualCommands(VisitingIndividualViewModel vm)
            {
                ClearForms = new DelegateCommand(vm.ClearForms);
                OrderForms = new DelegateCommand(vm.OrderForms);
            }
        }

        private VisitingIndividualCommands _commands;

        public VisitingIndividualCommands Commands => _commands ?? new VisitingIndividualCommands(this);
    }
}
