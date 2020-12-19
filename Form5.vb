Public Class Form5

    Private _Form1 As Form1
    Public Sub New(ByVal form As Form1)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        _Form1 = form
        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If スタート.practice = False Then
        Send()
        'End If
        'データを送信する
        _Form1.Opacity = 1
        _Form1.実験開始.PerformClick()

        Me.Close()
    End Sub
    Private Sub SendCallback(ar As IAsyncResult)
        Dim udp As System.Net.Sockets.UdpClient =
        DirectCast(ar.AsyncState, System.Net.Sockets.UdpClient)

        '非同期送信を終了する
        Try
            udp.EndSend(ar)
        Catch ex As System.Net.Sockets.SocketException
            Console.WriteLine("送信エラー({0}/{1})", ex.Message, ex.ErrorCode)
        Catch ex As ObjectDisposedException
            'すでに閉じている時は終了
            Console.WriteLine("Socketは閉じられています。")
        End Try
    End Sub
    Private udpClient As System.Net.Sockets.UdpClient = Nothing
    Private Sub Send()
        'データを送信する
        '送信するデータを作成する
        Dim sendBytes As Byte()
        sendBytes = System.Text.Encoding.UTF8.GetBytes("スタート")


        'UdpClientを作成する
        If udpClient Is Nothing Then
            udpClient = New System.Net.Sockets.UdpClient()
        End If

        '非同期的にデータを送信する
        udpClient.BeginSend(sendBytes, sendBytes.Length, IP_child1,
        Integer.Parse(2002), AddressOf SendCallback, udpClient)

        udpClient.BeginSend(sendBytes, sendBytes.Length, IP_child2,
        Integer.Parse(2002), AddressOf SendCallback, udpClient)


        Console.WriteLine("<スタート>送信しました")
    End Sub
    Dim IP_child1
    Dim IP_child2
    Dim IP_parent



    Private Delegate Sub SetLabelTextDelegate()
    Private Sub SetLabelText()

        'データを送信する
        _Form1.Opacity = 1
        _Form1.実験開始.PerformClick()
        Me.Close()
    End Sub

    Private Sub Form5＿Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IP_child1 = スタート.TextBox2.Text
        IP_child2 = スタート.TextBox3.Text
        IP_parent = スタート.TextBox1.Text
        Console.WriteLine(IP_child1)


        If スタート.親PC.Checked = True Then
            Button1.Visible = True
            Label1.Visible = False
        Else
            Button1.Visible = False
            Label1.Visible = True

            '受信
            Recieve_start()
        End If




    End Sub

    Private Sub Recieve_start()

        If udpClient IsNot Nothing Then
            Return
        End If
        'DirectCast(sender).Enabled = False

        'UdpClientを作成し、指定したポート番号にバインドする
        Dim localEP As New System.Net.IPEndPoint(
                System.Net.IPAddress.Any, Integer.Parse(2002))
        udpClient = New System.Net.Sockets.UdpClient(localEP)
        '非同期的なデータ受信を開始する
        udpClient.BeginReceive(AddressOf ReceiveCallback, udpClient)

    End Sub



    'データを受信した時
    Public Sub ReceiveCallback(ar As IAsyncResult)
        Dim udp As System.Net.Sockets.UdpClient =
            DirectCast(ar.AsyncState, System.Net.Sockets.UdpClient)

        '非同期受信を終了する
        Dim remoteEP As System.Net.IPEndPoint = Nothing
        Dim rcvBytes As Byte()
        Try
            rcvBytes = udp.EndReceive(ar, remoteEP)

        Catch ex As System.Net.Sockets.SocketException
            Console.WriteLine("受信エラー({0}/{1})", ex.Message, ex.ErrorCode)
            Return
        Catch ex As ObjectDisposedException
            'すでに閉じている時は終了
            Console.WriteLine("Socketは閉じられています。")
            Return
        End Try

        'データを文字列に変換する
        Dim rcvMsg As String = System.Text.Encoding.UTF8.GetString(rcvBytes)

        '受信したデータと送信者の情報をRichTextBoxに表示する
        Dim displayMsg As String = String.Format("[{0} ({1})] > {2}",
            remoteEP.Address, remoteEP.Port, rcvMsg)
        'RichTextBox1.BeginInvoke(
        '	New Action(Of String)(AddressOf ShowReceivedString), displayMsg)
        'ShowReceivedString(rcvMsg)
        Console.WriteLine(rcvMsg)

        Invoke(New SetLabelTextDelegate(AddressOf SetLabelText))


        '再びデータ受信を開始する
        'udp.BeginReceive(AddressOf ReceiveCallback, udp)
    End Sub

End Class