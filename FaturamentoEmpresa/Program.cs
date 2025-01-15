FaturamentoEmpresaTarget faturamentTarget = new FaturamentoEmpresaTarget();
faturamentTarget.FaturamentoEmpresa();
public class FaturamentoEmpresaTarget()
{
    public void FaturamentoEmpresa()
    {
        double[] faturamentoDiario = { 200, 300, 150, 400, 350, 600, 250, 
                                       100, 450, 500, 700, 550, 600, 300, 
                                       150, 400, 450, 600, 300, 450, 300,
                                       350, 400, 600, 700, 800, 500, 600,
                                       550, 450, 300 };

        double menorFaturamento = faturamentoDiario[0];
        double maiorFaturamento = faturamentoDiario[0];
        double somaFaturamento = 0;
        int diasAcimaDaMedia = 0;

        foreach (var faturamento in faturamentoDiario)
        {
            if (faturamento < menorFaturamento)
            {
                menorFaturamento = faturamento;
            }
            if (faturamento > maiorFaturamento)
            {
                maiorFaturamento = faturamento;
            }

            somaFaturamento += faturamento;
        }

        double mediaMensal = somaFaturamento / faturamentoDiario.Length;

        foreach (var faturamento in faturamentoDiario)
        {
            if (faturamento > mediaMensal)
            {
                diasAcimaDaMedia++;
            }
        }

        Console.WriteLine($"Menor valor de faturamento ocorrido em um dia: {menorFaturamento}");
        Console.WriteLine($"Maior valor de faturamento ocorrido em um dia: {maiorFaturamento}");
        Console.WriteLine($"Número de dias com faturamento superior à média mensal: {diasAcimaDaMedia}");
    }
}
