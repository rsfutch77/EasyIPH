﻿
Public Class frmSettings

    Private SSLoaded As Boolean
    Private RegionLoaded As Boolean
    Private FirstLoad As Boolean
    Private SelectedReset As Boolean
    Private SVRComboLoaded As Boolean

    Private ReloadSkills As Boolean

    Private Defaults As New ProgramSettings ' For default constants

#Region "Click object Functions"

    Private Sub chkBeanCounterManufacturing_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBeanCounterManufacturing.CheckedChanged
        If Not FirstLoad Then
            If chkBeanCounterManufacturing.Checked Then
                cmbBeanCounterManufacturing.Enabled = True
                cmbBeanCounterManufacturing.Text = "Zainou 'Beancounter' Industry BX-802"
            Else
                cmbBeanCounterManufacturing.Enabled = False
                cmbBeanCounterManufacturing.Text = ""
            End If
        End If
        btnSave.Text = "Save"
    End Sub

    Private Sub chkBeanCounterRefining_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBeanCounterRefining.CheckedChanged
        If Not FirstLoad Then
            If chkBeanCounterRefining.Checked Then
                cmbBeanCounterRefining.Enabled = True
                cmbBeanCounterRefining.Text = "Zainou 'Beancounter' Reprocessing RX-802"
            Else
                cmbBeanCounterRefining.Enabled = False
                cmbBeanCounterRefining.Text = ""
            End If
        End If
        btnSave.Text = "Save"
    End Sub

    Private Sub chkBeanCounterCopy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBeanCounterCopy.CheckedChanged
        If Not FirstLoad Then
            If chkBeanCounterCopy.Checked Then
                cmbBeanCounterCopy.Enabled = True
                cmbBeanCounterCopy.Text = "Zainou 'Beancounter' Science SC-803"
            Else
                cmbBeanCounterCopy.Enabled = False
                cmbBeanCounterCopy.Text = ""
            End If
        End If
        btnSave.Text = "Save"
    End Sub

    Private Sub chkBrokerCorpStanding_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBrokerCorpStanding.CheckedChanged
        If chkBrokerCorpStanding.Checked = True Then
            txtBrokerCorpStanding.Enabled = True
            txtBrokerCorpStanding.Focus()
        Else
            txtBrokerCorpStanding.Enabled = False
            txtBrokerCorpStanding.Text = FormatNumber(Defaults.DefaultBrokerCorpStanding, 2)
        End If
        btnSave.Text = "Save"
    End Sub

    Private Sub chkBrokerFactionStanding_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBrokerFactionStanding.CheckedChanged
        If chkBrokerFactionStanding.Checked = True Then
            txtBrokerFactionStanding.Enabled = True
            txtBrokerFactionStanding.Focus()
        Else
            txtBrokerFactionStanding.Enabled = False
            txtBrokerFactionStanding.Text = FormatNumber(Defaults.DefaultBrokerFactionStanding, 2)
        End If
        btnSave.Text = "Save"
    End Sub

    Private Sub txtEVEMarketerInterval_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEVEMarketerInterval.KeyPress
        ' Only allow numbers or backspace
        If e.KeyChar <> ControlChars.Back Then
            ' Only integer values
            If allowedRunschars.IndexOf(e.KeyChar) = -1 Then
                ' Invalid Character
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtBrokerFactionStandings_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBrokerFactionStanding.KeyPress
        ' Only allow numbers or backspace
        If e.KeyChar <> ControlChars.Back Then
            If allowedDecimalChars.IndexOf(e.KeyChar) = -1 Then
                ' Invalid Character
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtBrokerCorpStandings_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBrokerCorpStanding.KeyPress
        ' Only allow numbers or backspace
        If e.KeyChar <> ControlChars.Back Then
            If allowedDecimalChars.IndexOf(e.KeyChar) = -1 Then
                ' Invalid Character
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtRefineCorpStanding_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        ' Only allow numbers or backspace
        If e.KeyChar <> ControlChars.Back Then
            If allowedDecimalChars.IndexOf(e.KeyChar) = -1 Then
                ' Invalid Character
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub chkShowToolTips_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowToolTips.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub chkCheckUpdatesStartup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheckUpdatesStartup.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub chkBuildBuyDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBuildBuyDefault.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub chkDefaultME_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDefaultME.CheckedChanged
        If chkDefaultME.Checked = True Then
            txtDefaultME.Enabled = True
            txtDefaultME.Focus()
        Else
            txtDefaultME.Enabled = False
            txtDefaultME.Text = FormatNumber(Defaults.DefaultSettingME, 0)
        End If
        btnSave.Text = "Save"
    End Sub

    Private Sub chkEVEMarketerInterval_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkEVEMarketerInterval.CheckedChanged
        If chkEVEMarketerInterval.Checked = True Then
            txtEVEMarketerInterval.Enabled = True
            txtEVEMarketerInterval.Focus()
        Else
            txtEVEMarketerInterval.Enabled = False
            txtEVEMarketerInterval.Text = FormatNumber(Defaults.DefaultEVEMarketerRefreshInterval, 0)
        End If
        btnSave.Text = "Save"
    End Sub

    Private Sub chkDefaultPE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDefaultTE.CheckedChanged
        If chkDefaultTE.Checked = True Then
            txtDefaultTE.Enabled = True
            txtDefaultTE.Focus()
        Else
            txtDefaultTE.Enabled = False
            txtDefaultTE.Text = FormatNumber(Defaults.DefaultSettingTE, 0)
        End If
        btnSave.Text = "Save"
    End Sub

    Private Sub chkDisableSVR_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkDisableSVR.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub chkDisableSound_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisableSound.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub chkSaveFacilitiesbyChar_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveFacilitiesbyChar.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub chkLoadBPsbyChar_CheckedChanged(sender As Object, e As EventArgs) Handles chkLoadBPsbyChar.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub cmbRefineTax_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        ' Only allow numbers, period or percent and backspace
        If e.KeyChar <> ControlChars.Back Then
            If allowedPercentChars.IndexOf(e.KeyChar) = -1 Then
                ' Invalid Character
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub chkRefreshMarketDataonStartup_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkRefreshMarketDataonStartup.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub chkRefreshFacilityDataonStartup_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkRefreshSystemCostIndiciesDataonStartup.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub rbtnExportDefault_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtnExportDefault.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub rbtnExportCSV_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtnExportCSV.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub rbtnExportSSV_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rbtnExportSSV.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub chkSaveBPRelicsDecryptors_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkSaveBPRelicsDecryptors.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub rbtnBuildT2T3AdvancedMats_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBuildT2T3AdvancedMats.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub rbtnBuildT2ProcessedMats_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBuildT2ProcessedMats.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub rbtnBuildT2T3RawMats_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBuildT2T3RawMats.CheckedChanged
        btnSave.Text = "Save"
    End Sub

    Private Sub cmbSVRAvgPriceDuration_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbSVRAvgPriceDuration.KeyPress
        ' Only allow numbers or backspace
        If e.KeyChar <> ControlChars.Back Then
            If allowedRunschars.IndexOf(e.KeyChar) = -1 Then
                ' Invalid Character
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtSVRThreshold_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSVRThreshold.KeyPress
        ' Only allow numbers or backspace
        If e.KeyChar <> ControlChars.Back Then
            If allowedDecimalChars.IndexOf(e.KeyChar) = -1 Then
                ' Invalid Character
                e.Handled = True
            Else
                btnSave.Text = "Save"
            End If
        End If
    End Sub

    Private Sub cmbSVRRegion_DropDown(sender As System.Object, e As System.EventArgs) Handles cmbSVRRegion.DropDown
        If Not SVRComboLoaded Then
            Call LoadRegionCombo(cmbSVRRegion, UserApplicationSettings.SVRAveragePriceRegion)
            SVRComboLoaded = True
        End If
    End Sub

    Private Sub cmbSVRRegion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cmbSVRRegion.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtDefaultME_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDefaultME.KeyPress
        ' Only allow numbers or backspace
        If e.KeyChar <> ControlChars.Back Then
            If allowedRunschars.IndexOf(e.KeyChar) = -1 Then
                ' Invalid Character
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDefaultTE_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDefaultTE.KeyPress
        ' Only allow numbers or backspace
        If e.KeyChar <> ControlChars.Back Then
            If allowedRunschars.IndexOf(e.KeyChar) = -1 Then
                ' Invalid Character
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtProxyPort_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtProxyPort.KeyPress
        ' Only allow numbers or backspace
        If e.KeyChar <> ControlChars.Back Then
            If allowedRunschars.IndexOf(e.KeyChar) = -1 Then
                ' Invalid Character
                e.Handled = True
            Else
                btnSave.Text = "Save"
            End If
        End If
    End Sub

    Private Sub txtProxyAddress_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtProxyAddress.TextChanged
        btnSave.Text = "Save"
    End Sub

