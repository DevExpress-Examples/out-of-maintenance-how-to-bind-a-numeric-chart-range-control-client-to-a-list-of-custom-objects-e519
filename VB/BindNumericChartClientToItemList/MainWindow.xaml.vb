Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows

Namespace BindNumericChartClientToItemList

	Public Class NumericItem
		Private privateArgument As Object
		Public Property Argument() As Object
			Get
				Return privateArgument
			End Get
			Set(ByVal value As Object)
				privateArgument = value
			End Set
		End Property
		Private privateValue As Object
		Public Property Value() As Object
			Get
				Return privateValue
			End Get
			Set(ByVal value As Object)
				privateValue = value
			End Set
		End Property
	End Class

	Partial Public Class MainWindow
		Inherits Window

		Private Const dataCount As Integer = 10
		Private data As New List(Of NumericItem)()
		Private rand As New Random()

		Private Function GenerateNumericData() As List(Of NumericItem)
			For i As Integer = 0 To dataCount - 1
				data.Add(New NumericItem() With {.Argument = i, .Value = rand.Next(0, 30) + i})
			Next i
			Return data
		End Function

		Public Sub New()
			InitializeComponent()
			Me.DataContext = GenerateNumericData()
		End Sub
	End Class
End Namespace
