// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


 Console.WriteLine("Введите цифру дня");

        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 8 && number > 0)
        {
         
         string numberText = Convert.ToString(number);

            if (number > 5)
         
               {

                Console.WriteLine(number + " -> Выходной");

               }

            else 
              
              {

               Console.WriteLine("Будни");


              }


        }

         else 
              
              {

               Console.WriteLine("Не является днем недели");


              }
