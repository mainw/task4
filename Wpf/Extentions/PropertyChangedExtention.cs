using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Wpf.Extentions
{
    /// <summary>
    /// Расширение класса PropertyChangedEventHandler.
    /// </summary>
    public static class PropertyChangedExtention
    {
        /// <summary>
        /// Оповещает о изменении свойства.
        /// </summary>
        /// <param name="PropertyChanged"></param>
        /// <param name="sender">this экземпляр реализации INotifyPropertyChanged, для которого обрабатывается изменение.</param>
        /// <param name="propertyName">Имя изменяемого свойства, по умолчанию принимает значение по атрибуту [CallerMemberName].</param>
        static public void OnPropertyChanged(this PropertyChangedEventHandler PropertyChanged, object sender, [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs(propertyName));
        }
    }
}
