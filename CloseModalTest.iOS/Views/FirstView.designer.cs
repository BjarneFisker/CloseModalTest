// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CloseModalTest.iOS.Views
{
	[Register ("FirstView")]
	partial class FirstView
	{
		[Outlet]
		UIKit.UILabel InfoLabel { get; set; }

		[Outlet]
		UIKit.UIButton ShowModalButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ShowModalButton != null) {
				ShowModalButton.Dispose ();
				ShowModalButton = null;
			}

			if (InfoLabel != null) {
				InfoLabel.Dispose ();
				InfoLabel = null;
			}
		}
	}
}
