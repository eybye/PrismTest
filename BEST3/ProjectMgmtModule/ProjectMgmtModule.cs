using ProjectMgmtModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace ProjectMgmtModule
{
    public class ProjectMgmtModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ToolBarRegion", typeof(NewProject));
            regionManager.RegisterViewWithRegion("ToolBarRegion", typeof(OpenProject));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}