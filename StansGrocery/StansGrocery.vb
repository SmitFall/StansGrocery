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
            Food(Row, 0) = temp(1)


            'grab item location
            Input(1, record)
            temp = Split(record, "##LOC")
            Food(Row, 1) = temp(1)


            'grab item category
            Input(1, record)
            temp = Split(record, "%%CAT")
            Food(Row, 2) = temp(1)

            Row += 1
        Loop
        FileClose(1)
    End Sub

    Sub listboxDisplay()

        For I = Me.Food.GetLowerBound(0) To Me.Food.GetUpperBound(0)
            DisplayListBox.Items.Add($"{Me.Food(I, 0)} : {Me.Food(I, 1)} : {Me.Food(I, 2)}")

        Next
    End Sub
    Private Sub StansGrocery_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDataFile()
        listboxDisplay()
    End Sub
    Private Sub LocationRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles LocationRadioButton.CheckedChanged




    End Sub

    Private Sub CategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles CategoryRadioButton.CheckedChanged

    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click

    End Sub

    Private Sub SearchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem1.Click

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
        Me.Hide()
    End Sub
End Class
