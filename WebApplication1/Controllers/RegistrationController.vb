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
    Public Class RegistrationController
        Inherits System.Web.Mvc.Controller

        Private ReadOnly db As New Model1

        ' GET: Registration
        Function Index() As ActionResult
            Dim registrations = db.registrations.Include(Function(r) r.batch).Include(Function(r) r.course)
            Return View(registrations.ToList())
        End Function

        ' GET: Registration/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim registration As registration = db.registrations.Find(id)
            If IsNothing(registration) Then
                Return HttpNotFound()
            End If
            Return View(registration)
        End Function

        ' GET: Registration/Create
        Function Create() As ActionResult
            ViewBag.batch_id = New SelectList(db.batches, "id", "batch1")
            ViewBag.course_id = New SelectList(db.courses, "id", "course1")
            Return View()
        End Function

        ' POST: Registration/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,firstname,lastname,nic,course_id,batch_id,telno")> ByVal registration As registration) As ActionResult
            If ModelState.IsValid Then
                db.registrations.Add(registration)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.batch_id = New SelectList(db.batches, "id", "batch1", registration.batch_id)
            ViewBag.course_id = New SelectList(db.courses, "id", "course1", registration.course_id)
            Return View(registration)
        End Function

        ' GET: Registration/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim registration As registration = db.registrations.Find(id)
            If IsNothing(registration) Then
                Return HttpNotFound()
            End If
            ViewBag.batch_id = New SelectList(db.batches, "id", "batch1", registration.batch_id)
            ViewBag.course_id = New SelectList(db.courses, "id", "course1", registration.course_id)
            Return View(registration)
        End Function

        ' POST: Registration/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,firstname,lastname,nic,course_id,batch_id,telno")> ByVal registration As registration) As ActionResult
            If ModelState.IsValid Then
                db.Entry(registration).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.batch_id = New SelectList(db.batches, "id", "batch1", registration.batch_id)
            ViewBag.course_id = New SelectList(db.courses, "id", "course1", registration.course_id)
            Return View(registration)
        End Function

        ' GET: Registration/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim registration As registration = db.registrations.Find(id)
            If IsNothing(registration) Then
                Return HttpNotFound()
            End If
            Return View(registration)
        End Function

        ' POST: Registration/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim registration As registration = db.registrations.Find(id)
            db.registrations.Remove(registration)
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
