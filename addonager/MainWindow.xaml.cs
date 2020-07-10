using MahApps.Metro.Controls;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;

namespace addonager
{
    public partial class MainWindow : MetroWindow
    {
        public ObservableCollection<AddonVM> ListOfAddons
        {
            get { return _listOfAddons; }
            set
            {
                if (_listOfAddons != value)
                {
                    _listOfAddons = value;
                }
            }
        }

        private ObservableCollection<AddonVM> _listOfAddons { get; set; } = new ObservableCollection<AddonVM>();

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        private void LaunchGitHubSite(object sender, RoutedEventArgs e)
        {
            var tacos = Directory.EnumerateDirectories(@"C:\Program Files (x86)\World of Warcraft\_retail_\Interface\AddOns").ToList();

            foreach (var iteam in tacos)
            {
                _listOfAddons.Add(new AddonVM() { Name = iteam, Version="0.0.0"});
            }
        }

        private void DeployCupCakes(object sender, RoutedEventArgs e)
        {
            //C:\Program Files (x86)\World of Warcraft\_retail_\Interface

            //secondFlyout.IsOpen = !secondFlyout.IsOpen;
            //await this.ShowMessageAsync("This is the title", "Some message");
        }
    }

    public enum Position
    {
        Left,
        Right,
        Top,
        Bottom
    }

    public enum FlyoutTheme
    {
        /// <summary>
        /// Adapts the Flyout's theme to the theme of its host window.
        /// </summary>
        Adapt,

        /// <summary>
        /// Adapts the Flyout's theme to the theme of its host window, but inverted.
        /// This theme can only be applied if the host window's theme abides the "Dark" and "Light" affix convention.
        /// (see <see cref="ThemeManager.GetInverseTheme"/> for more infos.
        /// </summary>
        Inverse,

        /// <summary>
        /// The dark theme. This is the default theme.
        /// </summary>
        Dark,
        Light,

        /// <summary>
        /// The flyouts theme will match the host window's accent color.
        /// </summary>
        Accent
    }

    [Flags]
    public enum WindowCommandsOverlayBehavior
    {
        /// <summary>
        /// Doesn't overlay a hidden TitleBar.
        /// </summary>
        Never = 0,

        /// <summary>
        /// Overlays a hidden TitleBar.
        /// </summary>
        HiddenTitleBar = 1 << 0
    }

    [Flags]
    public enum OverlayBehavior
    {
        /// <summary>
        /// Doesn't overlay Flyouts nor a hidden TitleBar.
        /// </summary>
        Never = 0,

        /// <summary>
        /// Overlays opened <see cref="Flyout"/> controls.
        /// </summary>
        Flyouts = 1 << 0,

        /// <summary>
        /// Overlays a hidden TitleBar.
        /// </summary>
        HiddenTitleBar = 1 << 1,

        Always = ~(-1 << 2)
    }
}
