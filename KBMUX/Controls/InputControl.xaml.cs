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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace KBMUX.Controls
{
    public sealed partial class InputControl : UserControl
    {

        public InputControl()
        {
            this.InitializeComponent();
        }

        public void SetOriginalKeys(List<string> Keys)
        {
            OriginalKeys.ItemsSource = Keys;
        }

        public void SetRemappedKeys(List<string> Keys)
        {
            RemappedKeys.ItemsSource = Keys;
        }

        private void OriginalToggleBtn_Checked(object sender, RoutedEventArgs e)
        {
            RemappedToggleBtn.IsChecked = false;
        }

        private void RemappedToggleBtn_Checked(object sender, RoutedEventArgs e)
        {
            OriginalToggleBtn.IsChecked = false;
        }

        public void SetApp(bool IsSpecificApp, string AppName)
        {
            if (IsSpecificApp)
            {
                AllAppsCheckBox.IsChecked = true;
                AppNameTextBox.Text = AppName;
                AppNameTextBox.Visibility = Visibility.Visible;
            }
            else
            {
                AllAppsCheckBox.IsChecked = false;
                AppNameTextBox.Visibility = Visibility.Collapsed;
            }
        }

        private void AllAppsCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            AppNameTextBox.Visibility = Visibility.Visible;
        }

        private void AllAppsCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            AppNameTextBox.Visibility = Visibility.Collapsed;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            AllAppsCheckBox.Checked += AllAppsCheckBox_Checked;
            AllAppsCheckBox.Unchecked += AllAppsCheckBox_Unchecked;
        }


    }
}
