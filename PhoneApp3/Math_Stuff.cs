using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp3
{
    class Math_Stuff
    {
        public string calculate(string num)
        {
            int count = 0, inserter = 0;

            double A_num = 0, num0 = 0, A_num1=0;
            List<string> operators = new List<string>();
            List<string> numbers = new List<string>();

            for (int i = 0; i < num.Length; i++)
            {
                bool canConvert = double.TryParse(num[i].ToString(), out num0);//This will step through the string char by char and set a bool to indicate if it can convert to a double or not

                if (canConvert == false)
                {
                    operators.Add(num[i].ToString());// This stores each operator in the order that the user imputed
                    count++;// this will happen every set of digits i.e after the first number is completely transferred into the place holder. the first place holder will be 0 and the second 1 and so on...
                    inserter = 0;// I needed this because I want to insert a new place holder for my list and add to that existing list after word 
                }
                else if (canConvert == true && inserter == 0) // if canConvert == true
                {
                    numbers.Insert(count, num[i].ToString());// this will create a new place holder for the first digit of a number. The list will increment after every operator
                    inserter++;
                }
                else if (canConvert == true)
                {
                    numbers[count] += num[i].ToString();//this adds the rest of the digits to the number char by char
                }
            }
            // the numbers list will hold all the numbers in order of them being typed i.e if the first number typed is 100 then numbers[0] = 100 and so on...
            // the operators list will hold each operator in order that it is input. This assumes there will always be one more number than operator.
            for (int q = 0; q < operators.Count(); q += 2)//this will not do order of operations but will read and compute the equation left to right
            {
                A_num1 = Convert.ToDouble(numbers[q + 1]);// A_num1 will be used to manipulate the A_num amount
                A_num = Convert.ToDouble(numbers[q]);// this will be the total amount

                if (operators[q] == "/")// this will check to see which operator is being used
                {
                    A_num /= A_num1;
                    numbers[q + 1] += A_num.ToString();
                }
                else if (operators[q] == "*")
                {
                    A_num *= A_num1;
                    numbers[q + 1] += A_num.ToString();
                }
                else if (operators[q] == "-")
                {
                    A_num -= A_num1;
                    numbers[q + 1] += A_num.ToString();
                }
                else if (operators[q] == "+")
                {
                    A_num += A_num1;
                    numbers[q + 1] += A_num.ToString();
                }
            }

            return A_num.ToString();//This returns the total amount after calculations are done
        }
    }
}
