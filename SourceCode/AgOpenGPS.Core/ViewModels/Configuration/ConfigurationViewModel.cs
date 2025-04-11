using AgLibrary.ViewModels;
using System.ComponentModel;

namespace AgOpenGPS.Core.ViewModels
{
    public class ConfigurationViewModel : DayNightAndUnitsViewModel
    {
        private readonly ApplicationModel _appModel;
        private ConfigurationPageViewModel _selectedPageViewModel;

        private ConfigVehicleTypeViewModel _configVehicleTypeViewModel;
        private ConfigVehicleSizeViewModel _configVehicleSizeViewModel;
        private ConfigVehicleAntennaViewModel _configVehicleAntennaViewModel;
        private ConfigToolTypeViewModel _configToolTypeViewModel;
        private ConfigToolSizeViewModel _configToolSizeViewModel;
        private ConfigToolOffsetViewModel _configToolOffsetViewModel;
        private ConfigToolOverlapViewModel _configToolOverlapViewModel;
        private ConfigToolSectionsViewModel _configToolSectionsViewModel;
        private ConfigToolLookAheadViewModel _configToolLookAheadViewModel;
        private ConfigToolSwitchesViewModel _configToolSwitchesViewModel;
        private ConfigInputsAntennaViewModel _configInputsAntennaViewModel;
        private ConfigInputsImuViewModel _configInputsImuViewModel;
        private ConfigTurnViewModel _configTurnViewModel;
        private ConfigMachineModuleViewModel _configMachineModuleViewModel;
        private ConfigSwitchesViewModel _configSwitchesViewModel;
        private ConfigTramLinesViewModel _configTramLinesViewModel;
        private ConfigViewportViewModel _configViewportViewModel;
        private ConfigButtonsViewModel _configButtonsViewModel;

        private bool _vehicleTypeSelected;
        private bool _vehicleSizeSelected;
        private bool _vehicleAntennaSelected;
        private bool _toolTypeSelected;
        private bool _toolSizeSelected;
        private bool _toolOffsetSelected;
        private bool _toolOverlapSelected;
        private bool _toolSectionsSelected;
        private bool _toolLookAheadSelected;
        private bool _toolSwitchesSelected;
        private bool _inputsAntennaSelected;
        private bool _inputsImuSelected;
        private bool _turnSelected;
        private bool _machineModuleSelected;
        private bool _switchesSelected;
        private bool _tramLinesSelected;
        private bool _viewportSelected;
        private bool _buttonsSelected;

        public ConfigurationViewModel(ApplicationModel appModel)
        {
            _appModel = appModel;
            _selectedPageViewModel = ConfigVehicleTypeViewModel;
        }

        public void UpdateFromSettings()
        {

        }

        public ConfigVehicleTypeViewModel ConfigVehicleTypeViewModel
        {
            get
            {
                if (_configVehicleTypeViewModel == null)
                {
                    _configVehicleTypeViewModel = new ConfigVehicleTypeViewModel();
                    AddChild(_configVehicleTypeViewModel);
                }
                return _configVehicleTypeViewModel;
            }
        }

        public ConfigVehicleSizeViewModel ConfigVehicleSizeViewModel
        {
            get
            {
                if (_configVehicleSizeViewModel == null)
                {
                    _configVehicleSizeViewModel = new ConfigVehicleSizeViewModel();
                    AddChild(_configVehicleSizeViewModel);
                }
                return _configVehicleSizeViewModel;
            }
        }

        public ConfigVehicleAntennaViewModel ConfigVehicleAntennaViewModel
        {
            get
            {
                if (_configVehicleAntennaViewModel == null)
                {
                    _configVehicleAntennaViewModel = new ConfigVehicleAntennaViewModel();
                    AddChild(_configVehicleAntennaViewModel);
                }
                return _configVehicleAntennaViewModel;
            }
        }

        public ConfigToolTypeViewModel ConfigToolTypeViewModel
        {
            get
            {
                if (_configToolTypeViewModel == null)
                {
                    _configToolTypeViewModel = new ConfigToolTypeViewModel();
                    AddChild(_configToolTypeViewModel);
                }
                return _configToolTypeViewModel;
            }
        }

        public ConfigToolSizeViewModel ConfigToolSizeViewModel
        {
            get
            {
                if (_configToolSizeViewModel == null)
                {
                    _configToolSizeViewModel = new ConfigToolSizeViewModel();
                    AddChild(_configToolSizeViewModel);
                }
                return _configToolSizeViewModel;
            }
        }

