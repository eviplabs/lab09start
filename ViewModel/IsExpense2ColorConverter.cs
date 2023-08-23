using System.Globalization;

namespace LAB09_MAUI_DataBindingLab.ViewModel
{
    public class IsExpense2ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isExpense = (bool)value;
            return isExpense ? Colors.Red : Colors.Green;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
