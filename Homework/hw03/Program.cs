using System;


namespace hw03
{
    class Program
    {
        static void Main(string[] args)

        {
        long factorial (int dataValue)
            {
                if (dataValue == 1)
                    return 1;
                else
                    return dataValue * factorial(dataValue - 1);
            }
        }
    }
}
