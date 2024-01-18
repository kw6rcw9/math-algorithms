using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SqrtAlgo
{
    public class SqrtCalculator
    {
        private List<char> result;
        List<string> fullNum;

        public void Calculate(int number, int ranks){
            result = new List<char>();
            if(number == 0){
                Console.WriteLine("Корень: " + 0 );
                return;
            }
            if(number == 1){
                
                Console.WriteLine("Корень: " + 1 );
                return;
            }
            fullNum = new List<string>();
            string stringNum = number.ToString();
            for (int i = stringNum.Length - 1; i >= 0; i -= 2)
            {
                if(i == 0){
                    fullNum.Add(stringNum[i].ToString());
                    break;
                }
                fullNum.Add( stringNum[i - 1].ToString() + stringNum[i].ToString() );
            }
            fullNum.Reverse();
            string ostatok = ""; 
            string n = "";
            DevideRecursion(fullNum[0], ostatok, n, ranks);
            Console.WriteLine($"Корень числа {number}: ");
            foreach (var item in result)
            {
                Console.Write(item + "");
             }
        }


        public void DevideRecursion(string fullStr, string ostatok, string n, int ranks){
            if(fullStr == ""){
                return;
            }
            string workStr = ostatok + fullStr;
            string left = "";
            if(n != "")
                 left = (int.Parse(n) * 2).ToString();
             int temp = 0;
                
            for (int i = 0; i < 10; i++)
             {
                 if(int.Parse(left + i.ToString()) * i > int.Parse(workStr))
                 {
                     temp = int.Parse(left + (i - 1).ToString()) * (i - 1);
                      ostatok = (int.Parse(workStr) - temp).ToString();
                     result.Add(char.Parse((i - 1).ToString()));
                      n = n + (i - 1).ToString(); 
                    break;
                }
                    
            }
            for (int i = 0; i < fullNum.Count; i++)
            {
                if(fullNum[fullNum.Count - 1] == fullStr && ostatok == "0"){
                     fullStr = "";  
                     break;
                }
                if(fullNum[fullNum.Count - 1] == fullStr && ranks > 0){     
                    fullStr = "00";
                     ranks -= 1;
                     result.Add(',');
                     break;
                }

                if(fullNum[i] == fullStr){     
                     fullStr = fullNum[i + 1];
                    break;
                }
                if(ranks == 0 && fullNum[fullNum.Count - 1] != fullStr){     
                    fullStr = "";
                     break;
                }
                if(ranks > 0){
                    fullStr = "00";
                     ranks -= 1;   
                     break;
                }
            }    
            DevideRecursion(fullStr, ostatok, n, ranks);        
        }
    }
}