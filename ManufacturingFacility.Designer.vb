﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManufacturingFacility
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.cmbFacilityorArray = New System.Windows.Forms.ComboBox()
        Me.cmbFacilitySystem = New System.Windows.Forms.ComboBox()
        Me.cmbFacilityRegion = New System.Windows.Forms.ComboBox()
        Me.btnFacilitySave = New System.Windows.Forms.Button()
        Me.mainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'cmbFacilityorArray
        '
        Me.cmbFacilityorArray.FormattingEnabled = True
        Me.cmbFacilityorArray.ItemHeight = 16
        Me.cmbFacilityorArray.Location = New System.Drawing.Point(11, 261)
        Me.cmbFacilityorArray.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbFacilityorArray.Name = "cmbFacilityorArray"
        Me.cmbFacilityorArray.Size = New System.Drawing.Size(387, 24)
        Me.cmbFacilityorArray.TabIndex = 14
        Me.cmbFacilityorArray.Text = "Select Facility / Array"
        '
        'cmbFacilitySystem
        '
        Me.cmbFacilitySystem.FormattingEnabled = True
        Me.cmbFacilitySystem.Location = New System.Drawing.Point(185, 46)
        Me.cmbFacilitySystem.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbFacilitySystem.Name = "cmbFacilitySystem"
        Me.cmbFacilitySystem.Size = New System.Drawing.Size(208, 24)
        Me.cmbFacilitySystem.TabIndex = 13
        Me.cmbFacilitySystem.Text = "Select System"
        '
        'cmbFacilityRegion
        '
        Me.cmbFacilityRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbFacilityRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbFacilityRegion.FormattingEnabled = True
        Me.cmbFacilityRegion.Location = New System.Drawing.Point(7, 46)
        Me.cmbFacilityRegion.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbFacilityRegion.Name = "cmbFacilityRegion"
        Me.cmbFacilityRegion.Size = New System.Drawing.Size(172, 24)
        Me.cmbFacilityRegion.TabIndex = 12
        Me.cmbFacilityRegion.Text = "Select Region"
        '
        'btnFacilitySave
        '
        Me.btnFacilitySave.Location = New System.Drawing.Point(340, 105)
        Me.btnFacilitySave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFacilitySave.Name = "btnFacilitySave"
        Me.btnFacilitySave.Size = New System.Drawing.Size(53, 27)
        Me.btnFacilitySave.TabIndex = 24
        Me.btnFacilitySave.Text = "Save"
        Me.btnFacilitySave.UseVisualStyleBackColor = True
        '
        'ManufacturingFacility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnFacilitySave)
        Me.Controls.Add(Me.cmbFacilityorArray)
        Me.Controls.Add(Me.cmbFacilitySystem)
        Me.Controls.Add(Me.cmbFacilityRegion)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ManufacturingFacility"
        Me.Size = New System.Drawing.Size(549, 422)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbFacilityorArray As ComboBox
    Friend WithEvents cmbFacilitySystem As ComboBox
    Friend WithEvents cmbFacilityRegion As ComboBox
    Friend WithEvents btnFacilitySave As Button
    Friend WithEvents mainToolTip As ToolTip
End Class
