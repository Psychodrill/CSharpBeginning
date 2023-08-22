// using System;

// namespace Seminar6
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
            //Console.WriteLine("Hello World!");

            //Task 1 Напишите программу, которая перевернёт одномерный
            //массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
           /* int[] CreateRandomArray(int size, int minValue, int maxValue)
            {
                int[]array = new int[size];

                for(int i =0; i< size; i++)
                {
                    array[i]= new Random().Next(minValue, maxValue+1);
                }
                return array;
            }
            void ReverseArray(int[] array)
            {
                for(int i =0; i<array.Length/2;i++)
                {
                    int temp = array[i];
                    array[i]= array[array.Length-1-i];
                    array[array.Length-1-i]=temp;
                }
            }
            Console.Write("Input a length of an array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a min of possible value: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a max of possible value: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] myArray= CreateRandomArray(length, min, max);
            ReverseArray(myArray);

            void ReverseArray2(int[] array)
            {
                for(int i =0, j=array.Length-1; i<j;i++, j--)
                {
                    int temp = array[i];
                    array[i]= array[j];
                    array[j]=temp;
                }
            }
            */

            //Task2 Напишите программу, которая принимает на вход три 
            //числа и проверяет, может ли существовать треугольник с сторонами такой длины.
           /* Console.Write("Input side a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input side b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input side c : ");
            int c = Convert.ToInt32(Console.ReadLine());
            bool IsTriangle(int A, int B, int C)
            {
                bool result = false;
                if(A<B+C && B<A+C && C<A+B ) result = true;
                return result;
            }

            bool isTriangle = IsTriangle(a,b,c);
            Console.Write($"Triangle : {isTriangle} ");
            */
            //Task3 Не используя рекурсию, выведите первые N чисел Фибоначчи.
            //Первые два числа Фибоначчи: 0 и 1.
            /*
            void WriteArray(int[] array)
            {
                for(int i =0; i<array.Length; i++)
                {
                    Console.Write(array[i]+ " ");
                }
                Console.WriteLine();
            }
            int[] FibonachiArray(int size)
            {
                int[] array = new int[size];
                array[0]=0;
                array[1]=1;
                for (int i=2; i<array.Length;i++){
                    array[i]= array[i-1]+ array[i-2];
                }
                return array;
            }

            Console.Write("Input count of Fibonachi numbers : ");
            int arrayLength =Convert.ToInt32(Console.ReadLine());
            int[] myArray =FibonachiArray(arrayLength);
            WriteArray(myArray);
            */
            //Task4 Напишите программу, которая будет создавать копию заданного массива
            //с помощью поэлементного копирования.

            int[] ArrayCopy(int [] array)
            {
                int[] result = new int[array.Length];
                for(int i=0; i< array.Length; i++)
                {
                    result[i]= array[i];
                }
                return result;
            }
            void WriteArray(int[] array)
            {
                for(int i =0; i<array.Length; i++)
                {
                    Console.Write(array[i]+ " ");
                }
                Console.WriteLine();
            }

            Console.Write("Input a length of an array: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a min of possible value: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a max of possible value: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] myArray= CreateRandomArray(length, min, max);
            WriteArray(myArray);
            int[] arrayCopy = ArrayCopy(myArray);
            WriteArray(arrayCopy);

            int[] CreateRandomArray(int size, int minValue, int maxValue)
            {
                int[]array = new int[size];

                for(int i =0; i< size; i++)
                {
                    array[i]= new Random().Next(minValue, maxValue+1);
                }
                return array;
            }


//         }
//     }
// }
