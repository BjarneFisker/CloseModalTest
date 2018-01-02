using CloseModalTest.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;

namespace CloseModalTest.iOS.Views
{
    [MvxRootPresentation]
    public partial class FirstView : MvxViewController<FirstViewModel>
    {
        public FirstView() : base(nameof(FirstView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(ShowModalButton).To(vm => vm.ShowModalCommand);
            set.Apply();

            InfoLabel.Text = nameof(FirstView) + " " + this.GetHashCode().ToString();
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            System.Console.WriteLine(string.Format("{0} controller disposed - {1}", this.GetType(), this.GetHashCode()));
        }
    }
}
