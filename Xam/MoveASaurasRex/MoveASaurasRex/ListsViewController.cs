using System;
using Foundation;
using UIKit;
using System.CodeDom.Compiler;

namespace MoveASaurasRex
{
	partial class ListsViewController : UITableViewController
	{
		public ListsViewController (IntPtr handle) : base (handle)
		{
		}

		[Action("UnwindToListsViewController:")]
		public void UnwindToListsViewController(UIStoryboardSegue segue)
		{
			Console.WriteLine ("going back to lists page");
		}
	}
}
