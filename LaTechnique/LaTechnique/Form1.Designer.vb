﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
<<<<<<< HEAD
        Me.lblFrank = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFrank
        '
        Me.lblFrank.AutoSize = True
        Me.lblFrank.Location = New System.Drawing.Point(193, 48)
        Me.lblFrank.Name = "lblFrank"
        Me.lblFrank.Size = New System.Drawing.Size(34, 13)
        Me.lblFrank.TabIndex = 0
        Me.lblFrank.Text = "Frank"
=======
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
>>>>>>> f22da78fbac3d03d372ac6174790003800c2a8a3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(714, 437)
        Me.Controls.Add(Me.lblFrank)
=======
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button1)
>>>>>>> f22da78fbac3d03d372ac6174790003800c2a8a3
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

<<<<<<< HEAD
    Private WithEvents lblFrank As Label
=======
    Friend WithEvents Button1 As Button
>>>>>>> f22da78fbac3d03d372ac6174790003800c2a8a3
End Class
