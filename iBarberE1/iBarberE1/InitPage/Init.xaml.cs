using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ZXing.Net.Mobile.Forms;


namespace iBarberE1.InitPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Init : ContentPage
	{

        ZXingScannerPage scanPage;

        public Init ()
		{
            InitializeComponent();


            var tapQrCodeButton = new TapGestureRecognizer();
            var tapRLButtonOk = new TapGestureRecognizer();

            //Binding events    
            tapQrCodeButton.Tapped += QrCodeButton_Tapped;
            tapRLButtonOk.Tapped += RLButtonOk_Tapped;

            //Associating tap events to the image buttons    
            QrCodeButton.GestureRecognizers.Add(tapQrCodeButton);
            RLButtonOk.GestureRecognizers.Add(tapRLButtonOk);

        }


        private async void QrCodeButton_Tapped(object sender, EventArgs args)
        {
            scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) => {
                scanPage.IsScanning = false;

                //Do something with result
                Device.BeginInvokeOnMainThread(() => {
                    EntryCode.Text = result.Text;
                    Navigation.PopModalAsync();
                    DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };

            

            await Navigation.PushModalAsync(scanPage);
        }



        void RLButtonOk_Tapped(object sender, EventArgs  args)
        {
            App.Current.MainPage = new MainPage.Main();
        }



        private void LoginButton(object sender, EventArgs args)
        {
            DisplayAlert("Entrou", "LoginButton", "OK");
        }
    }
}