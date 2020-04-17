using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncStreamsExercise
{
	public static class Program
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
            var random = new Random();

			while (true)
			{
				var randomNumber = random.Next(1000);
				await Task.Delay(randomNumber);
				yield return randomNumber;
			}
		}


	}
}
