using Prism.Regions;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using 知识产权数字化平台.Share;

namespace 知识产权数字化平台.ViewModels
{
    internal class LoginViewModel:ReactiveObject
    {
        // ===================== 核心：当前显示的ViewModel =====================
        private IReactiveObject _currentViewModel;
        public IReactiveObject CurrentViewModel
        {
            get => _currentViewModel;
            // ReactiveUI 自带属性通知，自动更新UI
            set => this.RaiseAndSetIfChanged(ref _currentViewModel, value);
        }
        private IRegionManager RegionManager { get; }

        // ===================== 响应式切换命令 =====================
        public ReactiveCommand<Unit, Unit> NavigateToHomeCommand { get; }
        //public ICommand LoginCommand { get; }
        ///// <summary>
        ///// 获取窗口的第二种方式，区别于shellViewModel中的代码
        ///// </summary>
        ///// <param name="regionManager"></param>
        //public LoginViewModel(IRegionManager regionManager)
        //{
        //    RegionManager = regionManager;
        //    LoginCommand = ReactiveCommand.Create(OnLoginCommand);
        //}

        //private void OnLoginCommand()
        //{
            
        //    RegionManager.RequestNavigate(RegionNames.MainRegion, ViewNames.MainView);
        //}
        public LoginViewModel()
        {
            // 初始化命令：执行时切换ViewModel
            NavigateToHomeCommand = ReactiveCommand.Create(() => CurrentViewModel = new MainViewModel());
        }
    }
}
