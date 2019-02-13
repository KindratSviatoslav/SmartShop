using SmartShop.Views;
using Prism.Ioc;
using System.Windows;
using Prism.Modularity;
using System;
using UserManagment.Views;

namespace SmartShop
{
	public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
			//Navigation registration
			containerRegistry.RegisterForNavigation<ViewLogin>();
        }

		protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
		{
			base.ConfigureModuleCatalog(moduleCatalog);
			Type userManagmentModule = typeof(UserManagment.UserManagmentModule);
			moduleCatalog.AddModule(
			  new ModuleInfo()
			  {
				  ModuleName = userManagmentModule.Name,
				  ModuleType = userManagmentModule.AssemblyQualifiedName,
			  });
		}
	}
}
