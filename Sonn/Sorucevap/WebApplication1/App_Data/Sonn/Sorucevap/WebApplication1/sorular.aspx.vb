﻿Imports System.Data.OleDb
Imports System.Data
Public Class sorular
    Inherits System.Web.UI.Page

    Dim dbConnection As OleDbConnection
    Dim dbCommand As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim ConnectString As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source = C:\Users\orcun\OneDrive\Masaüstü\Sonn\Sorucevap\WebApplication1\App_Data\csharpsorucevap.accdb"
    Dim ds As DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As OleDbConnection
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\orcun\OneDrive\Masaüstü\Sonn\Sorucevap\WebApplication1\App_Data\csharpsorucevap.accdb")
        Dim soruekle1 As String = "INSERT INTO sorular(ogretmen,ders,konu,dcevap,ycevap1,ycevap2,ycevap3,soru) VALUES (@ogretmenad,@dersadi,@konuadi,@dogrucevap,@yanlis1,@yanlis2,@yanlis3,@soru)"
        Dim cmd As New OleDb.OleDbCommand(soruekle1, conn)
        cmd.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text)
        cmd.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue)
        cmd.Parameters.AddWithValue("@konuadi", konuadi.Text)
        cmd.Parameters.AddWithValue("@soru", soru1.Text)
        cmd.Parameters.AddWithValue("@dogrucevap", dogru1.Text)
        cmd.Parameters.AddWithValue("@yanlis1", yanliscevapbir1.Text)
        cmd.Parameters.AddWithValue("@yanlis2", yanliscevapiki1.Text)
        cmd.Parameters.AddWithValue("@yanlis3", yanliscevapuc1.Text)


        Dim soruekle2 As String = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)"
        Dim cmd2 As New OleDb.OleDbCommand(soruekle2, conn)
        cmd2.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text)
        cmd2.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue)
        cmd2.Parameters.AddWithValue("@konuadi", konuadi.Text)
        cmd2.Parameters.AddWithValue("@soru", soru2.Text)
        cmd2.Parameters.AddWithValue("@dogrucevap", dogru1.Text)
        cmd2.Parameters.AddWithValue("@yanlis1", yanliscevapbir2.Text)
        cmd2.Parameters.AddWithValue("@yanlis2", yanliscevapiki2.Text)
        cmd2.Parameters.AddWithValue("@yanlis3", yanliscevapuc2.Text)

        Dim soruekle3 As String = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)"
        Dim cmd3 As New OleDb.OleDbCommand(soruekle3, conn)
        cmd3.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text)
        cmd3.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue)
        cmd3.Parameters.AddWithValue("@konuadi", konuadi.Text)
        cmd3.Parameters.AddWithValue("@soru", soru3.Text)
        cmd3.Parameters.AddWithValue("@dogrucevap", dogru3.Text)
        cmd3.Parameters.AddWithValue("@yanlis1", yanliscevapbir3.Text)
        cmd3.Parameters.AddWithValue("@yanlis2", yanliscevapiki3.Text)
        cmd3.Parameters.AddWithValue("@yanlis3", yanliscevapuc3.Text)

        Dim soruekle4 As String = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)"
        Dim cmd4 As New OleDb.OleDbCommand(soruekle4, conn)
        cmd4.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text)
        cmd4.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue)
        cmd4.Parameters.AddWithValue("@konuadi", konuadi.Text)
        cmd4.Parameters.AddWithValue("@soru", soru4.Text)
        cmd4.Parameters.AddWithValue("@dogrucevap", dogru4.Text)
        cmd4.Parameters.AddWithValue("@yanlis1", yanliscevapbir4.Text)
        cmd4.Parameters.AddWithValue("@yanlis2", yanliscevapiki4.Text)
        cmd4.Parameters.AddWithValue("@yanlis3", yanliscevapuc4.Text)

        Dim soruekle5 As String = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)"
        Dim cmd5 As New OleDb.OleDbCommand(soruekle5, conn)
        cmd5.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text)
        cmd5.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue)
        cmd5.Parameters.AddWithValue("@konuadi", konuadi.Text)
        cmd5.Parameters.AddWithValue("@soru", soru3.Text)
        cmd5.Parameters.AddWithValue("@dogrucevap", dogru5.Text)
        cmd5.Parameters.AddWithValue("@yanlis1", yanliscevapbir5.Text)
        cmd5.Parameters.AddWithValue("@yanlis2", yanliscevapiki5.Text)
        cmd5.Parameters.AddWithValue("@yanlis3", yanliscevapuc5.Text)

        Dim soruekle6 As String = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)"
        Dim cmd6 As New OleDb.OleDbCommand(soruekle6, conn)
        cmd6.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text)
        cmd6.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue)
        cmd6.Parameters.AddWithValue("@konuadi", konuadi.Text)
        cmd6.Parameters.AddWithValue("@soru", soru6.Text)
        cmd6.Parameters.AddWithValue("@dogrucevap", dogru6.Text)
        cmd6.Parameters.AddWithValue("@yanlis1", yanliscevapbir6.Text)
        cmd6.Parameters.AddWithValue("@yanlis2", yanliscevapiki6.Text)
        cmd6.Parameters.AddWithValue("@yanlis3", yanliscevapuc6.Text)

        Dim soruekle7 As String = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)"
        Dim cmd7 As New OleDb.OleDbCommand(soruekle7, conn)
        cmd7.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text)
        cmd7.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue)
        cmd7.Parameters.AddWithValue("@konuadi", konuadi.Text)
        cmd7.Parameters.AddWithValue("@soru", soru7.Text)
        cmd7.Parameters.AddWithValue("@dogrucevap", dogru7.Text)
        cmd7.Parameters.AddWithValue("@yanlis1", yanliscevapbir7.Text)
        cmd7.Parameters.AddWithValue("@yanlis2", yanliscevapiki7.Text)
        cmd7.Parameters.AddWithValue("@yanlis3", yanliscevapuc7.Text)

        Dim soruekle8 As String = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)"
        Dim cmd8 As New OleDb.OleDbCommand(soruekle8, conn)
        cmd8.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text)
        cmd8.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue)
        cmd8.Parameters.AddWithValue("@konuadi", konuadi.Text)
        cmd8.Parameters.AddWithValue("@soru", soru8.Text)
        cmd8.Parameters.AddWithValue("@dogrucevap", dogru8.Text)
        cmd8.Parameters.AddWithValue("@yanlis1", yanliscevapbir8.Text)
        cmd8.Parameters.AddWithValue("@yanlis2", yanliscevapiki8.Text)
        cmd8.Parameters.AddWithValue("@yanlis3", yanliscevapuc8.Text)

        Dim soruekle9 As String = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)"
        Dim cmd9 As New OleDb.OleDbCommand(soruekle9, conn)
        cmd9.Parameters.AddWithValue("@ogretmenad", hiddenogretmen.Text)
        cmd9.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue)
        cmd9.Parameters.AddWithValue("@konuadi", konuadi.Text)
        cmd9.Parameters.AddWithValue("@soru", soru9.Text)
        cmd9.Parameters.AddWithValue("@dogrucevap", dogru9.Text)
        cmd9.Parameters.AddWithValue("@yanlis1", yanliscevapbir9.Text)
        cmd9.Parameters.AddWithValue("@yanlis2", yanliscevapiki9.Text)
        cmd9.Parameters.AddWithValue("@yanlis3", yanliscevapuc9.Text)

        Dim soruekle10 As String = "INSERT INTO sorular(ogretmen,ders,konu,soru,dcevap,ycevap1,ycevap2,ycevap3) VALUES (@ogretmenad,@dersadi,@konuadi,@soru,@dogrucevap,@yanlis1,@yanlis2,@yanlis3)"
        Dim cmd10 As New OleDb.OleDbCommand(soruekle10, conn)
        cmd10.Parameters.AddWithValue("@dersadi", DropDownListders.SelectedValue)
        cmd10.Parameters.AddWithValue("@konuadi", konuadi.Text)
        cmd10.Parameters.AddWithValue("@soru", soru10.Text)
        cmd10.Parameters.AddWithValue("@dogrucevap", dogru10.Text)
        cmd10.Parameters.AddWithValue("@yanlis1", yanliscevapbir10.Text)
        cmd10.Parameters.AddWithValue("@yanlis2", yanliscevapiki10.Text)
        cmd10.Parameters.AddWithValue("@yanlis3", yanliscevapuc10.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        cmd2.ExecuteNonQuery()
        cmd3.ExecuteNonQuery()
        cmd4.ExecuteNonQuery()
        cmd5.ExecuteNonQuery()
        cmd6.ExecuteNonQuery()
        cmd7.ExecuteNonQuery()
        cmd8.ExecuteNonQuery()
        cmd9.ExecuteNonQuery()
        cmd10.ExecuteNonQuery()
        conn.Close()







    End Sub
End Class