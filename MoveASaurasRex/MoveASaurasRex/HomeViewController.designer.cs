// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace MoveASaurasRex
{
	[Register ("HomeViewController")]
	partial class HomeViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ListsButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton MoveDetailsButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ListsButton != null) {
				ListsButton.Dispose ();
				ListsButton = null;
			}
			if (MoveDetailsButton != null) {
				MoveDetailsButton.Dispose ();
				MoveDetailsButton = null;
			}
		}
	}
}
