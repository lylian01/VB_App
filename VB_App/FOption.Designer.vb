<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FOption
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.B_INSERT = New System.Windows.Forms.Button()
        Me.B_UPDATE = New System.Windows.Forms.Button()
        Me.B_VIEW = New System.Windows.Forms.Button()
        Me.B_DELETE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'B_INSERT
        '
        Me.B_INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_INSERT.Location = New System.Drawing.Point(15, 15)
        Me.B_INSERT.Name = "B_INSERT"
        Me.B_INSERT.Size = New System.Drawing.Size(126, 45)
        Me.B_INSERT.TabIndex = 0
        Me.B_INSERT.Text = "Insert"
        Me.B_INSERT.UseVisualStyleBackColor = True
        '
        'B_UPDATE
        '
        Me.B_UPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_UPDATE.Location = New System.Drawing.Point(147, 15)
        Me.B_UPDATE.Name = "B_UPDATE"
        Me.B_UPDATE.Size = New System.Drawing.Size(126, 45)
        Me.B_UPDATE.TabIndex = 1
        Me.B_UPDATE.Text = "Update "
        Me.B_UPDATE.UseVisualStyleBackColor = True
        '
        'B_VIEW
        '
        Me.B_VIEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_VIEW.Location = New System.Drawing.Point(411, 15)
        Me.B_VIEW.Name = "B_VIEW"
        Me.B_VIEW.Size = New System.Drawing.Size(126, 45)
        Me.B_VIEW.TabIndex = 3
        Me.B_VIEW.Text = "View"
        Me.B_VIEW.UseVisualStyleBackColor = True
        '
        'B_DELETE
        '
        Me.B_DELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_DELETE.Location = New System.Drawing.Point(279, 15)
        Me.B_DELETE.Name = "B_DELETE"
        Me.B_DELETE.Size = New System.Drawing.Size(126, 45)
        Me.B_DELETE.TabIndex = 2
        Me.B_DELETE.Text = "Delete"
        Me.B_DELETE.UseVisualStyleBackColor = True
        '
        'FOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 70)
        Me.Controls.Add(Me.B_VIEW)
        Me.Controls.Add(Me.B_DELETE)
        Me.Controls.Add(Me.B_UPDATE)
        Me.Controls.Add(Me.B_INSERT)
        Me.Name = "FOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FOption"
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents B_INSERT As Button
    Public WithEvents B_UPDATE As Button
    Public WithEvents B_VIEW As Button
    Public WithEvents B_DELETE As Button
End Class
