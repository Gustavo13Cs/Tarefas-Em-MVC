'------------------------------------------------------------------------------
' <auto-generated>
'    O código foi gerado a partir de um modelo.
'
'    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
'    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Pessoa
    Public Property PESID As Integer
    Public Property Nome As String

    Public Overridable Property Tarefa As ICollection(Of Tarefa) = New HashSet(Of Tarefa)

End Class
