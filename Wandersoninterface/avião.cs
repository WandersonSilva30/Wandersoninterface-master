
using girselyinterface;

public class aviao : trem, Ivoador

        {
            public void abastecer()
            {
                Console.WriteLine("ele abastece o tanque");
            }

            public void Alertar()
            {
                Console.WriteLine("ele alerta");
            }

            public void cair()
            {
                Console.WriteLine("ele cai");
            }

            public void decolar()
            {
        Console.WriteLine("ele cria força para decolar");
               }

            public void desligar()
            {
                Console.WriteLine("ele desliga o motor");

            }

            public void ligar()
            {
                Console.WriteLine("ele liga o motor");

            }

            public void planar()
            {
                Console.WriteLine("ele plana");

            }

            public void pousar()
            {
                Console.WriteLine("ele pousa");

            }
        }