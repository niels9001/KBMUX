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
    public sealed partial class Text : Page
    {
        ObservableCollection<Remapping> RemappedTexts { get; set; }

        public Text()
        {
            this.InitializeComponent();
            RemappedTexts = new ObservableCollection<Remapping>();
            RemappedTexts.Add(new Remapping() { OriginalKeys = new List<string>() { "/msft" }, RemappedKeys = new List<string>() { "Microsoft" }, IsAllApps = true });
            RemappedTexts.Add(new Remapping() { OriginalKeys = new List<string>() { "cu" }, RemappedKeys = new List<string>() { "See you" }, IsAllApps = true, });
        }
    }
}