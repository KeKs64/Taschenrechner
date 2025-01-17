using Taschenrechner.Core;
using Taschenrechner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Windows;
using System.Windows.Input;

namespace Taschenrechner.MVVM.ViewModel
{
    internal class SettingsViewModel : Core.ViewModel
    {
        private INavigationService _navigation;

        public ICommand SwitchThemeCommand { get; private set; }

        private bool _isLightTheme = true;

        public bool IsLightTheme
        {
            get
            {
                return _isLightTheme;
            }
            set
            {
                _isLightTheme = value;
                OnPropertyChanged(nameof(IsLightTheme));
            }
        }

        private void SwitchTheme()
        {
            IsLightTheme = !IsLightTheme;
            string newThemePath = IsLightTheme ? "LightTheme.xaml" : "DarkTheme.xaml";
            var newTheme = (ResourceDictionary)Application.LoadComponent(new Uri(newThemePath, UriKind.Relative));
            Application.Current.Resources.MergedDictionaries.RemoveAt(0);
            Application.Current.Resources.MergedDictionaries.Add(newTheme);
        }

        public INavigationService Navigation
        {
            get => _navigation;
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand NavigateToTRCommand { get; set; }

        public SettingsViewModel(INavigationService navigation)
        {
            Navigation = navigation;
            NavigateToTRCommand = new RelayCommand(o => { Navigation.NavigateTo<Window1ViewModel>(); }, o => true);
            SwitchThemeCommand = new RelayCommand(o => { SwitchTheme(); }, o => true);
        }
    }
}
