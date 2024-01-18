using SqrtAlgo;

var calc = new SqrtCalculator();
var success = false;
int num = 0;
int ranks = 0;
do{
success = true;
   try{
    Console.WriteLine("Введите число, из которого нужно вычислить корень");
     num = int.Parse(Console.ReadLine());
     if(num < 0)
        throw new ArgumentException();
     Console.WriteLine("Введите желаемое число разрядов, до которых требуется округлить число");
     ranks = int.Parse(Console.ReadLine());
     if(ranks < 0)
        throw new ArgumentException();

    }catch(FormatException){
        Console.WriteLine("Вы ввели неверный формат, попробуйте еще раз.");
        success = false;
    }catch(ArgumentException){
        Console.WriteLine("Вы ввели отрицательное число, попробуйте еще раз");
        success = false;
    }
}while(success == false);

calc.Calculate(num, ranks);

