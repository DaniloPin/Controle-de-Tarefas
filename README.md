Desenvolvi um sistema de gestão de projetos. Cada projeto possui uma lista de tarefas internas, que não pode ser acessada nem modificada diretamente de fora da classe. O sistema só permite adicionar tarefas, e precisa mostrar quantas já existem.

Criei uma classe Projeto com:

- Uma propriedade pública Nome.
- Uma lista privada de strings chamada tarefas.
- Um método público AdicionarTarefa(string tarefa) que insere uma nova tarefa.
- Um método público ExibirTarefas() que imprime todas as tarefas.
- Uma propriedade somente leitura QuantidadeTarefas, baseada no tamanho da lista.
