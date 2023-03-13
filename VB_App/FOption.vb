Public Class FOption

    Public intOP As Integer = 0
    Public nameOP As String = " "

    'Set Name Option
    Function setName()
        Select Case intOP
            Case 1
                nameOP = "Insert"
            Case 2
                nameOP = "Update"
            Case 3
                nameOP = "Delete"
            Case 4
                nameOP = "View"
        End Select
        Return nameOP
    End Function
    '*******************************************************************************************
    'Enable FromMain and set Lable Mode 
    Public Function EnableAndSet()
        FMain.Enabled = True
        FMain.B_Mode.Text = nameOP
        FMain.iOP = intOP

    End Function
    '*******************************************************************************************
    'Insert click
    Private Function B_INSERT_Click(sender As Object, e As EventArgs) Handles B_INSERT.Click
        intOP = 1

        Call setName()
        Me.Close()
        EnableAndSet()

        Return intOP
    End Function
    '*******************************************************************************************
    'Update click
    Private Function B_UPDATE_Click(sender As Object, e As EventArgs) Handles B_UPDATE.Click
        intOP = 2

        Call setName()
        Me.Close()
        EnableAndSet()

        Return intOP
    End Function
    '*******************************************************************************************
    'Delete click
    Private Function B_DELETE_Click(sender As Object, e As EventArgs) Handles B_DELETE.Click
        intOP = 3

        Call setName()
        Me.Close()
        EnableAndSet()

        Return intOP
    End Function
    '*******************************************************************************************
    'View click
    Private Function B_VIEW_Click(sender As Object, e As EventArgs) Handles B_VIEW.Click
        intOP = 4

        Call setName()
        Me.Close()
        EnableAndSet()

        Return intOP
    End Function

End Class