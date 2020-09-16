using System;

namespace SalesTransaction.DataAcess
{
    class Program
    {
        static void Main(string [] args)
        {
            //DataAccessHelper ad = new DataAccessHelper(string abc);
            DataAccessHelper obj = new DataAccessHelper(); //instantiating object
            obj.SetConnection(); //invoking connection methodss
            
        }
    }
}
