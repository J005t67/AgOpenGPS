using AgLibrary.ViewModels;
using AgOpenGPS.Core.Interfaces;
using System.Windows.Input;

namespace AgOpenGPS.Core.ViewModels
{
    public class ConfigMenuViewModel : DayNightAndUnitsViewModel
    {
        private readonly ApplicationModel _appModel;
        private readonly IPanelPresenter _panelPresenter;
        private ConfigurationViewModel _configurationViewModel;
        public ConfigMenuViewModel(ApplicationModel appModel, IPanelPresenter panelPresenter)
        {
            _appModel = appModel;
            _panelPresenter = panelPresenter;
            StartConfigurationCommand = new RelayCommand(StartConfiguration);
        }

        public ICommand StartConfigurationCommand { get; }

        private ConfigurationViewModel ConfigurationViewModel
        {
            get
            {
                if (_configurationViewModel == null)
                {
                    _configurationViewModel =
                        new ConfigurationViewModel(_appModel);
                }
                return _configurationViewModel;
            }
        }

        private void StartConfiguration()
        {
            _panelPresenter.CloseConfigMenuDialog();
            ConfigurationViewModel.UpdateFromSettings();
            _panelPresenter.ShowConfigurationDialog(ConfigurationViewModel);
        }
    }
}
