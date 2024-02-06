
using System.Security.Cryptography.X509Certificates;

int[,] arr = new int[5,7]{
    {1,3,7,8,12,14,16},
    {2,5,9,11,16,19,21},
    {5,8,12,13,17,22,25},
    {6,10,13,15,20,24,27},
    {11,14,16,18,21,27,30}
    };

Search(arr, 17);
// SearchAll(arr,6);


bool Search(int[,] arr, int searchElement){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = arr.GetLength(1) - 1; j >= 0; j--)
        {
            
            if(searchElement > arr[i,j]){
              
                break;
            }
    
            if(searchElement == arr[i,j]){
                Console.WriteLine($"Element: {searchElement} has index [{i},{j}]");
                return true;
            }

            if(j == 0){
                 Console.WriteLine("There is no such element in this matrix");
                 return false;
            }
        }
    }

 return false;

}

bool SearchAll(int[,] arr, int searchElement){
    var isFound = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = arr.GetLength(1) - 1; j >= 0; j--)
        {
            
            if(searchElement > arr[i,j]){
              
                break;
            }
    
            if(searchElement == arr[i,j]){
                Console.WriteLine($"Element: {searchElement} has index [{i},{j}]");
                isFound = true;
                
            }

            if(j == 0 && !isFound){
                 Console.WriteLine("There is no such element in this matrix");
                 return false;
            }
        }
    }

    return true;

}