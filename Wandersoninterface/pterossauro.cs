
namespace girselyinterface
{
    internal class pterossauro : dinossauro, Ivoador
    {
        public void cair()
        {
            Console.WriteLine("ele cai");

        }

        public void decolar()
        {
            Console.WriteLine("ele decola");
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
}