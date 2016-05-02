using Foundation;
using System;
using System.CodeDom.Compiler;
using MonoTouch.Dialog;
using UIKit;

namespace App1
{
    partial class ViewControlerLogIn : UIViewController
    {
        public ViewControlerLogIn(IntPtr handle) : base(handle)
        {

        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }
        public void SignUpScreemFill (UITableView viewer)
        {
           //viewer.ReloadSections = new DialogViewController(new RootElement("Username"));
        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    
    }
}
