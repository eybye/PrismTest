using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersMgmtModule.Commands
{
    public interface IViewCommands
    {
        CompositeCommand OverviewCommand { get; }
        CompositeCommand MonitoringCommand { get; }
        CompositeCommand ConfigurationCommand { get; }
        CompositeCommand AlarmCommand { get; }
    }

    public class ViewCommands : IViewCommands
    {
        private CompositeCommand _overviewCommand = new CompositeCommand();
        private CompositeCommand _monitoringCommand = new CompositeCommand();
        private CompositeCommand _configurationCommand = new CompositeCommand();
        private CompositeCommand _alarmCommand = new CompositeCommand();
        public CompositeCommand OverviewCommand
        {
            get { return _overviewCommand; }
        }
        public CompositeCommand MonitoringCommand
        {
            get { return _monitoringCommand; }
        }
        public CompositeCommand ConfigurationCommand
        {
            get { return _configurationCommand; }
        }
        public CompositeCommand AlarmCommand
        {
            get { return _alarmCommand; }
        }
    }
}
