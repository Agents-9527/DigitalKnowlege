using Prism.Commands;
using Prism.Ioc;
using Prism.Regions;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using 知识产权数字化平台.Share;
using 知识产权数字化平台.Views;

namespace 知识产权数字化平台.ViewModels
{
    internal class ShellViewModel
    {
        //private IContainerExtension Container;

        //public ICommand LoadCommand { get; }

        //public ShellViewModel(IContainerExtension containerExtension) {
        //    Container = containerExtension;
            
        //    LoadCommand = new DelegateCommand(Onloaded);
        //}
        //private void Onloaded()
        //{
        //    //获取窗口对象第一种方式
        //    Container.Resolve<IRegionManager>().RequestNavigate(RegionNames.MainRegion, ViewNames.LoginView);
        //}
        private IRegionManager RegionManager { get; }
        public ICommand LoadCommand { get; }
        /// <summary>
        /// 获取窗口的第二种方式，区别于shellViewModel中的代码
        /// </summary>
        /// <param name="regionManager"></param>
        public ShellViewModel(IRegionManager regionManager)
        {
            RegionManager = regionManager;
            LoadCommand = ReactiveCommand.Create(Onloaded);
        }

        private void Onloaded()
        {
            RegionManager.RequestNavigate(RegionNames.MainRegion, ViewNames.LoginView);
        }
    }
}
