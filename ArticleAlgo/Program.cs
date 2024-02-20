

Console.WriteLine(CalculateGrade(GenerateArray(20)));




int[] GenerateArray(int length){

    Random random = new Random();
    
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = random.Next(0,100);
    }
    //arr = new int[] {0, 1, 7, 8, 9 };
    Array.Sort(arr);
    Array.Reverse(arr);
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(" " + arr[i]);
    }
        Console.WriteLine();
    return arr;
}

int CalculateGrade(int[] arr){


    
    int buf =0;
    int grade = 0;
 
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if(arr[i] == 0)
            break;

        buf++;

        if(buf == arr[i + 1] || buf > arr[i + 1]){
            grade = buf;
            break;
        }

    }
    return grade;
}