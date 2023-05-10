using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWPFamily_Launcher.Pages;
using Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPFamily_Launcher
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Window.Current.SetTitleBar(AppTitleBar);
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.GoBack();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(HomePage));
        }
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(HomePage));
        }
        private void AppsButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(AppsPage));
        }
        private void GamesButton_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(GamesPage));
        }
        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SettingsPage));
        }
    }
}
