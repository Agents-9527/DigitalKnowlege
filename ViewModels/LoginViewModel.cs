using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using 知识产权数字化平台.Share;

namespace 知识产权数字化平台.ViewModels
{
    public class LoginViewModel
    {
        //#region 绑定属性（Prism的SetProperty自动触发UI更新）
        //private string _userName;
        ///// <summary>
        ///// 用户名（绑定到输入框）
        ///// </summary>
        //public string UserName
        //{
        //    get => _userName;
        //    set => SetProperty(ref _userName, value); // 线程安全（但需在UI线程调用）
        //}

        //private string _password;
        ///// <summary>
        ///// 密码（绑定到输入框）
        ///// </summary>
        //public string Password
        //{
        //    get => _password;
        //    set => SetProperty(ref _password, value);
        //}

        //private string _tipText;
        ///// <summary>
        ///// 登录提示文本（绑定到UI）
        ///// </summary>
        //public string TipText
        //{
        //    get => _tipText;
        //    set => SetProperty(ref _tipText, value);
        //}

        //private bool _isLoginButtonEnabled;
        ///// <summary>
        ///// 登录按钮是否可用（绑定到UI）
        ///// </summary>
        //public bool IsLoginButtonEnabled
        //{
        //    get => _isLoginButtonEnabled;
        //    set => SetProperty(ref _isLoginButtonEnabled, value);
        //}
        //#endregion

        private IRegionManager RegionManager { get; }//Prism导航服务

        public ICommand LoginCommand { get; }

        private IContainerExtension Container;


        public LoginViewModel(IContainerExtension containerExtension)
        {
            Container = containerExtension;
            LoginCommand = new DelegateCommand(OnLoginCommand);
            
        }
        private void OnLoginCommand()
        {
            //获取窗口对象第一种方式
            Container.Resolve<IRegionManager>().RequestNavigate(RegionNames.MainRegion, ViewNames.MainView);
        }
        /// <summary>
        /// 获取窗口的第二种方式，区别于shellViewModel中的代码，后被证实会出现跨线程冲突
        /// </summary>
        /// <param name="regionManager"></param>
        //public LoginViewModel(IRegionManager regionManager)
        //{
        //    RegionManager = regionManager;
        //    //LoginCommand = ReactiveCommand.Create(OnLoginCommand);
        //    LoginCommand = new DelegateCommand(async () => await ExecuteLoginAsync());

        //    IsLoginButtonEnabled = true;
        //}

        #region 核心：异步登录逻辑（解决跨线程问题）
        //private async Task ExecuteLoginAsync()
        //{
        //    try
        //    {
        //        // 1. UI线程：禁用按钮 + 更新提示（无跨线程问题）
        //        IsLoginButtonEnabled = false;
        //        TipText = "正在登录，请稍候...";

        //        // 2. 捕获UI线程的输入值（避免后台线程访问绑定属性）
        //        string currentUserName = UserName;
        //        string currentPassword = Password;

        //        // 3. 后台线程执行耗时登录逻辑（Task.Run切到线程池）
        //        // .NET Framework 4.7.2中Task.Run完全兼容
        //        bool loginSuccess = await Task.Run(() =>
        //        {
        //            // 此处仅为示例：替换为你的真实登录逻辑（数据库/接口调用）
        //            // 模拟耗时操作（1秒）
        //            System.Threading.Thread.Sleep(1000);

        //            // 简单验证（实际需加密/校验）
        //            return currentUserName == "12" && currentPassword == "123";
        //        });

        //        // 4. await后自动切回UI线程：安全更新属性/执行导航
        //        if (loginSuccess)
        //        {
        //            TipText = "登录成功！正在跳转...";
        //            // Prism导航（UI操作，必须在UI线程）
        //            RegionManager.RequestNavigate(RegionNames.MainRegion, ViewNames.MainView); // 替换为你的主界面Region和View名称
        //        }
        //        else
        //        {
        //            TipText = "账号或密码错误，请重试！";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // 异常处理（UI线程）
        //        TipText = $"登录失败：{ex.Message}";
        //        MessageBox.Show($"登录异常：{ex.InnerException?.Message ?? ex.Message}", "错误",
        //            MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //    finally
        //    {
        //        // UI线程：恢复按钮状态
        //        IsLoginButtonEnabled = true;
        //    }
        //}
        #endregion

        //private void OnLoginCommand()
        //{

        //    RegionManager.RequestNavigate(RegionNames.MainRegion, ViewNames.MainView);
        //}

    }
}
