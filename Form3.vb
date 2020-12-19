Imports System.IO
Imports NPOI.SS.UserModel
Imports NPOI.XSSF.UserModel
Imports NPOI.HSSF.UserModel

Public Class スタート

    'Imports System.Windows.Forms

    'フォームのLoadイベントハンドラ
    Private Sub Form3_Load(sender As Object, e As EventArgs) _
            Handles MyBase.Load
        'コンボボックスにディスプレイのリストを表示する
        Me.ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        'デバイス名が表示されるようにする
        Me.ComboBox1.DisplayMember = "DeviceName"
        Me.ComboBox1.DataSource = Screen.AllScreens

        If ComboBox1.SelectedIndex <> 0 Then
            ComboBox1.SelectedIndex = 1
        End If


		'Select_participant()

		'zikkennzyoukenn()

	End Sub

    'Public Sub Select_participant()
    '	'（WorkbookFactory.Create()を使ってinterfaceで受け取れば、xls, xlsxの両方に対応できます）
    '	'Dim workbook As IWorkbook = WorkbookFactory.Create("C:\Users\naoki\Documents\実験\被験者\被験者.xlsx")OpenFileDialog1.FileName

    '	Dim workbook As IWorkbook = WorkbookFactory.Create(OpenFileDialog1.FileName)
    '	'シート１
    '	Dim worksheet As ISheet = workbook.GetSheetAt(0)
    '	Dim lastRow As Integer = worksheet.LastRowNum



    '	'氏名
    '	氏名.Text = worksheet.GetRow(0).GetCell(0).ToString
    '	'性別
    '	If worksheet.GetRow(1).GetCell(0).ToString = "男" Then
    '		男.Checked = True
    '	Else
    '		女.Checked = True
    '	End If
    '	'年齢
    '	年齢.Text = worksheet.GetRow(2).GetCell(0).ToString
    '	'マニュアル

    '	If worksheet.GetRow(3).GetCell(0).ToString = "任意" Then
    '		任意.Checked = True
    '	Else
    '		厳守.Checked = True
    '	End If

    '	外向性.Text = worksheet.GetRow(4).GetCell(0).ToString
    '	協調性.Text = worksheet.GetRow(5).GetCell(0).ToString
    '	勤勉性.Text = worksheet.GetRow(6).GetCell(0).ToString
    '	神経症傾向.Text = worksheet.GetRow(7).GetCell(0).ToString
    '	開放性.Text = worksheet.GetRow(8).GetCell(0).ToString

    '	実験回数.Text = 1


    '	'シナリオ
    '	'シート2
    '	'シート１
    '	Dim worksheet2 As ISheet = workbook.GetSheetAt(1)
    '	Dim lastRow2 As Integer = worksheet.LastRowNum

    '	For n = 0 To 17
    '		If worksheet2.GetRow(n + 1).GetCell(0).ToString = "水の枯渇" Then
    '			conditions(n, 0) = "水の枯渇"
    '		ElseIf worksheet2.GetRow(n + 1).GetCell(0).ToString = "渋滞" Then
    '			conditions(n, 0) = "渋滞"
    '		ElseIf worksheet2.GetRow(n + 1).GetCell(0).ToString = "作業者の負傷" Then
    '			conditions(n, 0) = "作業者の負傷"
    '		ElseIf worksheet2.GetRow(n + 1).GetCell(0).ToString = "リソースの遅れ" Then
    '			conditions(n, 0) = "リソースの遅れ"
    '		ElseIf worksheet2.GetRow(n + 1).GetCell(0).ToString = "風向きが変わる" Then
    '			conditions(n, 0) = "風向きが変わる"
    '		ElseIf worksheet2.GetRow(n + 1).GetCell(0).ToString = "シナリオなし" Then
    '			conditions(n, 0) = "シナリオなし"
    '		End If
    '	Next

    '	For n = 0 To 17
    '		If worksheet2.GetRow(n + 1).GetCell(1).ToString = 3 Then
    '			conditions(n, 1) = 3
    '		ElseIf worksheet2.GetRow(n + 1).GetCell(1).ToString = 7 Then
    '			conditions(n, 1) = 7
    '		ElseIf worksheet2.GetRow(n + 1).GetCell(1).ToString = 11 Then
    '			conditions(n, 1) = 11
    '		ElseIf worksheet2.GetRow(n + 1).GetCell(1).ToString = 15 Then
    '			conditions(n, 1) = 15
    '		End If
    '	Next

    '	For n = 0 To 17
    '		If conditions(n, 0) = "風向きが変わる" Then
    '			If worksheet2.GetRow(n + 1).GetCell(2).ToString = "上" Then
    '				conditions(n, 2) = "上下"
    '			ElseIf worksheet2.GetRow(n + 1).GetCell(2).ToString = "右" Then
    '				conditions(n, 2) = "右左"
    '			ElseIf worksheet2.GetRow(n + 1).GetCell(2).ToString = "下" Then
    '				conditions(n, 2) = "下上"
    '			ElseIf worksheet2.GetRow(n + 1).GetCell(2).ToString = "左" Then
    '				conditions(n, 2) = "左右"
    '			End If
    '		Else
    '			If worksheet2.GetRow(n + 1).GetCell(2).ToString = "上" Then
    '				conditions(n, 2) = "上"
    '			ElseIf worksheet2.GetRow(n + 1).GetCell(2).ToString = "右" Then
    '				conditions(n, 2) = "右"
    '			ElseIf worksheet2.GetRow(n + 1).GetCell(2).ToString = "下" Then
    '				conditions(n, 2) = "下"
    '			ElseIf worksheet2.GetRow(n + 1).GetCell(2).ToString = "左" Then
    '				conditions(n, 2) = "左"
    '			End If
    '		End If
    '	Next

    '	For n = 0 To 17
    '		conditions(n, 3) = worksheet2.GetRow(n + 1).GetCell(3).ToString
    '	Next

    'End Sub


    'Private Sub zikkennzyoukenn()

    '       実験回数.Text = count_zikkenn + 1

    '       If conditions(count_zikkenn, 0) = "水の枯渇" Then
    '           水の枯渇.Checked = 1
    '       ElseIf conditions(count_zikkenn, 0) = "渋滞" Then
    '           渋滞.Checked = 1
    '       ElseIf conditions(count_zikkenn, 0) = "作業者の負傷" Then
    '           作業者の負傷.Checked = 1
    '       ElseIf conditions(count_zikkenn, 0) = "リソースの遅れ" Then
    '           リソースの遅れ.Checked = 1
    '       ElseIf conditions(count_zikkenn, 0) = "風向きが変わる" Then
    '           風向きが変わる.Checked = 1
    '       ElseIf conditions(count_zikkenn, 0) = "シナリオなし" Then
    '           シナリオなし.Checked = 1
    '       End If

    '       If conditions(count_zikkenn, 1) = 11 Then
    '           ms9.Checked = 1
    '       ElseIf conditions(count_zikkenn, 1) = 7 Then
    '           ms6.Checked = 1
    '       ElseIf conditions(count_zikkenn, 1) = 3 Then
    '           ms3.Checked = 1
    '       End If


    '       If conditions(count_zikkenn, 2) = "上" Then
    '           上.Checked = 1
    '       ElseIf conditions(count_zikkenn, 2) = "右" Then
    '           右.Checked = 1
    '       ElseIf conditions(count_zikkenn, 2) = "下" Then
    '           下.Checked = 1
    '       ElseIf conditions(count_zikkenn, 2) = "左" Then
    '           左.Checked = 1
    '       ElseIf conditions(count_zikkenn, 2) = "上下" Then
    '           上下.Checked = 1
    '       ElseIf conditions(count_zikkenn, 2) = "右左" Then
    '           右左.Checked = 1
    '       ElseIf conditions(count_zikkenn, 2) = "下上" Then
    '           下上.Checked = 1
    '       ElseIf conditions(count_zikkenn, 2) = "左右" Then
    '           左右.Checked = 1
    '       End If



    '       If conditions(count_zikkenn, 0) = "風向きが変わる" And conditions(count_zikkenn, 2) = "上" Then
    '           上下.Checked = 1
    '       End If
    '       If conditions(count_zikkenn, 0) = "風向きが変わる" And conditions(count_zikkenn, 2) = "右" Then
    '           右左.Checked = 1
    '       End If
    '       If conditions(count_zikkenn, 0) = "風向きが変わる" And conditions(count_zikkenn, 2) = "下" Then
    '           下上.Checked = 1
    '       End If
    '       If conditions(count_zikkenn, 0) = "風向きが変わる" And conditions(count_zikkenn, 2) = "左" Then
    '           左右.Checked = 1
    '       End If




    '       街.Text = conditions(count_zikkenn, 3)
    '   End Sub






    '   Public Sub loading()
    '       flag_gameover = 0

    '       If 水の枯渇.Checked = False And 渋滞.Checked = False And 作業者の負傷.Checked = False And リソースの遅れ.Checked = False And シナリオなし.Checked = False And 風向きが変わる.Checked = False Then
    '           シナリオ.ForeColor = Color.Red
    '           Exit Sub
    '       End If
    '       シナリオ.ForeColor = Color.Black


    '       If ms3.Checked = False And ms6.Checked = False And ms9.Checked = False Then
    '           風速.ForeColor = Color.Red
    '           Exit Sub
    '       End If
    '       風速.ForeColor = Color.Black

    '       If 上.Checked = False And 右.Checked = False And 下.Checked = False And 左.Checked = False And 上下.Checked = False And 右左.Checked = False And 下上.Checked = False And 左右.Checked = False Then
    '           風向.ForeColor = Color.Red
    '           Exit Sub
    '       End If
    '       風向.ForeColor = Color.Black

    '       If 厳守.Checked = False And 任意.Checked = False Then
    '           マニュアル.ForeColor = Color.Red
    '           Exit Sub
    '       End If
    '       マニュアル.ForeColor = Color.Black

    '       If 街.Text = Nothing Then
    '           Label4.ForeColor = Color.Red
    '           Exit Sub
    '       End If
    '       Label4.ForeColor = Color.Black

    '       If 氏名.Text = Nothing Or 年齢.Text = Nothing Or 実験回数.Text = Nothing Or (男.Checked = False And 女.Checked = False) Then
    '           被験者.ForeColor = Color.Red
    '           Exit Sub
    '       End If
    '       被験者.ForeColor = Color.Black



    '       '風速
    '       '9m/s
    '       If ms9.Checked = True Then
    '           flag_speed = 1
    '           time_sinario = 120
    '       End If
    '       '6m/s
    '       If ms6.Checked = True Then
    '           flag_speed = 2
    '           time_sinario = 90
    '       End If
    '       '3m/s
    '       If ms3.Checked = True Then
    '           flag_speed = 3
    '           time_sinario = 60
    '       End If


    '       If 水の枯渇.Checked = True Then
    '           flag_sinario = 1
    '       End If
    '       If 渋滞.Checked = True Then
    '           flag_sinario = 2
    '       End If
    '       If 作業者の負傷.Checked = True Then
    '           flag_sinario = 3
    '       End If
    '       If リソースの遅れ.Checked = True Then
    '           flag_sinario = 4
    '       End If
    '       If シナリオなし.Checked = True Then
    '           flag_sinario = 5
    '       End If
    '       If 風向きが変わる.Checked = True Then
    '           flag_sinario = 6
    '       End If


    '       If 上.Checked = True Then
    '           flag_winddirection = 1
    '       End If
    '       If 右.Checked = True Then
    '           flag_winddirection = 2
    '       End If
    '       If 下.Checked = True Then
    '           flag_winddirection = 3
    '       End If
    '       If 左.Checked = True Then
    '           flag_winddirection = 4
    '       End If
    '       If 上下.Checked = True Then
    '           flag_winddirection = 5
    '       End If
    '       If 右左.Checked = True Then
    '           flag_winddirection = 6
    '       End If
    '       If 下上.Checked = True Then
    '           flag_winddirection = 7
    '       End If
    '       If 左右.Checked = True Then
    '           flag_winddirection = 8
    '       End If








    '       '表示させるフォームを作成する
    '       Dim f As New Form1()
    '       'フォームを表示するディスプレイのScreenを取得する
    '       Dim s As Screen = DirectCast(Me.ComboBox1.SelectedItem, Screen)
    '       'フォームの開始位置をディスプレイの左上座標に設定する
    '       f.StartPosition = FormStartPosition.Manual
    '       f.Location = s.Bounds.Location
    '       'フォームを表示する
    '       f.Show()
    '   End Sub




    Public bunnsi As Integer
    Public bunnbo As Integer

    Public byouinn As Boolean
    Public rouzinnhome As Boolean
    Public sisetuC As Boolean
    Public sisetuD As Boolean
    Public sisetuE As Boolean
    Public sisetuF As Boolean


    Public conditions(17, 3) As String


    Public max_wind As Integer = 300

    Public WindSpeed(max_wind) As Integer
    Public WindDirection() As Integer

    Public flag_speed As Integer

    Public flag_gameover As Integer = 0

    Public time_sinario As Short

    Public flag_sinario As Short

    Public flag_winddirection As Short

    Public count_zikkenn As Short = 0
    'Public syuuryou As Boolean = False


    Public Sub finish()
        'メッセージボックスを表示する 
        Dim result As DialogResult = MessageBox.Show("実験を終了しますか？",
                                                     "確認",
                                                     MessageBoxButtons.YesNoCancel,
                                                     MessageBoxIcon.Exclamation,
                                                     MessageBoxDefaultButton.Button2)

        '何が選択されたか調べる 
        If result = DialogResult.Yes Then
            '「はい」が選択された時 
            Console.WriteLine("「はい」が選択されました")
            flag_gameover = 1
            'Form1.sdf()
            Form1.syuuryou = True
        ElseIf result = DialogResult.No Then
            '「いいえ」が選択された時 
            Console.WriteLine("「いいえ」が選択されました")
        ElseIf result = DialogResult.Cancel Then
            '「キャンセル」が選択された時 
            Console.WriteLine("「キャンセル」が選択されました")
        End If


    End Sub





    '<System.Security.Permissions.UIPermission(
    'System.Security.Permissions.SecurityAction.Demand,
    'Window:=System.Security.Permissions.UIPermissionWindow.AllWindows)>
    'Protected Overrides Function ProcessDialogKey(
    '    ByVal keyData As Keys) As Boolean
    '    If (keyData And Keys.KeyCode) = Keys.S Then
    '        loading()
    '        Return True
    '    ElseIf (keyData And Keys.KeyCode) = Keys.x Then
    '        finish()
    '        Return True
    '    ElseIf (keyData And Keys.KeyCode) = Keys.C Then
    '        close_form1()
    '    End If

    '    Return MyBase.ProcessDialogKey(keyData)
    'End Function

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    If count_zikkenn < 17 Then
    '        count_zikkenn += 1
    '        zikkennzyoukenn()
    '    End If
    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs)
    '    If count_zikkenn > 0 Then
    '        count_zikkenn -= 1
    '        zikkennzyoukenn()
    '    End If
    'End Sub

    'Private Sub close_form1()
    '    Form1.Close()
    '    If count_zikkenn < 17 Then
    '        count_zikkenn += 1
    '        zikkennzyoukenn()
    '    End If
    'End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs)
    '    close_form1()
    'End Sub



    'Private Sub Button5_Click(sender As Object, e As EventArgs)
    '    OpenFileDialog1.ShowDialog()
    '    Console.WriteLine(OpenFileDialog1.FileName)

    '    Select_participant()
    '    zikkennzyoukenn()

    'End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        OpenFileDialog2.ShowDialog()
        Console.WriteLine(OpenFileDialog2.FileName)

    End Sub


    Public input_path
    Public town
    Public name_sannkasya
    Public event_name
    Public windspeed_average
    Public winddirection_average



    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        Console.WriteLine(ComboBox2.SelectedItem)

        Dim rb1 As RadioButton
        Dim msg As String

        For Each rb1 In GroupBox1.Controls
            If rb1.Checked Then
                msg = rb1.Text
                Console.WriteLine(msg)
            End If
        Next
        name_zibun = TextBox8.Text
        zyunnbann = ComboBox2.SelectedItem
        Console.WriteLine(TextBox7.Text & "\ログ(集団)" & name_zibun & zyunnbann & ".csv")
        If msg <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" Then
            If System.IO.File.Exists(TextBox7.Text & "\ログ(集団)" & name_zibun & zyunnbann & ".csv") Then
                Label16.Text = "エラー(同じ名前のログデータが存在します)"
            Else
                loading()
            End If

        Else
            Label16.Text = "エラー(全ての入力が完了していません)"
        End If



    End Sub

    Public name_zibun As String
    Public zyunnbann As String

    Public name_pcA As String
    Public name_pcB As String
    Public name_pcC As String


    Public Sub loading()


        If 親PC.Checked = True Then

            name_pcA = name_zibun
            name_pcB = TextBox4.Text
            name_pcC = TextBox5.Text

        ElseIf 子PC1.Checked = True Then

            name_pcA = TextBox5.Text
            name_pcB = name_zibun
            name_pcC = TextBox4.Text

        ElseIf 子PC2.Checked = True Then

            name_pcA = TextBox4.Text
            name_pcB = TextBox5.Text
            name_pcC = name_zibun


        End If


        '表示させるフォームを作成する
        Dim f As New Form1()
        'フォームを表示するディスプレイのScreenを取得する
        Dim s As Screen = DirectCast(Me.ComboBox1.SelectedItem, Screen)
        'フォームの開始位置をディスプレイの左上座標に設定する
        f.StartPosition = FormStartPosition.Manual
        f.Location = s.Bounds.Location
        'フォームを表示する
        f.Show()
    End Sub


    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles 出力.Click
        FolderBrowserDialog1.ShowDialog()
        Console.WriteLine(FolderBrowserDialog1.SelectedPath)


        TextBox7.Text = FolderBrowserDialog1.SelectedPath
        output_path = FolderBrowserDialog1.SelectedPath
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles 入力.Click
        Try
            FolderBrowserDialog2.ShowDialog()
            Console.WriteLine(FolderBrowserDialog2.SelectedPath)
            TextBox6.Text = FolderBrowserDialog2.SelectedPath

            input_path = FolderBrowserDialog2.SelectedPath

            '被験者.Visible = True

            'If GroupBox4.Visible = True Then
            '    Dim workbook As IWorkbook = WorkbookFactory.Create(input_path & "\実験条件練習.xlsx")
            '    'シート１
            '    Dim worksheet As ISheet = workbook.GetSheetAt(0)
            '    Dim lastRow As Integer = worksheet.LastRowNum

            '    name_sannkasya = worksheet.GetRow(0).GetCell(1).ToString
            '    windspeed_average = worksheet.GetRow(1).GetCell(1).ToString
            '    winddirection_average = worksheet.GetRow(2).GetCell(1).ToString
            '    event_name = worksheet.GetRow(3).GetCell(1).ToString
            '    town = worksheet.GetRow(4).GetCell(1).ToString

            '    Console.WriteLine("＜入力＞")
            '    Console.WriteLine(name_sannkasya)
            '    Console.WriteLine(windspeed_average)
            '    Console.WriteLine(winddirection_average)
            '    Console.WriteLine(event_name)
            '    Console.WriteLine(town)


            '    実験条件.Text = "練習"

            '    氏名.Text = "練習"


            'Else
            Dim workbook As IWorkbook = WorkbookFactory.Create(input_path & "\実験条件1.xlsx")
            'シート１
            Dim worksheet As ISheet = workbook.GetSheetAt(0)
            Dim lastRow As Integer = worksheet.LastRowNum

            name_sannkasya = worksheet.GetRow(0).GetCell(1).ToString
            windspeed_average = worksheet.GetRow(1).GetCell(1).ToString
            winddirection_average = worksheet.GetRow(2).GetCell(1).ToString
            event_name = worksheet.GetRow(3).GetCell(1).ToString
            town = worksheet.GetRow(4).GetCell(1).ToString

            Console.WriteLine("＜入力＞")
            Console.WriteLine(name_sannkasya)
            Console.WriteLine(windspeed_average)
            Console.WriteLine(winddirection_average)
            Console.WriteLine(event_name)
            Console.WriteLine(town)

            'If event_name = "消防車の遅れ" Then
            '    実験条件.Text = "A"
            'End If
            '氏名.Text = name_sannkasya

            'End If






        Catch ex As Exception
            Console.WriteLine("エラー")
            TextBox6.Text = "エラー"
        End Try
    End Sub

    Public output_path As String

    Private Sub TextBox6_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox6.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub TextBox6_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox6.DragDrop
        TextBox6.Text = e.Data.GetData(DataFormats.FileDrop)(0)
        input_path = e.Data.GetData(DataFormats.FileDrop)(0)
        Try


            Dim workbook As IWorkbook = WorkbookFactory.Create(input_path & "\実験条件1.xlsx")
            'シート１
            Dim worksheet As ISheet = workbook.GetSheetAt(0)
            Dim lastRow As Integer = worksheet.LastRowNum

            name_sannkasya = worksheet.GetRow(0).GetCell(1).ToString
            windspeed_average = worksheet.GetRow(1).GetCell(1).ToString
            winddirection_average = worksheet.GetRow(2).GetCell(1).ToString
            event_name = worksheet.GetRow(3).GetCell(1).ToString
            town = worksheet.GetRow(4).GetCell(1).ToString


        Catch ex As Exception
            Console.WriteLine("エラー")
            TextBox6.Text = "エラー"
        End Try
    End Sub

    Private Sub TextBox7_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox7.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub TextBox7_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox7.DragDrop

        Try

            TextBox7.Text = e.Data.GetData(DataFormats.FileDrop)(0)
            output_path = e.Data.GetData(DataFormats.FileDrop)(0)


        Catch ex As Exception
            Console.WriteLine("エラー")
            TextBox6.Text = "エラー"
        End Try
    End Sub






    Private Sub Button1_Click(sender As Object, e As EventArgs)
        GroupBox3.Visible = True
        start.Visible = True
        If 親PC.Checked = True Then
            'Label8.Text = "B"
            'Label7.Text = "C"

            Label8.Text = "C"
            Label7.Text = "B"


        ElseIf 子PC1.Checked = True Then
            'Label8.Text = "C"
            'Label7.Text = "A"

            Label8.Text = "A"
            Label7.Text = "C"


        ElseIf 子PC2.Checked = True Then
            'Label8.Text = "A"
            'Label7.Text = "B"

            Label8.Text = "B"
            Label7.Text = "A"


        End If
    End Sub

    Private Sub 親PC_CheckedChanged(sender As Object, e As EventArgs) Handles 親PC.CheckedChanged
        If 親PC.Checked = True Then
            'Label8.Text = "B"
            'Label7.Text = "C"

            Label8.Text = "C"
            Label7.Text = "B"


        ElseIf 子PC1.Checked = True Then
            'Label8.Text = "C"
            'Label7.Text = "A"

            Label8.Text = "A"
            Label7.Text = "C"


        ElseIf 子PC2.Checked = True Then
            'Label8.Text = "A"
            'Label7.Text = "B"

            Label8.Text = "B"
            Label7.Text = "A"


        End If
    End Sub

    Private Sub 子PC1_CheckedChanged(sender As Object, e As EventArgs) Handles 子PC1.CheckedChanged
        If 親PC.Checked = True Then
            'Label8.Text = "B"
            'Label7.Text = "C"

            Label8.Text = "C"
            Label7.Text = "B"


        ElseIf 子PC1.Checked = True Then
            'Label8.Text = "C"
            'Label7.Text = "A"

            Label8.Text = "A"
            Label7.Text = "C"


        ElseIf 子PC2.Checked = True Then
            'Label8.Text = "A"
            'Label7.Text = "B"

            Label8.Text = "B"
            Label7.Text = "A"


        End If
    End Sub

    Private Sub 子PC2_CheckedChanged(sender As Object, e As EventArgs) Handles 子PC2.CheckedChanged
        If 親PC.Checked = True Then
            'Label8.Text = "B"
            'Label7.Text = "C"

            Label8.Text = "C"
            Label7.Text = "B"


        ElseIf 子PC1.Checked = True Then
            'Label8.Text = "C"
            'Label7.Text = "A"

            Label8.Text = "A"
            Label7.Text = "C"


        ElseIf 子PC2.Checked = True Then
            'Label8.Text = "A"
            'Label7.Text = "B"

            Label8.Text = "B"
            Label7.Text = "A"


        End If
    End Sub

    'Public practice As Boolean
    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    GroupBox4.Visible = True
    '    practice = True
    'End Sub
End Class
