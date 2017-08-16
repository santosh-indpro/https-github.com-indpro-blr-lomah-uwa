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
            var LoadingAnimation =  "< div style = 'fill: rgb(227, 227, 227); height: 64px; width: 64px;' > " + 
 
                " < svg xmlns = 'http://www.w3.org/2000/svg' viewBox = '0 0 32 32' > " +
    
                " < path transform = 'translate(2)' d = 'M 0 6.4912 V 25.5088 H 4 V 6.4912 Z' > " +
       
                " < animate attributeName = 'd' values = 'M0 12 V20 H4 V12z; M0 4 V28 H4 V4z; M0 12 V20 H4 V12z; M0 12 V20 H4 V12z' dur = '1.2s' repeatCount = 'indefinite' begin = '0' keyTimes = '0;.2;.5;1' keySplines = '0.2 0.2 0.4 0.8;0.2 0.6 0.4 0.8;0.2 0.8 0.4 0.8' calcMode = 'spline' ></ animate > " +
                      
                " </ path > "  + 
                      
                " < path transform = 'translate(8)' d = 'M 0 8.02838 V 23.9716 H 4 V 8.02838 Z' > " + 

                " < animate attributeName = 'd' values = 'M0 12 V20 H4 V12z; M0 4 V28 H4 V4z; M0 12 V20 H4 V12z; M0 12 V20 H4 V12z' dur = '1.2s' repeatCount = 'indefinite' begin = '0.2' keyTimes = '0;.2;.5;1' keySplines = '0.2 0.2 0.4 0.8;0.2 0.6 0.4 0.8;0.2 0.8 0.4 0.8' calcMode = 'spline' ></ animate > " +

                " </ path > " +

                " < path transform = 'translate(14)' d = 'M 0 12 V 20 H 4 V 12 Z' > " +

                " < animate attributeName = 'd' values = 'M0 12 V20 H4 V12z; M0 4 V28 H4 V4z; M0 12 V20 H4 V12z; M0 12 V20 H4 V12z' dur = '1.2s' repeatCount = 'indefinite' begin = '0.4' keyTimes = '0;.2;.5;1' keySplines = '0.2 0.2 0.4 0.8;0.2 0.6 0.4 0.8;0.2 0.8 0.4 0.8' calcMode = 'spline' ></ animate > " +

                " </ path > " +

                " < path transform = 'translate(20)' d = 'M 0 12 V 20 H 4 V 12 Z' > " +

                " < animate attributeName = 'd' values = 'M0 12 V20 H4 V12z; M0 4 V28 H4 V4z; M0 12 V20 H4 V12z; M0 12 V20 H4 V12z' dur = '1.2s' repeatCount = 'indefinite' begin = '0.6' keyTimes = '0;.2;.5;1' keySplines = '0.2 0.2 0.4 0.8;0.2 0.6 0.4 0.8;0.2 0.8 0.4 0.8' calcMode = 'spline' ></ animate > " +

                " </ path > " +

                " < path transform = 'translate(26)' d = 'M 0 12 V 20 H 4 V 12 Z' > " +

                " < animate attributeName = 'd' values = 'M0 12 V20 H4 V12z; M0 4 V28 H4 V4z; M0 12 V20 H4 V12z; M0 12 V20 H4 V12z' dur = '1.2s' repeatCount = 'indefinite' begin = '0.8' keyTimes = '0;.2;.5;1' keySplines = '0.2 0.2 0.4 0.8;0.2 0.6 0.4 0.8;0.2 0.8 0.4 0.8' calcMode = 'spline' ></ animate > " +

                " </ path > " +

                " </ svg > " +

                " </ div > ";
                                                                                                          this.InitializeComponent();
            this.WebViewSplace.NavigateToString(LoadingAnimation);
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