#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SSLoaded = False
        RegionLoaded = False
        btnSave.Text = "Save"
        FirstLoad = True
        SelectedReset = False
        SVRComboLoaded = False
        ReloadSkills = False

        If UserApplicationSettings.ShowToolTips Then
            With ToolTip1
                ' General
                .SetToolTip(chkShowToolTips, "Toogles tool tips through out IPH")
                .SetToolTip(chkLinksInCopyText, "Copying data to the clipboard will contain formatted text that enables in-game links to show when pasted in game")
                .SetToolTip(chkDisableSVR, "If you have issues with SVR updates on the Manufacturing Tab (ie website down, etc), you can disable those queries here")
                .SetToolTip(rbtnExportCSV, "Exports data in Common Separated Values with periods for decimals")
                .SetToolTip(chkDisableSound, "Disables sound functions in IPH")
                .SetToolTip(chkSaveFacilitiesbyChar, "When checked, saved facilities will only apply to the selected character. If unchecked, all characters will share saved facilities")
                .SetToolTip(chkLoadBPsbyChar, "When checked, blueprints loaded into IPH will be different for each character. If unchecked, all characters share the same BPs")
                .SetToolTip(chkDisableTracking, "When checked, IPH will not send anonymous useage data to Google Analytics")

                ' Startup Options
                .SetToolTip(chkCheckUpdatesStartup, "IPH will check for program updates when the program starts")
                .SetToolTip(chkRefreshAssetsonStartup, "When checked, IPH will refresh assets (if cache date has past) for the selected character")
                .SetToolTip(chkRefreshBPsonStartup, "When checked, IPH will refresh blueprints (if cache date has past) for the selected character")
                .SetToolTip(chkRefreshMarketDataonStartup, "When checked, IPH will refresh average and adjusted market prices (if cache date has past) on startup for use in industry calcuations")
                .SetToolTip(chkRefreshSystemCostIndiciesDataonStartup, "When checked, IPH will refresh the system industry indicies on startup (if cache date has past) for use in industry calculations")
                .SetToolTip(chkRefreshPublicStructureDataonStartup, "When checked, IPH will refresh data on public structures (if cache date has past) for use in price updates")

                ' SVR Settings
                .SetToolTip(lblSVRThreshold, "When set, this will be the default threshold for Sales to Volume Ratio on the BP and Manufacturing tabs")
                .SetToolTip(lblSVRAvgPrice, "When set, this will be the default days the Sales to Volume Ratio will be averaged over for the BP and Manufacturing tabs")
                .SetToolTip(lblSVRRegion, "When set, this will be the default region for Sales to Volume Ratio calcuations on the BP and Manufacturing tabs")
                .SetToolTip(chkAutoUpdateSVRBPTab, "When set, the Sales to Volume Ratio will be updated on the BP tab when a Blueprint is selected")

                ' Export Data
                .SetToolTip(rbtnExportSSV, "Exports data in SemiColon Separated Values with commas for decimals")
                .SetToolTip(rbtnExportDefault, "Exports data in basic space or dashes to separate data for easy readability")
                .SetToolTip(rbtnExportCSV, "Exports data in Comma Separated Values")

                ' Character Options
                .SetToolTip(chkAlphaAccount, "When checked, IPH will calculate costs adding the 2% industry tax on industry and science jobs")
                .SetToolTip(chkUseActiveSkills, "When checked, IPH will use active skills instead of trained skills for calculations (useful for unsubscribed Omega accounts in Alpha)")

                ' Build Settings
                .SetToolTip(chkBuildBuyDefault, "When checked, BP builds will use Build/Buy calcuations for final costs")
                .SetToolTip(chkSuggestBuildwhenBPnotOwned, "If you do not own a component BP and this is checked, then IPH will suggest you build the item anyway if the price is cheaper than buying it")
                .SetToolTip(chkSaveBPRelicsDecryptors, "When selected, Saving Settings on the BP tab will also save the Decryptor and Relic Types if selected and autoload them for each relevant BP")
                .SetToolTip(rbtnBuildT2T3AdvancedMats, "When selected, blueprints will be built using Advanced Moon materials (e.g. Fullerides)")
                .SetToolTip(rbtnBuildT2ProcessedMats, "When selected, blueprints will be built using Processed Moon materials, which are used in reactions to make Advanced Moon Materials")
                .SetToolTip(rbtnBuildT2T3RawMats, "When selected, blueprints will be built using Raw Moon materials, which are used in reactions to make Processed Moon Materials")

                ' Tips by Group box
                .SetToolTip(gbImplants, "Select implants to use with selected characters for industry calculations")
                .SetToolTip(gbDefaultMEPE, "On the BP and Manufacturing tabs, these default ME and TE values will be used for non-owned blueprints")
                .SetToolTip(gbShoppingList, "If checked, then IPH will send invention or copy materials needed to the shopping list when saving the build information for a blueprint")
                .SetToolTip(gbEVEMarketer, "The value stored here is the cache date (how often IPH will update) for EVE Marketer prices")
                .SetToolTip(gbStationStandings, "Station standings affect broker fees and some other industry related fees based on standing. These values here will be used in those calculations.")
                .SetToolTip(gbProxySettings, "When proxy information is in both the port and address, IPH will use this to connect to CCP servers. Note this information will also be used with the EVE IPH updater")

            End With
        End If

    End Sub

    Private Sub frmSettings_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ' Load the settings for the program from DB
        Call LoadFormSettings()
    End Sub

    Private Sub LoadFormSettings()

        With UserApplicationSettings
            ' General Settings
            chkCheckUpdatesStartup.Checked = .CheckforUpdatesonStart

            If rbtnExportCSV.Text = .DataExportFormat Then
                rbtnExportCSV.Checked = True
            ElseIf rbtnExportSSV.Text = .DataExportFormat Then
                rbtnExportSSV.Checked = True
            ElseIf rbtnExportDefault.Text = .DataExportFormat Then
                rbtnExportDefault.Checked = True
            End If

            chkShowToolTips.Checked = .ShowToolTips
            chkRefreshAssetsonStartup.Checked = .LoadAssetsonStartup
            chkRefreshBPsonStartup.Checked = .LoadBPsonStartup
            chkDisableSound.Checked = .DisableSound

            chkLoadBPsbyChar.Checked = .LoadBPsbyChar
            chkSaveFacilitiesbyChar.Checked = .SaveFacilitiesbyChar

            ' ESI
            chkRefreshSystemCostIndiciesDataonStartup.Checked = .LoadESISystemCostIndiciesDataonStartup
            chkRefreshMarketDataonStartup.Checked = .LoadESIMarketDataonStartup
            chkRefreshPublicStructureDataonStartup.Checked = .LoadESIPublicStructuresonStartup

            If .BrokerCorpStanding = Defaults.DefaultBrokerCorpStanding Then
                ' Default
                chkBrokerCorpStanding.Checked = False
                txtBrokerCorpStanding.Enabled = False
                txtBrokerCorpStanding.Text = FormatNumber(Defaults.DefaultBrokerCorpStanding, 2)
            Else
                ' User
                chkBrokerCorpStanding.Checked = True
                txtBrokerCorpStanding.Enabled = True
                txtBrokerCorpStanding.Text = FormatNumber(.BrokerCorpStanding, 2)
            End If

            If .BrokerFactionStanding = Defaults.DefaultBrokerFactionStanding Then
                ' Default
                chkBrokerFactionStanding.Checked = False
                txtBrokerFactionStanding.Enabled = False
                txtBrokerFactionStanding.Text = FormatNumber(Defaults.DefaultBrokerFactionStanding, 2)
            Else
                ' User
                chkBrokerFactionStanding.Checked = True
                txtBrokerFactionStanding.Enabled = True
                txtBrokerFactionStanding.Text = FormatNumber(.BrokerFactionStanding, 2)
            End If

            ' Implants
            If .ManufacturingImplantValue > 0 Then
                chkBeanCounterManufacturing.Checked = True
                Select Case .ManufacturingImplantValue
                    Case (-1 * GetAttribute("manufacturingTimeBonus", Defaults.MBeanCounterName & "1") / 100)
                        cmbBeanCounterManufacturing.Text = Defaults.MBeanCounterName & "1"
                    Case (-1 * GetAttribute("manufacturingTimeBonus", Defaults.MBeanCounterName & "2") / 100)
                        cmbBeanCounterManufacturing.Text = Defaults.MBeanCounterName & "2"
                    Case (-1 * GetAttribute("manufacturingTimeBonus", Defaults.MBeanCounterName & "4") / 100)
                        cmbBeanCounterManufacturing.Text = Defaults.MBeanCounterName & "4"
                End Select
            Else
                cmbBeanCounterManufacturing.Enabled = False
            End If

            If .RefiningImplantValue > 0 Then
                chkBeanCounterRefining.Checked = True
                Select Case .RefiningImplantValue
                    Case (GetAttribute("refiningYieldMutator", Defaults.RBeanCounterName & "1") / 100)
                        cmbBeanCounterRefining.Text = Defaults.RBeanCounterName & "1"
                    Case (GetAttribute("refiningYieldMutator", Defaults.RBeanCounterName & "2") / 100)
                        cmbBeanCounterRefining.Text = Defaults.RBeanCounterName & "2"
                    Case (GetAttribute("refiningYieldMutator", Defaults.RBeanCounterName & "4") / 100)
                        cmbBeanCounterRefining.Text = Defaults.RBeanCounterName & "4"
                End Select
            Else
                cmbBeanCounterRefining.Enabled = False
            End If

            If .CopyImplantValue > 0 Then
                chkBeanCounterCopy.Checked = True
                Select Case .CopyImplantValue
                    Case (-1 * GetAttribute("copySpeedBonus", Defaults.CBeanCounterName & "1") / 100)
                        cmbBeanCounterCopy.Text = Defaults.CBeanCounterName & "1"
                    Case (-1 * GetAttribute("copySpeedBonus", Defaults.CBeanCounterName & "3") / 100)
                        cmbBeanCounterCopy.Text = Defaults.CBeanCounterName & "3"
                    Case (-1 * GetAttribute("copySpeedBonus", Defaults.CBeanCounterName & "5") / 100)
                        cmbBeanCounterCopy.Text = Defaults.CBeanCounterName & "5"
                End Select
            Else
                cmbBeanCounterCopy.Enabled = False
            End If

            ' For Build/Buy
            chkBuildBuyDefault.Checked = .CheckBuildBuy
            chkSuggestBuildwhenBPnotOwned.Checked = .SuggestBuildBPNotOwned
            chkSaveBPRelicsDecryptors.Checked = .SaveBPRelicsDecryptors

            Select Case .BuildT2T3Materials
                Case BuildMatType.AdvMaterials
                    rbtnBuildT2T3AdvancedMats.Checked = True
                Case BuildMatType.ProcessedMaterials
                    rbtnBuildT2ProcessedMats.Checked = True
                Case BuildMatType.RawMaterials
                    rbtnBuildT2T3RawMats.Checked = True
            End Select

            chkDisableSVR.Checked = .DisableSVR
            chkDisableTracking.Checked = .DisableGATracking

            chkAlphaAccount.Checked = .AlphaAccount
            chkUseActiveSkills.Checked = .UseActiveSkillLevels

            chkLinksInCopyText.Checked = .IncludeInGameLinksinCopyText

            ' ShoppingList
            chkIncludeShopListInventMats.Checked = .ShopListIncludeInventMats
            chkIncludeShopListCopyMats.Checked = .ShopListIncludeCopyMats

            If .DefaultBPME = 0 Then
                txtDefaultME.Text = CStr(Defaults.DefaultSettingME)
                chkDefaultME.Checked = False
                txtDefaultME.Enabled = False
            Else
                txtDefaultME.Text = CStr(.DefaultBPME)
                chkDefaultME.Checked = True
                txtDefaultME.Enabled = True
            End If

            If .DefaultBPTE = 0 Then
                txtDefaultTE.Text = CStr(Defaults.DefaultSettingTE)
                chkDefaultTE.Checked = False
                txtDefaultTE.Enabled = False
            Else
                txtDefaultTE.Text = CStr(.DefaultBPTE)
                chkDefaultTE.Checked = True
                txtDefaultTE.Enabled = True
            End If

            If .EVEMarketerRefreshInterval <> Defaults.DefaultEVEMarketerRefreshInterval Then
                chkEVEMarketerInterval.Checked = True
                txtEVEMarketerInterval.Enabled = True
                txtEVEMarketerInterval.Text = CStr(.EVEMarketerRefreshInterval)
            Else
                chkEVEMarketerInterval.Checked = False
                txtEVEMarketerInterval.Enabled = False
                txtEVEMarketerInterval.Text = CStr(Defaults.DefaultEVEMarketerRefreshInterval)
            End If

            cmbSVRRegion.Text = .SVRAveragePriceRegion
            cmbSVRAvgPriceDuration.Text = .SVRAveragePriceDuration
            txtSVRThreshold.Text = CStr(.IgnoreSVRThresholdValue)
            chkAutoUpdateSVRBPTab.Checked = .AutoUpdateSVRonBPTab

            txtProxyAddress.Text = .ProxyAddress
            txtProxyPort.Text = CStr(.ProxyPort)
        End With

        FirstLoad = False

        btnSave.Focus()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim TempSettings As ApplicationSettings = Nothing

        ' Default values are 0 for implants in settings, since the value stored will get added later. This is the value bonus of the implant
        Dim RefineImplantValue As Double = 0
        Dim ManufacturingImplantValue As Double = 0
        Dim CopyImplantValue As Double = 0

        Dim Settings As New ProgramSettings

        If btnSave.Text = "Save" Then

            ' Make sure accurate data is entered
            If Not CheckEntries() Then
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            ' Get the implant values if set
            If chkBeanCounterManufacturing.Checked Then
                ManufacturingImplantValue = -1 * GetAttribute("manufacturingTimeBonus", cmbBeanCounterManufacturing.Text) / 100
            End If

            If chkBeanCounterRefining.Checked Then
                RefineImplantValue = GetAttribute("refiningYieldMutator", cmbBeanCounterRefining.Text) / 100
            End If

            If chkBeanCounterCopy.Checked Then
                CopyImplantValue = -1 * GetAttribute("copySpeedBonus", cmbBeanCounterCopy.Text) / 100
            End If

            With TempSettings

                .CheckforUpdatesonStart = CBool(chkCheckUpdatesStartup.Checked)
                If rbtnExportDefault.Checked Then
                    .DataExportFormat = rbtnExportDefault.Text
                ElseIf rbtnExportCSV.Checked Then
                    .DataExportFormat = rbtnExportCSV.Text
                ElseIf rbtnExportSSV.Checked Then
                    .DataExportFormat = rbtnExportSSV.Text
                End If
                .ShowToolTips = CBool(chkShowToolTips.Checked)
                ' Disable sound here - only works for update dings, not all sound
                .DisableSound = CBool(chkDisableSound.Checked)

                .RefiningImplantValue = RefineImplantValue
                .ManufacturingImplantValue = ManufacturingImplantValue
                .CopyImplantValue = CopyImplantValue

                ' ESI
                .LoadESISystemCostIndiciesDataonStartup = chkRefreshSystemCostIndiciesDataonStartup.Checked
                .LoadESIMarketDataonStartup = chkRefreshMarketDataonStartup.Checked
                .LoadESIPublicStructuresonStartup = chkRefreshPublicStructureDataonStartup.Checked

                ' If they didn't have this checked before, refresh assets
                If SelectedCharacter.ID <> DummyCharacterID Then
                    If UserApplicationSettings.LoadAssetsonStartup = False And chkRefreshAssetsonStartup.Checked Then
                        Call SelectedCharacter.GetAssets.LoadAssets(SelectedCharacter.ID, SelectedCharacter.CharacterTokenData, True)
                        Call SelectedCharacter.CharacterCorporation.GetAssets.LoadAssets(SelectedCharacter.CharacterCorporation.CorporationID, SelectedCharacter.CharacterTokenData, True)
                    End If

                    ' Same with blueprints
                    If UserApplicationSettings.LoadBPsonStartup = False And chkRefreshBPsonStartup.Checked Then
                        Call SelectedCharacter.GetBlueprints.LoadBlueprints(SelectedCharacter.ID, SelectedCharacter.CharacterTokenData, ScanType.Personal, True)
                        Call SelectedCharacter.CharacterCorporation.GetBlueprints.LoadBlueprints(SelectedCharacter.CharacterCorporation.CorporationID, SelectedCharacter.CharacterTokenData, ScanType.Corporation, True)
                    End If
                End If

                ' Now set these
                .LoadAssetsonStartup = CBool(chkRefreshAssetsonStartup.Checked)
                .LoadBPsonStartup = CBool(chkRefreshBPsonStartup.Checked)
                .SaveFacilitiesbyChar = CBool(chkSaveFacilitiesbyChar.Checked)
                .LoadBPsbyChar = CBool(chkLoadBPsbyChar.Checked)

                ' Standings
                .BrokerCorpStanding = CDbl(txtBrokerCorpStanding.Text)
                .BrokerFactionStanding = CDbl(txtBrokerFactionStanding.Text)

                ' Default build/buy
                .CheckBuildBuy = CBool(chkBuildBuyDefault.Checked)

                ' How they want to build T2/T3 items
                If rbtnBuildT2T3AdvancedMats.Checked Then
                    .BuildT2T3Materials = BuildMatType.AdvMaterials
                ElseIf rbtnBuildT2ProcessedMats.Checked Then
                    .BuildT2T3Materials = BuildMatType.ProcessedMaterials
                ElseIf rbtnBuildT2T3RawMats.Checked Then
                    .BuildT2T3Materials = BuildMatType.RawMaterials
                End If

                .DefaultBPME = CInt(txtDefaultME.Text)
                .DefaultBPTE = CInt(txtDefaultTE.Text)

                .DisableSVR = chkDisableSVR.Checked
                .DisableGATracking = chkDisableTracking.Checked
                .SuggestBuildBPNotOwned = chkSuggestBuildwhenBPnotOwned.Checked
                .SaveBPRelicsDecryptors = chkSaveBPRelicsDecryptors.Checked

                ' Account options, don't allow if dummy account active
                If SelectedCharacter.ID <> DummyCharacterID Then
                    .AlphaAccount = chkAlphaAccount.Checked
                    .UseActiveSkillLevels = chkUseActiveSkills.Checked
                Else
                    .AlphaAccount = False
                    .UseActiveSkillLevels = False
                End If

                .ShopListIncludeInventMats = chkIncludeShopListInventMats.Checked
                .ShopListIncludeCopyMats = chkIncludeShopListCopyMats.Checked

                .EVEMarketerRefreshInterval = CInt(txtEVEMarketerInterval.Text)

                .IncludeInGameLinksinCopyText = chkLinksInCopyText.Checked

                ' SVR
                .IgnoreSVRThresholdValue = CDbl(txtSVRThreshold.Text)
                .SVRAveragePriceRegion = cmbSVRRegion.Text
                .SVRAveragePriceDuration = cmbSVRAvgPriceDuration.Text
                .AutoUpdateSVRonBPTab = chkAutoUpdateSVRBPTab.Checked

                If txtProxyAddress.Text <> "" Then
                    .ProxyAddress = txtProxyAddress.Text
                Else
                    .ProxyAddress = ""
                End If

                If Trim(txtProxyPort.Text) <> "" Then
                    .ProxyPort = CInt(txtProxyPort.Text)
                Else
                    .ProxyPort = 0
                End If

            End With

            ' Save the data in the XML file
            Call Settings.SaveApplicationSettings(TempSettings)

            ' Save the data to the local variable
            UserApplicationSettings = TempSettings

            ' They changed the active skill levels, update skills now with new application settings
            If ReloadSkills Then
                ' Set the flag first
                Call SelectedCharacter.Skills.SetActiveSkillFlagValue(UserApplicationSettings.UseActiveSkillLevels)
                Call SelectedCharacter.Skills.LoadCharacterSkills(SelectedCharacter.ID, SelectedCharacter.CharacterTokenData)
            End If

            ' Re-init any tabs that have settings changes before displaying dialog
            Call frmMain.ResetTabs(False)
            Call frmMain.ResetRefresh()

            MsgBox("Settings Saved", vbInformation, Application.ProductName)

            btnSave.Text = "OK"
            Me.Cursor = Cursors.Default
        Else
            ' Just exit
            Me.Hide()
        End If

        btnSave.Focus()

    End Sub

    Private Function CheckEntries() As Boolean
        Dim TempTextBox As TextBox = Nothing
        Dim TempCheckBox As CheckBox = Nothing
        Dim TempComboBox As ComboBox = Nothing

        If (Not IsNumeric(txtBrokerCorpStanding.Text) Or Trim(txtBrokerCorpStanding.Text) = "") And chkBrokerCorpStanding.Checked Then
            TempTextBox = txtBrokerCorpStanding
            TempCheckBox = chkBrokerCorpStanding
            GoTo InvalidData
        ElseIf CDbl(txtBrokerCorpStanding.Text) > 10 Then
            txtBrokerCorpStanding.Text = "10.0"
        End If

        If (Not IsNumeric(txtBrokerFactionStanding.Text) Or Trim(txtBrokerFactionStanding.Text) = "") And chkBrokerFactionStanding.Checked Then
            TempTextBox = txtBrokerFactionStanding
            TempCheckBox = chkBrokerFactionStanding
            GoTo InvalidData
        ElseIf CDbl(txtBrokerFactionStanding.Text) > 10 Then
            txtBrokerFactionStanding.Text = "10.0"
        End If

        ' ME/TE
        If (Not IsNumeric(txtDefaultME.Text) Or Trim(txtDefaultME.Text) = "") And chkDefaultME.Checked Then
            TempTextBox = txtDefaultME
            TempCheckBox = chkDefaultME
            GoTo InvalidData
        End If

        If (Not IsNumeric(txtDefaultTE.Text) Or Trim(txtDefaultTE.Text) = "") And chkDefaultTE.Checked Then
            TempTextBox = txtDefaultTE
            TempCheckBox = chkDefaultTE
            GoTo InvalidData
        End If

        If (Not IsNumeric(txtEVEMarketerInterval.Text) Or Trim(txtEVEMarketerInterval.Text) = "") And chkEVEMarketerInterval.Checked Then
            TempTextBox = txtEVEMarketerInterval
            TempCheckBox = chkEVEMarketerInterval
            GoTo InvalidData
        ElseIf CInt(txtEVEMarketerInterval.Text) <= 0 Then
            MsgBox("Cannot set EVE Central Update Interval less than 1 Hour", vbExclamation, Application.ProductName)
            txtEVEMarketerInterval.Focus()
            Call txtEVEMarketerInterval.SelectAll()
            Return False
        ElseIf CInt(txtEVEMarketerInterval.Text) > 99 Then
            MsgBox("Cannot set EVE Central Update Interval greater than 99 hours", vbExclamation, Application.ProductName)
            txtEVEMarketerInterval.Focus()
            Call txtEVEMarketerInterval.SelectAll()
            Return False
        End If

        Return True

