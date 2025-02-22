using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf.Extentions
{
    static class MvvmExtention
    {
        public static FrameworkElement WithViewModel<T>(this FrameworkElement view, T viewModel) where T : new ()
        {
            view.DataContext = viewModel;
            return view;
        }
    }
}
