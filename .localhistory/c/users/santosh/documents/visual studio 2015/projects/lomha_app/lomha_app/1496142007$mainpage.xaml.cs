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
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var appConfig = new ApplicationConfiguration() { ApplicationUrl = textBox.Text };

            XmlSerializer x = new XmlSerializer(typeof(ApplicationConfiguration));
            FileStream fs = new FileStream("ms-appx-web:///configuration.html", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            x.Serialize(sw, appConfig);
        }
    }
}