InvalidData:

        If Not IsNothing(TempComboBox) Then
            MsgBox("Invalid " & TempComboBox.Name & " Value", vbExclamation, Application.ProductName)
            TempComboBox.Focus()
            Call TempComboBox.SelectAll()
        Else
            MsgBox("Invalid " & TempCheckBox.Name & " Value", vbExclamation, Application.ProductName)
            TempTextBox.Focus()
            Call TempTextBox.SelectAll()
        End If

        Return False

    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If SelectedReset Then
            ' If we hit reset, then we need to get the current list of settings, not just what is loaded (might be defaults)
            ' So just reload the settings
            UserApplicationSettings = AllSettings.LoadApplicationSettings()
        End If
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        SelectedReset = True
        ' Load default settings
        UserApplicationSettings = AllSettings.SetDefaultApplicationSettings()
        ' Reload the form
        Call LoadFormSettings()

    End Sub

    Private Sub chkAlphaAccount_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlphaAccount.CheckedChanged
        If chkAlphaAccount.Checked Then
            ' Force them to use active skills in this case
            chkUseActiveSkills.Checked = True
            chkUseActiveSkills.Enabled = False
        Else
            chkUseActiveSkills.Enabled = True
        End If
    End Sub

    Private Sub chkUseActiveSkills_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseActiveSkills.CheckedChanged
        ' They changed active skills, so reload character skills on exit
        ReloadSkills = True
    End Sub
End Class