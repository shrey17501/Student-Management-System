Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("batch")>
Partial Public Class batch
    Public Sub New()
        registrations = New HashSet(Of registration)()
    End Sub

    Public Property id As Integer

    <Column("batch")>
    <StringLength(50)>
    Public Property batch1 As String

    <StringLength(50)>
    Public Property year As String

    Public Overridable Property registrations As ICollection(Of registration)
End Class
