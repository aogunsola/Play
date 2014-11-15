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
	[Register ("CreateListViewController")]
	partial class CreateListViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CancelButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton DoneButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch FolderSwitch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField ListNameText { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (CancelButton != null) {
				CancelButton.Dispose ();
				CancelButton = null;
			}
			if (DoneButton != null) {
				DoneButton.Dispose ();
				DoneButton = null;
			}
			if (FolderSwitch != null) {
				FolderSwitch.Dispose ();
				FolderSwitch = null;
			}
			if (ListNameText != null) {
				ListNameText.Dispose ();
				ListNameText = null;
			}
		}
	}
}
