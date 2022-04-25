Option Strict On
Option Explicit On
Option Compare Text

Public Class StansGrocery
    Dim Food(255, 2) As String
    Sub LoadDataFile()
        Dim Filename As String = "C:\Users\capta\source\repos\StansGrocery\Grocery.txt"
        Dim record As String
        Dim Row As Integer
        Dim temp() As String


        Try
            FileOpen(1, Filename, OpenMode.Input)
        Catch ex As Exception

        End Try

        Do Until EOF(1)
            'grab item name
            Input(1, record)
            temp = Split(record, "$$ITM")
            Food(Row, 0) = record


            'grab item location
            Input(1, record)
            Food(Row, 1) = record
            'grab item category
            Input(1, record)
            Food(Row, 2) = record

            Row += 1
        Loop

        FileClose(1)
    End Sub

    Sub listboxDisplay()


        For I = Me.Food.GetLowerBound(0) To Me.Food.GetUpperBound(0)
            'DisplaylsitBox.items.add($"{me.fodd(I,0)} : {me.food(i,1)} : {me.food(I,2)})

        Next

    End Sub
    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDataFile()
        listboxDisplay()
    End Sub
End Class
