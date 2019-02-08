Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class TCPControl
    Public Event MessageReceived(sender As TCPControl, Data As String)

    'Server Configuration
    Public ServerIP As IPAddress = IPAddress.Parse("10.0.0.137")
    Public ServerPort As Integer = 64555
    Public Server As TcpListener

    Private CommThread As Thread
    Private IsListening As Boolean = True

    'Clients
    Private Client As TcpClient
    Private ClientData As StreamReader

    Public Sub New()
        Server = New TcpListener(ServerIP, ServerPort)
        Server.Start()

        CommThread = New Thread(New ThreadStart(AddressOf Listening))
        CommThread.Start()

    End Sub

    Private Sub Listening()
        'Create listener loop
        Do Until IsListening = False
            'Accept incoming connections
            If Server.Pending = True Then
                Client = Server.AcceptTcpClient
                ClientData = New StreamReader(Client.GetStream)
            End If

            'Raise event for incoming messages
            Try
                RaiseEvent MessageReceived(Me, ClientData.ReadLine)
            Catch ex As Exception

            End Try


            'Sleeping the thread reducing cpu usage
            Thread.Sleep(100)
        Loop
    End Sub
End Class