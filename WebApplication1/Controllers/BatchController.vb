Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebApplication1

Namespace Controllers
    Public Class BatchController
        Inherits System.Web.Mvc.Controller

        Private ReadOnly db As New Model1

        ' GET: Batch
        Function Index() As ActionResult
            Return View(db.batches.ToList())
        End Function

        ' GET: Batch/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim batch As batch = db.batches.Find(id)
            If IsNothing(batch) Then
                Return HttpNotFound()
            End If
            Return View(batch)
        End Function

        ' GET: Batch/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Batch/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,batch1,year")> ByVal batch As batch) As ActionResult
            If ModelState.IsValid Then
                db.batches.Add(batch)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(batch)
        End Function

        ' GET: Batch/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim batch As batch = db.batches.Find(id)
            If IsNothing(batch) Then
                Return HttpNotFound()
            End If
            Return View(batch)
        End Function

        ' POST: Batch/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,batch1,year")> ByVal batch As batch) As ActionResult
            If ModelState.IsValid Then
                db.Entry(batch).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(batch)
        End Function

        ' GET: Batch/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim batch As batch = db.batches.Find(id)
            If IsNothing(batch) Then
                Return HttpNotFound()
            End If
            Return View(batch)
        End Function

        ' POST: Batch/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim batch As batch = db.batches.Find(id)
            db.batches.Remove(batch)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
