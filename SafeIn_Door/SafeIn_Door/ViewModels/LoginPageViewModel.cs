using MvvmHelpers;
using MvvmHelpers.Commands;
using SafeIn_Door.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SafeIn_Door.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public string DoorID
        {
            get => door_id; set => SetProperty(ref door_id, value);
        }
        public string ErrorMessage { get => ErrorMessage_; set => SetProperty(ref ErrorMessage_, value); }
        private string ErrorMessage_;
        public string door_id = "";

        public AsyncCommand LoginCommand { get; set; }
        public LoginPageViewModel()
        {
            //to delete
            door_id = "18888871-19ef-4ebd-bc27-d2bfc3b896ef";

            OnPropertyChanged();

            LoginCommand = new AsyncCommand(Login);
        }
        async Task Login()
        {
            var is_valid_id = await DoorID_Validation.Validate_door_id(door_id);
            if (!is_valid_id)
            {
                ErrorMessage = "Invalid input!";
            }
            else
            {
                App.Door_id = door_id;
                var route_ = $"{nameof(MainPage)}";
                await Shell.Current.GoToAsync(route_);
            }
        }
    }
}
