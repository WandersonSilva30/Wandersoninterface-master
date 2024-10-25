
namespace girselyinterface
{
    public class trem
    {
        public class Trem : Imaquina
        {
            public void abastecer()
            {
                Console.WriteLine("ele abastece o tanque");
            }

            public void alerta()
            {
                Console.WriteLine("ele alerta");
            }

            public void desligar()
            {
                Console.WriteLine("ele desliga o motor");
            }

            public void ligar()
            {
                Console.WriteLine("ele liga o motor");
            }
        }
    }
}
