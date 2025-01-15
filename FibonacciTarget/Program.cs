FibonacciTargt  fibonaciRetorno = new FibonacciTargt();
fibonaciRetorno.FibonacciCalc();

public class FibonacciTargt
{
    public void FibonacciCalc()
    {
        Console.WriteLine("Digite o valor a ser calculado");
        int numero = int.Parse(Console.ReadLine());

        if (PertenceFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    public bool PertenceFibonacci(int numero)
    {
        int a = 0;
        int b = 2;

        if (numero == 0 || numero == 1)
            return true;
        else
            while (b < numero)
            {
                int proximo = a + b;
                a = b;
                b = proximo;

                if (b == numero)
                {
                    return true;
                }
            }
        return false;
    }
}
