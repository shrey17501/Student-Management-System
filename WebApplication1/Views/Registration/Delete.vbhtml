@ModelType WebApplication1.registration
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
