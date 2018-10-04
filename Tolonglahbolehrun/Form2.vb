Public Class Form2
    Dim acc_val = Form1.acc_val
    Dim first_run As Boolean = True
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Rumusan Akaun " & acc_val
        Me.BillTableAdapter.Fill(Me.VbDataSet.Bill)
        Me.UserTableAdapter.Fill(Me.VbDataSet.User)

        'No safe handling because previous form had handle all possible error, maybe'
        Dim foundRow() As Data.DataRow = VbDataSet.Bill.Select("No_akaun='" & acc_val & "'")
        ComboBox1.Items.Clear()
        For i As Integer = 1 To foundRow.Count
            ComboBox1.Items.Add(i)
        Next
        ComboBox1.SelectedIndex = 0
        ReloadForm(ComboBox1.SelectedIndex)
        first_run = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub UserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VbDataSet)

    End Sub

    Private Sub UserBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VbDataSet)

    End Sub

    Private Sub ReloadForm(index As Integer)
        TextBox10.Text = "0.00"
        TextBox11.Text = "0.00"
        TextBox12.Text = "0.00"
        TextBox4.Text = "0"
        TextBox5.Text = "0"
        TextBox6.Text = "0"

        Dim foundRowUser() As Data.DataRow = VbDataSet.User.Select("No_akaun='" & acc_val & "'")
        Dim foundRowBill() As Data.DataRow = VbDataSet.Bill.Select("No_akaun='" & acc_val & "'")

        NamaTextBox.Text = foundRowUser(0).Item("Nama")
        AlamatTextBox.Text = foundRowUser(0).Item("Alamat")


        TextBox14.Text = foundRowBill(index).Item("Tarikh")
        No_akaunTextBox.Text = foundRowBill(index).Item("No_akaun")

        'Bacaan Dahulu' -------------
        If index = 0 Then
            Meter_dahuluTextBox.Text = 0
        Else
            Meter_dahuluTextBox.Text = foundRowBill(index - 1).Item("Meter_bacaan")
        End If
        Meter_semasaTextBox.Text = foundRowBill(index).Item("Meter_bacaan")

        TextBox13.Text = foundRowBill(index).Item("No_akaun")
        No_meterTextBox.Text = foundRowBill(index).Item("No_meter")
        TunggakanTextBox.Text = foundRowBill(index).Item("Tunggakan")

        JumlahTextBox.Text = foundRowBill(index).Item("Jumlah")
        TextBox15.Text = Double.Parse(TunggakanTextBox.Text) + Double.Parse(JumlahTextBox.Text)

        Dim usage As Integer = Integer.Parse(foundRowBill(index).Item("Penggunaan"))
        If usage > 35 Then
            TextBox4.Text = usage
            TextBox10.Text = JumlahTextBox.Text
        ElseIf usage > 21 Then
            TextBox5.Text = usage
            TextBox11.Text = JumlahTextBox.Text
        ElseIf usage >= 0 Then
            TextBox6.Text = usage
            TextBox12.Text = JumlahTextBox.Text
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If first_run = False Then
            ReloadForm(ComboBox1.SelectedIndex)
        End If
    End Sub
End Class