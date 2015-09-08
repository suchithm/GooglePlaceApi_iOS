using System;   
using Foundation;
using UIKit;

namespace DataManip
{
	public partial class ViewController : UIViewController
	{ 
		public ViewController ( IntPtr handle ) : base ( handle )
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			FnInitialize ();
		
		}
		void FnInitialize()
		{
			//check place api implementation in LocationViewController
		}
		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue (segue, sender);

			if(segue.Identifier!=null)
			if(segue.Identifier.Equals("ToLocation"))
			{  
				var objSecondViewController =	segue.DestinationViewController as LocationViewController;
				if ( objSecondViewController != null )
				{
					objSecondViewController.strSampleString = "DataToLocation";

				}

			}
		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning (); 
		}
	}
}

