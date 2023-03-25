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
        public PopupPage(string PopupText_)
        {
            InitializeComponent();
            PopupText = PopupText_;
            Resultlabel.Text = PopupText;
        }

        private void ClosePopup(object sender, EventArgs e)
        {
            Dismiss(null);
        }
    } }