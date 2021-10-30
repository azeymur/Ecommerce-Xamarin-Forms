using System;
using System.Globalization;
using EcommerceTemplate.MaterialDesign;
using Xamarin.Forms;

namespace EcommerceTemplate.Converters
{
    /// <summary>
    /// Binding value converter that returns a full heart for favorite products and an empty heart for others.
    /// <seealso href="https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/data-binding/converters"/>
    /// </summary>
    public class FavoriteConverter : IValueConverter
    {
        /// <param name="value">True for favorite items.</param>
        /// <param name="targetType">Unused</param>
        /// <param name="parameter">Unused</param>
        /// <param name="culture">Unused</param>
        /// <returns>The Unicode string of a Material icon.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Icons.Favorite : Icons.FavoriteOutline;
        }

        /// <summary>
        /// It is unnecessary to implement.
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
