using System;

using UIKit;

namespace Phoneword
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			Console.WriteLine ("=> DidLoad!");

			string translatedNumber = ""; 
			TranslateButton.TouchUpInside += (object sender, EventArgs e) => { 
				// Convert the phone number with text to a number 
				// using PhoneTranslator.cs 
				translatedNumber = PhoneTranslator.ToNumber( PhoneNumberText.Text); 
				Console.WriteLine("=> translatedNumber: {0}", translatedNumber);

				ResultLabel.Text = translatedNumber;
			};
				
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

