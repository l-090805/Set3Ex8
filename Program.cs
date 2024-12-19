namespace Set3Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vector: ");
            string input = Console.ReadLine();
            int[] v = Array.ConvertAll(input.Split(' '),int.Parse);
            int aux = 0;
            int n = v.Length;

            for(int i = 0; i < v.Length; i++)
            {
                v[i] = aux;
                v[i] = v[(i + 1) % n];
                v[(i + 1) % n] = v[i];   
            }

            Console.WriteLine("vector rotit: " + String.Join(" ",v));
        }
    }
}
