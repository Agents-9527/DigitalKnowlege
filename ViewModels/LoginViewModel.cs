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
    internal class LoginViewModel
    {
        private IRegionManager RegionManager { get; }
        public ICommand LoginCommand { get; }
        /// <summary>
        /// 获取窗口的第二种方式，区别于shellViewModel中的代码
        /// </summary>
        /// <param name="regionManager"></param>
        public LoginViewModel(IRegionManager regionManager)
        {
            RegionManager = regionManager;
            LoginCommand = ReactiveCommand.Create(OnLoginCommand);
        }

        private void OnLoginCommand()
        {
            RegionManager.RequestNavigate(RegionNames.MainRegion, ViewNames.MainView);
        }
    }
}
