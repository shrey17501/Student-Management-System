@ModelType WebApplication1.batch
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>batch</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.batch1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.batch1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.year)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.year)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
