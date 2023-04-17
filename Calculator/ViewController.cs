using GameController;
using ObjCRuntime;

namespace Calculator;

public partial class ViewController : NSViewController {
	protected ViewController (NativeHandle handle) : base (handle)
	{
		// This constructor is required if the view controller is loaded from a xib or a storyboard.
		// Do not put any initialization here, use ViewDidLoad instead.
	}
	private string calcString = "";

	public string CalcOutputString { get {
			return calcString;
        }
        set
		{
			Console.WriteLine(value);
			if (value == "switch")
			{
				string equ = calcString;
				if (equ.Length == 0)
				{
					calcString = "";
					calcString += "-";
					calcString += equ;
					Console.WriteLine("WTF" + calcString);
					string formatedOutput = String.Format("{0}\n----\n{1}", calcString, solutionString);
					CalcOutput.StringValue = formatedOutput;
				}
				else
				{
					if (equ[0] != '-')
					{
						calcString = "";
						calcString += "-";
						calcString += equ;
						string formatedOutput = String.Format("{0}\n----\n{1}", calcString, solutionString);
						CalcOutput.StringValue = formatedOutput;
					}
					else
					{
						calcString = calcString.Substring(1, calcString.Length - 1);
						string formatedOutput = String.Format("{0}\n----\n{1}", calcString, solutionString);
						CalcOutput.StringValue = formatedOutput;
					}
				}
			}
			else
			{
				calcString = value;
				string formatedOutput = String.Format("{0}\n----\n{1}", calcString, solutionString);
				CalcOutput.StringValue = formatedOutput;
			}
		}
	}
	private string solutionString = " ";
	public string Solution{
		get
		{
			return solutionString;
		}
		set
		{
			solutionString = value;
			CalcOutputString = CalcOutputString;
		}
	}

	public override void ViewDidLoad ()
	{
		base.ViewDidLoad ();
		
		// Do any additional setup after loading the view.
		UpdateCalcOutput("", "");
	}

	public override NSObject RepresentedObject {
		get => base.RepresentedObject;
		set {
			base.RepresentedObject = value;

			// Update the view, if already loaded.
		}
	}
    partial void Evaluate(NSObject sender)
    {
		Solver itSolves = new Solver();
		itSolves.Accumulate(calcString);
		double solution = itSolves.Solve();
		Solution = solution.ToString();
        
    }


    
	public void UpdateCalcOutput(string input, string eval="") {
		string formatedOutput = String.Format("{0}\n----\n{1}", input, eval);
		CalcOutput.StringValue = formatedOutput;
	}
	partial void OneClick(NSObject sender) {
		CalcOutputString += "1";
	}
	partial void TwoClick(NSObject sender) {
		CalcOutputString += "2";
	}
    partial void ThreeClick(NSObject sender)
    {
		CalcOutputString += "3";
    }
    partial void FourClick(NSObject sender)
    {
		CalcOutputString += "4";
    }
    partial void FiveClick(NSObject sender)
    {
		CalcOutputString += "5";
    }
	partial void SixClick(NSObject sender) {
		CalcOutputString += "6";
	}

    partial void SevenClick(NSObject sender)
    {
		CalcOutputString += "7";
    }
    partial void EightClick(NSObject sender)
    {
		CalcOutputString += "8";
    }

    partial void NineClick(NSObject sender)
    {
		CalcOutputString += "9";
    }
    partial void ZeroClick(NSObject sender)
    {
		CalcOutputString += "0";
    }
    partial void DecimalClick(NSObject sender)
    {
		CalcOutputString += ".";
    }

    partial void AddClick(NSObject sender)
    {
		CalcOutputString += "+";
    }

    partial void MulitplyClick(NSObject sender)
    {
		CalcOutputString += "*";
    }
    partial void Divideclick(NSObject sender)
    {
		CalcOutputString += "/";
    }
    partial void MinusClick(NSObject sender)
    {
		CalcOutputString += "-";
    }
    partial void SwapSign(NSObject sender)
    {
		CalcOutputString = "switch";
    }


    partial void ClearButton(NSButton sender)
    {
		CalcOutputString = "";
		Solution = "";
    }





    partial void Output(NSTextField sender)
	{
		throw new NotImplementedException();

	}




}