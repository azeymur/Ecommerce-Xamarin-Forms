using System;
using System.Globalization;
using EcommerceTemplate.MaterialDesign;
using Xamarin.Forms;

namespace EcommerceTemplate.Converters
{
    /// <summary>
    /// Binding value converter that returns a star icon (empty, half, full) corresponding to the rating.
    /// <seealso href="https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/data-binding/converters"/>
    /// </summary>
    public class RatingStarConverter : IValueConverter
    {
        /// <param name="value">Rating value (float).</param>
        /// <param name="targetType">Unused</param>
        /// <param name="parameter">Star position (int).</param>
        /// <param name="culture">Unused</param>
        /// <returns>Unicode string of a Material icon.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            float v = float.Parse(value.ToString()) - float.Parse(parameter.ToString());
            return v < 0.25f ? Icons.StarOutline : v >= 0.25f && v < 0.75 ? Icons.StarHalf : Icons.Star;
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
