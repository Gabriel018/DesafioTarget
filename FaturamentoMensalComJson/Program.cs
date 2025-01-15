
using Newtonsoft.Json;

//OBS: nao deu tempo para finalizar esse desafio


public class FatuamentoJson
{
    public List<FaturamentoDiario> FaturamentoDiario { get; set; }

    public void FaturamentoMensal()
    {
        var dadosFaturamento = CarregarDadosFaturamento("Faturamento.json");

    }

    public static List<FaturamentoDiario> CarregarDadosFaturamento(string arquivo)
    {
        var json = File.ReadAllText(arquivo);
        var dados = JsonConvert.DeserializeObject<FatuamentoJson>(json);
        return dados.FaturamentoDiario;
    }
}

public class FaturamentoDiario
{
    public string? Dia { get; set; }
    public double? Faturamento { get; set; }
}