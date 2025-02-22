using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using Prism.Commands;

namespace Wpf.Controls.Forms
{
	internal sealed partial class VisitorInfoFormViewModel
	{
		internal sealed class VisitorInfoFormCommands
		{
			public ICommand UploadImage { get; }

			public VisitorInfoFormCommands(VisitorInfoFormViewModel vm)
			{
				UploadImage = new DelegateCommand(vm.UploadImage);
			}
		}

		private VisitorInfoFormCommands _commands;

		public VisitorInfoFormCommands Commands => _commands ?? new VisitorInfoFormCommands(this);
	}
}
