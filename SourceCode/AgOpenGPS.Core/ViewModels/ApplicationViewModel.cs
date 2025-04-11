using AgLibrary.ViewModels;
using AgOpenGPS.Core.Presenters;
using System.Windows.Input;

namespace AgOpenGPS.Core.ViewModels
{
    public class ApplicationViewModel : DayNightAndUnitsViewModel
    {
        private readonly ApplicationModel _appModel;
        private ApplicationPresenter _applicationPresenter;
        private ConfigMenuViewModel _configMenuViewModel;
        private StartNewFieldViewModel _startNewFieldViewModel;

        public ApplicationViewModel(ApplicationModel appModel)
        {
            _appModel = appModel;
            ShowConfigMenuCommand = new RelayCommand(ShowConfigMenu);
            StartNewFieldCommand = new RelayCommand(StartNewField);
        }

        public void SetPresenter(ApplicationPresenter appPresenter)
        {
            _applicationPresenter = appPresenter;
            StartNewFieldViewModel.PanelPresenter = appPresenter.PanelPresenter;
        }

        public ConfigMenuViewModel ConfigMenuViewModel
        {
            get
            {
                if (_configMenuViewModel == null)
                {
                    _configMenuViewModel = new ConfigMenuViewModel(_appModel, _applicationPresenter.PanelPresenter);
                    AddChild(_configMenuViewModel);
                }
                return _configMenuViewModel;
            }
        }

        public StartNewFieldViewModel StartNewFieldViewModel
        {
            get
            {
                if (_startNewFieldViewModel == null)
                {
                    _startNewFieldViewModel = new StartNewFieldViewModel(_appModel);
                    AddChild(_startNewFieldViewModel);
                }
                return _startNewFieldViewModel;
            }
        }

        public ICommand ShowConfigMenuCommand { get; }
        public ICommand StartNewFieldCommand { get; }

        private void ShowConfigMenu()
        {
            _applicationPresenter.ShowConfigMenuDialog(ConfigMenuViewModel);
        }

        private void StartNewField()
        {
            _applicationPresenter.PresentStartNewField(StartNewFieldViewModel);
        }

    }
}
