@ModelType WebApplication1.course
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>course</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.course1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.course1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.duration)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.duration)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
