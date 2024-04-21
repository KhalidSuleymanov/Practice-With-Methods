using System;
using System.Globalization;
using System.Threading;

namespace MyHomeTask24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PracticeLesson
            // char.ToString
            Console.WriteLine(char.ToString('@')); // return @
            Console.WriteLine(char.ToString('1')); // return 1
            Console.WriteLine(char.ToString('c')); // return c
            Console.WriteLine(char.ToString('D')); // return D

            //char.ToLower
            Console.WriteLine(char.ToLower('A'));  //return a

            //char.ToUpper
            Console.WriteLine(char.ToUpper('a'));  //return A

            //char.IsDigit 
            Console.WriteLine(char.IsDigit('5')); // return True
            Console.WriteLine(char.IsDigit('a')); // return False
            Console.WriteLine(char.IsDigit('@')); // return False
            Console.WriteLine(char.IsDigit('A')); // return False

            //char.IsLower, char.IsUpper
            Console.WriteLine(char.IsLower('h')); // return True
            Console.WriteLine(char.IsLower('2')); // return False
            Console.WriteLine(char.IsUpper('A')); // return True
            Console.WriteLine(char.IsUpper('3')); // return False

            string sentence = "Salam Rufet xos gelmisen";
            var wordsArr = sentence.Split(" "); // return Salam, Rufet, xos, gelmisen.
            for (int i = 0; i < wordsArr.Length; i++)
            {
                Console.WriteLine(wordsArr[i]);
            }

            string str = "Hello World";
            Console.WriteLine(str.IndexOf("l"));  //Return 2
            Console.WriteLine(str.LastIndexOf("l")); // return 9
            Console.WriteLine(str.Substring(str.IndexOf(' ') + 1)); //return World
            Console.WriteLine(str.Replace("Hello", "GoodBay")); // return GoodBay World


            int num;
            SetZero(out num);
            var result = num;


            Console.WriteLine(num);
            string name = "Hikmet";
            name = null;

            SetZero(ref name);
            Console.WriteLine(name);


            int[] numbers = { 34, 45, 6 };
            SetZero(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            int num1 = -34;
            MakePositive(ref num1);
            Console.WriteLine(num1);

            numbers = new int[] { 34, 23, -12, 33, -23, -4, 5 };

            int number = 34;



            #endregion


            #region LessonTask
            //Verilmis ededi 10 vahid artiran method
            Console.WriteLine("Zehmet olmasa ededi daxil edin");
            int num2 = int.Parse(Console.ReadLine());
            AddedNumber(ref num2);
            Console.WriteLine(num2);

            // Gonderilmis deyer menfidirse 0, 100 den yuxaridirsa 100, 0 ve 100 araligindadirsa ededin ozunu qaytarsin.

            Console.WriteLine("Zehmet olmasa ededi daxil edin");
            int number1 = int.Parse(Console.ReadLine());
            FindNumber(ref number1);
            Console.WriteLine(number1);

            //Verilmis ededler siyahisinda yalniz cut deyerler qalan yeni bir arraye ceviren method.
            int[] ints = { 2, 5, 6, 98, 150, 245, 266, 666 };
            TotalArray(ref ints);

            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
            #endregion

            #region HomeTask 

            int[] arr = { 2, 4, 6, 8, 16, 32 };
            int newNum = 5;
            AddedNewNumberToArray(ref arr, newNum);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion
        }


        #region LessonTaskPrac
        static void SetZero(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            //arr = new int[arr.Length];
        }

        static void SetZero(out int number)
        {
            number = 0;
        }

        static void SetZero(ref string str)
        {
            str = "0";
        }

        static void MakePositive(ref int num)
        {
            if (num < 0)
                num *= -1;
        }

        static void AddZero(ref string str)
        {
            str = str + "0";
        }


        #endregion 


        #region LessonTask
        // Verilmis ededi 10 vahid artiran method
        static void AddedNumber(ref int num)
        {
            num += 10;
        }

        // Gonderilmis deyer menfidirse 0, 100 den yuxaridirsa 100, 0 ve 100 araligindadirsa ededin ozunu qaytarsin.

        static void FindNumber(ref int num)
        {
            if (num < 0)
            {
                num = 0;
            }
            else if (num > 100)
            {
                num = 100;
            }
        }

        // Verilmis ededler siyahisinda yalniz cut deyerler qalan yeni bir arraye ceviren method.

        static void TotalArray(ref int[] ints)
        {
            int count = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0)
                {
                    count++;
                }
            }

            int[] newAarr = new int[count];
            int j = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0)
                {
                    newAarr[j] = ints[i];
                    j++;
                }
            }

            ints = newAarr;
        }
        #endregion

        #region HomeTask Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod.
        //Misalçün metodu çağırıb array elementimi və 5 dəyəri göndərsəm, arrayim dəyişilməli və arrayin  içində əvəlki 
        //elementləri, əlavə olaraq son indexində isə 5 elementi olmalıdır və arrayin uzunluğu 1 vahid artmış olmalıdır.

        static void AddedNewNumberToArray(ref int[] arr, int newNum)
        {

            int[] newArray = new int[arr.Length + 1];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[j] = arr[i];
                j++;
            }

            newArray[newArray.Length - 1] = newNum;
            arr = newArray;
        }
        #endregion
        
    }
}
