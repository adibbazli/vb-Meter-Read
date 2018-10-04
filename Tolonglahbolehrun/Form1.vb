Imports System.Data.OleDb

Public Class Form1
    ' Me.TableAdapterManager.UpdateAll(Me.VbDataSet)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BillTableAdapter.Fill(Me.VbDataSet.Bill)
        Me.UserTableAdapter.Fill(Me.VbDataSet.User)
        ListBoxUpdate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As Integer

        Try
            s = Integer.Parse(TextBox12.Text)
        Catch ex As FormatException
            Label13.Text = "Sila Masukkan Nombor Meter Dengan Betul"
            Label13.Visible = True
            Return
        End Try


        Dim foundRow() As Data.DataRow
        foundRow = VbDataSet.Bill.Select("No_meter='" & s & "'")
        'Label13.Text = foundRow.Count

        If foundRow.Count <> 0 Then
            ' Kira'
            Dim m As Double
            Try
                m = Double.Parse(TextBox4.Text)
            Catch ex As FormatException
                Label13.Text = "Sila Masukkan Bacaan Dengan Betul"
                Label13.Visible = True
                Return
            End Try
            Label13.Visible = False

            Dim lastRead As Double

            If foundRow.Count <> 1 Then
                Dim read As Integer = foundRow.Count - 1
                lastRead = foundRow(read).Item("Meter_bacaan")
            Else
                lastRead = 0 ' For New Account '
            End If
            Console.WriteLine("lastRead = " & lastRead)

            Dim price As Double
            Dim use As Integer

            use = m - lastRead
            price = use
            '  Console.WriteLine("use = " & use)
            '  Label12.Text = lastRead
            '  Label4.Text = price

            If m < lastRead Then
                Label13.Text = "Sila Masukkan Bacaan Dengan Betul"
                Label13.Visible = True
                Return
            ElseIf use > 35 Then
                price *= 2.0
            ElseIf use > 20 Then
                price *= 1.03
            ElseIf use >= 0 Then
                price *= 0.57
            End If

            TextBox8.Text = "RM " & price
            Save(s, foundRow.Count, m, use, price)
        Else
            Label13.Text = "Nombor Meter Tiada Di Dalam Rekod Pengkalan Data"
            Label13.Visible = True
        End If
    End Sub

    Private Sub Save(meter As Integer, numRow As Integer, now As Integer, usage As Integer, total As Double)
        Dim foundRowUser() As Data.DataRow = VbDataSet.Bill.Select("No_meter='" & meter & "'")


        If numRow <> 1 Then
            numRow -= 1 ' If 1 mean new account '
        Else
            numRow = 0
        End If
        TextBox1.Text = foundRowUser(numRow).Item("Meter_bacaan")
        TextBox2.Text = now
        TextBox3.Text = usage

        Dim regDate As Date = Date.Now()
        Dim strDate As String = regDate.ToString("dd\/MM\/yyyy")


        Dim foundRow As Integer = VbDataSet.Bill.Rows.Count
        VbDataSet.Bill.Rows.Add()

        VbDataSet.Bill(foundRow).No_akaun = foundRowUser(0).Item("No_akaun")
        VbDataSet.Bill(foundRow).No_meter = meter
        VbDataSet.Bill(foundRow).Meter_bacaan = now
        VbDataSet.Bill(foundRow).Penggunaan = usage
        VbDataSet.Bill(foundRow).Tarikh = strDate
        VbDataSet.Bill(foundRow).Tunggakan = 0
        VbDataSet.Bill(foundRow).Jumlah = total

        Me.TableAdapterManager.UpdateAll(VbDataSet)
    End Sub

    Private Sub ListBoxUpdate()
        ListBox1.Items.Clear()

        Dim foundRow As Integer
        foundRow = VbDataSet.User.Rows.Count

        Dim i As Integer = 0
        While i < foundRow
            ListBox1.Items.Add(VbDataSet.User(i).No_akaun & " - " & VbDataSet.User(i).Nama)
            i += 1
        End While
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            Button4.Enabled = True
            Button3.Enabled = True
            Button5.Enabled = True
        End If

        Try
            TextBox9.Text = VbDataSet.User(ListBox1.SelectedIndex).No_akaun
            TextBox10.Text = VbDataSet.User(ListBox1.SelectedIndex).Nama
            TextBox11.Text = VbDataSet.User(ListBox1.SelectedIndex).Alamat

            Dim foundRow() As Data.DataRow = VbDataSet.Bill.Select("No_akaun='" & TextBox9.Text & "'")
            TextBox14.Text = foundRow(0).Item("No_meter")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label15.Visible = False
        Try
            Integer.Parse(TextBox9.Text)
        Catch ex As FormatException
            Label15.Text = "Sila Masukkan No Akaun Dengan Betul"
            Label15.Visible = True
            Return
        End Try

        Try
            Integer.Parse(TextBox14.Text)
        Catch ex As FormatException
            Label15.Text = "Sila Masukkan No Meter Dengan Betul"
            Label15.Visible = True
            Return
        End Try

        Dim foundRow() As Data.DataRow = VbDataSet.User.Select("No_akaun='" & TextBox9.Text & "'")
        If foundRow.Count <> 0 Then
            MessageBox.Show("Nombor Akaun Sudah Ada Di Dalam Pengkalan Data",
                            "Sila Semak Semula", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            foundRow = VbDataSet.Bill.Select("No_meter='" & TextBox14.Text & "'")
            If foundRow.Count <> 0 Then
                MessageBox.Show("Nombor Meter Sudah Ada Di Dalam Pengkalan Data",
                            "Sila Semak Semula", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            'Add'

            If TextBox10.Text = "" Or TextBox11.Text = "" Then
                Label15.Text = "Nama dan Alamat tidak boleh kosong"
                Label15.Visible = True
                Return
            End If

            Dim numRow As Integer = VbDataSet.User.Rows.Count
            VbDataSet.User.Rows.Add()

            VbDataSet.User(numRow).No_akaun = TextBox9.Text
            VbDataSet.User(numRow).Nama = TextBox10.Text
            VbDataSet.User(numRow).Alamat = TextBox11.Text

            numRow = VbDataSet.Bill.Rows.Count
            VbDataSet.Bill.Rows.Add()

            Dim regDate As Date = Date.Now()
            Dim strDate As String = regDate.ToString("dd\/MM\/yyyy")

            VbDataSet.Bill(numRow).No_akaun = TextBox9.Text
            VbDataSet.Bill(numRow).No_meter = TextBox14.Text
            VbDataSet.Bill(numRow).Meter_bacaan = 0
            VbDataSet.Bill(numRow).Penggunaan = 0
            VbDataSet.Bill(numRow).Tunggakan = 0
            VbDataSet.Bill(numRow).Jumlah = 0
            VbDataSet.Bill(numRow).Tarikh = strDate
            ListBoxUpdate()
            Me.TableAdapterManager.UpdateAll(VbDataSet)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label15.Visible = False
        Dim foundRow() As Data.DataRow
        Try
            foundRow = VbDataSet.User.Select("No_akaun='" & TextBox9.Text & "'")
        Catch ex As FormatException
            Label15.Text = "Sila Masukkan No Akaun Dengan Betul"
            Label15.Visible = True
            Return
        End Try

        Dim foundRow2() As Data.DataRow
        Try
            foundRow2 = VbDataSet.Bill.Select("No_meter='" & TextBox14.Text & "'")
        Catch ex As Exception
            Label15.Text = "Sila Masukkan No Meter Dengan Betul"
            Label15.Visible = True
            Return
        End Try


        If foundRow.Count = 0 Then
            MessageBox.Show("Nombor Akaun Tidak Dijumpai Di Dalam Pengkalan Data",
                            "Sila Semak Semula", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf foundRow2.Count = 0 Then
            MessageBox.Show("Nombor Meter Tidak Dijumpai Di Dalam Pengkalan Data",
                            "Sila Semak Semula", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            'Update'
            If TextBox10.Text = "" Or TextBox11.Text = "" Then
                Label15.Text = "Nama dan Alamat tidak boleh kosong"
                Label15.Visible = True
                Return
            End If

            Dim numRow As Integer = ListBox1.SelectedIndex

            VbDataSet.User(numRow).Nama = TextBox10.Text
            VbDataSet.User(numRow).Alamat = TextBox11.Text

            ListBoxUpdate()
            Me.TableAdapterManager.UpdateAll(VbDataSet)
        End If
    End Sub

    Public acc_val As String
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        acc_val = VbDataSet.User(ListBox1.SelectedIndex).No_akaun
        Dim summary = New Form2()
        summary.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'No Failsafe, just delete'
        Dim acc As Integer = VbDataSet.User(ListBox1.SelectedIndex).No_akaun
        Dim res = MessageBox.Show("Anda Pasti Hendak Padam Akaun No " & acc & " Daripada Pengkalan Data?",
                            "Amaran", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        Select Case res
            Case DialogResult.OK

                Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\vb1.accdb")
                con.Open()
                Dim com As OleDbCommand
                com = New OleDbCommand
                com.CommandText = "DELETE User.[No_akaun], *
                                    FROM [User]
                                        WHERE (((User.[No_akaun])=@acc));"

                com.Parameters.AddWithValue("@acc", acc)
                com.Connection = con
                com.ExecuteNonQuery()
                con.Close()

                VbDataSet.User.Rows.RemoveAt(ListBox1.SelectedIndex)

                Me.TableAdapterManager.UpdateAll(VbDataSet)
                ListBoxUpdate()

        End Select

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about = New AboutBox1()
        about.ShowDialog()
    End Sub
End Class