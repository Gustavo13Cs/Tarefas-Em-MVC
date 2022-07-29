@ModelType IEnumerable(Of TarefaMVC.Tarefa)
@Code
ViewData("Title") = "Index"
End Code

<h2>Lista de tarefas</h2>

<p>
    @Html.ActionLink("Criar novo", "Criar")
</p>
<table class="table">
    <tr>
        <th>
            Tarefa
        </th>
        <th>
            Data
        </th>
        <th>
            Feito
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Pessoa.Nome)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.tarDescricao) 

        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.tardedata)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.tarfeito)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Pessoa.Nome)
        </td>
        <td>
            @Html.ActionLink("Editar", "Editar", New With {.id = item.Tarid}) |
            @Html.ActionLink("Detalhes", "Detalhes", New With {.id = item.Tarid}) |
            @Html.ActionLink("Excluir", "Excluir", New With {.id = item.Tarid})
        </td>
    </tr>
Next

</table>
