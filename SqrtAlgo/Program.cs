using SqrtAlgo;

var calc = new SqrtCalculator();

Console.WriteLine("Введите число, из которого нужно вычислить корень");
int num = calc.CorrectNum();
calc.Calculate(num);

