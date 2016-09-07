Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub


    ''' <summary>
    ''' Ver- Adventure Of A Lifetime
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnVer.Click

        lblTitulo.Text = "Adventure Of A Lifetime"
        lblArtista.Text = "Cold Play"
        lblPrecio.Text = "$23.99"
        PictureBox1.Image = pbCover.Images.Item(3)


    End Sub
    ''' <summary>
    ''' Ver-Sweet Child On Mine
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lblTitulo.Text = "Sweet Child On Mine"
        lblArtista.Text = "Guns N'Roses"
        lblPrecio.Text = "$55.79"
        PictureBox1.Image = pbCover.Images.Item(2)



    End Sub

    ''' <summary>
    ''' Ver- Smells like teen Spirit
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        lblTitulo.Text = "Smells like teen Spirit"
        lblArtista.Text = "Nirvana"
        lblPrecio.Text = "$42.69"
        PictureBox1.Image = pbCover.Images.Item(0)






    End Sub
    ''' <summary>
    ''' Ver-Fiesta Pagana 2.0
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        lblTitulo.Text = "Fiesta Pagana 2.0"
        lblArtista.Text = "Mago de Oz"
        lblPrecio.Text = "$14.59"
        PictureBox1.Image = pbCover.Images.Item(1)


    End Sub
End Class
