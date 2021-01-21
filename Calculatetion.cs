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
            Program.WriteToConsole($"Your physical condition score is: {String.Format("{0:0.0}", fitness2)}", 28);
            Program.WriteToConsole("Press any key to try again", 28);
            Console.ReadKey();
            Program.Main();
        }
    }
}
