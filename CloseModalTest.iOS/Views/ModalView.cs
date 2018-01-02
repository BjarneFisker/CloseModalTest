using System;
using System.Drawing;
using Foundation;
using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using CloseModalTest.Core.ViewModels;
using MvvmCross.iOS.Views.Presenters.Attributes;

namespace CloseModalTest.iOS.Views
{
    [MvxModalPresentationAttribute(WrapInNavigationController = true)]
    public partial class ModalView : MvxViewController<ModalViewModel>
    {
        public ModalView() : base(nameof(ModalView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<ModalView, ModalViewModel>();
            set.Bind(CloseButton).To(vm => vm.CloseCommand);
            set.Apply();

            InfoLabel.Text = nameof(ModalView) + " " + this.GetHashCode().ToString();
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            System.Console.WriteLine(string.Format("{0} controller disposed - {1}", this.GetType(), this.GetHashCode()));
        }
    }
}
