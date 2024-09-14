Imports System.Reflection
Imports dllTestProject

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim ID As VariantType = "1000"
        Dim FormName As String = "Form2"
        Dim FullFormName As String = "OpenFormInAssemplyPrjCSharp.Form2"

        FullFormName = System.Reflection.Assembly.GetEntryAssembly.GetName.Name & "." & FormName

        Dim frm As Form = System.Activator.CreateInstance(System.Type.GetType(FullFormName), ID)


        frm.ShowDialog()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim frm As Form = AssemblyForm.GenerateFrom("", "Form2", "1:System.Int32;ali:System.String")
        frm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As Form = AssemblyForm.GenerateFrom("", "Form3")
        frm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As Form = AssemblyForm.GenerateFrom("dllTestProject", "frmTest")

        frm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New dllTestProject.frmTest(10)
        frm.ShowDialog()
    End Sub
End Class
