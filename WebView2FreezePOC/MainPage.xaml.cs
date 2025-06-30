using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WebView2PerformancePOC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            await MyWebView.EnsureCoreWebView2Async();
            string html = @"<!DOCTYPE html>
                            <html>
                            <head>
                                <meta charset='UTF-8'>
                            </head>
                            <body contenteditable='true'>
                             Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque volutpat velit dui, in blandit odio gravida sit amet. Aenean interdum, sapien sed rutrum imperdiet, leo nisi bibendum felis, et dictum lorem est quis justo. Donec a iaculis est. Vivamus vel est sit amet dui pulvinar fermentum. Fusce semper augue leo, id ultricies ante blandit quis. Sed mollis ullamcorper quam vel pharetra. Sed sed eleifend ex, eu auctor eros. Mauris dapibus, purus eu venenatis pulvinar, turpis turpis congue erat, ut accumsan dui dolor id erat. Pellentesque non tristique nulla. Vestibulum eget pulvinar ex, non vulputate ante. Nam sodales tristique molestie. Vivamus ac sapien porttitor, dapibus dui quis, mollis turpis. Curabitur pulvinar vulputate orci. Duis auctor enim a eros egestas, in ultricies turpis tristique. Praesent congue efficitur nisl, sed laoreet dolor laoreet nec.
                            </body>
                            //</html>";
            MyWebView.NavigateToString(html);
        }

        private void Click_Click(object sender, RoutedEventArgs e)
        {
            if ((ClickButton.Background as SolidColorBrush)?.Color == Colors.LightBlue)
            {
                ClickButton.Background = new SolidColorBrush(Colors.LightGreen);
            }
            else
            {
                ClickButton.Background = new SolidColorBrush(Colors.LightBlue);
            }
        }
    }
}
