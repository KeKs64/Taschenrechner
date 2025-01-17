using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taschenrechner.Core;
using Taschenrechner.Services;

namespace Taschenrechner.MVVM.ViewModel
{
    internal class Window1ViewModel : Core.ViewModel
    {
        private INavigationService _navigation;


        public INavigationService Navigation
        {
            get => _navigation;
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand NavigateToSettingsCommand { get; set; }

        public Window1ViewModel(INavigationService navigation)
        {
            Navigation = navigation;
            NavigateToSettingsCommand = new RelayCommand(o => { Navigation.NavigateTo<SettingsViewModel>(); }, o => true);
        }
    }
}

