using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SafeIn_Door.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupPage : Popup
    {
        private static string PopupText;
        private static string ErrorText;

        public PopupPage(string PopupText_, string ResultText_)
        {
            this.BackgroundColor = new Color(0, 0, 0, 0.4);
            InitializeComponent();
            PopupText = PopupText_;
            Resultlabel.Text = PopupText;
            ErrorText = ResultText_;
            ResultErrorLabel.Text = ErrorText;
            ResultErrorLabel.TextColor = Color.Red;
            if (ErrorText == "Success!")
            {
                ResultErrorLabel.TextColor = Color.Lime;
            }
           
        }

        private void ClosePopup(object sender, EventArgs e)
        {
            Dismiss(null);
        }
    } }