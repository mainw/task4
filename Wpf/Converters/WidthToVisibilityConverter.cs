using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace Wpf.Converters
{
    /// <summary>
    /// Пороговый конвертер значений (value [LogicOperator] AllowValue ? DefaultValue : NewValue).
    /// </summary>
    public class WidthToWidthByConditionConverter : IValueConverter
    {
        /// <summary> Значение возвращаемое по умолчанию (при несрабатывании порогового условия).</summary>
        public object DefaultValue { get; set; }

        /// <summary> Значение возвращаемое при выполнении условия.</summary>
        public object NewValue { get; set; }

        /// <summary> Устанавливает значение, с которым происходит сравнение.</summary>
        public double AllowValue { get; set; }
        
        /// <summary> Оператор сравнения (>|<|=).</summary>
        public char LogicOperator { get; set; } = '>';

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double width)
            {
                switch (LogicOperator)
                {
                    case '>':
                        return width > AllowValue ? DefaultValue : NewValue;
                    case '<':
                        return width < AllowValue ? DefaultValue : NewValue;
                    case '=':
                        return width == AllowValue ? DefaultValue : NewValue;
                    default:
                        return DefaultValue;
                }
            }
            return DefaultValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
