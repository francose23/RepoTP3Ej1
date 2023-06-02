Public Class Form1
    Dim Num1 As Integer            'Definimos Num1 como variable de tipo entero
    Dim Num2 As Integer            'Definimos Num2 como variable de tipo entero
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Num1 = Val(TextBox1.Text)              'Transforma el número ingresado en TextBox1 como cadena a tipo entero y lo almacena en Num1
        Num2 = Val(TextBox2.Text)              'Transforma el número ingresado en TextBox2 como cadena a tipo entero y lo almacena en Num2
        If (Num1 > Num2) Then                     'Comparación entre Num1 y Num2
            TextBox3.Text = Str(Num1)          'Convierte la variable a en cadena de caracteres y la muestra en pantalla
        Else
            TextBox3.Text = Str(Num2)          'Convierte la variable b en cadena de caracteres y la muestra en pantalla
        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
