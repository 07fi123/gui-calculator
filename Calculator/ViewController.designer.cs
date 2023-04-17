// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Calculator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton Add { get; set; }

		[Outlet]
		AppKit.NSTextField CalcOutput { get; set; }

		[Outlet]
		AppKit.NSButton Clear { get; set; }

		[Outlet]
		AppKit.NSButton DecimalPlace { get; set; }

		[Outlet]
		AppKit.NSButton Divide { get; set; }

		[Outlet]
		AppKit.NSButton Eight { get; set; }

		[Outlet]
		AppKit.NSButton Five { get; set; }

		[Outlet]
		AppKit.NSButton Four { get; set; }

		[Outlet]
		AppKit.NSButton Mod { get; set; }

		[Outlet]
		AppKit.NSButton Multiply { get; set; }

		[Outlet]
		AppKit.NSButton Nine { get; set; }

		[Outlet]
		AppKit.NSButton One { get; set; }

		[Outlet]
		AppKit.NSButton Seven { get; set; }

		[Outlet]
		AppKit.NSButton Six { get; set; }

		[Outlet]
		AppKit.NSButton Subtract { get; set; }

		[Outlet]
		AppKit.NSButton Three { get; set; }

		[Outlet]
		AppKit.NSButton Two { get; set; }

		[Outlet]
		AppKit.NSButton Zero { get; set; }

		[Action ("AddClick:")]
		partial void AddClick (Foundation.NSObject sender);

		[Action ("ClearButton:")]
		partial void ClearButton (AppKit.NSButton sender);

		[Action ("DecimalClick:")]
		partial void DecimalClick (Foundation.NSObject sender);

		[Action ("Divideclick:")]
		partial void Divideclick (Foundation.NSObject sender);

		[Action ("EightClick:")]
		partial void EightClick (Foundation.NSObject sender);

		[Action ("Evaluate:")]
		partial void Evaluate (Foundation.NSObject sender);

		[Action ("FiveClick:")]
		partial void FiveClick (Foundation.NSObject sender);

		[Action ("FourClick:")]
		partial void FourClick (Foundation.NSObject sender);

		[Action ("MinusClick:")]
		partial void MinusClick (Foundation.NSObject sender);

		[Action ("ModClick:")]
		partial void ModClick (Foundation.NSObject sender);

		[Action ("MulitplyClick:")]
		partial void MulitplyClick (Foundation.NSObject sender);

		[Action ("NineClick:")]
		partial void NineClick (Foundation.NSObject sender);

		[Action ("OneClick:")]
		partial void OneClick (Foundation.NSObject sender);

		[Action ("Output:")]
		partial void Output (AppKit.NSTextField sender);

		[Action ("SevenClick:")]
		partial void SevenClick (Foundation.NSObject sender);

		[Action ("SixClick:")]
		partial void SixClick (Foundation.NSObject sender);

		[Action ("swapSign:")]
		partial void swapSign (AppKit.NSButton sender);

		[Action ("SwapSign:")]
		partial void SwapSign (Foundation.NSObject sender);

		[Action ("ThreeClick:")]
		partial void ThreeClick (Foundation.NSObject sender);

		[Action ("TwoClick:")]
		partial void TwoClick (Foundation.NSObject sender);

		[Action ("ZeroClick:")]
		partial void ZeroClick (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (CalcOutput != null) {
				CalcOutput.Dispose ();
				CalcOutput = null;
			}

			if (One != null) {
				One.Dispose ();
				One = null;
			}

			if (Two != null) {
				Two.Dispose ();
				Two = null;
			}

			if (Three != null) {
				Three.Dispose ();
				Three = null;
			}

			if (Four != null) {
				Four.Dispose ();
				Four = null;
			}

			if (Five != null) {
				Five.Dispose ();
				Five = null;
			}

			if (Six != null) {
				Six.Dispose ();
				Six = null;
			}

			if (Seven != null) {
				Seven.Dispose ();
				Seven = null;
			}

			if (Eight != null) {
				Eight.Dispose ();
				Eight = null;
			}

			if (Nine != null) {
				Nine.Dispose ();
				Nine = null;
			}

			if (Zero != null) {
				Zero.Dispose ();
				Zero = null;
			}

			if (DecimalPlace != null) {
				DecimalPlace.Dispose ();
				DecimalPlace = null;
			}

			if (Multiply != null) {
				Multiply.Dispose ();
				Multiply = null;
			}

			if (Subtract != null) {
				Subtract.Dispose ();
				Subtract = null;
			}

			if (Add != null) {
				Add.Dispose ();
				Add = null;
			}

			if (Divide != null) {
				Divide.Dispose ();
				Divide = null;
			}

			if (Mod != null) {
				Mod.Dispose ();
				Mod = null;
			}

			if (Clear != null) {
				Clear.Dispose ();
				Clear = null;
			}
		}
	}
}
