using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace LoginWindowUI3
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            // Win32

            IntPtr thisWindow=WinRT.Interop.WindowNative.GetWindowHandle(this); // IntPrt
            var thisWindowId=Microsoft.UI.Win32Interop.GetWindowIdFromWindow(thisWindow); // GetWindowId
            var thisWindowApp=Microsoft.UI.Windowing.AppWindow.GetFromWindowId(thisWindowId); // Get Window

            // Set Prop
            thisWindowApp.SetPresenter(Microsoft.UI.Windowing.AppWindowPresenterKind.CompactOverlay);
            thisWindowApp.Resize(new Windows.Graphics.SizeInt32(1080, 720));
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked";
        }
    }
}
