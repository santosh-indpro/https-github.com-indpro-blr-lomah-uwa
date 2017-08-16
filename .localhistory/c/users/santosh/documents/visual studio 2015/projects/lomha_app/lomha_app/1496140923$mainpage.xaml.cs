using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lomha_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            MainWebView.Visibility = Visibility.Collapsed;
            MainWebView.Opacity = 0;
            MainWebView.Navigate(new Uri("http://www.contoso.com"));
        }

        private async void MainWebView_OnDOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs args)
        {
            MainWebView.Visibility = Visibility.Visible;
            double splaceOpecity = 1;
            double opecity = 0;
            while (opecity < 1)
            {
                await Task.Delay(25);
                opecity = opecity + 0.1;
                splaceOpecity = splaceOpecity - 0.1;
                MainWebView.Opacity = opecity;
                WebViewSplace.Opacity = splaceOpecity;
            }

            WebViewSplace.Visibility = Visibility.Collapsed;
        }
    }
}
