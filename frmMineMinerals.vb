﻿Public Class frmMineMinerals

    Public MaterialList As Materials

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Public Sub New()

        Me.AutoScaleMode = AutoScaleSetting

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class