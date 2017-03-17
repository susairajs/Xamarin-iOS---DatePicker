// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamariniOSDatePicker
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker datePicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDisplay { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (datePicker != null) {
                datePicker.Dispose ();
                datePicker = null;
            }

            if (lblDisplay != null) {
                lblDisplay.Dispose ();
                lblDisplay = null;
            }
        }
    }
}