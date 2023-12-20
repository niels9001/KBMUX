using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace KBMUX
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            RootView.SelectedItem = RootView.MenuItems[0];
        }

        private void RootView_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            Microsoft.UI.Xaml.Controls.NavigationViewItem selectedItem = args.SelectedItem as Microsoft.UI.Xaml.Controls.NavigationViewItem;

            if (selectedItem != null)
            {
                switch ((string)selectedItem.Tag)
                {
                    case "Remappings": NavigationFrame.Navigate(typeof(Pages.Shortcuts)); break;
                 
                    case "Text": NavigationFrame.Navigate(typeof(Pages.Text)); break;

                    case "URLs":
                        NavigationFrame.Navigate(typeof(Pages.URLs)); break;

                    case "Programs":
                        NavigationFrame.Navigate(typeof(Pages.Programs)); break;


                }
            }
        }
    }
}
