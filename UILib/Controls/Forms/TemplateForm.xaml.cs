using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UILib.Controls.Forms
{
    /// <summary>
    /// Логика взаимодействия для TemplateForm.xaml
    /// </summary>
    public partial class TemplateForm : UserControl
    {
        public TemplateForm()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty HeaderTextProperty =
            DependencyProperty.Register("HeaderText", typeof(string), typeof(TemplateForm),
                new PropertyMetadata(string.Empty));

        // CLR-свойство для доступа к свойству зависимости
        public string HeaderText
        {
            get => (string)GetValue(HeaderTextProperty);
            set
            {
                SetValue(HeaderTextProperty, value);
            }
        }
    }
}
