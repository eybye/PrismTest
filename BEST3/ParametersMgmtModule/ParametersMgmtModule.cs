using ParametersMgmtModule.Commands;
using ParametersMgmtModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ParametersMgmtModule
{
    public class ParametersMgmtModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ViewBarRegion", typeof(ViewBarCommand));
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ParameterMgmt));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewCommands, ViewCommands>();

            containerRegistry.RegisterForNavigation<Overview>();
            containerRegistry.RegisterForNavigation<Monitoring>();
            containerRegistry.RegisterForNavigation<Configuration>();
            containerRegistry.RegisterForNavigation<Alarm>();
        }
    }
}