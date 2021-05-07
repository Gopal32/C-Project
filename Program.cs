using System;

public class Program
{
   static int getMissingNo(int[] A, int n)
   {
     int total = (n +1)*(n+2)/2;
	 for(int i=0; i<n; i++)
	  total-=A[i];
	  
	 return total;
   }
   public static void Main(string[] args)
   {
    int[] A = {1,2,4,5,6};
	int miss = getMissingNo(A, 5);
	Console.Write(miss);
   }
}