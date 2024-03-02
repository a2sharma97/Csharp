using System; 
class TransMatrix { 
	static int N = 4; 
	// This function stores transpose 
	// of A[][] in B[][] 
	static void transpose(int[, ] A, int[, ] B) 
	{ 
		int i, j; 
		for (i = 0; i < N; i++) 
			for (j = 0; j < N; j++) 
				B[i, j] = A[j, i]; 
	} 
	// Driver code 
	public static void Main() 
	{ 
		int[, ] A = { { 1, 1, 1, 1 }, 
			        { 2, 2, 2, 2 }, 
			        { 3, 3, 3, 3 }, 
			       { 4, 4, 4, 4 } }; 
		int[, ] B = new int[N, N]; 
		// Function call 
		transpose(A, B); 
		Console.WriteLine("Result matrix is \n"); 
		for (int i = 0; i < N; i++) { 
			for (int j = 0; j < N; j++) 
				Console.Write(B[i, j] + " "); 
			Console.Write("\n"); 
		}
		Console.WriteLine("Created By Abhishek sharma");
        Console.WriteLine("MCA-II-A Roll-No : 06");
	} 
} 
