// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DataManip
{
	[Register ("LocationViewController")]
	partial class LocationViewController
	{
		[Outlet]
		UIKit.UIButton btnBack { get; set; }

		[Outlet]
		UIKit.UITableView tableViewLocationAutoComplete { get; set; }

		[Outlet]
		UIKit.UITextField txtLocation { get; set; }

		[Outlet]
		UIKit.UIView ViewMainLocationContainer { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tableViewLocationAutoComplete != null) {
				tableViewLocationAutoComplete.Dispose ();
				tableViewLocationAutoComplete = null;
			}

			if (txtLocation != null) {
				txtLocation.Dispose ();
				txtLocation = null;
			}

			if (ViewMainLocationContainer != null) {
				ViewMainLocationContainer.Dispose ();
				ViewMainLocationContainer = null;
			}

			if (btnBack != null) {
				btnBack.Dispose ();
				btnBack = null;
			}
		}
	}
}
