using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonditalProgram_H2
{
    class Calculatetion
    {
        public static void CalculateFitness(int restingPulse, int maxPulse)
        {
            double Fitness = (double)maxPulse / (double)restingPulse;
            double fitness2 = Fitness * 15.3;
            Program.WriteToConsole($"Your physical condition score is: {String.Format("{0:0.0}", fitness2)} ml/kg/min\n", 28);
        }
        public static void CalculateO2Rate(int restingPulse, int maxPulse, int weight)
        {
            double fitnessScore = ((double)maxPulse / (double)restingPulse) * 15.3;
            double o2Consumption = (fitnessScore * weight) / 1000;
            Program.WriteToConsole($"Your Oxygen consumption rate is: {String.Format("{0:0.0}", o2Consumption)} l/ml\n", 28);
            Program.WriteToConsole("Press any key to try again", 28);
            Console.ReadKey();
            Console.Clear();
            Program.Main();
        }
    }
}
