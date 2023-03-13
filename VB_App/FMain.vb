Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Security.AccessControl
Imports System.Security.Cryptography.X509Certificates

Public Class FMain
    Dim connetionString As String
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim adapter As New SqlDataAdapter
    Dim ds As New DataSet
    Dim tables As DataTable
    Dim i As Integer
    Dim sql As String

    Public iOP As Integer


    '*******************************************************************************************
    Private Sub FMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Enabled = False
        FOption.Show()

        Dim checkKeyOK As Boolean = False
        SetKeyEnable()

    End Sub
    '*******************************************************************************************
    'Enable KEY 
    Private Sub SetKeyEnable()
        Me.G_Key.Enabled = True
        Me.G_Body.Enabled = False
    End Sub
    '*******************************************************************************************
    'Enable BODY    
    Private Sub SetBodyEnable()
        Me.G_Key.Enabled = False
        Me.G_Body.Enabled = True
    End Sub
    '*******************************************************************************************
    'Button MODE click
    Private Sub B_Mode_Click(sender As Object, e As EventArgs) Handles B_Mode.Click
        Me.Enabled = False
        FOption.Show()
    End Sub
    '*******************************************************************************************
    'Button END click
    Private Sub B_End_Click(sender As Object, e As EventArgs) Handles B_End.Click
        Me.Close()
    End Sub
    '*******************************************************************************************
    'Button SEARCH click
    Private Sub B_Search_Click(sender As Object, e As EventArgs) Handles B_Search.Click

        'check values 
        If checkKeyValues() = True Then
            MessageBox.Show(iOP)

            If iOP <> 1 Then
                If checkAvaible() Then
                    SetBodyEnable()
                End If
            Else
                If checkAvaible() = False Then
                    SetBodyEnable()
                End If
            End If

        End If



    End Sub

    Private Function checkAvaible() As Boolean
        'create connect
        connetionString = "Data Source=LYLIAN;Initial Catalog=VB_App;Integrated Security=True"
        'create command
        sql = "SELECT * FROM ITEM WHERE KEY_ITEM = '" + KEY_ITEM.Text + " ' "
        connection = New SqlConnection(connetionString)
        'open connect
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds, "Dữ liệu đã tồn tại ")
            Return True
            adapter.Dispose()
            command.Dispose()
            connection.Close()


            For Each tables In ds.Tables
                MsgBox(tables.TableName)
            Next

        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try
    End Function

    Private Function checkKeyValues() As Boolean
        If KEY_ITEM.Text = " " Then
            MessageBox.Show("Không được để trống Key Item !!! ")
            Return False
        End If
        Return True
    End Function

    Private Sub B_OK_Click(sender As Object, e As EventArgs) Handles B_OK.Click
        'create connect
        connetionString = "Data Source=LYLIAN;Initial Catalog=VB_App;Integrated Security=True"
        'create command
        'cmd.CommandText = "INSERT INTO table([field1], [field2]) VALUES([Value1], [Value2])"
        sql = "INSERT INTO [dbo].[ITEM] VALUES('" + KEY_ITEM.Text + "','" + ITEM_1.Text + "','" + ITEM_2.Text + "','" + ITEM_3.Text + "','" + ITEM_4.Text + "','" + ITEM_N.Text + "')"
        connection = New SqlConnection(connetionString)
        'open connect
        Try
            connection.Open()
            command = New SqlCommand(sql, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds, "Đã thêm thành công")
            adapter.Dispose()
            command.Dispose()
            connection.Close()


            For Each tables In ds.Tables
                MsgBox(tables.TableName)
            Next

        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        End Try
    End Sub
    '*******************************************************************************************
    '

End Class
