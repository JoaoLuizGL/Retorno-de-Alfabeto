public class RetornoAlfabeto
{
    public void Letras(int letras)
    {
        char letra = 'A';

        for (int i = 1; i <= letras; i++)
        {
            Console.Write(i + "- ");
            Console.WriteLine(letra);
            letra++;

        }

    }
    public static void Main()
    {
        int letras;
        RetornoAlfabeto alfabeto = new RetornoAlfabeto();

        do
        {
            Console.Clear();
            Console.Write("Digite quantas letras do alfabeto serão retornadas: ");
            letras = int.Parse(Console.ReadLine());
        } while (letras < 1 || letras > 26);

        alfabeto.Letras(letras);
        Console.ReadKey();
    }
}
