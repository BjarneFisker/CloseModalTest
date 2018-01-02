using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Navigation;

namespace CloseModalTest.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        readonly IMvxNavigationService navigationService;

        public FirstViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        private MvxCommand _showModalCommand;

        public ICommand ShowModalCommand
        {
            get
            {
                _showModalCommand = _showModalCommand ?? new MvxCommand(DoShowMoCommand);
                return _showModalCommand;
            }
        }

        private void DoShowMoCommand()
        {
            navigationService.Navigate<ModalViewModel>();
        }
    }
}
