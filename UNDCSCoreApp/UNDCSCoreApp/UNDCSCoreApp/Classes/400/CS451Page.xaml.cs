using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UNDCSCoreApp.Classes._400
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CS451Page : ContentPage
    {
        public CS451Page()
        {
            InitializeComponent();
        }

        private void LinuxTerminalButton_Clicked(object sender, EventArgs e)
        {
            LinuxBody.IsVisible = !LinuxBody.IsVisible;
        }

        private void TermDefinitonsButton_Clicked(object sender, EventArgs e)
        {
            TermDefinitionBody.IsVisible = !TermDefinitionBody.IsVisible;
        }

        private void ProgrammingConceptsButton_Clicked(object sender, EventArgs e)
        {
            ProgrammingConceptsBody.IsVisible = !ProgrammingConceptsBody.IsVisible;
        }

        private void ThreadsButton_Clicked(object sender, EventArgs e)
        {
            ThreadsBody.IsVisible = !ThreadsBody.IsVisible;
        }

        private void SemaphoresButton_Clicked(object sender, EventArgs e)
        {
            SemaphoresBody.IsVisible = !SemaphoresBody.IsVisible;
        }

        private void ForkButton_Clicked(object sender, EventArgs e)
        {
            ForkBody.IsVisible = !ForkBody.IsVisible;
        }

        private void MutexButton_Clicked(object sender, EventArgs e)
        {
            MutexBody.IsVisible = !MutexBody.IsVisible;
        }

        private void PipesButton_Clicked(object sender, EventArgs e)
        {
            PipesBody.IsVisible = !PipesBody.IsVisible;
        }
    }
}