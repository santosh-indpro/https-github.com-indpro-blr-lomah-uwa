﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

            this.mainWebView.Source = new Uri("http://Google.com");

            XmlSerializer ser = new XmlSerializer(typeof(ApplicationServer));

            Stream iStream = new FileStream(@"C:\Lomha\app.txt", FileMode.Create);
            TextWriter writer = new StreamWriter(iStream);
            ser.Serialize(writer, new ApplicationServer() {ServerUrl = "http://Google.com" });
            writer.Dispose();

        }
    }
}
