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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btnDoCall { get; set; }

		[Outlet]
		UIKit.UIButton btnNext { get; set; }

		[Outlet]
		UIKit.UIButton btnTranslate { get; set; }

		[Outlet]
		UIKit.UITextField txtPhoneWords { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnDoCall != null) {
				btnDoCall.Dispose ();
				btnDoCall = null;
			}

			if (btnTranslate != null) {
				btnTranslate.Dispose ();
				btnTranslate = null;
			}

			if (txtPhoneWords != null) {
				txtPhoneWords.Dispose ();
				txtPhoneWords = null;
			}

			if (btnNext != null) {
				btnNext.Dispose ();
				btnNext = null;
			}
		}
	}
}
