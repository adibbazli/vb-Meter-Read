<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label6 As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim No_meterLabel As System.Windows.Forms.Label
        Dim TunggakanLabel As System.Windows.Forms.Label
        Dim TarikhLabel As System.Windows.Forms.Label
        Dim Meter_dahuluLabel As System.Windows.Forms.Label
        Dim Meter_semasaLabel As System.Windows.Forms.Label
        Dim JumlahLabel As System.Windows.Forms.Label
        Dim No_akaunLabel As System.Windows.Forms.Label
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.No_meterTextBox = New System.Windows.Forms.TextBox()
        Me.TunggakanTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Meter_dahuluTextBox = New System.Windows.Forms.TextBox()
        Me.Meter_semasaTextBox = New System.Windows.Forms.TextBox()
        Me.JumlahTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.VbDataSet = New Tolonglahbolehrun.vbDataSet()
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableAdapter = New Tolonglahbolehrun.vbDataSetTableAdapters.UserTableAdapter()
        Me.TableAdapterManager = New Tolonglahbolehrun.vbDataSetTableAdapters.TableAdapterManager()
        Me.BillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillTableAdapter = New Tolonglahbolehrun.vbDataSetTableAdapters.BillTableAdapter()
        Me.No_akaunTextBox = New System.Windows.Forms.TextBox()
        Label6 = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        No_meterLabel = New System.Windows.Forms.Label()
        TunggakanLabel = New System.Windows.Forms.Label()
        TarikhLabel = New System.Windows.Forms.Label()
        Meter_dahuluLabel = New System.Windows.Forms.Label()
        Meter_semasaLabel = New System.Windows.Forms.Label()
        JumlahLabel = New System.Windows.Forms.Label()
        No_akaunLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(419, 222)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(43, 13)
        Label6.TabIndex = 76
        Label6.Text = "Jumlah:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(72, 87)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(38, 13)
        NamaLabel.TabIndex = 65
        NamaLabel.Text = "Nama:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(68, 113)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(42, 13)
        AlamatLabel.TabIndex = 67
        AlamatLabel.Text = "Alamat:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(405, 87)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(57, 13)
        Label5.TabIndex = 69
        Label5.Text = "No akaun:"
        '
        'No_meterLabel
        '
        No_meterLabel.AutoSize = True
        No_meterLabel.Location = New System.Drawing.Point(409, 113)
        No_meterLabel.Name = "No_meterLabel"
        No_meterLabel.Size = New System.Drawing.Size(53, 13)
        No_meterLabel.TabIndex = 71
        No_meterLabel.Text = "No meter:"
        '
        'TunggakanLabel
        '
        TunggakanLabel.AutoSize = True
        TunggakanLabel.Location = New System.Drawing.Point(397, 139)
        TunggakanLabel.Name = "TunggakanLabel"
        TunggakanLabel.Size = New System.Drawing.Size(65, 13)
        TunggakanLabel.TabIndex = 73
        TunggakanLabel.Text = "Tunggakan:"
        '
        'TarikhLabel
        '
        TarikhLabel.AutoSize = True
        TarikhLabel.Location = New System.Drawing.Point(93, 196)
        TarikhLabel.Name = "TarikhLabel"
        TarikhLabel.Size = New System.Drawing.Size(40, 13)
        TarikhLabel.TabIndex = 54
        TarikhLabel.Text = "Tarikh:"
        '
        'Meter_dahuluLabel
        '
        Meter_dahuluLabel.AutoSize = True
        Meter_dahuluLabel.Location = New System.Drawing.Point(51, 248)
        Meter_dahuluLabel.Name = "Meter_dahuluLabel"
        Meter_dahuluLabel.Size = New System.Drawing.Size(82, 13)
        Meter_dahuluLabel.TabIndex = 57
        Meter_dahuluLabel.Text = "Bacaan dahulu:"
        '
        'Meter_semasaLabel
        '
        Meter_semasaLabel.AutoSize = True
        Meter_semasaLabel.Location = New System.Drawing.Point(47, 274)
        Meter_semasaLabel.Name = "Meter_semasaLabel"
        Meter_semasaLabel.Size = New System.Drawing.Size(86, 13)
        Meter_semasaLabel.TabIndex = 59
        Meter_semasaLabel.Text = "Bacaan semasa:"
        '
        'JumlahLabel
        '
        JumlahLabel.AutoSize = True
        JumlahLabel.Location = New System.Drawing.Point(396, 196)
        JumlahLabel.Name = "JumlahLabel"
        JumlahLabel.Size = New System.Drawing.Size(66, 13)
        JumlahLabel.TabIndex = 61
        JumlahLabel.Text = "Caj Semasa:"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(476, 193)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.ReadOnly = True
        Me.TextBox15.Size = New System.Drawing.Size(76, 20)
        Me.TextBox15.TabIndex = 77
        '
        'NamaTextBox
        '
        Me.NamaTextBox.Location = New System.Drawing.Point(139, 84)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.ReadOnly = True
        Me.NamaTextBox.Size = New System.Drawing.Size(239, 20)
        Me.NamaTextBox.TabIndex = 66
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.Location = New System.Drawing.Point(139, 110)
        Me.AlamatTextBox.Multiline = True
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.ReadOnly = True
        Me.AlamatTextBox.Size = New System.Drawing.Size(239, 53)
        Me.AlamatTextBox.TabIndex = 68
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(476, 84)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(100, 20)
        Me.TextBox13.TabIndex = 70
        '
        'No_meterTextBox
        '
        Me.No_meterTextBox.Location = New System.Drawing.Point(476, 110)
        Me.No_meterTextBox.Name = "No_meterTextBox"
        Me.No_meterTextBox.ReadOnly = True
        Me.No_meterTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_meterTextBox.TabIndex = 72
        '
        'TunggakanTextBox
        '
        Me.TunggakanTextBox.Location = New System.Drawing.Point(476, 136)
        Me.TunggakanTextBox.Name = "TunggakanTextBox"
        Me.TunggakanTextBox.ReadOnly = True
        Me.TunggakanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TunggakanTextBox.TabIndex = 74
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(501, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Tutup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.TextBox12)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(139, 321)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 134)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tarif Penggunaan"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(349, 88)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(76, 20)
        Me.TextBox10.TabIndex = 15
        Me.TextBox10.Text = "0"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(349, 62)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(76, 20)
        Me.TextBox11.TabIndex = 14
        Me.TextBox11.Text = "0"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(349, 36)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(76, 20)
        Me.TextBox12.TabIndex = 13
        Me.TextBox12.Text = "0"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(235, 88)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(76, 20)
        Me.TextBox7.TabIndex = 12
        Me.TextBox7.Text = "2.00"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(235, 62)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(76, 20)
        Me.TextBox8.TabIndex = 11
        Me.TextBox8.Text = "1.03"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(235, 36)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(76, 20)
        Me.TextBox9.TabIndex = 10
        Me.TextBox9.Text = "0.57"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(124, 88)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(76, 20)
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.Text = "0"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(124, 62)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(76, 20)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.Text = "0"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(123, 36)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(76, 20)
        Me.TextBox6.TabIndex = 7
        Me.TextBox6.Text = "0"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(20, 88)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(76, 20)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Text = "> 35"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(20, 62)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(76, 20)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "21 - 35"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(20, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(76, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "0- 20"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(359, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jumlah (RM)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kadar (RM)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Penggunaan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Blok Tarif"
        '
        'Meter_dahuluTextBox
        '
        Me.Meter_dahuluTextBox.Location = New System.Drawing.Point(139, 245)
        Me.Meter_dahuluTextBox.Name = "Meter_dahuluTextBox"
        Me.Meter_dahuluTextBox.ReadOnly = True
        Me.Meter_dahuluTextBox.Size = New System.Drawing.Size(146, 20)
        Me.Meter_dahuluTextBox.TabIndex = 58
        '
        'Meter_semasaTextBox
        '
        Me.Meter_semasaTextBox.Location = New System.Drawing.Point(139, 271)
        Me.Meter_semasaTextBox.Name = "Meter_semasaTextBox"
        Me.Meter_semasaTextBox.ReadOnly = True
        Me.Meter_semasaTextBox.Size = New System.Drawing.Size(146, 20)
        Me.Meter_semasaTextBox.TabIndex = 60
        '
        'JumlahTextBox
        '
        Me.JumlahTextBox.Location = New System.Drawing.Point(476, 219)
        Me.JumlahTextBox.Name = "JumlahTextBox"
        Me.JumlahTextBox.ReadOnly = True
        Me.JumlahTextBox.Size = New System.Drawing.Size(76, 20)
        Me.JumlahTextBox.TabIndex = 62
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(139, 193)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(146, 20)
        Me.TextBox14.TabIndex = 78
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1"})
        Me.ComboBox1.Location = New System.Drawing.Point(476, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 79
        Me.ComboBox1.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(409, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "No Index:"
        '
        'VbDataSet
        '
        Me.VbDataSet.DataSetName = "vbDataSet"
        Me.VbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "User"
        Me.UserBindingSource.DataSource = Me.VbDataSet
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BillTableAdapter = Me.BillTableAdapter
        Me.TableAdapterManager.UpdateOrder = Tolonglahbolehrun.vbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Me.UserTableAdapter
        '
        'BillBindingSource
        '
        Me.BillBindingSource.DataMember = "UserBill"
        Me.BillBindingSource.DataSource = Me.UserBindingSource
        '
        'BillTableAdapter
        '
        Me.BillTableAdapter.ClearBeforeFill = True
        '
        'No_akaunTextBox
        '
        Me.No_akaunTextBox.Location = New System.Drawing.Point(139, 219)
        Me.No_akaunTextBox.Name = "No_akaunTextBox"
        Me.No_akaunTextBox.ReadOnly = True
        Me.No_akaunTextBox.Size = New System.Drawing.Size(146, 20)
        Me.No_akaunTextBox.TabIndex = 56
        '
        'No_akaunLabel
        '
        No_akaunLabel.AutoSize = True
        No_akaunLabel.Location = New System.Drawing.Point(76, 222)
        No_akaunLabel.Name = "No_akaunLabel"
        No_akaunLabel.Size = New System.Drawing.Size(57, 13)
        No_akaunLabel.TabIndex = 55
        No_akaunLabel.Text = "No akaun:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 558)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(AlamatLabel)
        Me.Controls.Add(Me.AlamatTextBox)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(No_meterLabel)
        Me.Controls.Add(Me.No_meterTextBox)
        Me.Controls.Add(TunggakanLabel)
        Me.Controls.Add(Me.TunggakanTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(TarikhLabel)
        Me.Controls.Add(No_akaunLabel)
        Me.Controls.Add(Me.No_akaunTextBox)
        Me.Controls.Add(Meter_dahuluLabel)
        Me.Controls.Add(Me.Meter_dahuluTextBox)
        Me.Controls.Add(Meter_semasaLabel)
        Me.Controls.Add(Me.Meter_semasaTextBox)
        Me.Controls.Add(JumlahLabel)
        Me.Controls.Add(Me.JumlahTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rumusan [No. Account]"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents NamaTextBox As TextBox
    Friend WithEvents AlamatTextBox As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents No_meterTextBox As TextBox
    Friend WithEvents TunggakanTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Meter_dahuluTextBox As TextBox
    Friend WithEvents Meter_semasaTextBox As TextBox
    Friend WithEvents JumlahTextBox As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents VbDataSet As vbDataSet
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserTableAdapter As vbDataSetTableAdapters.UserTableAdapter
    Friend WithEvents TableAdapterManager As vbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BillTableAdapter As vbDataSetTableAdapters.BillTableAdapter
    Friend WithEvents BillBindingSource As BindingSource
    Friend WithEvents No_akaunTextBox As TextBox
End Class
