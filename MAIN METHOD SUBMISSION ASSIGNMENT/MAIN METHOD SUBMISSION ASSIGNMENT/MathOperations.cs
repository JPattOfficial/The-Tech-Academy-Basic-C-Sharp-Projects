using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MathOperations
{
    public int DoOperation(int number)
    {
        return number + 10; // Adding 10 to the number
    }

    public int DoOperation(decimal number)
    {
        return (int)(number / 2); // Dividing the number by 2 and casting to integer
    }

    public int DoOperation(string number)
    {
        int convertedNumber;
        if (int.TryParse(number, out convertedNumber)) // Try to convert string to integer
        {
            return convertedNumber * 3; // Multiplying by 3 if conversion is successful
        }
        else
        {
            return 0; // Return 0 if conversion fails
        }
    }
}