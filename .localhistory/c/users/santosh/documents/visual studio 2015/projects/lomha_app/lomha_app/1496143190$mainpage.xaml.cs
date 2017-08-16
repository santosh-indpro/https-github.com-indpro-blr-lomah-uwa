using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
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
           Load();
        }

        private async void Load()
        {
            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile = await storageFolder.GetFileAsync("configuration.txt");
            if (sampleFile != null)
            {
                textBox.Text = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);
            }
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var appConfig = new ApplicationConfiguration() { ApplicationUrl = textBox.Text };

            Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile = await storageFolder.CreateFileAsync("configuration.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);

            XmlSerializer x = new XmlSerializer(typeof(ApplicationConfiguration));
            MemoryStream memStream = new MemoryStream();
            StreamWriter sw = new StreamWriter(memStream);
            x.Serialize(sw, appConfig);
            sw.Flush();

            memStream.Position = 0;
            var sr = new StreamReader(memStream);

            await Windows.Storage.FileIO.WriteTextAsync(sampleFile, sr.ReadToEnd());

            memStream.Dispose();
            sw.Dispose();
        }
    }
}
