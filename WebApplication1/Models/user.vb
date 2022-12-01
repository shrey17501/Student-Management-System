Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("user")>
Partial Public Class user
    Public Property id As Integer

    <StringLength(50)>
    Public Property firstname As String

    <StringLength(50)>
    Public Property lastname As String

    <StringLength(50)>
    Public Property username As String

    <StringLength(50)>
    Public Property password As String
End Class
