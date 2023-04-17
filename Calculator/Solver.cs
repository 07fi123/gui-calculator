using System;
namespace Calculator
{
    public class Solver : ISolve
    {

        public string Accumulator { get; set; }

        public void Accumulate(string s)
        {
            Accumulator += s;
        }

        public void Clear()
        {
            Accumulator = "";
        }
        public double Solve()
        {
            Accumulator = MatchOperation();
            double result;
            if (double.TryParse(Accumulator, out result))
            {
                return result;
            }
            return 0;
        }
        // private int ExtractLHS(int i){
        //     int number;
        //     if(i <= 0 || i == 0){
        //         Console.WriteLine("The hell");

        //         return i; 
        //     }
        //     if(!(int.TryParse(Accumulator[i]+"", out number) || Accumulator[i].Equals('.')))
        //     {
        //         Console.WriteLine("The hell");
        //         return i++;
        //     }
        //     int k = i-1;

        //     return ExtractLHS(k);
        // }
        // private int ExtractRHS(int i){
        //     int number;
        //     if(i >= Accumulator.Length){
        //         return i; 
        //     }
        //     if(!(int.TryParse(Accumulator[i]+"", out number) || Accumulator[i].Equals('.')))
        //     {
        //         return i;
        //     }
        //     int k = i+1;

        //     return ExtractRHS(k);
        // }


        private (int, int, string, string) GetOperands(int i)
        {
            int number;
            string blah = "";
            string lhs = "";
            string rhs = "";
            int lhsIndex = i - 1;
            int rhsIndex = i + 1;
            while (lhsIndex >= 0)
            {
                if (!(int.TryParse(Accumulator[lhsIndex] + "", out number) || Accumulator[lhsIndex].Equals('.') || Accumulator[rhsIndex].Equals('-')))
                {
                    break;
                }
                if (lhsIndex > 0)
                {
                    blah += Accumulator[lhsIndex];
                    lhsIndex--;
                }
                else
                {
                    blah += Accumulator[lhsIndex];
                    break;
                }

            }
            // Un-reverse the string woot
            for (int z = blah.Length - 1; z >= 0; z--)
            {
                lhs += (blah[z]);
            }

            // I think we should be able to iderate again to go backwards to get the correct number order. 
            // Go backwards to go forwards.
            while (rhsIndex < Accumulator.Length)
            {
                if (!(int.TryParse(Accumulator[rhsIndex] + "", out number) || Accumulator[rhsIndex].Equals('.') || Accumulator[rhsIndex].Equals('-')))
                {
                    break;
                }
                if (rhsIndex < Accumulator.Length - 1)
                {
                    rhs += Accumulator[rhsIndex];
                    rhsIndex++;
                }
                else
                {
                    rhs += Accumulator[rhsIndex];
                    break;
                }
            }
            Console.WriteLine("LHS: {0}, RHS:{1}", lhs, rhs);
            Console.WriteLine("LHSindex: {0}, RHSindex:{1}\n Length:{2}", lhsIndex, rhsIndex, Accumulator.Length);


            return (lhsIndex, rhsIndex, lhs, rhs);


        }

        private (string, string) getTheRest(int lhsIndex, int rhsIndex)
        {

            string leftPart = "";
            if (!(lhsIndex <= 0))
            {
                for (int b = 0; b <= lhsIndex; b++)
                {
                    leftPart += Accumulator[b];
                }
            }
            string rightPart = "";

            if (!(rhsIndex >= Accumulator.Length - 1))
            {
                for (int b = rhsIndex; b < Accumulator.Length; b++)
                {
                    rightPart += Accumulator[b];
                }
            }
            Console.WriteLine("LeftPart: {0}, RightPart: {1}", leftPart, rightPart);

            return (leftPart, rightPart);
        }

        //private void Extract()
        private string MatchOperation()
        {
            Console.WriteLine("-----------------------------");
            if (Accumulator.IndexOf("*") >= 0)
            {
                int i = Accumulator.IndexOf("*");
                (int lhsIndex, int rhsIndex, string lhs, string rhs) = GetOperands(i);

                double result = double.Parse(rhs) * double.Parse(lhs);
                (string leftPart, string rightPart) = getTheRest(lhsIndex, rhsIndex);
                Accumulator = leftPart + result.ToString() + rightPart;
                Console.WriteLine(Accumulator);
                MatchOperation();
            }
            if (Accumulator.IndexOf("/") >= 0)
            {
                int i = Accumulator.IndexOf("/");
                (int lhsIndex, int rhsIndex, string lhs, string rhs) = GetOperands(i);
                double result = double.Parse(lhs) / double.Parse(rhs);
                (string leftPart, string rightPart) = getTheRest(lhsIndex, rhsIndex);
                Accumulator = leftPart + result.ToString() + rightPart;
                Console.WriteLine(Accumulator);
                MatchOperation();
            }
            if (Accumulator.IndexOf("%") >= 0)
            {
                int i = Accumulator.IndexOf("%");
                (int lhsIndex, int rhsIndex, string lhs, string rhs) = GetOperands(i);
                double result = double.Parse(lhs) % double.Parse(rhs);
                (string leftPart, string rightPart) = getTheRest(lhsIndex, rhsIndex);
                Accumulator = leftPart + result.ToString() + rightPart;
                MatchOperation();

            }
            if (Accumulator.IndexOf("+") >= 0)
            {
                int i = Accumulator.IndexOf("+");
                (int lhsIndex, int rhsIndex, string lhs, string rhs) = GetOperands(i);
                double result = double.Parse(lhs) + double.Parse(rhs);
                (string leftPart, string rightPart) = getTheRest(lhsIndex, rhsIndex);
                Accumulator = leftPart + result.ToString() + rightPart;
                Console.WriteLine(Accumulator);
                MatchOperation();

            }
            if (Accumulator.IndexOf("-") >= 0)
            {
                int i = Accumulator.IndexOf("-");
                (int lhsIndex, int rhsIndex, string lhs, string rhs) = GetOperands(i);
                double result = double.Parse(lhs) - double.Parse(rhs);
                (string leftPart, string rightPart) = getTheRest(lhsIndex, rhsIndex);
                Accumulator = leftPart + result.ToString() + rightPart;
                Console.WriteLine(Accumulator);
                MatchOperation();

            }
            else
            {
                return Accumulator;
            }
            return Accumulator;


        }


        public Solver()
        {
            Accumulator = "";
        }
    }
}