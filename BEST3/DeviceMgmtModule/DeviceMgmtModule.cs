using DeviceMgmtModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace DeviceMgmtModule
{
    public class DeviceMgmtModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ToolBarRegion", typeof(Connect));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}