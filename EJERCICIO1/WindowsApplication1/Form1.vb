Public Class Form1
    Dim a As Integer            'Definimos a como variable de tipo entero
    Dim b As Integer            'Definimos b como variable de tipo entero
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)              'Transforma el número ingresado en TextBox1 como cadena a tipo entero y lo almacena en a
        b = Val(TextBox2.Text)              'Transforma el número ingresado en TextBox2 como cadena a tipo entero y lo almacena en b
        If (a > b) Then                     'Comparación entre a y b
            TextBox3.Text = Str(a)          'Convierte la variable a en cadena de caracteres y la muestra en pantalla
        Else
            TextBox3.Text = Str(b)          'Convierte la variable b en cadena de caracteres y la muestra en pantalla
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
