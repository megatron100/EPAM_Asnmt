// See https://aka.ms/new-console-template for more information


namespace BasicAssignments

{
    class Solutions
    {
        public void fab(int limit)
        {

            int num1 = 0, num2 = 1, num3, numOfMember;
            Console.Write("Enter the number of elements: ");
            numOfMember = Int32.Parse(Console.ReadLine());
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            for (int i = 2; i < numOfMember; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;


            }
        }
        public static void Main(String[] args)
        {
           Solutions fabnociObject=new Solutions();
            fabnociObject.fab(10);


            /*Sort 5 digit in increasing order

            

            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            int swapper;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    Console.WriteLine("Inner is:" + Convert.ToString(i) + " and outer is: " + Convert.ToString(j));
                    if (arr[i] > arr[i + 1])
                    {
                        swapper = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = swapper;
                        for (int x = 0; x < arr.Length; x++)
                        {
                            Console.Write(Convert.ToString(arr[x])+" ");
                        }
                    }
                }
            }
            */



            /* Third Highest num in array

            int[] arr=new int[10];
            for (int i = 0; i < arr.Length; i++)
            { 
            arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            int num1 = 0, num2 = 0, num3 = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if(arr[i]==num1 || arr[i] == num2 || arr[i] == num3) {continue;}
                if (arr[i] > num1)
                {
                    num3 = num2;
                    num2 = num1;
                    num1 = arr[i];

                }
                else {
                    if (arr[i] > num2 && arr[i] > num3)
                    {
                        num3 = num2;
                        num2 = arr[i];
                    }
                    else if (arr[i] > num3 && arr[i] < num2)
                    { 
                    num3=arr[i]; 
                    }
                }


            }
            Console.WriteLine("3rd Greatest is: ");

            Console.WriteLine(num3);

            */



            /*  print hello if there is hundai in arr using switch

            String[] cars = new String[] { "Hundai", "Tata", "Mahindra", "Bajaj ", "Kia" };

            foreach (String car in cars)
            { switch (car)
                { case "Hundai":
                        Console.WriteLine("There is Hundai in array");
                        break;
                    

                }
            */

            /* Command line Calcualor*/


            Console.WriteLine("Command Line Calculator");

            String doItAgain = "y";

            while (doItAgain.Equals("y"))
            {

                bool isfirstNum = false;
                bool issecondNum = false;
                float firstNum = 0, float = 0;

                Console.Write("Enter first number: ");
                while (!(isfirstNum))
                {

                    String stringVal = Console.ReadLine();

                    isfirstNum = int.TryParse(stringVal, out firstNum);
                    if (!isfirstNum)

                        Console.WriteLine("Please enter valid numbers");

                }
                Console.WriteLine("Enter second number: ");
                while (!(issecondNum))
                {
                    String stringVal = Console.ReadLine();
                    issecondNum = float.TryParse(stringVal, out secondNum);
                    if (!issecondNum)
                        Console.WriteLine("Please enter valid numbers");
                }

                Console.WriteLine("Available Operation are: \n press 1 for addition \n press 2 for substraction \n press 3 for multiplication \n press 4 for division");
                String opChoice = Console.ReadLine();
                Console.Write("Your result is: ");

                switch (opChoice)
                {
                    case "1":
                        Console.WriteLine(firstNum + secondNum);
                        break;
                    case "2":
                        Console.WriteLine(secondNum - firstNum);
                        break;
                    case "3":
                        Console.WriteLine(firstNum * secondNum);
                        break;
                    case "4":
                        Console.WriteLine(firstNum / secondNum);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;





                }

                Console.WriteLine("press y to continue \n  press any button to stop calculator");
                doItAgain = Console.ReadLine();
            }













        }






    }
}




