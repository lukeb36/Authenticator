﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Authenticator_for_Windows.Views.Pages
{
    public sealed partial class AccessDeniedDialog : ContentDialog
    {
        public AccessDeniedDialog()
        {
            this.InitializeComponent();
        }

        private async void CameraSettings_Tapped(object sender, TappedRoutedEventArgs e)
        {
            bool result = await Launcher.LaunchUriAsync(new Uri("ms-settings:privacy-webcam"));
        }
    }
}
