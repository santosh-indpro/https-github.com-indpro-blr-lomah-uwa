using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Lomha_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AssignedAccessPage : Page
    {
        public AssignedAccessPage()
        {
            InitializeComponent();
            InitializeComponent();
            MainWebView.Visibility = Visibility.Collapsed;
            MainWebView.Opacity = 0;
            MainWebView.Navigate(new Uri("http://www.contoso.com"));
        }

        private async void Load()
        {
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            try
            {
                Windows.Storage.StorageFile sampleFile = await storageFolder.GetFileAsync("configuration.txt");

                if (sampleFile != null)
                {
                    var configString = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);
                    XmlSerializer x = new XmlSerializer(typeof(ApplicationConfiguration));
                    TextReader sr = new StringReader(configString);
                    ApplicationConfiguration applicationConfig = x.Deserialize(sr) as ApplicationConfiguration;
                    if (applicationConfig != null)
                    {
                        MainWebView.Navigate(new Uri(applicationConfig.ApplicationUrl));
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                MainWebView.Navigate(new Uri("NOT Found"));
            }
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
