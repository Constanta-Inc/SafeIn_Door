using SafeIn_Door.ViewModels;
using System;
using System.Diagnostics;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SafeIn_Door
{
    public partial class MainPage : ContentPage
    {
        string scan_result = "";

        public MainPage()
        {
            InitializeComponent();
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            var width = mainDisplayInfo.Width;
            double fontSize = 0, ButtonFontSize = 0, ButtonHeightRequest = 0;
            

            if (width <= 640)
            {
                fontSize = 30;
                ButtonFontSize = 16;
                ButtonHeightRequest = 40;

                Camera.Margin = new Thickness(40, 30, 40, 0);
                TryButton.Margin = new Thickness(40, 0, 40, 0);

            }
            else if (width <= 768)
            {
                fontSize = 36;
                ButtonFontSize = 20;
                ButtonHeightRequest = 50;

                Camera.Margin = new Thickness(40, 30, 40, 0);
                TryButton.Margin = new Thickness(40, 0, 40, 0);

            }
            else if (width <= 1080)
            {
                fontSize = 42;
                ButtonFontSize = 24;
                ButtonHeightRequest = 70;
            }
            else
            {
                fontSize = 46;
                ButtonFontSize = 24;
                ButtonHeightRequest = 70;
            }

            TryButton.FontSize = ButtonFontSize;
            TryButton.HeightRequest = ButtonHeightRequest;
            ScanLabel.FontSize = fontSize;    
        }

        void ZXingScannerView_OnScanResult(ZXing.Result result)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                scan_result = result.Text;

                (BindingContext as MainPageViewModel)?.ProcessScanResult(scan_result);
            });
        }

        
    }
}
