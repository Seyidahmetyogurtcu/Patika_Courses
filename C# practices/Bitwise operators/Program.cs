// C# program to demonstrate the working
// of Bitwise Operators
using System;
namespace Bitwise {
	
    class GFG {
        
        // Main Function
        static void Main(string[] args)
        {
            int x = 5, y = 10, result;//5:0101 ,  10:1010
            
                // Bitwise AND Operator
                result = x & y; //0000
                Console.WriteLine("Bitwise AND: " + result);
                
                // Bitwise OR Operator
                result = x | y;//1111
                Console.WriteLine("Bitwise OR: " + result);
                
                // Bitwise XOR Operator
                result = x ^ y;//1111
                Console.WriteLine("Bitwise XOR: " + result);
                
                // Bitwise AND Operator
                result = ~x;//0110   2's complement
                Console.WriteLine("Bitwise Complement: " + result);
                
                // Bitwise LEFT SHIFT Operator
                result = x << 2;//10100
                Console.WriteLine("Bitwise Left Shift: " + result);
                
                // Bitwise RIGHT SHIFT Operator
                result = x >> 2;//1
                Console.WriteLine("Bitwise Right Shift: " + result);
            

            /*Bitwise AND: 0
            Bitwise OR: 15
            Bitwise XOR: 15
            Bitwise Complement: -6
            Bitwise Left Shift: 20
            Bitwise Right Shift: 1*/
        }
    }
}
