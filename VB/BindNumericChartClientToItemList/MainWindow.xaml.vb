Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace BindNumericChartClientToItemList

    Public Class NumericItem

        Public Property Argument As Object

        Public Property Value As Object
    End Class

    Public Partial Class MainWindow
        Inherits Window

        Const dataCount As Integer = 10

        Private data As List(Of NumericItem) = New List(Of NumericItem)()

        Private rand As Random = New Random()

        Private Function GenerateNumericData() As List(Of NumericItem)
            For i As Integer = 0 To dataCount - 1
                data.Add(New NumericItem() With {.Argument = i, .Value = rand.Next(0, 30) + i})
            Next

            Return data
        End Function

        Public Sub New()
            Me.InitializeComponent()
            DataContext = GenerateNumericData()
        End Sub
    End Class
End Namespace
