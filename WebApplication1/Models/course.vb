Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("course")>
Partial Public Class course
    Public Sub New()
        registrations = New HashSet(Of registration)()
    End Sub

    Public Property id As Integer

    <Column("course")>
    <StringLength(50)>
    Public Property course1 As String

    Public Property duration As Integer?

    Public Overridable Property registrations As ICollection(Of registration)
End Class
