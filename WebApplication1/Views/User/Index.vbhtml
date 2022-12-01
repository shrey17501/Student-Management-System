@ModelType IEnumerable(Of WebApplication1.user)
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
            @Html.DisplayNameFor(Function(model) model.firstname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.lastname)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.username)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.password)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.firstname)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.lastname)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.username)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.password)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id })
        </td>
    </tr>
Next

</table>
