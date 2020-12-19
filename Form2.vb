Public Class 成績


    'フォームのLoadイベントハンドラ
    Private Sub Form3_Load(sender As Object, e As EventArgs) _
            Handles MyBase.Load

        'Label1.Text = "守った部分" + スタート.bunnsi.ToString + vbCrLf + "守れなかった部分" + (スタート.bunnbo - スタート.bunnsi).ToString + vbCrLf + vbCrLf + "点数" + ((スタート.bunnsi / スタート.bunnbo) * 100).ToString
        Label1.Text = "あなたの得点：" + ((1 - (スタート.bunnsi / スタート.bunnbo)) * 100).ToString("0.0") + " / 100" + vbCrLf + vbCrLf

        Label1.Text += vbCrLf + vbCrLf + "施設A:   "
        If スタート.rouzinnhome = False Then
            Label1.Text += "守れた"
        Else
            Label1.Text += "守れなかった"
        End If


        Label1.Text += vbCrLf + vbCrLf + "施設B:   "
        If スタート.byouinn = False Then
            Label1.Text += "守れた"
        Else
            Label1.Text += "守れなかった"
        End If


        Label1.Text += vbCrLf + vbCrLf + "施設C:   "
        If スタート.sisetuC = False Then
            Label1.Text += "守れた"
        Else
            Label1.Text += "守れなかった"
        End If

        Label1.Text += vbCrLf + vbCrLf + "施設D:   "
        If スタート.sisetuD = False Then
            Label1.Text += "守れた"
        Else
            Label1.Text += "守れなかった"
        End If

        Label1.Text += vbCrLf + vbCrLf + "施設E:   "
        If スタート.sisetuE = False Then
            Label1.Text += "守れた"
        Else
            Label1.Text += "守れなかった"
        End If

        Label1.Text += vbCrLf + vbCrLf + "施設F:   "
        If スタート.sisetuF = False Then
            Label1.Text += "守れた"
        Else
            Label1.Text += "守れなかった"
        End If










    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'メッセージボックスを表示する 
        Dim result As DialogResult = MessageBox.Show("本当に終了しますか？",
                                                     "確認",
                                                     MessageBoxButtons.YesNoCancel,
                                                     MessageBoxIcon.Exclamation,
                                                     MessageBoxDefaultButton.Button2)

        '何が選択されたか調べる 
        If result = DialogResult.Yes Then
            '「はい」が選択された時 
            Console.WriteLine("「はい」が選択されました")
            Me.Close()

            Form1.Close()
            スタート.Close()
        ElseIf result = DialogResult.No Then
            '「いいえ」が選択された時 
            Console.WriteLine("「いいえ」が選択されました")
        ElseIf result = DialogResult.Cancel Then
            '「キャンセル」が選択された時 
            Console.WriteLine("「キャンセル」が選択されました")
        End If

    End Sub
End Class