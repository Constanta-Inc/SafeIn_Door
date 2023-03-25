using SafeIn_Door.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SafeIn_Door
{
    public partial class MainPage : ContentPage
    {
        string scan_result = "";
        public MainPage()
        {
            InitializeComponent();
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
