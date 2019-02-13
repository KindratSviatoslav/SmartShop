using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows.Input;

namespace SmartShop.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
		private IRegionManager _regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
			_regionManager = regionManager;
			ContentRegionLoadedCommand = new DelegateCommand(() => 
			{
				_regionManager.RequestNavigate("ContentRegion", "ViewLogin");
			});
        }

		public ICommand ContentRegionLoadedCommand { get; private set; }
	}
}
