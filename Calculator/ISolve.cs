using System;
namespace Calculator
{
	public interface ISolve
	{
		void Accumulate(string s);
		void Clear();
		double Solve();
	}
}

