﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class スタート
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.start = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.出力 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.親PC = New System.Windows.Forms.RadioButton()
        Me.子PC1 = New System.Windows.Forms.RadioButton()
        Me.子PC2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.入力 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'start
        '
        Me.start.BackColor = System.Drawing.Color.DarkRed
        Me.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.start.Font = New System.Drawing.Font("メイリオ", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.start.ForeColor = System.Drawing.Color.White
        Me.start.Location = New System.Drawing.Point(36, 502)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(761, 61)
        Me.start.TabIndex = 0
        Me.start.Text = "スタート"
        Me.start.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(52, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox1.TabIndex = 1
        '
        '出力
        '
        Me.出力.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.出力.Font = New System.Drawing.Font("Meiryo UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.出力.Location = New System.Drawing.Point(81, 238)
        Me.出力.Name = "出力"
        Me.出力.Size = New System.Drawing.Size(229, 54)
        Me.出力.TabIndex = 98
        Me.出力.Text = "出力"
        Me.出力.UseVisualStyleBackColor = False
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.SelectedPath = "C:\Users\SHE\Desktop\kubo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.InitialDirectory = "C:\Users\SHE\Desktop\kubo\被験者"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        Me.OpenFileDialog2.InitialDirectory = "C:\Users\SHE\Desktop\kubo\街"
        '
        '親PC
        '
        Me.親PC.Appearance = System.Windows.Forms.Appearance.Button
        Me.親PC.AutoSize = True
        Me.親PC.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.親PC.Location = New System.Drawing.Point(28, 20)
        Me.親PC.Name = "親PC"
        Me.親PC.Size = New System.Drawing.Size(30, 30)
        Me.親PC.TabIndex = 103
        Me.親PC.TabStop = True
        Me.親PC.Text = "A"
        Me.親PC.UseVisualStyleBackColor = True
        '
        '子PC1
        '
        Me.子PC1.Appearance = System.Windows.Forms.Appearance.Button
        Me.子PC1.AutoSize = True
        Me.子PC1.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.子PC1.Location = New System.Drawing.Point(98, 20)
        Me.子PC1.Name = "子PC1"
        Me.子PC1.Size = New System.Drawing.Size(30, 30)
        Me.子PC1.TabIndex = 104
        Me.子PC1.TabStop = True
        Me.子PC1.Text = "B"
        Me.子PC1.UseVisualStyleBackColor = True
        '
        '子PC2
        '
        Me.子PC2.Appearance = System.Windows.Forms.Appearance.Button
        Me.子PC2.AutoSize = True
        Me.子PC2.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.子PC2.Location = New System.Drawing.Point(168, 20)
        Me.子PC2.Name = "子PC2"
        Me.子PC2.Size = New System.Drawing.Size(30, 30)
        Me.子PC2.TabIndex = 105
        Me.子PC2.TabStop = True
        Me.子PC2.Text = "C"
        Me.子PC2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.親PC)
        Me.GroupBox1.Controls.Add(Me.子PC2)
        Me.GroupBox1.Controls.Add(Me.子PC1)
        Me.GroupBox1.Location = New System.Drawing.Point(81, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 60)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PC選択"
        '
        '入力
        '
        Me.入力.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.入力.Font = New System.Drawing.Font("Meiryo UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.入力.Location = New System.Drawing.Point(81, 144)
        Me.入力.Name = "入力"
        Me.入力.Size = New System.Drawing.Size(229, 49)
        Me.入力.TabIndex = 107
        Me.入力.Text = "入力"
        Me.入力.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(36, 595)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(761, 67)
        Me.GroupBox2.TabIndex = 108
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "管理者用"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(563, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 19)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(397, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 19)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 19)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "A"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(591, 25)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(124, 26)
        Me.TextBox3.TabIndex = 80
        Me.TextBox3.Text = "192.168.10.3"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(424, 25)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(124, 26)
        Me.TextBox2.TabIndex = 79
        Me.TextBox2.Text = "192.168.10.2"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(247, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 26)
        Me.TextBox1.TabIndex = 78
        Me.TextBox1.Text = "192.168.10.4"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(505, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(292, 146)
        Me.GroupBox3.TabIndex = 78
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "協力者の名前"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 24)
        Me.Label7.TabIndex = 72
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(49, 96)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(176, 31)
        Me.TextBox4.TabIndex = 76
        Me.TextBox4.WordWrap = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(49, 36)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(176, 31)
        Me.TextBox5.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 24)
        Me.Label8.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Red
        Me.Label9.Font = New System.Drawing.Font("メイリオ", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(405, 468)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(392, 31)
        Me.Label9.TabIndex = 114
        Me.Label9.Text = "画面キャプチャーは起動しましたか？？"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(45, 356)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(752, 25)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "実験中、チームメンバーの２人とコミュニケーションをとることができます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(45, 381)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(752, 75)
        Me.Label11.TabIndex = 116
        Me.Label11.Text = "消防業務は命がかかった業務です。基本的にマニュアルに従って行動してください。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "しかし、目標達成(人命救助、または多くの面積を守ること)のために良いと判断した場合" &
    "は、マニュアル外の行動を取っても構いません。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 24)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "①"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(41, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 24)
        Me.Label12.TabIndex = 119
        Me.Label12.Text = "②"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(41, 251)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 24)
        Me.Label13.TabIndex = 120
        Me.Label13.Text = "③"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.Location = New System.Drawing.Point(456, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 24)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "④"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.Location = New System.Drawing.Point(213, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(393, 24)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "①～⑥を指示に従って入力してください。"
        '
        'TextBox6
        '
        Me.TextBox6.AllowDrop = True
        Me.TextBox6.Location = New System.Drawing.Point(36, 199)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(392, 19)
        Me.TextBox6.TabIndex = 124
        '
        'TextBox7
        '
        Me.TextBox7.AllowDrop = True
        Me.TextBox7.Location = New System.Drawing.Point(36, 298)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(392, 19)
        Me.TextBox7.TabIndex = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(456, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "⑤自分の名前"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(460, 296)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(146, 19)
        Me.TextBox8.TabIndex = 128
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(643, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 24)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "⑥タスクの回数"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2"})
        Me.ComboBox2.Location = New System.Drawing.Point(663, 297)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox2.TabIndex = 132
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(301, 575)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 12)
        Me.Label16.TabIndex = 134
        '
        'スタート
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 684)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.入力)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.出力)
        Me.Controls.Add(Me.start)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "スタート"
        Me.Text = "集団タスク(本番)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents start As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents 出力 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents 親PC As RadioButton
    Friend WithEvents 子PC1 As RadioButton
    Friend WithEvents 子PC2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents 入力 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label16 As Label
End Class
