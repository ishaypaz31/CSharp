        static void Main(string[] args)
        {
			//2 examples for exceptions: Divide by zero, Out of bounds array
			try
			{

				int a = Convert.ToInt32(Console.ReadLine());
				int b = Convert.ToInt32(Console.ReadLine());
				//Calling a function which has both out of range and div by zero exceptions
				foo(a, b);
			}
			catch (IndexOutOfRangeException e)
			{
				Console.WriteLine("out of range");
				Console.WriteLine(e.StackTrace);
				Console.WriteLine(e.Message);
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("Divide By Zero");
				Console.WriteLine(e.StackTrace);
				Console.WriteLine(e.Message);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.StackTrace);
				Console.WriteLine(e.Message);
			}
		}
		static void foo(int a,int b)
		{
			//1 - divide by zero
			Console.WriteLine($"Trying to divide {a} with {b}");
			int c = a / b;

			int[] arr = { 1, 2, 3 };

			//2 - out of bounds array 
			Console.WriteLine("Trying to access out of bounds in array");
			Console.WriteLine(arr[5]);

		}
