@ModelType TarefaMVC.Tarefa
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Tarefa</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.tarDescricao)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tarDescricao)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tardedata)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tardedata)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tarfeito)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tarfeito)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Pessoa.Nome)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Pessoa.Nome)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Tarid }) |
    @Html.ActionLink("Back to List", "Index")
</p>
