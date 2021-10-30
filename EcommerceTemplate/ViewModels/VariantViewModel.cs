using EcommerceTemplate.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace EcommerceTemplate.ViewModels
{
    public class VariantViewModel : BaseViewModel
    {
        public string Id { get; }

        public string Name { get; }

        public string Value { get; }

        public string VariantId { get; }

        public bool IsAvailable { get; }

        private bool isSelected;
        public bool IsSelected
        {
            get => isSelected;
            set
            {
                SetProperty(ref isSelected, value);
                OnPropertyChanged(nameof(BackgroundColor));
                OnPropertyChanged(nameof(TextColor));
            }
        }

        public Color BackgroundColor
        {
            get
            {
                string keyCardColor = "CardColorLight";
                string keyPrimaryColor = "PrimaryColorLight";

                if (AppInfo.RequestedTheme == AppTheme.Dark)
                {
                    keyCardColor = "CardColorDark";
                    keyPrimaryColor = "PrimaryColorDark";
                }

                return IsSelected ? (Color)Application.Current.Resources[keyPrimaryColor]
                                     : (Color)Application.Current.Resources[keyCardColor];
            }
        }

        public TextDecorations TextDecoration
        {
            get { return IsAvailable ? TextDecorations.None : TextDecorations.Strikethrough; }
        }

        public Color TextColor
        {
            get
            {
                string keyPrimaryTextColor = "PrimaryTextColorLight";
                string keyTextColorOnPrimary = "TextColorOnPrimaryLight";

                if (AppInfo.RequestedTheme == AppTheme.Dark)
                {
                    keyPrimaryTextColor = "PrimaryTextColorDark";
                    keyTextColorOnPrimary = "TextColorOnPrimaryDark";
                }

                return IsAvailable == false ? Color.Gray
                                                : IsSelected ? (Color)Application.Current.Resources[keyTextColorOnPrimary]
                                                    : (Color)Application.Current.Resources[keyPrimaryTextColor];
            }
        }

        public VariantViewModel(Variant variant)
        {

            Id = variant.Id;
            Name = variant.Name;
            Value = variant.Value;
            IsAvailable = variant.IsAvailable;
            IsSelected = variant.IsDefault;
        }
    }
}
