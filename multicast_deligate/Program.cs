using System;
delegate void math(float a , float b);

/*add and multipl two no using multicast deligate with anonymous method */
class Sushil
{
    static void Main()
    {

        math count = delegate (float a, float b)
        {
            float sum = a + b;
            Console.WriteLine("additionn is :"+sum);
        };

        count += delegate (float a, float b)
                {
                    float multi = a * b;
                    Console.WriteLine("multipictaion is :" +multi);
                };

        count += delegate (float a, float b)
        {
            float div = a / b;
            Console.WriteLine("div is :" + div);
        };

        count(11,22);
        Console.WriteLine();

    }

}