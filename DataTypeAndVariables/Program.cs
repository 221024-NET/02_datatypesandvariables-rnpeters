using System;

namespace DataTypeAndVariables
{
    public class Program
    {
      public static void Main(string[] args)
      {
          Console.WriteLine("Hello World!");

          byte myByte =50;
          sbyte mySbyte =-50;
          int myInt =2000000000;
          uint myUint = 4000000000;
          short myShort=30000;
          ushort myUShort =60000;
          long myLong = 1234312343123431; //added
          ulong myULong = 12344311234431234123; //added
          float myFloat = -5.3F;
          double myDouble = 20000.3432;
          decimal myDecimal = 0.23212M; //added
          char myCharacter = 'a';
          bool myBool = true;
          string myText = "I control test";
          string numText = "55";
          
          Console.WriteLine(myByte);
          Console.WriteLine(mySbyte);
          Console.WriteLine(myInt);
          Console.WriteLine(myUint);
          Console.WriteLine(myShort);
          Console.WriteLine(myUShort);
          Console.WriteLine(myLong);
          Console.WriteLine(myULong);
          Console.WriteLine(myCharacter);
          Console.WriteLine(myFloat);
          Console.WriteLine(myDouble);
          Console.WriteLine(myDecimal);
          Console.WriteLine(myCharacter);
          Console.WriteLine(myBool);
          Console.WriteLine(myText);
          Console.WriteLine(Text2Num(numText));

      }

      public static int Text2Num(string numText)
      {
        Int32.TryParse(numText,out int num);
        return num;
        //throw new NotImplementedException();
      }
    }
}
