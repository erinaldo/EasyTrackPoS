Public Class frmAddwaiter
    Private Sub BunifuButton21_Click(sender As Object, e As EventArgs) Handles BunifuButton21.Click
        create("insert into waiters (waitername) values('" + TextBox1.Text + "')")
        display()
    End Sub

    Private Sub frmAddwaiter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display()
    End Sub
    Sub display()
        reload("select * from waiters", BunifuDataGridView1)
    End Sub
End Class