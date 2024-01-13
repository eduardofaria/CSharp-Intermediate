namespace Generics
{



    public class Teste
    {


        //Generics
        public void Comparar<T>(T p1, T p2) where T : struct // or just: public void Comparar<T>(T p1, T p2)
        {
            var resultado = p1.Equals(p2);
            Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
            Console.WriteLine($"Where type is {p1.GetType()}");
        }


        //Without Generics
        public void CompararInt(int p1, int p2)
        {
            var resultado = p1.Equals(p2);
            Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
        }

        public void CompararFloat(float p1, float p2)
        {
            var resultado = p1.Equals(p2);
            Console.WriteLine($"{p1} e {p2} são iguais? {resultado}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {



            var teste = new Teste();

            int i1 = 10;
            int i2 = 10;

            float f1 = 10f;
            float f2 = 10f;

            teste.CompararInt(i1, i2);
            teste.CompararFloat(f1, f2);

            //Generics
            teste.Comparar(i1, i2);
            teste.Comparar(f1, f2);
            //Console.ReadKey();



        }
    }
}
