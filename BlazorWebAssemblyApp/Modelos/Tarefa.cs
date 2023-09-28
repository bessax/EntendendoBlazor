namespace BlazorWebAssemblyApp.Modelos;

public class Tarefa
{
    public Guid Id { get; set; }
    public string? Descricao { get; set; }
    public bool Concluida { get; set; }
    public DateTime DataCriacao { set; get; }
}
