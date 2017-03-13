using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace skijumping_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic settings

            // Constants
            double k_point = 116;
            double k_pointBasic = 60; // K-point, base points

            // Variables
            int skierID = 0; // Skier´s competiror number
            double platformAdjustment = 0; // difference to original platform height
            double lengthfactor = 1.8; // how many points per metre
            double windFactor = 0; // tailwind is negative and headwind is positive
            double measuredLength = 0;
            double judges = 0;
            int counter = 1;
            int skierCounter = -1;


            // Results
            double windPoints = 0; // calculated wind effect to the points
            double platformPoints = 0; // calculated platform effect to the points
            double jumpLenghtPoints = 0; // points only from the length
            double totalPoints = 0; // includes all sub calculations


            List<int> Skiers = new List<int>(); // Skiers ID list
            List<double> ResultLengthPoints = new List<double>();
            List<double> ResultWindPoints = new List<double>();
            List<double> ResultPlatformPoints = new List<double>();
            List<double> ResultJudgesPoints = new List<double>();
            List<double> ResultTotalPoints = new List<double>();
            List<double> copyResultTotalPoints = new List<double>();
            List<double> RankedResults = new List<double>();

            while (skierID < 999)
            {
                // Setting up the Skier
                Console.Write("Skier´s ID number:  ");
                skierID = int.Parse(Console.ReadLine());

                skierCounter++;
                Skiers.Add(skierID);

                // Points calculations from the length

                Console.Write("Give measured length: ");
                measuredLength = double.Parse(Console.ReadLine());

                if (measuredLength > k_point)
                    jumpLenghtPoints = (k_pointBasic + ((measuredLength - k_point) * lengthfactor));
                else
                    jumpLenghtPoints = (k_pointBasic - ((measuredLength - k_point) * lengthfactor));

                totalPoints = jumpLenghtPoints;
                ResultLengthPoints.Add(jumpLenghtPoints);

                // Console.WriteLine("Points from the length: " + jumpLenghtPoints);
                //Console.WriteLine();

                // Points re-calculated due to wind factor
                Console.Write("Give wind factor [m/s] (headwind = positive, tailwind negative): ");
                windFactor = double.Parse(Console.ReadLine());
                windPoints = windFactor * (k_point - 36) / 20;
                ResultWindPoints.Add(windPoints);

                totalPoints = totalPoints + windPoints;

                // Platform change factor
                Console.Write("Platform change [m] from original position? : ");
                platformAdjustment = double.Parse(Console.ReadLine());
                platformPoints = -platformAdjustment * 5 * lengthfactor;
                ResultPlatformPoints.Add(platformPoints);

                totalPoints = totalPoints + platformPoints;
                Console.WriteLine();

                // Points calculations from judges. List case.

                double score = 0;
                List<double> judgesPoints = new List<double>();
                List<double> judgesPointsSorted = new List<double>();

                counter = 1;
                do
                {
                    Console.Write("score judge " + counter + ": ");
                    score = double.Parse(Console.ReadLine());
                    judgesPoints.Add(score);
                    counter++;
                } while (counter <= 5);

                judgesPoints.Remove(judgesPoints.Max());
                judgesPoints.Remove(judgesPoints.Min());

                judges = 0;

                for (int i = 0; i < 3; i++)
                {
                    judges = judges + judgesPoints[i];
                }
                
                ResultJudgesPoints.Add(judges);
                judgesPoints.Clear();

                totalPoints = totalPoints + judges;
                ResultTotalPoints.Add(totalPoints);
                counter = 0;

                Console.WriteLine();
                Console.WriteLine("Results of the last skier");
                Console.Write("Skier no.: " + skierID);
                Console.Write("  L: " + ResultLengthPoints[skierCounter]);
                Console.Write("  Pf: " + ResultPlatformPoints[skierCounter]);
                Console.Write("  W: " + ResultWindPoints[skierCounter]);
                Console.Write("  J: " + ResultJudgesPoints[skierCounter]);
                Console.Write("  TOTAL = " + ResultTotalPoints[skierCounter]);
                Console.WriteLine();

                int index1 = 0;

                Console.WriteLine();
                Console.WriteLine("Results in descending order");
                Console.WriteLine();

      //  NEW
                int rank = 1;
                int pointer = 0;

                copyResultTotalPoints.Clear();
                for (int i = 0; i <= skierCounter; i++)
                {
                    copyResultTotalPoints.Add(ResultTotalPoints[i]);
                }
                copyResultTotalPoints.Reverse();

                RankedResults.Clear();
                foreach (var place in copyResultTotalPoints)
                {
                    RankedResults.Add(place);
                }

                for (int i = 0; i <= skierCounter; i++)
                {
                    double match = RankedResults[i];
                //}

                //foreach (var ranked in RankedResults)
                //{
                    pointer = ResultTotalPoints.FindIndex(item => item == match);
                    Console.Write("Rank: " + rank);
                    Console.Write("  Skier: " + Skiers[pointer]);
                    Console.Write("  L: " + ResultLengthPoints[pointer]);
                    Console.Write("  Pf: " + ResultPlatformPoints[pointer]);
                    Console.Write("  W: " + ResultWindPoints[pointer]);
                    Console.Write("  J: " + ResultJudgesPoints[pointer]);
                    Console.Write("  TOTAL = " + (ResultTotalPoints[pointer]));
                    Console.WriteLine(pointer);
                    rank++;
                }
                Console.WriteLine();

                
                int counter2 = counter++;

                
            }

            Console.WriteLine();
            Console.WriteLine("press enter to exit");
        }

    }
    }

