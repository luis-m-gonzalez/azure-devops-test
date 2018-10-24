using System;

namespace AzureDevOpsTest.Business
{
    public class IntToBoolMath : IIntToBoolMath
    {
        public bool Add(int a, int b)
        {
            return a + b != 0;
        }
        public bool Substract(int a, int b)
        {
            return a - b != 0;
        }
    }
}
