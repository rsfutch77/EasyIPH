﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHelp
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.LabelVersion = New MetroFramework.Controls.MetroLabel()
        Me.ReportBugIcon = New System.Windows.Forms.PictureBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.VisitWebIcon = New System.Windows.Forms.PictureBox()
        Me.PateronIcon = New System.Windows.Forms.PictureBox()
        Me.btnDonate = New MetroFramework.Controls.MetroButton()
        Me.btnVisitweb = New MetroFramework.Controls.MetroButton()
        Me.btnReportbug = New MetroFramework.Controls.MetroButton()
        Me.btnManageChar = New MetroFramework.Controls.MetroButton()
        Me.btnResetAll = New MetroFramework.Controls.MetroButton()
        CType(Me.ReportBugIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitWebIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PateronIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelVersion
        '
        Me.LabelVersion.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.LabelVersion.Location = New System.Drawing.Point(30, 71)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(181, 35)
        Me.LabelVersion.TabIndex = 108
        Me.LabelVersion.Text = "Version X.X.XXXXXX"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelVersion.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.LabelVersion.WrapToLine = True
        '
        'ReportBugIcon
        '
        Me.ReportBugIcon.ErrorImage = Nothing
        Me.ReportBugIcon.Image = CType(resources.GetObject("ReportBugIcon.Image"), System.Drawing.Image)
        Me.ReportBugIcon.Location = New System.Drawing.Point(33, 436)
        Me.ReportBugIcon.Name = "ReportBugIcon"
        Me.ReportBugIcon.Size = New System.Drawing.Size(57, 65)
        Me.ReportBugIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ReportBugIcon.TabIndex = 111
        Me.ReportBugIcon.TabStop = False
        '
        'MetroLabel2
        '
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(30, 106)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(509, 174)
        Me.MetroLabel2.TabIndex = 107
        Me.MetroLabel2.Text = resources.GetString("MetroLabel2.Text")
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.WrapToLine = True
        '
        'VisitWebIcon
        '
        Me.VisitWebIcon.ErrorImage = Nothing
        Me.VisitWebIcon.Image = CType(resources.GetObject("VisitWebIcon.Image"), System.Drawing.Image)
        Me.VisitWebIcon.Location = New System.Drawing.Point(33, 362)
        Me.VisitWebIcon.Name = "VisitWebIcon"
        Me.VisitWebIcon.Size = New System.Drawing.Size(57, 65)
        Me.VisitWebIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VisitWebIcon.TabIndex = 110
        Me.VisitWebIcon.TabStop = False
        '
        'PateronIcon
        '
        Me.PateronIcon.ErrorImage = Nothing
        Me.PateronIcon.Image = CType(resources.GetObject("PateronIcon.Image"), System.Drawing.Image)
        Me.PateronIcon.Location = New System.Drawing.Point(33, 289)
        Me.PateronIcon.Name = "PateronIcon"
        Me.PateronIcon.Size = New System.Drawing.Size(57, 65)
        Me.PateronIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PateronIcon.TabIndex = 109
        Me.PateronIcon.TabStop = False
        '
        'btnDonate
        '
        Me.btnDonate.Location = New System.Drawing.Point(110, 289)
        Me.btnDonate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(266, 52)
        Me.btnDonate.TabIndex = 112
        Me.btnDonate.Text = "Donate to the original creator of EVEIPH"
        Me.btnDonate.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnDonate.UseSelectable = True
        '
        'btnVisitweb
        '
        Me.btnVisitweb.Location = New System.Drawing.Point(110, 362)
        Me.btnVisitweb.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVisitweb.Name = "btnVisitweb"
        Me.btnVisitweb.Size = New System.Drawing.Size(266, 52)
        Me.btnVisitweb.TabIndex = 113
        Me.btnVisitweb.Text = "Visit EasyIPH.com for Tips and Tricks"
        Me.btnVisitweb.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnVisitweb.UseSelectable = True
        '
        'btnReportbug
        '
        Me.btnReportbug.Location = New System.Drawing.Point(110, 449)
        Me.btnReportbug.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReportbug.Name = "btnReportbug"
        Me.btnReportbug.Size = New System.Drawing.Size(266, 52)
        Me.btnReportbug.TabIndex = 114
        Me.btnReportbug.Text = "Report a Bug or Suggest a Feature"
        Me.btnReportbug.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnReportbug.UseSelectable = True
        '
        'btnManageChar
        '
        Me.btnManageChar.Location = New System.Drawing.Point(69, 543)
        Me.btnManageChar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnManageChar.Name = "btnManageChar"
        Me.btnManageChar.Size = New System.Drawing.Size(120, 36)
        Me.btnManageChar.TabIndex = 115
        Me.btnManageChar.Text = "Manage Characters"
        Me.btnManageChar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnManageChar.UseSelectable = True
        '
        'btnResetAll
        '
        Me.btnResetAll.BackColor = System.Drawing.Color.Red
        Me.btnResetAll.ForeColor = System.Drawing.Color.DarkRed
        Me.btnResetAll.Location = New System.Drawing.Point(344, 543)
        Me.btnResetAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResetAll.Name = "btnResetAll"
        Me.btnResetAll.Size = New System.Drawing.Size(120, 36)
        Me.btnResetAll.TabIndex = 116
        Me.btnResetAll.Text = "Reset All Data"
        Me.btnResetAll.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnResetAll.UseSelectable = True
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 633)
        Me.Controls.Add(Me.btnResetAll)
        Me.Controls.Add(Me.btnManageChar)
        Me.Controls.Add(Me.btnReportbug)
        Me.Controls.Add(Me.btnVisitweb)
        Me.Controls.Add(Me.btnDonate)
        Me.Controls.Add(Me.LabelVersion)
        Me.Controls.Add(Me.ReportBugIcon)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.VisitWebIcon)
        Me.Controls.Add(Me.PateronIcon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHelp"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Help"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.ReportBugIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitWebIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PateronIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelVersion As MetroFramework.Controls.MetroLabel
    Friend WithEvents ReportBugIcon As PictureBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents VisitWebIcon As PictureBox
    Friend WithEvents PateronIcon As PictureBox
    Friend WithEvents btnDonate As MetroFramework.Controls.MetroButton
    Friend WithEvents btnVisitweb As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReportbug As MetroFramework.Controls.MetroButton
    Friend WithEvents btnManageChar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnResetAll As MetroFramework.Controls.MetroButton
End Class