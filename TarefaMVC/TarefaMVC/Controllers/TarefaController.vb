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
    Public Class TarefaController
        Inherits System.Web.Mvc.Controller

        Private db As New BdtarefasEntities

        ' GET: Tarefa
        Function Index() As ActionResult
            Dim tarefa = db.Tarefa.Include(Function(t) t.Pessoa)
            Return View(tarefa.ToList())
        End Function

        ' GET: Tarefa/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tarefa As Tarefa = db.Tarefa.Find(id)
            If IsNothing(tarefa) Then
                Return HttpNotFound()
            End If
            Return View(tarefa)
        End Function

        ' GET: Tarefa/Create
        Function Create() As ActionResult
            ViewBag.PESID = New SelectList(db.Pessoa, "PESID", "Nome")
            Return View()
        End Function

        ' POST: Tarefa/Create
        'Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        'obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Tarid,tarDescricao,tardedata,tarfeito,PESID")> ByVal tarefa As Tarefa) As ActionResult
            If ModelState.IsValid Then
                db.Tarefa.Add(tarefa)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.PESID = New SelectList(db.Pessoa, "PESID", "Nome", tarefa.PESID)
            Return View(tarefa)
        End Function

        ' GET: Tarefa/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tarefa As Tarefa = db.Tarefa.Find(id)
            If IsNothing(tarefa) Then
                Return HttpNotFound()
            End If
            ViewBag.PESID = New SelectList(db.Pessoa, "PESID", "Nome", tarefa.PESID)
            Return View(tarefa)
        End Function

        ' POST: Tarefa/Edit/5
        'Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        'obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Tarid,tarDescricao,tardedata,tarfeito,PESID")> ByVal tarefa As Tarefa) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tarefa).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.PESID = New SelectList(db.Pessoa, "PESID", "Nome", tarefa.PESID)
            Return View(tarefa)
        End Function

        ' GET: Tarefa/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tarefa As Tarefa = db.Tarefa.Find(id)
            If IsNothing(tarefa) Then
                Return HttpNotFound()
            End If
            Return View(tarefa)
        End Function

        ' POST: Tarefa/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tarefa As Tarefa = db.Tarefa.Find(id)
            db.Tarefa.Remove(tarefa)
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
