public class Projeto {

    public string Nome { get; set; }
    private List<string> tarefas;
    private object get;

    public Projeto(string nome) {
        Nome = nome;
        tarefas = new List<string>();
    }

    public void AdicionarTarefas(string tarefa) {
        tarefas.Add(tarefa);
    }

    public void ExibirTarefas() {

        Console.WriteLine($"Projeto: {Nome}\n");
        Console.WriteLine($"Tarefa: ");

        foreach (string tarefa in tarefas) {

            Console.WriteLine($" - {tarefa}");
        }
        Console.WriteLine($"\nTotal: {QuantidadeTarefas} tarefas.");
    }

    public int QuantidadeTarefas {
        
        get { return tarefas.Count; }
    }
}