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
    Public Class LoginController
        Inherits Controller
        Private ReadOnly db As New Model1
        ' GET: Login
        Function Index() As ActionResult
            Return View()
        End Function

        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Login(obj As user) As ActionResult
            If ModelState.IsValid Then
                Dim data = db.users.Find(obj.username)
                Dim p = data.password.Equals(obj.password)
                If p Then
                    Dim v = HttpContext.Session.ToString(username)
                    Return RedirectToAction("Index")
                End If
                ModelState.AddModelError("", "Incorrect Username and Password")
            End If
            Return View(obj)
        End Function

        Function LogOut() As ActionResult
            Session.Clear()
            Return RedirectToAction("Index", "Login")
        End Function
        Private Function username() As Object
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace