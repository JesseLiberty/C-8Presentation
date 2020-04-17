using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncStreamsExercise
{
	class Program
	{
		static async Task Main(string[] args)
		{
			await foreach (var randomValue in intMachine())
			{
				Console.WriteLine($"Delayed by {randomValue} milliseconds");
			}

		}

		public static async IAsyncEnumerable<int> intMachine()
		{
			for (; ; )
			{
				var random = new Random();
				var randomNumber = random.Next(1000);
				await Task.Delay(randomNumber);
				yield return randomNumber;
			}
		}


	}
}
