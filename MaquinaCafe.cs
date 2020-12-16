using System;
namespace Coffee
{
    public class MaquinaCafe
    {
        public int acucarDisponivel = 60;
        string cafesem;

        public void FazerCafe()
        {
            int buton = int.Parse(Console.ReadLine());
            switch (buton)
            {
                case 1:Console.ForegroundColor = ConsoleColor.Green;
                    acucarDisponivel = acucarDisponivel - 10;
                    Console.WriteLine("cafe feito :)");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Açucar disponivel: " + acucarDisponivel );

                    break;
                default:
                    break;
            }
        }//fim do fazercafe


        public void menu()
        {   Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("______________________________");
            Console.WriteLine("-- Super maquina de café :) --");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[1] -- Fazer café");
            FazerCafe();
           
        }


        public void VerificAcucar(){
             if (acucarDisponivel <= 0)
                    {   Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ops o açucar acabou :(");
                        Console.WriteLine("deseja fazer cafe sem açucar? s/n");
                        string opcao = Console.ReadLine();
                        if (opcao == "s")
                        {   Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("cafe sem açucar feito :)");
                        }
                        else
                        {
                            Console.WriteLine("Ok! volte outra hora! ");
                            
                        }
                    }
        }



    }
}


