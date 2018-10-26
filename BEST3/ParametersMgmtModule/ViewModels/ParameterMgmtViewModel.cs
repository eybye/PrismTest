using ParametersMgmtModule.Commands;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersMgmtModule.ViewModels
{
    public class ParameterMgmtViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IViewCommands _viewCommands;

        public DelegateCommand OverviewCommand { get; private set; }
        public DelegateCommand MonitoringCommand { get; private set; }
        public DelegateCommand ConfigurationCommand { get; private set; }
        public DelegateCommand AlarmCommand { get; private set; }

        public ParameterMgmtViewModel(IRegionManager regionManager, IViewCommands viewCommands)
        {
            _regionManager = regionManager;
            _viewCommands = viewCommands;

            OverviewCommand = new DelegateCommand(OverviewExecuted);
            MonitoringCommand = new DelegateCommand(MonitoringExecuted);
            ConfigurationCommand = new DelegateCommand(ConfigurationExecuted);
            AlarmCommand = new DelegateCommand(AlarmExecuted);
            _viewCommands.OverviewCommand.RegisterCommand(OverviewCommand);
            _viewCommands.MonitoringCommand.RegisterCommand(MonitoringCommand);
            _viewCommands.ConfigurationCommand.RegisterCommand(ConfigurationCommand);
            _viewCommands.AlarmCommand.RegisterCommand(AlarmCommand);
        }

        private void OverviewExecuted()
        {
            Navigate("Overview");
        }
        private void MonitoringExecuted()
        {
            Navigate("Monitoring");
        }
        private void ConfigurationExecuted()
        {
            Navigate("Configuration");
        }
        private void AlarmExecuted()
        {
            Navigate("Alarm");
        }

        private void Navigate(string navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate("ParamMgmtRegion", navigatePath);
        }
    }
}
