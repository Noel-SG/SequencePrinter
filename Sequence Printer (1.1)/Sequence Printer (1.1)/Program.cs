using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.RegularExpressions;


namespace Sequence_Printer {
    class Program {

        static void Main(string[] args) {


            Console.WriteLine("SEQUENCE PRINTER");
            Console.WriteLine("Version 1.0.0");
            RunProgram();

            Console.ReadKey();
        }


        static void printHyphens() {
            for (int i = 0; i < 70; i++) {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        static void printOptions() {
            Console.WriteLine("   -Linear sequence      = lins");
            Console.WriteLine("   -Quadratic sequence   = quads");
            Console.WriteLine("   -Cubic sequence       = cubs");
            Console.WriteLine("   -Exponential sequence = exps");
            Console.WriteLine("   -Fibonacci sequence   = fibs");
        }

        static double[] getLinearSequenceValues() {
            Console.WriteLine("Please enter ___ n + b");
            double LinFirstTerm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter " + LinFirstTerm + "n +-" + " ___");
            double LinSecondTerm = Convert.ToDouble(Console.ReadLine());

            double[] LinArray = new double[2];

            LinArray[0] = LinFirstTerm;
            LinArray[1] = LinSecondTerm;

            return LinArray;

        }
        static void calculateLinearSequence(double[] LinResult) {

            double LinFirstTerm = LinResult[0];
            double LinSecondTerm = LinResult[1];



            Console.WriteLine("How many terms do you want to print?");
            long termNumber = Convert.ToInt64(Console.ReadLine());

            for (int i = 1; i < (termNumber + 1); i++) {
                Console.Write(LinFirstTerm * i + LinSecondTerm + ", ");

            }

        }

        static double[] getQuadraticSequenceValues() {
            Console.WriteLine("Please enter ____n^2 + bn + c");
            double QuadFirstTerm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter " + QuadFirstTerm + "^2 + ____n + c");
            double QuadSecondTerm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter " + QuadFirstTerm + "^2 " + QuadSecondTerm + "n + ____");
            double QuadThirdTerm = Convert.ToDouble(Console.ReadLine());

            double[] quadArray = new double[3];

            quadArray[0] = QuadFirstTerm;
            quadArray[1] = QuadSecondTerm;
            quadArray[2] = QuadThirdTerm;

            return quadArray;
        }
        static void calculateQuadraticSequence(double[] QuadResult) {

            double QuadFirstTerm = QuadResult[0];
            double QuadSecondTerm = QuadResult[1];
            double QuadThirdTerm = QuadResult[2];

            Console.WriteLine("How many terms do you want to print?");
            int termnumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < (termnumber + 1); i++) {
                Console.Write(QuadFirstTerm * Math.Pow(i, 2) + QuadSecondTerm * i + QuadThirdTerm + ", ");
            }



        }

        static double[] getCubicSequenceValue() {

            Console.WriteLine("Please enter  ___n^3 + bn^2 + cn + d");
            double CubFirstTerm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter " + CubFirstTerm + "n^3 + ____n^2 + cn + d");
            double CubSecondTerm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter " + CubFirstTerm + "n^3 + " + CubSecondTerm + "n^2 + ___n + d");
            double CubThirdTerm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter " + CubFirstTerm + "n^3 + " + CubSecondTerm + "n^2 + " + CubThirdTerm + "n + ____");
            double CubFourthTerm = Convert.ToDouble(Console.ReadLine());

            double[] cubArray = new double[4];

            cubArray[0] = CubFirstTerm;
            cubArray[1] = CubSecondTerm;
            cubArray[2] = CubThirdTerm;
            cubArray[3] = CubFourthTerm;

            return cubArray;



        }
        static void calculateCubicSequence(double[] CubResult) {

            double CubFirstTerm = CubResult[0];
            double CubSecondTerm = CubResult[1];
            double CubThirdTerm = CubResult[2];
            double CubFourthTerm = CubResult[3];

            Console.WriteLine("How many terms do you want to print?");
            int termnumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < termnumber + 1; i++) {

                Console.Write(CubFirstTerm * Math.Pow(i, 3) + CubSecondTerm * Math.Pow(i, 2) + CubThirdTerm * i + CubFourthTerm + ", ");

            }

        }

        static double[] getExponentialSequenceValue() {
            Console.WriteLine("Please enter ___ b^(n-c)");
            double ExpFirstTerm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter " + ExpFirstTerm + "____^(n-c)");
            double ExpSecondTerm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter " + ExpFirstTerm + ExpSecondTerm + " ^(n-____)");
            double ExpThirdTerm = Convert.ToDouble(Console.ReadLine());

            double[] expArray = new double[3];


            expArray[0] = ExpFirstTerm;
            expArray[1] = ExpSecondTerm;
            expArray[3] = ExpThirdTerm;

            return expArray;
        }
        static void calculateExponentialSequence(double[] ExpResult) {

            double ExpFirstTerm = ExpResult[0];
            double ExpSecondTerm = ExpResult[1];
            double ExpThirdTerm = ExpResult[3];

            Console.WriteLine("How many terms do you want to print?");
            int termnumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < termnumber + 1; i++) {
                Console.Write(ExpFirstTerm * Math.Pow(ExpSecondTerm, i - ExpThirdTerm) + ", ");

            }


        }

        static void printFibonacciSequence() {

            Console.WriteLine("How many terms do you want to print?");
            long termnumber = Convert.ToInt64(Console.ReadLine());
            int FibTerm1 = 0;
            int FibTerm2 = 1;
            int FibTerm3;

            Console.Write(FibTerm1 + ", " + FibTerm2 + ", ");
            for (int i = 1; i < termnumber; i++) {
                FibTerm3 = FibTerm2 + FibTerm1;
                Console.Write(FibTerm3 + ", ");
                FibTerm1 = FibTerm2;
                FibTerm2 = FibTerm3;
            }
        }

        static void newLine() {
            Console.WriteLine();
        }

        static void RunProgram() {
            printHyphens();
            Restart:
            Console.WriteLine("Please choose an option:");
            printOptions();
            newLine();
            Console.Write("Command :   ");
            string userResponse = Console.ReadLine();


            if (userResponse == "lins") {
                double[] LinResult = getLinearSequenceValues();
                calculateLinearSequence(LinResult);

            }
            else if (userResponse == "quads") {
                double[] QuadResult = getQuadraticSequenceValues();
                calculateQuadraticSequence(QuadResult);
            }
            else if (userResponse == "cubs") {
                double[] CubResult = getCubicSequenceValue();
                calculateCubicSequence(CubResult);
            }
            else if (userResponse == "exps") {
                double[] ExpResult = getExponentialSequenceValue();
                calculateExponentialSequence(ExpResult);
            }
            else if (userResponse == "fibs") {
                printFibonacciSequence();

            }
            else {
                Console.WriteLine("Please enter a valid command.");
                goto Restart;
            }
            Console.WriteLine();

            Console.WriteLine("Enter another sequence (y/n)?");
            string userResponse2 = Console.ReadLine();
            if (userResponse2 == "y") {
                Console.WriteLine();
                RunProgram();
            }

            else {
                Environment.Exit(0);
            }


        }




        

    }
}
