double accumulator = 0;
double initialNumber = 0; 
double secondNumber = 1;
int quantityTerms;

void calculateFibonachiNumbers(int quantityTerms)
{
    double sumNumbers = 0;
    for (int x = 0; x < quantityTerms; x++)
    {
        Console.Write(initialNumber + " ");
        accumulator = initialNumber + secondNumber;
        initialNumber = secondNumber;
        secondNumber = accumulator;

        sumNumbers += initialNumber;
    }
    Console.Write("\nthe sum is: " + sumNumbers);
}

quantityTerms = RequestInt("how many terms do you want: ");

calculateFibonachiNumbers(quantityTerms);
Console.ReadKey (); 

static int RequestInt(string message)
{
    Console.Write(message);
    var inputString = Console.ReadLine();
    try
    {
        return Convert.ToInt32(inputString);
    }
    catch (Exception)
    {
        throw new Exception("You must enter a valid integer number.");
    }

}