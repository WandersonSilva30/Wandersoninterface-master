
namespace girselyinterface
{
    internal class passaro : Ivoador, Iservivo
    {
        public void cair()
        {
            Console.WriteLine("ele cai");
        }

        public void comer()
        {
            Console.WriteLine("ele tem que comer");

        }

        public void decolar()
        {
            Console.WriteLine("ele bate as asas");
        }

        public void dormir()
        {
            Console.WriteLine("ele dorme");

        }

        public void morrer()
        {
            Console.WriteLine("ele morre");

        }

        public void planar()
        {
            Console.WriteLine("ele estica suas asas");
        }

        public void pousar()
        {
            Console.WriteLine("ele faz sua aterrissagem");
        }

        public void respirar()
        {
            Console.WriteLine("ele tem que respirar para viver");

        }
    }
}