
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
    public sealed partial class Shortcuts : Page
    {
        ObservableCollection<Remapping> RemappedShortcuts { get; set; }
        public Shortcuts()
        {
            this.InitializeComponent();
            RemappedShortcuts = new ObservableCollection<Remapping>();
            RemappedShortcuts.Add(new Remapping() { OriginalKeys = new List<string>() { "Ctrl", "Shift", "F" }, RemappedKeys = new List<string>() { "Shift", "F" },  IsAllApps = true });
            RemappedShortcuts.Add(new Remapping() { OriginalKeys = new List<string>() { "Shift", "M" }, RemappedKeys = new List<string>() { "Ctrl", "M" }, IsAllApps = true });
            RemappedShortcuts.Add(new Remapping() { OriginalKeys = new List<string>() { "Shift", "Alt", "B" }, RemappedKeys = new List<string>() { "Alt", "B" }, IsAllApps = false, AppName = "outlook.exe" });
        }

        private async void NewShortcutBtn_Click(object sender, RoutedEventArgs e)
        {
            await KeyDialog.ShowAsync();
        }

        private async void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Remapping selectedShortcut = e.ClickedItem as Remapping;
            ShortcutControl.SetOriginalKeys(selectedShortcut.OriginalKeys);
            ShortcutControl.SetRemappedKeys(selectedShortcut.RemappedKeys);
            ShortcutControl.SetApp(!selectedShortcut.IsAllApps, selectedShortcut.AppName);
            await KeyDialog.ShowAsync();
        }
    }
}