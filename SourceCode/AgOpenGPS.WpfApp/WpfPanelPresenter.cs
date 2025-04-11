using AgOpenGPS.Core.Interfaces;
using AgOpenGPS.Core.ViewModels;
using AgOpenGPS.WpfApp.Configuration;
using AgOpenGPS.WpfApp.Field;
using System;
using System.Windows;

namespace AgOpenGPS.WpfApp
{
    public class WpfPanelPresenter : IPanelPresenter
    {
        private ConfigMenuDialog _configMenuDialog;
        private ConfigurationDialog _configurationDialog;

        private StartNewFieldDialog _startNewFieldDialog;
        private SelectNearFieldDialog _selectNearFieldDialog;
        private CreateFromExistingFieldDialog _createFromExistingFieldDialog;
        private SelectFieldDialog _selectFieldDialog;

        public void ShowConfigMenuDialog(ConfigMenuViewModel viewModel)
        {
            _configMenuDialog = new ConfigMenuDialog
            {
                DataContext = viewModel
            };
            _configMenuDialog.ShowDialog();
        }

        public void CloseConfigMenuDialog()
        {
            _configMenuDialog?.Close();
            _configMenuDialog = null;
        }

        public void ShowConfigurationDialog(ConfigurationViewModel viewModel)
        {
            _configurationDialog = new ConfigurationDialog
            {
                DataContext = viewModel
            };
            _configurationDialog.ShowDialog();
        }

        public void CloseConfigurationDialog()
        {
            _configurationDialog?.Close();
            _configurationDialog = null;
        }

        public void ShowStartNewFieldDialog(StartNewFieldViewModel viewModel)
        {
            _startNewFieldDialog = new StartNewFieldDialog
            {
                DataContext = viewModel
            };
            _startNewFieldDialog.ShowDialog();
        }

        public void CloseStartNewFieldDialog()
        {
            _startNewFieldDialog?.Close();
        }

        void IPanelPresenter.ShowSelectNearFieldDialog(SelectNearFieldViewModel viewModel)
        {
            viewModel.UpdateFields();
            _selectNearFieldDialog = new SelectNearFieldDialog
            {
                DataContext = viewModel
            };
            _selectNearFieldDialog.ShowDialog();
        }

        void IPanelPresenter.CloseSelectNearFieldDialog()
        {
            _selectNearFieldDialog?.Close();
        }

        public void ShowCreateFromExistingFieldDialog(CreateFromExistingFieldViewModel viewModel)
        {
            viewModel.UpdateFields();
            _createFromExistingFieldDialog = new CreateFromExistingFieldDialog
            {
                DataContext = viewModel
            };
            _createFromExistingFieldDialog.ShowDialog();
        }

        public void CloseCreateFromExistingFieldDialog()
        {
            _createFromExistingFieldDialog?.Close();
        }

        void IPanelPresenter.ShowSelectFieldDialog(SelectFieldViewModel viewModel)
        {
            viewModel.UpdateFields();
            _selectFieldDialog = new SelectFieldDialog
            {
                DataContext = viewModel
            };
            _selectFieldDialog.ShowDialog();
        }

        void IPanelPresenter.CloseSelectFieldDialog()
        {
            _selectFieldDialog.Close();
        }

        bool IPanelPresenter.ShowConfirmDeleteMessageBox(string fieldName)
        {
            MessageBoxResult result = MessageBox.Show(
                "Are you sure you want to delete field " + fieldName + "?",
                "Delete field",
                MessageBoxButton.OKCancel);
            return result == MessageBoxResult.OK;
        }

    }
}
