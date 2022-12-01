@ModelType WebApplication1.registration
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>registration</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.batch.batch1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.batch.batch1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.course.course1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.course.course1)
        </dd>

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
            @Html.DisplayNameFor(Function(model) model.nic)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nic)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.telno)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.telno)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
