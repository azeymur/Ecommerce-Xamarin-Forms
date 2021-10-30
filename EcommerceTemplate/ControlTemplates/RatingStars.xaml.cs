using Xamarin.Forms;

namespace EcommerceTemplate.ControlTemplates
{
    /// <summary>
    /// Indicates the level of rating out of five stars.
    /// </summary>
    public partial class RatingStars : ContentView
    {
        public static readonly BindableProperty RatingProperty =
            BindableProperty.Create(nameof(Rating), typeof(float), typeof(RatingStars), 0f);

        public static readonly BindableProperty StarSizeProperty =
            BindableProperty.Create(nameof(StarSize), typeof(double), typeof(RatingStars), 16.0);

        /// <summary>
        /// The rating value to be displayed.
        /// </summary>
        public float Rating
        {
            get => (float)GetValue(RatingProperty);
            set => SetValue(RatingProperty, value);
        }

        /// <summary>
        /// The size of the star icons. Default is 16.
        /// </summary>
        public double StarSize
        {
            get => (double)GetValue(StarSizeProperty);
            set => SetValue(StarSizeProperty, value);
        }

        public RatingStars()
        {
            InitializeComponent();
        }
    }
}