        public ConfigToolOffsetViewModel ConfigToolOffsetViewModel
        {
            get
            {
                if (_configToolOffsetViewModel == null)
                {
                    _configToolOffsetViewModel = new ConfigToolOffsetViewModel();
                    AddChild(_configToolOffsetViewModel);
                }
                return _configToolOffsetViewModel;
            }
        }

        public ConfigToolOverlapViewModel ConfigToolOverlapViewModel
        {
            get
            {
                if (_configToolOverlapViewModel == null)
                {
                    _configToolOverlapViewModel = new ConfigToolOverlapViewModel();
                    AddChild(_configToolOverlapViewModel);
                }
                return _configToolOverlapViewModel;
            }
        }

        public ConfigToolSectionsViewModel ConfigToolSectionsViewModel
        {
            get
            {
                if (_configToolSectionsViewModel == null)
                {
                    _configToolSectionsViewModel = new ConfigToolSectionsViewModel();
                    AddChild(_configToolSectionsViewModel);
                }
                return _configToolSectionsViewModel;
            }
        }

        public ConfigToolLookAheadViewModel ConfigToolLookAheadViewModel
        {
            get
            {
                if (_configToolLookAheadViewModel == null)
                {
                    _configToolLookAheadViewModel = new ConfigToolLookAheadViewModel();
                    AddChild(_configToolLookAheadViewModel);
                }
                return _configToolLookAheadViewModel;
            }
        }

        public ConfigToolSwitchesViewModel ConfigToolSwitchesViewModel
        {
            get
            {
                if (_configToolSwitchesViewModel == null)
                {
                    _configToolSwitchesViewModel = new ConfigToolSwitchesViewModel();
                    AddChild(_configToolSwitchesViewModel);
                }
                return _configToolSwitchesViewModel;
            }
        }

        public ConfigInputsAntennaViewModel ConfigInputsAntennaViewModel
        {
            get
            {
                if (_configInputsAntennaViewModel == null)
                {
                    _configInputsAntennaViewModel = new ConfigInputsAntennaViewModel();
                    AddChild(_configInputsAntennaViewModel);
                }
                return _configInputsAntennaViewModel;
            }
        }

        public ConfigInputsImuViewModel ConfigInputsImuViewModel
        {
            get
            {
                if (_configInputsImuViewModel == null)
                {
                    _configInputsImuViewModel = new ConfigInputsImuViewModel();
                    AddChild(_configInputsImuViewModel);
                }
                return _configInputsImuViewModel;
            }
        }

        public ConfigTurnViewModel ConfigTurnViewModel
        {
            get
            {
                if (_configTurnViewModel == null)
                {
                    _configTurnViewModel = new ConfigTurnViewModel();
                    AddChild(_configTurnViewModel);
                }
                return _configTurnViewModel;
            }
        }

        public ConfigMachineModuleViewModel ConfigMachineModuleViewModel
        {
            get
            {
                if (_configMachineModuleViewModel == null)
                {
                    _configMachineModuleViewModel = new ConfigMachineModuleViewModel();
                    AddChild(_configMachineModuleViewModel);
                }
                return _configMachineModuleViewModel;
            }
        }

        public ConfigSwitchesViewModel ConfigSwitchesViewModel
        {
            get
            {
                if (_configSwitchesViewModel == null)
                {
                    _configSwitchesViewModel = new ConfigSwitchesViewModel();
                    AddChild(_configSwitchesViewModel);
                }
                return _configSwitchesViewModel;
            }
        }

        public ConfigTramLinesViewModel ConfigTramLinesViewModel
        {
            get
            {
                if (_configTramLinesViewModel == null)
                {
                    _configTramLinesViewModel = new ConfigTramLinesViewModel();
                    AddChild(_configTramLinesViewModel);
                }
                return _configTramLinesViewModel;
            }
        }

        public ConfigViewportViewModel ConfigViewportViewModel
        {
            get
            {
                if (_configViewportViewModel == null)
                {
                    _configViewportViewModel = new ConfigViewportViewModel();
                    AddChild(_configViewportViewModel);
                }
                return _configViewportViewModel;
            }
        }

        public ConfigButtonsViewModel ConfigButtonsViewModel
        {
            get
            {
                if (_configButtonsViewModel == null)
                {
                    _configButtonsViewModel = new ConfigButtonsViewModel();
                    AddChild(_configButtonsViewModel);
                }
                return _configButtonsViewModel;
            }
        }

