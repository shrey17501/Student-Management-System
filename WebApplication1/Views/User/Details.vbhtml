@ModelType WebApplication1.user
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>user</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.firstname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.firstname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.lastname)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.lastname)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.username)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.username)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.password)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.password)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
