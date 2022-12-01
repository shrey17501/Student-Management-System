Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class Model1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Model1")
    End Sub

    Public Overridable Property batches As DbSet(Of batch)
    Public Overridable Property courses As DbSet(Of course)
    Public Overridable Property registrations As DbSet(Of registration)
    Public Overridable Property users As DbSet(Of user)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of batch)() _
            .Property(Function(e) e.batch1) _
            .IsUnicode(False)

        modelBuilder.Entity(Of batch)() _
            .Property(Function(e) e.year) _
            .IsUnicode(False)

        modelBuilder.Entity(Of batch)() _
            .HasMany(Function(e) e.registrations) _
            .WithOptional(Function(e) e.batch) _
            .HasForeignKey(Function(e) e.batch_id)

        modelBuilder.Entity(Of course)() _
            .Property(Function(e) e.course1) _
            .IsUnicode(False)

        modelBuilder.Entity(Of course)() _
            .HasMany(Function(e) e.registrations) _
            .WithOptional(Function(e) e.course) _
            .HasForeignKey(Function(e) e.course_id)

        modelBuilder.Entity(Of registration)() _
            .Property(Function(e) e.firstname) _
            .IsUnicode(False)

        modelBuilder.Entity(Of registration)() _
            .Property(Function(e) e.lastname) _
            .IsUnicode(False)

        modelBuilder.Entity(Of registration)() _
            .Property(Function(e) e.nic) _
            .IsUnicode(False)

        modelBuilder.Entity(Of user)() _
            .Property(Function(e) e.firstname) _
            .IsUnicode(False)

        modelBuilder.Entity(Of user)() _
            .Property(Function(e) e.lastname) _
            .IsUnicode(False)

        modelBuilder.Entity(Of user)() _
            .Property(Function(e) e.username) _
            .IsUnicode(False)

        modelBuilder.Entity(Of user)() _
            .Property(Function(e) e.password) _
            .IsUnicode(False)
    End Sub
End Class
