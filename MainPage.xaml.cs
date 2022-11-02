using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FlowerApp2.Views;
//using FlowerApp2.MarkupExtensions;

namespace FlowerApp2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        
        
        public SetupPage setupPage = new SetupPage();
        public SetupView2 setupView2 = new SetupView2();
        //public ImageResourceExtension imageResourceExtension = new ImageResourceExtension();
       // public EmbeddedImage embeddedImage = new EmbeddedImage();   

        public INavigation Inavigation;

        public MainPage()
        {
            this.InitializeComponent();

            //imgClip.Source = ImageSource.FromFile("Clip1.png");

            //Routing.RegisterRoute(nameof(setupPage), typeof(SetupPage));
            //Routing.RegisterRoute(nameof(setupView2), typeof(SetupView2));
            //INavigationPageController.PushAsync(navigableElement);
           // Content = new StackPanel();
        }

        private async void ButtonClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(setupPage);

        }

        private async void ButtonClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(setupView2);

        }

       /* private async void ButtonClicked3(object sender, EventArgs e)
        {
           // await Navigation.PushAsync(imageResourceExtension);
           // await Navigation.PushAsync(embeddedImage);

        }
       */
    }

}

