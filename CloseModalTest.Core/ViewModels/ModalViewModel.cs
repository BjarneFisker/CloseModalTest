using System;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Navigation;

namespace CloseModalTest.Core.ViewModels
{
    public class ModalViewModel : MvxViewModel
    {
        readonly IMvxNavigationService navigationService;

        public ModalViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }


        private MvxCommand _closeCommand;

        public ICommand CloseCommand
        {
            get
            {
                _closeCommand = _closeCommand ?? new MvxCommand(DoCloseCommand);
                return _closeCommand;
            }
        }

        private void DoCloseCommand()
        {

            //We don't want a simple 'close' here, since we need to kill the whole navigation tree in the modal view. 
            //navigationService.Close() would simply remove the last view in the modal navigation view controller

            //Since FirstViewModel is [MvxRootPresentation] it should clear the stack. This works fine the first time. but the second time we run it, it kills all navigation from FirstView

            navigationService.Navigate<FirstViewModel>();
        }

    }
}
