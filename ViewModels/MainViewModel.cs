using Prism.Commands;
using Prism.Regions;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using 知识产权数字化平台.Share;

namespace 知识产权数字化平台.ViewModels
{
    internal class MainViewModel 
    {
        private IRegionManager RegionManager { get; }
        public ICommand LogoutCommand { get; }
        public ICommand MainLoadCommand { get; }

        public MainViewModel(IRegionManager regionManager)
        {
            RegionManager = regionManager;
            LogoutCommand = ReactiveCommand.Create(OnLogoutCommand);
            MainLoadCommand = ReactiveCommand.Create(OnMainload);
            //MainLoadCommand = new DelegateCommand(OnMainload);
        }

        private void OnMainload()
        {
            RegionManager.RequestNavigate(RegionNames.ContainerRegion, ViewNames.indexView);
        }

        private void OnLogoutCommand()
        {
            RegionManager.RequestNavigate(RegionNames.MainRegion, ViewNames.LoginView);
        }
    }
}
