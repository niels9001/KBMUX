
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
    public sealed partial class Keys : Page
    {
        ObservableCollection<Remapping> RemappedKeys { get; set; }
        public Keys()
        {
            this.InitializeComponent();
            RemappedKeys = new ObservableCollection<Remapping>();
            RemappedKeys.Add(new Remapping() { OriginalKeys = new List<string>() { "Ctrl (Left)" }, RemappedKeys = new List<string>() { "Ctrl (Right)" }, IsAllApps = true });
            RemappedKeys.Add(new Remapping() { OriginalKeys = new List<string>() { "Numpad 1" }, RemappedKeys = new List<string>() { "Ctrl", "F" }, IsAllApps = true });
            RemappedKeys.Add(new Remapping() { OriginalKeys = new List<string>() { "Numpad 2" }, RemappedKeys = new List<string>() { "Alt", "F" }, IsAllApps = true, AppName = "outlook.exe" });
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
            await KeyDialog.ShowAsync();
        }
    }
}