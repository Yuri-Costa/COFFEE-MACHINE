using System;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe mq = new MaquinaCafe();
            do
            {
            mq.menu();
            mq.VerificAcucar();
                
            } while (true);
           
          
        }
    }
}
