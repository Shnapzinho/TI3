public static class PrimeNumberGenerator
{
	public static bool IsPrime(int n)
	{
		if (n <= 1) return false;
		if (n == 2) return true;
		if (n % 2 == 0) return false;

		int boundary = (int)Math.Sqrt(n);
		for (int i = 3; i <= boundary; i += 2)
		{
			if (n % i == 0) return false;
		}
		return true;
	}

	/*
	  private static int FastExp(int a, int z, int n)
	{
		long a1 = a;
		long z1 = z;
		long x = 1;

		while (z1 != 0)
		{
			while (z1 % 2 == 0)
			{
				z1 /= 2;
				a1 = (a1 * a1) % n;
			}
			z1--;
			x = (x * a1) % n;
		}

		return (int)x;
	}
	*/
}