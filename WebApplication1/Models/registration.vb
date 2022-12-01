Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("registration")>
Partial Public Class registration
    Public Property id As Integer

    <StringLength(50)>
    Public Property firstname As String

    <StringLength(50)>
    Public Property lastname As String

    <StringLength(50)>
    Public Property nic As String

    Public Property course_id As Integer?

    Public Property batch_id As Integer?

    Public Property telno As Integer?

    Public Overridable Property batch As batch

    Public Overridable Property course As course
End Class
