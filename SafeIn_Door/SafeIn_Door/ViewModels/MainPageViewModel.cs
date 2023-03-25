using MvvmHelpers;
using MvvmHelpers.Commands;
using SafeIn_Door.Services;
using SafeIn_Door.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace SafeIn_Door.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {

        private string scanResult = "";
        public string AlertText { get => AlertText_; set => SetProperty(ref AlertText_, value); }

        public static string AlertText_ = "";
        public string ScanResult
        {
            get { return scanResult; }
            set => SetProperty(ref scanResult, value);

        }
        public AsyncCommand DoorTryCommand { get; set; }
        public AsyncCommand PopupCloseCommand { get; set; }
        IDoorService door_service;

        public void ProcessScanResult(string scanResult_)
        {
            ScanResult = scanResult_;
        }
        public MainPageViewModel()
        {
            DoorTryCommand = new AsyncCommand(DoorTry);
            door_service = DependencyService.Get<IDoorService>();
        }
   
        async Task DoorTry()
        {
            if (scanResult == "")
            {
                AlertText = "Scan a QR code!";
            }
            else
            {
                var DoorTryResult = await door_service.DoorOpen(App.Door_id, ScanResult);
                if (!DoorTryResult.ISSuccess)
                {
                    AlertText = DoorTryResult.ErrorMessage;
                }
                else
                {
                    AlertText = "Unlocked!";
                }
            }
            Shell.Current.ShowPopup(new PopupPage(AlertText) {});

            scanResult = "";

        }
       
    }
}