        public ConfigurationPageViewModel SelectedPageViewModel
        {
            get { return _selectedPageViewModel; }
            set
            {
                if (value != SelectedPageViewModel)
                {
                    _selectedPageViewModel = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool VehicleTypeSelected
        {
            get { return _vehicleTypeSelected; }
            set
            {
                if (value != _vehicleTypeSelected)
                {
                    if (value) SelectedPageViewModel = ConfigVehicleTypeViewModel;
                    _vehicleTypeSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool VehicleSizeSelected
        {
            get { return _vehicleSizeSelected; }
            set
            {
                if (value != _vehicleSizeSelected)
                {
                    if (value) SelectedPageViewModel = ConfigVehicleSizeViewModel;
                    _vehicleSizeSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool VehicleAntennaSelected
        {
            get { return _vehicleAntennaSelected; }
            set
            {
                if (value != _vehicleAntennaSelected)
                {
                    if (value) SelectedPageViewModel = ConfigVehicleAntennaViewModel;
                    _vehicleAntennaSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool ToolTypeSelected
        {
            get { return _toolTypeSelected; }
            set
            {
                if (value != _toolTypeSelected)
                {
                    if (value) SelectedPageViewModel = ConfigToolTypeViewModel;
                    _toolTypeSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool ToolSizeSelected
        {
            get { return _toolSizeSelected; }
            set
            {
                if (value != _toolSizeSelected)
                {
                    if (value) SelectedPageViewModel = ConfigToolSizeViewModel;
                    _toolSizeSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool ToolOffsetSelected
        {
            get { return _toolOffsetSelected; }
            set
            {
                if (value != _toolOffsetSelected)
                {
                    if (value) SelectedPageViewModel = ConfigToolOffsetViewModel;
                    _toolOffsetSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool ToolOverlapSelected
        {
            get { return _toolOverlapSelected; }
            set
            {
                if (value != _toolOverlapSelected)
                {
                    if (value) SelectedPageViewModel = ConfigToolOverlapViewModel;
                    _toolOverlapSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool ToolSectionsSelected
        {
            get { return _toolSectionsSelected; }
            set
            {
                if (value != _toolSectionsSelected)
                {
                    if (value) SelectedPageViewModel = ConfigToolSectionsViewModel;
                    _toolSectionsSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool ToolLookAheadSelected
        {
            get { return _toolLookAheadSelected; }
            set
            {
                if (value != _toolLookAheadSelected)
                {
                    if (value) SelectedPageViewModel = ConfigToolLookAheadViewModel;
                    _toolLookAheadSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool ToolSwitchesSelected
        {
            get { return _toolSwitchesSelected; }
            set
            {
                if (value != _toolSwitchesSelected)
                {
                    if (value) SelectedPageViewModel = ConfigToolSwitchesViewModel;
                    _toolSwitchesSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool InputsAntennaSelected
        {
            get { return _inputsAntennaSelected; }
            set
            {
                if (value != _inputsAntennaSelected)
                {
                    if (value) SelectedPageViewModel = ConfigInputsAntennaViewModel;
                    _inputsAntennaSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool InputsImuSelected
        {
            get { return _inputsImuSelected; }
            set
            {
                if (value != _inputsImuSelected)
                {
                    if (value) SelectedPageViewModel = ConfigInputsImuViewModel;
                    _inputsImuSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool TurnSelected
        {
            get { return _turnSelected; }
            set
            {
                if (value != _turnSelected)
                {
                    if (value) SelectedPageViewModel = ConfigTurnViewModel;
                    _turnSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool MachineModuleSelected
        {
            get { return _machineModuleSelected; }
            set
            {
                if (value != _machineModuleSelected)
                {
                    if (value) SelectedPageViewModel = ConfigMachineModuleViewModel;
                    _machineModuleSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool SwitchesSelected
        {
            get { return _switchesSelected; }
            set
            {
                if (value != _switchesSelected)
                {
                    if (value) SelectedPageViewModel = ConfigSwitchesViewModel;
                    _switchesSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool TramLinesSelected
        {
            get { return _tramLinesSelected; }
            set
            {
                if (value != _tramLinesSelected)
                {
                    if (value) SelectedPageViewModel = ConfigTramLinesViewModel;
                    _tramLinesSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool ViewportSelected
        {
            get { return _viewportSelected; }
            set
            {
                if (value != _viewportSelected)
                {
                    if (value) SelectedPageViewModel = ConfigViewportViewModel;
                    _viewportSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool ButtonsSelected
        {
            get { return _buttonsSelected; }
            set
            {
                if (value != _buttonsSelected)
                {
                    if (value) SelectedPageViewModel = ConfigButtonsViewModel;
                    _buttonsSelected = value;
                    NotifyPropertyChanged();
                }
            }
        }


    }
}
