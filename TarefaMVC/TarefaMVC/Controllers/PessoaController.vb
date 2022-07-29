Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports TarefaMVC

Namespace Controllers
    Public Class PessoaController
        Inherits System.Web.Mvc.Controller

        Private db As New BdtarefasEntities

        ' GET: Pessoa
        Function Index() As ActionResult
            Return View(db.Pessoa.ToList())
        End Function

        ' GET: Pessoa/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pessoa As Pessoa = db.Pessoa.Find(id)
            If IsNothing(pessoa) Then
                Return HttpNotFound()
            End If
            Return View(pessoa)
        End Function

        ' GET: Pessoa/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Pessoa/Create
        'Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        'obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="PESID,Nome")> ByVal pessoa As Pessoa) As ActionResult
            If ModelState.IsValid Then
                db.Pessoa.Add(pessoa)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(pessoa)
        End Function

        ' GET: Pessoa/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pessoa As Pessoa = db.Pessoa.Find(id)
            If IsNothing(pessoa) Then
                Return HttpNotFound()
            End If
            Return View(pessoa)
        End Function

        ' POST: Pessoa/Edit/5
        'Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        'obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="PESID,Nome")> ByVal pessoa As Pessoa) As ActionResult
            If ModelState.IsValid Then
                db.Entry(pessoa).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(pessoa)
        End Function

        ' GET: Pessoa/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim pessoa As Pessoa = db.Pessoa.Find(id)
            If IsNothing(pessoa) Then
                Return HttpNotFound()
            End If
            Return View(pessoa)
        End Function

        ' POST: Pessoa/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim pessoa As Pessoa = db.Pessoa.Find(id)
            db.Pessoa.Remove(pessoa)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
