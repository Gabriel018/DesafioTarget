TargetInvertString targerInvert = new TargetInvertString();
targerInvert.TargetInvert();

public class TargetInvertString
{
    public void TargetInvert()
    {
        Console.WriteLine("Digite a string a ser invertida:");
        string? entrada = Console.ReadLine();

        string? invertida = Inverter(entrada);

        Console.WriteLine("String invertida: " + invertida);
    }

    public static string Inverter(string input)
    {
        char[] array = new char[input.Length];

        int j = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            array[j] = input[i];
            j++;
        }

        return new string(array);
    }
}