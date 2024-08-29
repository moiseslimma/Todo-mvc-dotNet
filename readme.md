# Todo MVC Application

Este é um projeto ASP.NET Core MVC para gerenciar tarefas (To do). A aplicação permite criar, editar, excluir e marcar tarefas como concluídas, com suporte para validações e datas de entrega.

## Funcionalidades

- **Listagem de Tarefas**: Exibe uma lista de todas as tarefas, com informações como título, data de criação, data de entrega e data de conclusão.
- **Criação de Tarefas**: Permite adicionar uma nova tarefa com título e data de entrega.
- **Edição de Tarefas**: Permite editar o título e a data de entrega de uma tarefa existente.
- **Concluir Tarefa**: Marque uma tarefa como concluída.
- **Excluir Tarefas**: Exclua uma tarefa do sistema.

## Estrutura do Projeto

- **Controllers**: Contém o `TodoController`, responsável por gerenciar as requisições relacionadas às tarefas.
- **Models**: Contém o modelo `Todos`, que representa uma tarefa no sistema.
- **Views**: Contém as views para listar, criar, editar e excluir tarefas.