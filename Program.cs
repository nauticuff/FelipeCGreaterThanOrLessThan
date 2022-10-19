/*
Carlos Felipe Sales
10/19/22
Mini Challenge 4 - Greater Than or Less Than
I built a calculator that checks if the first number entered
is less than, greater than, or equal to the second number entered
*/
Console.Clear();
bool run = true;

while (run){

    Console.Write("Enter a number: ");
    string inputOne = Console.ReadLine();
    bool isNumberOne = Double.TryParse(inputOne, out double numOne);
    while (isNumberOne){

        Console.Write("\nEnter a second nmumber: ");
        string inputTwo = Console.ReadLine();
        bool isNumberTwo = Double.TryParse(inputTwo, out double numTwo);
        if(isNumberTwo){

            if (numOne < numTwo){
                Console.WriteLine(numOne + " is less than " + numTwo);
            }

            else if (numOne > numTwo){
                Console.WriteLine(numOne + " is greater " + numTwo);
            }

            else{
                Console.WriteLine("Both numbers are equal ");
            }
            Console.WriteLine("Run program again?\nType YES or NO: ");
                string runChoice = Console.ReadLine().ToUpper();
                while (runChoice != "YES" && runChoice != "NO")
                {
                    Console.WriteLine("I said 'YES' or 'NO'\nTry again: ");
                    runChoice = Console.ReadLine().ToUpper();
                }
                if (runChoice == "NO")
                {
                    run = false;
                    Console.WriteLine("Okay maybe next time!");
                    break;
                }
                else
                {
                    run = true;
                    break;
                }
        }
        else if(!isNumberTwo){
            Console.Write("That is not a number.\nTry again.\n");
        }
    }
    if (!isNumberOne)
    {
        Console.Write("That is not a number.\nTry again.\n");
    }
}





