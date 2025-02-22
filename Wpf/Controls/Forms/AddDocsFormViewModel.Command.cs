using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf.Controls.Forms
{
	internal sealed partial class AddDocsFormViewModel
	{
		internal sealed class AddDocsFormCommands
		{
			public ICommand LoadFile { get; }

			public AddDocsFormCommands(AddDocsFormViewModel vm)
			{
				LoadFile = new DelegateCommand(vm.LoadFile);
			}
		}

		private AddDocsFormCommands _commands;

		public AddDocsFormCommands Commands => _commands ?? new AddDocsFormCommands(this);
	}
}
