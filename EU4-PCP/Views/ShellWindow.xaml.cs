﻿using EU4_PCP.Contracts.Services;
using EU4_PCP.Contracts.Views;
using MahApps.Metro.Controls;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using static EU4_PCP.PCP_Data;

namespace EU4_PCP.Views
{
    public partial class ShellWindow : MetroWindow, IShellWindow, INotifyPropertyChanged
    {
        private readonly INavigationService _navigationService;
        private bool _canGoBack;
        private HamburgerMenuItem _selectedMenuItem;
        private HamburgerMenuItem _selectedOptionsMenuItem;

        private readonly DispatcherTimer NavigationTimer = new();

        public bool CanGoBack
        {
            get { return _canGoBack; }
            set { Set(ref _canGoBack, value); }
        }

        public HamburgerMenuItem SelectedMenuItem
        {
            get { return _selectedMenuItem; }
            set { Set(ref _selectedMenuItem, value); }
        }

        public HamburgerMenuItem SelectedOptionsMenuItem
        {
            get { return _selectedOptionsMenuItem; }
            set { Set(ref _selectedOptionsMenuItem, value); }
        }

        // TODO WTS: Change the icons and titles for all HamburgerMenuItems here.
        public ObservableCollection<HamburgerMenuItem> MenuItems { get; } = new ObservableCollection<HamburgerMenuItem>()
        {
            new HamburgerMenuGlyphItem() { Label = Properties.Resources.ShellProvTablePage, Glyph = "\uE82D", TargetPageType = typeof(ProvTablePage) },
            new HamburgerMenuGlyphItem() { Label = Properties.Resources.ShellColorPickerPage, Glyph = "\uE790", TargetPageType = typeof(ColorPickerPage) },
        };

        public ObservableCollection<HamburgerMenuItem> OptionMenuItems { get; } = new ObservableCollection<HamburgerMenuItem>()
        {
            new HamburgerMenuGlyphItem() { Label = Properties.Resources.ShellSettingsPage, Glyph = "\uE713", TargetPageType = typeof(SettingsPage) }
        };

        public ShellWindow(INavigationService navigationService)
        {
            _navigationService = navigationService;
            InitializeComponent();
            DataContext = this;

            NavigationTimer.Tick += NavigationTimer_Tick;
            NavigationTimer.Interval = TimeSpan.FromMilliseconds(10);
            NavigationTimer.Start();
        }

        private void NavigationTimer_Tick(object sender, EventArgs e)
        {
            if (NavigateToColorPicker)
            {
                NavigateToColorPicker = false;

                NavigateTo(typeof(ColorPickerPage));
            }
            else if (NavigateToSettings)
            {
                NavigateToSettings = false;

                NavigateTo(typeof(SettingsPage));
            }
        }

        public Frame GetNavigationFrame()
            => shellFrame;

        public void ShowWindow()
            => Show();

        public void CloseWindow()
            => Close();

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            _navigationService.Navigated += OnNavigated;
        }

        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
            _navigationService.Navigated -= OnNavigated;
        }

        private void OnItemClick(object sender, ItemClickEventArgs args)
            => NavigateTo(SelectedMenuItem.TargetPageType);

        private void OnOptionsItemClick(object sender, ItemClickEventArgs args)
            => NavigateTo(SelectedOptionsMenuItem.TargetPageType);

        private void NavigateTo(Type targetPage)
        {
            if (targetPage != null)
            {
                _navigationService.NavigateTo(targetPage);
            }
        }

        private void OnNavigated(object sender, Type pageType)
        {
            var item = MenuItems
                        .OfType<HamburgerMenuItem>()
                        .FirstOrDefault(i => pageType == i.TargetPageType);
            if (item != null)
            {
                SelectedMenuItem = item;
            }
            else
            {
                SelectedOptionsMenuItem = OptionMenuItems
                        .OfType<HamburgerMenuItem>()
                        .FirstOrDefault(i => pageType == i.TargetPageType);
            }

            CanGoBack = _navigationService.CanGoBack;
        }

        private void OnGoBack(object sender, RoutedEventArgs e)
        {
            _navigationService.GoBack();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
