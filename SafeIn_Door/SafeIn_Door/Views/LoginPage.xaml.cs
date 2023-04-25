using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

namespace SafeIn_Door.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            var width = mainDisplayInfo.Width;


            if (width <= 640)
            {
                LogInTitle.FontSize = 30;
                SubmitButton.FontSize = 16;
                SubmitButton.HeightRequest = 50;
                TitleLayout.Height = 280;

                IDLabel.FontSize = 12;

                SubmitButton.Margin = new Thickness(40, 0, 40, 0);

            }
            else if (width <= 768)
            {
                LogInTitle.FontSize = 36;
                SubmitButton.FontSize = 20;
                SubmitButton.HeightRequest = 70;
                TitleLayout.Height = 280;


                SubmitButton.Margin = new Thickness(40, 0, 40, 0);

            }
            else if (width <= 1080)
            {
                LogInTitle.FontSize = 42;

                EnterDoorLabel.FontSize = 24;

                IDLabel.FontSize = 16;

                SubmitButton.FontSize = 24;
                SubmitButton.HeightRequest = 70;
            }
            else
            {
                LogInTitle.FontSize = 44;

                EnterDoorLabel.FontSize = 30;

                IDLabel.FontSize = 20;

                EntryID.FontSize = 18;

                SubmitButton.FontSize = 24;
                SubmitButton.HeightRequest = 70;

                SubmitButton.TextTransform = TextTransform.None;
            }
        }
    }
}