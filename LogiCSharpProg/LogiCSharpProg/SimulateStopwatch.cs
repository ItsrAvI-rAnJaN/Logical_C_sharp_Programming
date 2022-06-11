 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogiCSharpProg
{
    internal class SimulateStopwatch
    {
		public void StopWatchSimulation()
		{
			Console.WriteLine("To Start The Stopwatch Enter Y/y: ");
			char start = Convert.ToChar(Console.ReadLine());
			Stopwatch stopwatch = Stopwatch.StartNew();
			if (start == 'Y' || start == 'y')
			{
				// Start Timer
				stopwatch.Start();

				Console.WriteLine("To stop the stopwatch enter Q/q: ");
				char end = Convert.ToChar(Console.ReadLine());
				if (end == 'Q' || end == 'q')
				{
					// Stop Timer
					stopwatch.Stop();

					// Printing Result
					Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
				}
			}
			else
			{
				Console.WriteLine("Invalid input");

			}

		}
	}
}
