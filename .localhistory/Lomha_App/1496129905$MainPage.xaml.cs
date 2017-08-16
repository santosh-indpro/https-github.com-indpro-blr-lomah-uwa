using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

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
            this.InitializeComponent();
            this.MainWebView.Visibility = Visibility.Collapsed;
            this.MainWebView.Opacity = 0;
            this.MainWebView.Navigate(new Uri("http://www.contoso.com"));
        }

        private async void MainWebView_OnDOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs args)
        {
            this.MainWebView.Visibility = Visibility.Visible;
            double splaceOpecity = 1;
            double opecity = 0;
            while (opecity < 1)
            {
                await Task.Delay(25);
                opecity = opecity + 0.1;
                splaceOpecity = splaceOpecity - 0.1;
                this.MainWebView.Opacity = opecity;
                this.WebViewSplace.Opacity = splaceOpecity;
            }

            this.WebViewSplace.Visibility = Visibility.Collapsed;
        }
    }
}
