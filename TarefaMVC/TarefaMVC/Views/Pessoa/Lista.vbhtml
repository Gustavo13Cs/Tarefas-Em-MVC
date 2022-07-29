@ModelType IEnumerable(Of TarefaMVC.Pessoa)
@Code
    ViewData("Title") = "Lista"
End Code

<h2>Lista</h2>

<p>
    @Html.ActionLink("Crie um novo", "Criar")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nome)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nome)
        </td>
        <td>
            @Html.ActionLink("Editar", "Edit", New With {.id = item.PESID}) |
            @Html.ActionLink("Detalhes", "Details", New With {.id = item.PESID}) |
            @Html.ActionLink("Excluir", "Delete", New With {.id = item.PESID})
        </td>
    </tr>
Next

</table>
