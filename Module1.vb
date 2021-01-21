Imports System.Windows.Forms
Module Module1

    Sub Main()
        Dim form As New Form1
        Dim s As String
        form.cas = InputBox("Zadejte čas v s:", "Zadejte čas")
        form.ShowDialog()
    End Sub

End Module
