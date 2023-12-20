﻿
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

namespace KBMUX.Pages
{
    public sealed partial class URLs : Page
    {
        ObservableCollection<URLShortcut> Shortcuts { get; set; }
        public URLs()
        {
            this.InitializeComponent();
            Shortcuts = new ObservableCollection<URLShortcut>();
            Shortcuts.Add(new URLShortcut() { Shortcut = new List<string>() { "Shift", "Win", "M" }, URL = "https://www.microsoft.com" });
            Shortcuts.Add(new URLShortcut() { Shortcut = new List<string>() { "Win", "P", }, URL = "https://www.contoso.com" });
            Shortcuts.Add(new URLShortcut() { Shortcut = new List<string>() { "Shift", "Win", "M" }, URL = "https://www.windows.com" });
            Shortcuts.Add(new URLShortcut() { Shortcut = new List<string>() { "Win", "U", }, URL = "https://www.xbox.com" });
            Shortcuts.Add(new URLShortcut() { Shortcut = new List<string>() { "Ctrl", "P" }, URL = "https://www.surface.com" });
            Shortcuts.Add(new URLShortcut() { Shortcut = new List<string>() { "Alt", "Ctrl", "Shift" }, URL = "https://www.xbox.com" });
        }

        private async void NewShortcutBtn_Click(object sender, RoutedEventArgs e)
        {
            await KeyDialog.ShowAsync();
        }

        private async void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Remapping selectedShortcut = e.ClickedItem as Remapping;
            await KeyDialog.ShowAsync();
        }
    }
}