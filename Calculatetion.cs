using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonditalProgram_H2
{
    class Calculatetion
    {
        /// <summary>
        /// Calculates users fitness score from resting pulse and max pulse
        /// </summary>
        /// <param name="restingPulse"></param>
        /// <param name="maxPulse"></param>
        public static void CalculateFitness(int restingPulse, int maxPulse)
        {
            double fitnessScore = ((double)maxPulse / (double)restingPulse) * 15.3;
            Program.WriteToConsole($"Your physical condition score is: {String.Format("{0:0}", fitnessScore)} ml/kg/min\n", 28);
        }
        /// <summary>
        /// Calculates users O2 consumption rate from users fitness scor and weight
        /// </summary>
        /// <param name="restingPulse"></param>
        /// <param name="maxPulse"></param>
        /// <param name="weight"></param>
        public static void CalculateO2Rate(int restingPulse, int maxPulse, int weight)
        {
            double test = ((((double)maxPulse / (double)restingPulse) * 15.3) * weight) / 1000;
            Program.WriteToConsole($"Your Oxygen consumption rate is: {String.Format("{0:0.0}", test)} l/ml\n", 28);
            Program.WriteToConsole("Press any key to try again", 28);
            Console.ReadKey();
            Console.Clear();
            Program.Main();
        }
    }
}
