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
            this.mainWebView.Visibility = Visibility.Collapsed;
            this.mainWebView.Opacity = 0;
            this.mainWebView.Navigate(new Uri("http://www.contoso.com"));
        }

        private async void MainWebView_OnDOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs args)
        {
            this.mainWebView.Visibility = Visibility.Visible;
            var opecity = 0;
            while (opecity < 10)
            {
                await Task.Delay(100);
                opecity = opecity + 1;
                this.mainWebView.Opacity = opecity;
            }
        }
    }
}
