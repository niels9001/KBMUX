using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace KBMUX.Pages
{
    public sealed partial class Text : Page
    {
        ObservableCollection<URLShortcut> Shortcuts { get; set; }

        public Text()
        {
            this.InitializeComponent();
            Shortcuts = new ObservableCollection<URLShortcut>();
            Shortcuts.Add(new URLShortcut() { Shortcut = new List<string>() { "Shift", "Win", "M" }, URL = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
            Shortcuts.Add(new URLShortcut() { Shortcut = new List<string>() { "Win", "P", }, URL = "Consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna" });
            Shortcuts.Add(new URLShortcut() { Shortcut = new List<string>() { "Shift", "Win", "M" }, URL = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat" });
            Shortcuts.Add(new URLShortcut() { Shortcut = new List<string>() { "Win", "U", }, URL = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
            Shortcuts.Add(new URLShortcut() { Shortcut = new List<string>() { "Ctrl", "P" }, URL = "Cupidatat non proident, sunt in culpa qui officia" });
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