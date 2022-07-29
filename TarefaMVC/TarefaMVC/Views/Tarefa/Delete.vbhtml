@ModelType TarefaMVC.Tarefa
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
