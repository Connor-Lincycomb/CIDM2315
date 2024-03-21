namespace Homework8;

class Program
{
    //*** Do NOT change the code in Main ***
    public static void Main (string[] args) {
        // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);

        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

    // Test Q2.1
    PrintAllOddNumber(array_2d);

    // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");

    // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");
        }
    }
    

    // Q1:
    public static void ArraySum(int[] int_array){
        int int_array_sum = 0;
        foreach (int k in int_array)
        {
            int_array_sum += k;
        }
        Console.WriteLine(int_array_sum);
    }

    //Q2.1:
    public static void PrintAllOddNumber(int[ , ] array_2d){
        for (int j = 0; j<3; j++)
        {
            if (j%2==0)
            {
                for (int l = 0; l < 3; l++)
                {
                if (l%2 == 0)
                    {
                    Console.Write(array_2d[j,l] + " ");
                    }
                }
            }
            else
            {
                for (int l = 0; l < 3; l++)
                {
                if (l%2 != 0)
                    {
                    Console.Write(array_2d[j,l] + " ");
                    }
                }
            }
            
            
        }
    }
    
    //Q2.2:
    public static int ElementSum(int[ , ] array_2d){
        int sum_array = 0;
        for (int q = 0; q<3; q++)
        {
            for (int w = 0; w<3; w++)
            {
                sum_array += array_2d[q,w];
            }
        }
        return sum_array;  
    }


    // Q2.3:
    public static int[ , ] DoubleArray(int[ , ] array_2d){
       for (int x = 0; x<3; x++)
        {
            for (int y = 0; y<3; y++)
            {
                int currentvalue = array_2d[x,y];
                array_2d[x,y] = currentvalue * 2;
            }
        }
        return array_2d; 
    }

}
