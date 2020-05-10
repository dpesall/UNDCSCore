using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNDCSCoreApp.Classes._400;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UNDCSCoreApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabsPage : ContentPage
    {
        public TabsPage()
        {
            InitializeComponent();
        }

        private void ToolbarItemNew_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabsPage());
        }

        private void MainButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void ClassButton_Clicked(object sender, EventArgs e)
        {
            ClassesStack.IsVisible = !ClassesStack.IsVisible;
        }
        private void OneButton_Clicked(object sender, EventArgs e)
        {
            OneStack.IsVisible = !OneStack.IsVisible;
        }

        private void TwoButton_Clicked(object sender, EventArgs e)
        {
            TwoStack.IsVisible = !TwoStack.IsVisible;
        }

        private void ThreeButton_Clicked(object sender, EventArgs e)
        {
            ThreeStack.IsVisible = !ThreeStack.IsVisible;
        }

        private void FourButton_Clicked(object sender, EventArgs e)
        {
            FourStack.IsVisible = !FourStack.IsVisible;
        }

        private void Nav451Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CS451Page());
        }
    }
}