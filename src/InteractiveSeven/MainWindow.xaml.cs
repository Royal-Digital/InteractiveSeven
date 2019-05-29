﻿using InteractiveSeven.ViewModels;
using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;

namespace InteractiveSeven
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MenuColorViewModel menuColorViewModel, SettingsViewModel settingsViewModel)
        {
            InitializeComponent();
            MenuColorGrid.DataContext = menuColorViewModel;
            MenuColorGroup.DataContext = menuColorViewModel;
            SettingsTab.DataContext = settingsViewModel;
        }

        private void PatreonLink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = e.Uri.AbsoluteUri,
                UseShellExecute = true
            };
            Process.Start(psi);
            e.Handled = true;
        }
    }
}
