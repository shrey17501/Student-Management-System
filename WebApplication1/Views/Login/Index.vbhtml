@ModelType IEnumerable(Of WebApplication1.registration)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.batch.batch1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.course.course1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.firstname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.lastname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.nic)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.telno)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.batch.batch1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.course.course1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.firstname)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.lastname)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nic)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.telno)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id })
        </td>
    </tr>
Next

</table>
