using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UNDCSCoreApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void CreditsButton_Clicked(object sender, EventArgs e)
        {
            
        }

        private void ToolbarItemNew_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabsPage());
        }
    }
}
