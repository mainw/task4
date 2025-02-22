using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf.Controls.Pages;

namespace Wpf.Controls.Forms
{
    internal sealed partial class ReceivingSideInfoFormViewModel
    {
        internal sealed class ReceivingSideInfoFormCommands
        {
            public ICommand LoadImage { get; }

            public ReceivingSideInfoFormCommands(ReceivingSideInfoFormViewModel vm)
            {
                LoadImage = new DelegateCommand(vm.LoadImage);
            }
        }

        private ReceivingSideInfoFormCommands _commands;

        public ReceivingSideInfoFormCommands Commands => _commands ?? new ReceivingSideInfoFormCommands(this);
    }
}
