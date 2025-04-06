// let's setup the input 

using System.Dynamic;

Console.WriteLine("What do you want to convert binary numbers or decimal numbers? ");

// declare the variables

int decimalResult = 0;

int toPower = 1;

string binaryResult = "";

int result;

string request = Console.ReadLine();


// start with a condition for the binary and decimal numbers

if (request == "binary")
{
    Console.WriteLine("Type a number: ");

    string binary = Console.ReadLine();

    // insert a loop that will convert decimal to bynary

    for (int i = binary.Length - 1; i >= 0; i--)
    {
        if (binary[i] == '1')
        {
            decimalResult += toPower;
        }

        toPower *= 2;
    }
    // insert result

    Console.WriteLine("Decimal is: " + decimalResult);
}
else if (request == "decimal") // condition to bynary to decimal
{
    Console.WriteLine("Type a decimal number: ");


    // insert the decimal number


    int decimalNumber = int.Parse(Console.ReadLine());


    // while condition because we need invert the ordered numbers

    while (decimalNumber != 0)
    {
        result = decimalNumber % 2;

        binaryResult = result + binaryResult;
        decimalNumber = decimalNumber / 2;
    }
    Console.WriteLine("Binary: " + binaryResult);
}
