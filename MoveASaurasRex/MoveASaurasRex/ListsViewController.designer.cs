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
	[Register ("ListsViewController")]
	partial class ListsViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIBarButtonItem AddListButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (AddListButton != null) {
				AddListButton.Dispose ();
				AddListButton = null;
			}
		}
	}
}
