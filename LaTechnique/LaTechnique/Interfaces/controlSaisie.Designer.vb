﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class controlSaisie
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label14 As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpVaccins = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboVaccins = New System.Windows.Forms.ComboBox()
        Me.lstVaccins = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSupprimerVaccin = New System.Windows.Forms.Button()
        Me.btnAjouterVaccin = New System.Windows.Forms.Button()
        Me.grpRessources = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lstRessource = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSupprimerRessource = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtNomRessource = New System.Windows.Forms.TextBox()
        Me.AjouterRessource = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTelephoneRessource = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPosteRessource = New System.Windows.Forms.TextBox()
        Me.grpAntecedentsPsychiatriques = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboMaladiesMentales = New System.Windows.Forms.ComboBox()
        Me.lstPsychiatriques = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSuppirmerPsychiatriques = New System.Windows.Forms.Button()
        Me.btnAjouterPsychiatriques = New System.Windows.Forms.Button()
        Me.txtTaille = New System.Windows.Forms.TextBox()
        Me.txtPoids = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblInfosSupp = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAssuranceMaladie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDateNaissance = New System.Windows.Forms.DateTimePicker()
        Me.txtDossierHopital = New System.Windows.Forms.TextBox()
        Me.btnAjouterPhoto = New System.Windows.Forms.Button()
        Me.btnSupprimerPhoto = New System.Windows.Forms.Button()
        Me.lblPoids = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblTaille = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.grpAntecedentsMedicaux = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboMaladies = New System.Windows.Forms.ComboBox()
        Me.lstMedicaux = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSupprimerMedicaux = New System.Windows.Forms.Button()
        Me.btnAjouterMedicaux = New System.Windows.Forms.Button()
        Me.chkLunettes = New System.Windows.Forms.CheckBox()
        Me.chkProtheses = New System.Windows.Forms.CheckBox()
        Me.chkAppareilAuditif = New System.Windows.Forms.CheckBox()
        Me.chkProtection = New System.Windows.Forms.CheckBox()
        Me.chkAideTechnique = New System.Windows.Forms.CheckBox()
        Me.chkCutane = New System.Windows.Forms.CheckBox()
        Me.chkContention = New System.Windows.Forms.CheckBox()
        Me.chkFugue = New System.Windows.Forms.CheckBox()
        Me.chkDesorientation = New System.Windows.Forms.CheckBox()
        Me.chkComportement = New System.Windows.Forms.CheckBox()
        Me.grpAntecedentsChirurgicaux = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboChirurgicaux = New System.Windows.Forms.ComboBox()
        Me.lstChirurgicaux = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSupprimerChirurgicaux = New System.Windows.Forms.Button()
        Me.btnAjouterChirurgicaux = New System.Windows.Forms.Button()
        Me.grpAllergies = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboAllergies = New System.Windows.Forms.ComboBox()
        Me.lstAllergies = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSupprimerAllergie = New System.Windows.Forms.Button()
        Me.btnAjouterAllergie = New System.Windows.Forms.Button()
        Me.txtComportement = New System.Windows.Forms.TextBox()
        Me.lblComportement = New System.Windows.Forms.Label()
        Me.lblContention = New System.Windows.Forms.Label()
        Me.txtContention = New System.Windows.Forms.TextBox()
        Me.chkBas = New System.Windows.Forms.CheckBox()
        Me.chkHaut = New System.Windows.Forms.CheckBox()
        Me.chkDeux = New System.Windows.Forms.CheckBox()
        Me.lblAideTechnique = New System.Windows.Forms.Label()
        Me.txtAideTechnique = New System.Windows.Forms.TextBox()
        Me.grpMedicaments = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboMedicaments = New System.Windows.Forms.ComboBox()
        Me.lstMedicaments = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSupprimerMedicaments = New System.Windows.Forms.Button()
        Me.btnAjouterMedicaments = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtPharmacie = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.dtpDernierePesee = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.chkReanimationOui = New System.Windows.Forms.CheckBox()
        Me.chkReanimationNon = New System.Windows.Forms.CheckBox()
        Label14 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpVaccins.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.grpRessources.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.grpAntecedentsPsychiatriques.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAntecedentsMedicaux.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.grpAntecedentsChirurgicaux.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grpAllergies.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.grpMedicaments.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label14
        '
        Label14.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Label14, 8)
        Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Label14.Location = New System.Drawing.Point(23, 1173)
=======
<<<<<<< HEAD
        Label14.Location = New System.Drawing.Point(23, 1173)
=======
        Label14.Location = New System.Drawing.Point(31, 1569)
        Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(520, 41)
        Label14.TabIndex = 30
        Label14.Text = "Risque de fugue : ......................................................"
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label14.UseCompatibleTextRendering = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.ColumnCount = 21
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label26, 1, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDernierePesee, 5, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.Label25, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPharmacie, 5, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label22, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.grpVaccins, 9, 56)
        Me.TableLayoutPanel1.Controls.Add(Me.grpRessources, 1, 51)
        Me.TableLayoutPanel1.Controls.Add(Me.grpAntecedentsPsychiatriques, 1, 21)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrenom, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label21, 1, 48)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 1, 46)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 1, 44)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 1, 42)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 1, 40)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 1, 38)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 1, 36)
        Me.TableLayoutPanel1.Controls.Add(Label14, 1, 34)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 1, 32)
        Me.TableLayoutPanel1.Controls.Add(Me.lblInfosSupp, 1, 30)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 1, 28)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.pbPhoto, 12, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtNom, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAssuranceMaladie, 5, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDateNaissance, 5, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDossierHopital, 5, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAjouterPhoto, 12, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSupprimerPhoto, 16, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPoids, 6, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.grpAntecedentsMedicaux, 1, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.chkLunettes, 9, 48)
        Me.TableLayoutPanel1.Controls.Add(Me.chkProtheses, 9, 46)
        Me.TableLayoutPanel1.Controls.Add(Me.chkAppareilAuditif, 9, 44)
        Me.TableLayoutPanel1.Controls.Add(Me.chkProtection, 9, 42)
        Me.TableLayoutPanel1.Controls.Add(Me.chkAideTechnique, 9, 40)
        Me.TableLayoutPanel1.Controls.Add(Me.chkCutane, 9, 38)
        Me.TableLayoutPanel1.Controls.Add(Me.chkContention, 9, 36)
        Me.TableLayoutPanel1.Controls.Add(Me.chkFugue, 9, 34)
        Me.TableLayoutPanel1.Controls.Add(Me.chkDesorientation, 9, 32)
        Me.TableLayoutPanel1.Controls.Add(Me.chkComportement, 9, 30)
        Me.TableLayoutPanel1.Controls.Add(Me.grpAntecedentsChirurgicaux, 9, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.grpAllergies, 9, 21)
        Me.TableLayoutPanel1.Controls.Add(Me.txtComportement, 11, 30)
        Me.TableLayoutPanel1.Controls.Add(Me.lblComportement, 10, 30)
        Me.TableLayoutPanel1.Controls.Add(Me.lblContention, 10, 36)
        Me.TableLayoutPanel1.Controls.Add(Me.txtContention, 11, 36)
        Me.TableLayoutPanel1.Controls.Add(Me.chkBas, 10, 46)
        Me.TableLayoutPanel1.Controls.Add(Me.chkHaut, 11, 46)
        Me.TableLayoutPanel1.Controls.Add(Me.chkDeux, 13, 46)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAideTechnique, 10, 40)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAideTechnique, 11, 40)
        Me.TableLayoutPanel1.Controls.Add(Me.grpMedicaments, 9, 51)
        Me.TableLayoutPanel1.Controls.Add(Me.btnEnregistrer, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPoids, 3, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label23, 4, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTaille, 3, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.Label24, 4, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.chkReanimationOui, 4, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTaille, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkReanimationNon, 6, 16)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
<<<<<<< HEAD
        Me.TableLayoutPanel1.RowCount = 55
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
<<<<<<< HEAD
=======
=======
        Me.TableLayoutPanel1.RowCount = 61
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
>>>>>>> cc626eb43399553a4c8b430ac67dc37e93cc49c0
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
<<<<<<< HEAD
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
=======
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
<<<<<<< HEAD
=======
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
<<<<<<< HEAD
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
=======
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1021, 2112)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'grpVaccins
        '
        Me.grpVaccins.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpVaccins.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.grpVaccins, 11)
        Me.grpVaccins.Controls.Add(Me.TableLayoutPanel8)
        Me.grpVaccins.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.grpVaccins.Location = New System.Drawing.Point(549, 1962)
        Me.grpVaccins.Name = "grpVaccins"
        Me.TableLayoutPanel1.SetRowSpan(Me.grpVaccins, 5)
        Me.grpVaccins.Size = New System.Drawing.Size(414, 147)
=======
<<<<<<< HEAD
        Me.grpVaccins.Location = New System.Drawing.Point(549, 1962)
=======
        Me.grpVaccins.Location = New System.Drawing.Point(733, 2541)
        Me.grpVaccins.Margin = New System.Windows.Forms.Padding(4)
>>>>>>> origin/Interfaces
        Me.grpVaccins.Name = "grpVaccins"
        Me.TableLayoutPanel1.SetRowSpan(Me.grpVaccins, 5)
<<<<<<< HEAD
        Me.grpVaccins.Size = New System.Drawing.Size(414, 147)
=======
        Me.grpVaccins.Size = New System.Drawing.Size(551, 83)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.grpVaccins.TabIndex = 167
        Me.grpVaccins.TabStop = False
        Me.grpVaccins.Text = "Vaccins"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.AutoSize = True
        Me.TableLayoutPanel8.ColumnCount = 4
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.75796!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.18093!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.74478!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.74318!))
        Me.TableLayoutPanel8.Controls.Add(Me.cboVaccins, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.lstVaccins, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.btnSupprimerVaccin, 3, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.btnAjouterVaccin, 2, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 3
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
<<<<<<< HEAD
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(408, 125)
=======
<<<<<<< HEAD
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(408, 125)
=======
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(543, 56)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.TableLayoutPanel8.TabIndex = 65
        '
        'cboVaccins
        '
        Me.cboVaccins.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel8.SetColumnSpan(Me.cboVaccins, 4)
        Me.cboVaccins.FormattingEnabled = True
        Me.cboVaccins.Location = New System.Drawing.Point(3, 3)
        Me.cboVaccins.MaxLength = 50
        Me.cboVaccins.Name = "cboVaccins"
        Me.cboVaccins.Size = New System.Drawing.Size(402, 24)
        Me.cboVaccins.TabIndex = 11
        '
        'lstVaccins
        '
        Me.lstVaccins.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10})
        Me.TableLayoutPanel8.SetColumnSpan(Me.lstVaccins, 4)
        Me.lstVaccins.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstVaccins.FullRowSelect = True
        Me.lstVaccins.Location = New System.Drawing.Point(3, 62)
        Me.lstVaccins.MultiSelect = False
        Me.lstVaccins.Name = "lstVaccins"
        Me.lstVaccins.Size = New System.Drawing.Size(402, 139)
        Me.lstVaccins.TabIndex = 62
        Me.lstVaccins.UseCompatibleStateImageBehavior = False
        Me.lstVaccins.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Vaccin"
        Me.ColumnHeader10.Width = 529
        '
        'btnSupprimerVaccin
        '
        Me.btnSupprimerVaccin.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSupprimerVaccin.Enabled = False
        Me.btnSupprimerVaccin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupprimerVaccin.Location = New System.Drawing.Point(330, 33)
        Me.btnSupprimerVaccin.Name = "btnSupprimerVaccin"
        Me.btnSupprimerVaccin.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimerVaccin.TabIndex = 63
        Me.btnSupprimerVaccin.Text = "Supprimer"
        Me.btnSupprimerVaccin.UseVisualStyleBackColor = False
        '
        'btnAjouterVaccin
        '
        Me.btnAjouterVaccin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAjouterVaccin.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAjouterVaccin.Enabled = False
        Me.btnAjouterVaccin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAjouterVaccin.Location = New System.Drawing.Point(242, 33)
        Me.btnAjouterVaccin.Name = "btnAjouterVaccin"
        Me.btnAjouterVaccin.Size = New System.Drawing.Size(82, 23)
        Me.btnAjouterVaccin.TabIndex = 61
        Me.btnAjouterVaccin.Text = "Ajouter"
        Me.btnAjouterVaccin.UseVisualStyleBackColor = False
        '
        'grpRessources
        '
        Me.grpRessources.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRessources.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.grpRessources, 7)
        Me.grpRessources.Controls.Add(Me.TableLayoutPanel5)
        Me.grpRessources.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.grpRessources.Location = New System.Drawing.Point(23, 1670)
=======
<<<<<<< HEAD
        Me.grpRessources.Location = New System.Drawing.Point(23, 1670)
=======
        Me.grpRessources.Location = New System.Drawing.Point(31, 2181)
        Me.grpRessources.Margin = New System.Windows.Forms.Padding(4)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.grpRessources.Name = "grpRessources"
        Me.TableLayoutPanel1.SetRowSpan(Me.grpRessources, 5)
        Me.grpRessources.Size = New System.Drawing.Size(464, 286)
        Me.grpRessources.TabIndex = 165
        Me.grpRessources.TabStop = False
        Me.grpRessources.Text = "Personnes à contacter"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = True
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.75796!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.41176!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.83006!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.74318!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label9, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lstRessource, 0, 6)
        Me.TableLayoutPanel5.Controls.Add(Me.btnSupprimerRessource, 3, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TextBox1, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.txtNomRessource, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.AjouterRessource, 1, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.Label10, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.txtTelephoneRessource, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.Label11, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.txtPosteRessource, 1, 3)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 7
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(458, 264)
        Me.TableLayoutPanel5.TabIndex = 65
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(157, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Prenom"
        '
        'lstRessource
        '
        Me.lstRessource.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.TableLayoutPanel5.SetColumnSpan(Me.lstRessource, 4)
        Me.lstRessource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstRessource.FullRowSelect = True
        Me.lstRessource.Location = New System.Drawing.Point(3, 123)
        Me.lstRessource.MultiSelect = False
        Me.lstRessource.Name = "lstRessource"
        Me.lstRessource.Size = New System.Drawing.Size(452, 139)
        Me.lstRessource.TabIndex = 62
        Me.lstRessource.UseCompatibleStateImageBehavior = False
        Me.lstRessource.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nom"
        Me.ColumnHeader5.Width = 209
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Prénom"
        Me.ColumnHeader7.Width = 183
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Téléphone"
        Me.ColumnHeader8.Width = 136
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Poste"
        Me.ColumnHeader9.Width = 72
        '
        'btnSupprimerRessource
        '
        Me.btnSupprimerRessource.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSupprimerRessource.Enabled = False
        Me.btnSupprimerRessource.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupprimerRessource.Location = New System.Drawing.Point(370, 94)
        Me.btnSupprimerRessource.Name = "btnSupprimerRessource"
        Me.btnSupprimerRessource.Size = New System.Drawing.Size(85, 23)
        Me.btnSupprimerRessource.TabIndex = 63
        Me.btnSupprimerRessource.Text = "Supprimer"
        Me.btnSupprimerRessource.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 16)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Nom"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(157, 18)
<<<<<<< HEAD
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 23)
        Me.TextBox1.TabIndex = 67
        '
        'txtNomRessource
        '
        Me.txtNomRessource.Location = New System.Drawing.Point(2, 18)
<<<<<<< HEAD
        Me.txtNomRessource.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
        Me.txtNomRessource.Margin = New System.Windows.Forms.Padding(2)
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.txtNomRessource.Name = "txtNomRessource"
        Me.txtNomRessource.Size = New System.Drawing.Size(144, 23)
        Me.txtNomRessource.TabIndex = 64
        '
        'AjouterRessource
        '
        Me.AjouterRessource.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AjouterRessource.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel5.SetColumnSpan(Me.AjouterRessource, 2)
        Me.AjouterRessource.Enabled = False
        Me.AjouterRessource.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AjouterRessource.Location = New System.Drawing.Point(277, 94)
        Me.AjouterRessource.Name = "AjouterRessource"
        Me.AjouterRessource.Size = New System.Drawing.Size(87, 23)
        Me.AjouterRessource.TabIndex = 61
        Me.AjouterRessource.Text = "Ajouter"
        Me.AjouterRessource.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(2, 43)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 16)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Téléphone"
        '
        'txtTelephoneRessource
        '
        Me.txtTelephoneRessource.Location = New System.Drawing.Point(2, 61)
<<<<<<< HEAD
        Me.txtTelephoneRessource.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
        Me.txtTelephoneRessource.Margin = New System.Windows.Forms.Padding(2)
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.txtTelephoneRessource.Name = "txtTelephoneRessource"
        Me.txtTelephoneRessource.Size = New System.Drawing.Size(144, 23)
        Me.txtTelephoneRessource.TabIndex = 69
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(157, 43)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Poste"
        '
        'txtPosteRessource
        '
        Me.txtPosteRessource.Location = New System.Drawing.Point(157, 61)
<<<<<<< HEAD
        Me.txtPosteRessource.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
        Me.txtPosteRessource.Margin = New System.Windows.Forms.Padding(2)
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.txtPosteRessource.Name = "txtPosteRessource"
        Me.txtPosteRessource.Size = New System.Drawing.Size(78, 23)
        Me.txtPosteRessource.TabIndex = 71
        '
        'grpAntecedentsPsychiatriques
        '
        Me.grpAntecedentsPsychiatriques.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAntecedentsPsychiatriques.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.grpAntecedentsPsychiatriques, 7)
        Me.grpAntecedentsPsychiatriques.Controls.Add(Me.TableLayoutPanel3)
        Me.grpAntecedentsPsychiatriques.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.grpAntecedentsPsychiatriques.Location = New System.Drawing.Point(23, 749)
=======
<<<<<<< HEAD
        Me.grpAntecedentsPsychiatriques.Location = New System.Drawing.Point(23, 749)
=======
        Me.grpAntecedentsPsychiatriques.Location = New System.Drawing.Point(31, 1047)
        Me.grpAntecedentsPsychiatriques.Margin = New System.Windows.Forms.Padding(4)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.grpAntecedentsPsychiatriques.Name = "grpAntecedentsPsychiatriques"
        Me.TableLayoutPanel1.SetRowSpan(Me.grpAntecedentsPsychiatriques, 5)
        Me.grpAntecedentsPsychiatriques.Size = New System.Drawing.Size(464, 226)
        Me.grpAntecedentsPsychiatriques.TabIndex = 144
        Me.grpAntecedentsPsychiatriques.TabStop = False
        Me.grpAntecedentsPsychiatriques.Text = "Antécédents psychiatriques"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.75796!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.18093!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.74478!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.74318!))
        Me.TableLayoutPanel3.Controls.Add(Me.cboMaladiesMentales, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lstPsychiatriques, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.btnSuppirmerPsychiatriques, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAjouterPsychiatriques, 2, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(458, 204)
        Me.TableLayoutPanel3.TabIndex = 65
        '
        'cboMaladiesMentales
        '
        Me.cboMaladiesMentales.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.cboMaladiesMentales, 4)
        Me.cboMaladiesMentales.FormattingEnabled = True
        Me.cboMaladiesMentales.Location = New System.Drawing.Point(3, 3)
        Me.cboMaladiesMentales.MaxLength = 50
        Me.cboMaladiesMentales.Name = "cboMaladiesMentales"
        Me.cboMaladiesMentales.Size = New System.Drawing.Size(452, 24)
        Me.cboMaladiesMentales.TabIndex = 11
        '
        'lstPsychiatriques
        '
        Me.lstPsychiatriques.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.TableLayoutPanel3.SetColumnSpan(Me.lstPsychiatriques, 4)
        Me.lstPsychiatriques.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPsychiatriques.FullRowSelect = True
        Me.lstPsychiatriques.Location = New System.Drawing.Point(3, 62)
        Me.lstPsychiatriques.MultiSelect = False
        Me.lstPsychiatriques.Name = "lstPsychiatriques"
        Me.lstPsychiatriques.Size = New System.Drawing.Size(452, 139)
        Me.lstPsychiatriques.TabIndex = 62
        Me.lstPsychiatriques.UseCompatibleStateImageBehavior = False
        Me.lstPsychiatriques.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Maladie mentale / Trouble psychiatrique"
        Me.ColumnHeader3.Width = 599
        '
        'btnSuppirmerPsychiatriques
        '
        Me.btnSuppirmerPsychiatriques.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSuppirmerPsychiatriques.Enabled = False
        Me.btnSuppirmerPsychiatriques.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSuppirmerPsychiatriques.Location = New System.Drawing.Point(369, 33)
        Me.btnSuppirmerPsychiatriques.Name = "btnSuppirmerPsychiatriques"
        Me.btnSuppirmerPsychiatriques.Size = New System.Drawing.Size(86, 23)
        Me.btnSuppirmerPsychiatriques.TabIndex = 63
        Me.btnSuppirmerPsychiatriques.Text = "Supprimer"
        Me.btnSuppirmerPsychiatriques.UseVisualStyleBackColor = False
        '
        'btnAjouterPsychiatriques
        '
        Me.btnAjouterPsychiatriques.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAjouterPsychiatriques.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAjouterPsychiatriques.Enabled = False
        Me.btnAjouterPsychiatriques.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAjouterPsychiatriques.Location = New System.Drawing.Point(281, 33)
        Me.btnAjouterPsychiatriques.Name = "btnAjouterPsychiatriques"
        Me.btnAjouterPsychiatriques.Size = New System.Drawing.Size(82, 23)
        Me.btnAjouterPsychiatriques.TabIndex = 61
        Me.btnAjouterPsychiatriques.Text = "Ajouter"
        Me.btnAjouterPsychiatriques.UseVisualStyleBackColor = False
        '
        'txtTaille
        '
        Me.txtTaille.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.txtTaille.Location = New System.Drawing.Point(140, 442)
        Me.txtTaille.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.txtTaille.Location = New System.Drawing.Point(140, 442)
        Me.txtTaille.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.txtTaille.Location = New System.Drawing.Point(188, 566)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.txtTaille.Name = "txtTaille"
        Me.txtTaille.Size = New System.Drawing.Size(55, 32)
        Me.txtTaille.TabIndex = 63
        '
        'txtPoids
        '
        Me.txtPoids.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.txtPoids.Location = New System.Drawing.Point(140, 392)
        Me.txtPoids.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.txtPoids.Location = New System.Drawing.Point(140, 392)
        Me.txtPoids.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.txtPoids.Location = New System.Drawing.Point(188, 521)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.txtPoids.Name = "txtPoids"
        Me.txtPoids.Size = New System.Drawing.Size(55, 32)
        Me.txtPoids.TabIndex = 60
        '
        'txtPrenom
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtPrenom, 6)
        Me.txtPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrenom.Location = New System.Drawing.Point(260, 172)
<<<<<<< HEAD
        Me.txtPrenom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
        Me.txtPrenom.Margin = New System.Windows.Forms.Padding(2)
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(258, 32)
        Me.txtPrenom.TabIndex = 52
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label21, 8)
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label21.Location = New System.Drawing.Point(23, 1600)
=======
<<<<<<< HEAD
        Me.Label21.Location = New System.Drawing.Point(23, 1600)
=======
        Me.Label21.Location = New System.Drawing.Point(31, 2094)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(520, 41)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Lunettes : ..................................................................."
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label20, 8)
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label20.Location = New System.Drawing.Point(23, 1539)
=======
<<<<<<< HEAD
        Me.Label20.Location = New System.Drawing.Point(23, 1539)
=======
        Me.Label20.Location = New System.Drawing.Point(31, 2019)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
=======
        Me.Label20.Location = New System.Drawing.Point(31, 2019)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> cc626eb43399553a4c8b430ac67dc37e93cc49c0
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(520, 41)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Prothèses dentaires : ..............................................."
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label19, 8)
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label19.Location = New System.Drawing.Point(23, 1478)
=======
<<<<<<< HEAD
        Me.Label19.Location = New System.Drawing.Point(23, 1478)
=======
        Me.Label19.Location = New System.Drawing.Point(31, 1944)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.Label19.Location = New System.Drawing.Point(31, 1944)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(520, 41)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Appareil auditif : ........................................................"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label18, 8)
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label18.Location = New System.Drawing.Point(23, 1417)
=======
<<<<<<< HEAD
        Me.Label18.Location = New System.Drawing.Point(23, 1417)
=======
        Me.Label18.Location = New System.Drawing.Point(31, 1869)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.Label18.Location = New System.Drawing.Point(31, 1869)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(520, 41)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Port de protection : ...................................................."
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label17, 8)
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label17.Location = New System.Drawing.Point(23, 1356)
=======
<<<<<<< HEAD
        Me.Label17.Location = New System.Drawing.Point(23, 1356)
=======
        Me.Label17.Location = New System.Drawing.Point(31, 1794)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.Label17.Location = New System.Drawing.Point(31, 1794)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(520, 41)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Aide technique : ........................................................."
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label16, 8)
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label16.Location = New System.Drawing.Point(23, 1295)
=======
<<<<<<< HEAD
        Me.Label16.Location = New System.Drawing.Point(23, 1295)
=======
        Me.Label16.Location = New System.Drawing.Point(31, 1719)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.Label16.Location = New System.Drawing.Point(31, 1719)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(520, 41)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Problèmes cutanés (escarres, plaies...) : ................."
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label15, 8)
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label15.Location = New System.Drawing.Point(23, 1234)
=======
<<<<<<< HEAD
        Me.Label15.Location = New System.Drawing.Point(23, 1234)
=======
        Me.Label15.Location = New System.Drawing.Point(31, 1644)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.Label15.Location = New System.Drawing.Point(31, 1644)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(520, 41)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Utilisation de contention : ........................................."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label13, 8)
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label13.Location = New System.Drawing.Point(23, 1112)
=======
<<<<<<< HEAD
        Me.Label13.Location = New System.Drawing.Point(23, 1112)
=======
        Me.Label13.Location = New System.Drawing.Point(31, 1494)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.Label13.Location = New System.Drawing.Point(31, 1494)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(520, 41)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Désorientation : .........................................................."
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInfosSupp
        '
        Me.lblInfosSupp.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblInfosSupp, 8)
        Me.lblInfosSupp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInfosSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.lblInfosSupp.Location = New System.Drawing.Point(23, 1051)
=======
<<<<<<< HEAD
        Me.lblInfosSupp.Location = New System.Drawing.Point(23, 1051)
=======
        Me.lblInfosSupp.Location = New System.Drawing.Point(31, 1419)
        Me.lblInfosSupp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.lblInfosSupp.Location = New System.Drawing.Point(31, 1419)
        Me.lblInfosSupp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfosSupp.Name = "lblInfosSupp"
        Me.lblInfosSupp.Size = New System.Drawing.Size(520, 41)
        Me.lblInfosSupp.TabIndex = 28
        Me.lblInfosSupp.Text = "Troubles du comportement : ....................................."
        Me.lblInfosSupp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label12, 8)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label12.Location = New System.Drawing.Point(23, 1002)
=======
<<<<<<< HEAD
        Me.Label12.Location = New System.Drawing.Point(23, 1002)
=======
        Me.Label12.Location = New System.Drawing.Point(31, 1358)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.Label12.Location = New System.Drawing.Point(31, 1358)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(316, 26)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Informations supplémentaires  :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Button1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Button1, 4)
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Button1, 2)
        Me.Button1.Size = New System.Drawing.Size(192, 64)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label5, 4)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 26)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Date de naissance :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label6, 2)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label6.Location = New System.Drawing.Point(23, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 26)
=======
<<<<<<< HEAD
        Me.Label6.Location = New System.Drawing.Point(23, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 26)
=======
        Me.Label6.Location = New System.Drawing.Point(31, 518)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label6, 2)
        Me.Label6.Size = New System.Drawing.Size(97, 31)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Poids :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label7, 2)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label7.Location = New System.Drawing.Point(23, 440)
=======
<<<<<<< HEAD
        Me.Label7.Location = New System.Drawing.Point(23, 440)
=======
        Me.Label7.Location = New System.Drawing.Point(31, 563)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.Label7.Location = New System.Drawing.Point(31, 563)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 26)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Taille :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Prénom :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pbPhoto
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.pbPhoto, 8)
        Me.pbPhoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbPhoto.Location = New System.Drawing.Point(756, 123)
        Me.pbPhoto.Name = "pbPhoto"
        Me.TableLayoutPanel1.SetRowSpan(Me.pbPhoto, 4)
        Me.pbPhoto.Size = New System.Drawing.Size(207, 194)
        Me.pbPhoto.TabIndex = 25
        Me.pbPhoto.TabStop = False
        '
        'txtNom
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtNom, 6)
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(260, 122)
<<<<<<< HEAD
        Me.txtNom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
        Me.txtNom.Margin = New System.Windows.Forms.Padding(2)
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(258, 32)
        Me.txtNom.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label3, 4)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Assurance maladie :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAssuranceMaladie
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtAssuranceMaladie, 3)
        Me.txtAssuranceMaladie.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssuranceMaladie.Location = New System.Drawing.Point(260, 272)
<<<<<<< HEAD
        Me.txtAssuranceMaladie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
        Me.txtAssuranceMaladie.Margin = New System.Windows.Forms.Padding(2)
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.txtAssuranceMaladie.Name = "txtAssuranceMaladie"
        Me.txtAssuranceMaladie.Size = New System.Drawing.Size(216, 32)
        Me.txtAssuranceMaladie.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label4, 3)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dossier hôpital :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpDateNaissance
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.dtpDateNaissance, 3)
        Me.dtpDateNaissance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateNaissance.Location = New System.Drawing.Point(260, 222)
<<<<<<< HEAD
        Me.dtpDateNaissance.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
        Me.dtpDateNaissance.Margin = New System.Windows.Forms.Padding(2)
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.dtpDateNaissance.Name = "dtpDateNaissance"
        Me.dtpDateNaissance.Size = New System.Drawing.Size(228, 32)
        Me.dtpDateNaissance.TabIndex = 56
        '
        'txtDossierHopital
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtDossierHopital, 3)
        Me.txtDossierHopital.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDossierHopital.Location = New System.Drawing.Point(260, 322)
<<<<<<< HEAD
        Me.txtDossierHopital.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
        Me.txtDossierHopital.Margin = New System.Windows.Forms.Padding(2)
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.txtDossierHopital.Name = "txtDossierHopital"
        Me.txtDossierHopital.Size = New System.Drawing.Size(216, 32)
        Me.txtDossierHopital.TabIndex = 55
        '
        'btnAjouterPhoto
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnAjouterPhoto, 2)
        Me.btnAjouterPhoto.Location = New System.Drawing.Point(755, 322)
<<<<<<< HEAD
        Me.btnAjouterPhoto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
        Me.btnAjouterPhoto.Margin = New System.Windows.Forms.Padding(2)
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.btnAjouterPhoto.Name = "btnAjouterPhoto"
        Me.btnAjouterPhoto.Size = New System.Drawing.Size(76, 38)
        Me.btnAjouterPhoto.TabIndex = 58
        Me.btnAjouterPhoto.Text = "Ajouter"
        Me.btnAjouterPhoto.UseVisualStyleBackColor = True
        '
        'btnSupprimerPhoto
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnSupprimerPhoto, 4)
        Me.btnSupprimerPhoto.Location = New System.Drawing.Point(895, 322)
<<<<<<< HEAD
        Me.btnSupprimerPhoto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
        Me.btnSupprimerPhoto.Margin = New System.Windows.Forms.Padding(2)
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.btnSupprimerPhoto.Name = "btnSupprimerPhoto"
        Me.btnSupprimerPhoto.Size = New System.Drawing.Size(69, 38)
        Me.btnSupprimerPhoto.TabIndex = 59
        Me.btnSupprimerPhoto.Text = "Supprimer"
        Me.btnSupprimerPhoto.UseVisualStyleBackColor = True
        '
        'lblPoids
        '
        Me.lblPoids.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblPoids, 2)
        Me.lblPoids.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.lblPoids.Location = New System.Drawing.Point(341, 390)
=======
<<<<<<< HEAD
        Me.lblPoids.Location = New System.Drawing.Point(341, 390)
=======
        Me.lblPoids.Location = New System.Drawing.Point(456, 563)
        Me.lblPoids.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.lblPoids.Location = New System.Drawing.Point(456, 563)
        Me.lblPoids.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPoids.Name = "lblPoids"
        Me.lblPoids.Size = New System.Drawing.Size(0, 26)
        Me.lblPoids.TabIndex = 13
        Me.lblPoids.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label23, 2)
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label23.Location = New System.Drawing.Point(201, 390)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 26)
=======
<<<<<<< HEAD
        Me.Label23.Location = New System.Drawing.Point(201, 390)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 26)
=======
        Me.Label23.Location = New System.Drawing.Point(269, 518)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label23, 2)
        Me.Label23.Size = New System.Drawing.Size(78, 31)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "livres"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTaille
        '
        Me.lblTaille.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblTaille, 2)
        Me.lblTaille.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.lblTaille.Location = New System.Drawing.Point(341, 440)
=======
<<<<<<< HEAD
        Me.lblTaille.Location = New System.Drawing.Point(341, 440)
=======
        Me.lblTaille.Location = New System.Drawing.Point(269, 0)
        Me.lblTaille.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.lblTaille.Location = New System.Drawing.Point(269, 0)
        Me.lblTaille.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaille.Name = "lblTaille"
        Me.lblTaille.Size = New System.Drawing.Size(0, 26)
        Me.lblTaille.TabIndex = 14
        Me.lblTaille.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label24, 2)
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Label24.Location = New System.Drawing.Point(201, 440)
=======
<<<<<<< HEAD
        Me.Label24.Location = New System.Drawing.Point(201, 440)
=======
        Me.Label24.Location = New System.Drawing.Point(269, 563)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.Label24.Location = New System.Drawing.Point(269, 563)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 26)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "cm"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpAntecedentsMedicaux
        '
        Me.grpAntecedentsMedicaux.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAntecedentsMedicaux.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.grpAntecedentsMedicaux, 7)
        Me.grpAntecedentsMedicaux.Controls.Add(Me.TableLayoutPanel7)
        Me.grpAntecedentsMedicaux.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.grpAntecedentsMedicaux.Location = New System.Drawing.Point(23, 493)
=======
<<<<<<< HEAD
        Me.grpAntecedentsMedicaux.Location = New System.Drawing.Point(23, 493)
=======
        Me.grpAntecedentsMedicaux.Location = New System.Drawing.Point(31, 731)
        Me.grpAntecedentsMedicaux.Margin = New System.Windows.Forms.Padding(4)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.grpAntecedentsMedicaux.Location = New System.Drawing.Point(31, 731)
        Me.grpAntecedentsMedicaux.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAntecedentsMedicaux.Name = "grpAntecedentsMedicaux"
        Me.TableLayoutPanel1.SetRowSpan(Me.grpAntecedentsMedicaux, 3)
        Me.grpAntecedentsMedicaux.Size = New System.Drawing.Size(464, 223)
        Me.grpAntecedentsMedicaux.TabIndex = 142
        Me.grpAntecedentsMedicaux.TabStop = False
        Me.grpAntecedentsMedicaux.Text = "Antécédents médicaux"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.AutoSize = True
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.75796!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.18093!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.74478!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.74318!))
        Me.TableLayoutPanel7.Controls.Add(Me.cboMaladies, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.lstMedicaux, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.btnSupprimerMedicaux, 3, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.btnAjouterMedicaux, 2, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(458, 201)
        Me.TableLayoutPanel7.TabIndex = 65
        '
        'cboMaladies
        '
        Me.cboMaladies.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.SetColumnSpan(Me.cboMaladies, 4)
        Me.cboMaladies.FormattingEnabled = True
        Me.cboMaladies.Location = New System.Drawing.Point(3, 3)
        Me.cboMaladies.MaxLength = 50
        Me.cboMaladies.Name = "cboMaladies"
        Me.cboMaladies.Size = New System.Drawing.Size(452, 24)
        Me.cboMaladies.TabIndex = 11
        '
        'lstMedicaux
        '
        Me.lstMedicaux.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.TableLayoutPanel7.SetColumnSpan(Me.lstMedicaux, 4)
        Me.lstMedicaux.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstMedicaux.FullRowSelect = True
        Me.lstMedicaux.Location = New System.Drawing.Point(3, 62)
        Me.lstMedicaux.MultiSelect = False
        Me.lstMedicaux.Name = "lstMedicaux"
        Me.lstMedicaux.Size = New System.Drawing.Size(452, 139)
        Me.lstMedicaux.TabIndex = 62
        Me.lstMedicaux.UseCompatibleStateImageBehavior = False
        Me.lstMedicaux.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Maladie"
        Me.ColumnHeader1.Width = 599
        '
        'btnSupprimerMedicaux
        '
        Me.btnSupprimerMedicaux.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSupprimerMedicaux.Enabled = False
        Me.btnSupprimerMedicaux.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupprimerMedicaux.Location = New System.Drawing.Point(369, 33)
        Me.btnSupprimerMedicaux.Name = "btnSupprimerMedicaux"
        Me.btnSupprimerMedicaux.Size = New System.Drawing.Size(86, 23)
        Me.btnSupprimerMedicaux.TabIndex = 63
        Me.btnSupprimerMedicaux.Text = "Supprimer"
        Me.btnSupprimerMedicaux.UseVisualStyleBackColor = False
        '
        'btnAjouterMedicaux
        '
        Me.btnAjouterMedicaux.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAjouterMedicaux.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAjouterMedicaux.Enabled = False
        Me.btnAjouterMedicaux.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAjouterMedicaux.Location = New System.Drawing.Point(281, 33)
        Me.btnAjouterMedicaux.Name = "btnAjouterMedicaux"
        Me.btnAjouterMedicaux.Size = New System.Drawing.Size(82, 23)
        Me.btnAjouterMedicaux.TabIndex = 61
        Me.btnAjouterMedicaux.Text = "Ajouter"
        Me.btnAjouterMedicaux.UseVisualStyleBackColor = False
        '
        'chkLunettes
        '
        Me.chkLunettes.AutoSize = True
        Me.chkLunettes.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
<<<<<<< HEAD
        Me.chkLunettes.Location = New System.Drawing.Point(548, 1602)
        Me.chkLunettes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.chkLunettes.Location = New System.Drawing.Point(548, 1602)
        Me.chkLunettes.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.chkLunettes.Location = New System.Drawing.Point(732, 2097)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.chkLunettes.Location = New System.Drawing.Point(732, 2097)
        Me.chkLunettes.Name = "chkLunettes"
        Me.chkLunettes.Size = New System.Drawing.Size(60, 30)
        Me.chkLunettes.TabIndex = 155
        Me.chkLunettes.Text = "Oui"
        Me.chkLunettes.UseVisualStyleBackColor = True
        '
        'chkProtheses
        '
        Me.chkProtheses.AutoSize = True
        Me.chkProtheses.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.chkProtheses.Location = New System.Drawing.Point(548, 1541)
        Me.chkProtheses.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.chkProtheses.Location = New System.Drawing.Point(548, 1541)
        Me.chkProtheses.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.chkProtheses.Location = New System.Drawing.Point(732, 2022)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.chkProtheses.Location = New System.Drawing.Point(732, 2022)
        Me.chkProtheses.Name = "chkProtheses"
        Me.chkProtheses.Size = New System.Drawing.Size(60, 30)
        Me.chkProtheses.TabIndex = 154
        Me.chkProtheses.Text = "Oui"
        Me.chkProtheses.UseVisualStyleBackColor = True
        '
        'chkAppareilAuditif
        '
        Me.chkAppareilAuditif.AutoSize = True
        Me.chkAppareilAuditif.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.chkAppareilAuditif.Location = New System.Drawing.Point(548, 1480)
        Me.chkAppareilAuditif.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.chkAppareilAuditif.Location = New System.Drawing.Point(548, 1480)
        Me.chkAppareilAuditif.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.chkAppareilAuditif.Location = New System.Drawing.Point(732, 1947)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.chkAppareilAuditif.Location = New System.Drawing.Point(732, 1947)
        Me.chkAppareilAuditif.Name = "chkAppareilAuditif"
        Me.chkAppareilAuditif.Size = New System.Drawing.Size(60, 30)
        Me.chkAppareilAuditif.TabIndex = 153
        Me.chkAppareilAuditif.Text = "Oui"
        Me.chkAppareilAuditif.UseVisualStyleBackColor = True
        '
        'chkProtection
        '
        Me.chkProtection.AutoSize = True
        Me.chkProtection.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
<<<<<<< HEAD
        Me.chkProtection.Location = New System.Drawing.Point(548, 1419)
        Me.chkProtection.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.chkProtection.Location = New System.Drawing.Point(548, 1419)
        Me.chkProtection.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.chkProtection.Location = New System.Drawing.Point(732, 1872)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.chkProtection.Location = New System.Drawing.Point(732, 1872)
        Me.chkProtection.Name = "chkProtection"
        Me.chkProtection.Size = New System.Drawing.Size(60, 30)
        Me.chkProtection.TabIndex = 152
        Me.chkProtection.Text = "Oui"
        Me.chkProtection.UseVisualStyleBackColor = True
        '
        'chkAideTechnique
        '
        Me.chkAideTechnique.AutoSize = True
        Me.chkAideTechnique.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.chkAideTechnique.Location = New System.Drawing.Point(548, 1358)
        Me.chkAideTechnique.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.chkAideTechnique.Location = New System.Drawing.Point(548, 1358)
        Me.chkAideTechnique.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.chkAideTechnique.Location = New System.Drawing.Point(732, 1797)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.chkAideTechnique.Location = New System.Drawing.Point(732, 1797)
        Me.chkAideTechnique.Name = "chkAideTechnique"
        Me.chkAideTechnique.Size = New System.Drawing.Size(60, 30)
        Me.chkAideTechnique.TabIndex = 151
        Me.chkAideTechnique.Text = "Oui"
        Me.chkAideTechnique.UseVisualStyleBackColor = True
        '
        'chkCutane
        '
        Me.chkCutane.AutoSize = True
        Me.chkCutane.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.chkCutane.Location = New System.Drawing.Point(548, 1297)
        Me.chkCutane.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.chkCutane.Location = New System.Drawing.Point(548, 1297)
        Me.chkCutane.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.chkCutane.Location = New System.Drawing.Point(732, 1722)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.chkCutane.Location = New System.Drawing.Point(732, 1722)
        Me.chkCutane.Name = "chkCutane"
        Me.chkCutane.Size = New System.Drawing.Size(60, 30)
        Me.chkCutane.TabIndex = 150
        Me.chkCutane.Text = "Oui"
        Me.chkCutane.UseVisualStyleBackColor = True
        '
        'chkContention
        '
        Me.chkContention.AutoSize = True
        Me.chkContention.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.chkContention.Location = New System.Drawing.Point(548, 1236)
        Me.chkContention.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.chkContention.Location = New System.Drawing.Point(548, 1236)
        Me.chkContention.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.chkContention.Location = New System.Drawing.Point(732, 1647)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.chkContention.Location = New System.Drawing.Point(732, 1647)
        Me.chkContention.Name = "chkContention"
        Me.chkContention.Size = New System.Drawing.Size(60, 30)
        Me.chkContention.TabIndex = 149
        Me.chkContention.Text = "Oui"
        Me.chkContention.UseVisualStyleBackColor = True
        '
        'chkFugue
        '
        Me.chkFugue.AutoSize = True
        Me.chkFugue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.chkFugue.Location = New System.Drawing.Point(548, 1175)
        Me.chkFugue.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.chkFugue.Location = New System.Drawing.Point(548, 1175)
        Me.chkFugue.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.chkFugue.Location = New System.Drawing.Point(732, 1572)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.chkFugue.Location = New System.Drawing.Point(732, 1572)
        Me.chkFugue.Name = "chkFugue"
        Me.chkFugue.Size = New System.Drawing.Size(60, 30)
        Me.chkFugue.TabIndex = 148
        Me.chkFugue.Text = "Oui"
        Me.chkFugue.UseVisualStyleBackColor = True
        '
        'chkDesorientation
        '
        Me.chkDesorientation.AutoSize = True
        Me.chkDesorientation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.chkDesorientation.Location = New System.Drawing.Point(548, 1114)
        Me.chkDesorientation.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.chkDesorientation.Location = New System.Drawing.Point(548, 1114)
        Me.chkDesorientation.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.chkDesorientation.Location = New System.Drawing.Point(732, 1497)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.chkDesorientation.Location = New System.Drawing.Point(732, 1497)
        Me.chkDesorientation.Name = "chkDesorientation"
        Me.chkDesorientation.Size = New System.Drawing.Size(60, 30)
        Me.chkDesorientation.TabIndex = 147
        Me.chkDesorientation.Text = "Oui"
        Me.chkDesorientation.UseVisualStyleBackColor = True
        '
        'chkComportement
        '
        Me.chkComportement.AutoSize = True
        Me.chkComportement.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.chkComportement.Location = New System.Drawing.Point(548, 1053)
        Me.chkComportement.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.chkComportement.Location = New System.Drawing.Point(548, 1053)
        Me.chkComportement.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.chkComportement.Location = New System.Drawing.Point(732, 1422)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.chkComportement.Location = New System.Drawing.Point(732, 1422)
        Me.chkComportement.Name = "chkComportement"
        Me.chkComportement.Size = New System.Drawing.Size(60, 30)
        Me.chkComportement.TabIndex = 146
        Me.chkComportement.Text = "Oui"
        Me.chkComportement.UseVisualStyleBackColor = True
        '
        'grpAntecedentsChirurgicaux
        '
        Me.grpAntecedentsChirurgicaux.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAntecedentsChirurgicaux.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.grpAntecedentsChirurgicaux, 11)
        Me.grpAntecedentsChirurgicaux.Controls.Add(Me.TableLayoutPanel2)
        Me.grpAntecedentsChirurgicaux.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.grpAntecedentsChirurgicaux.Location = New System.Drawing.Point(549, 493)
=======
<<<<<<< HEAD
        Me.grpAntecedentsChirurgicaux.Location = New System.Drawing.Point(549, 493)
=======
        Me.grpAntecedentsChirurgicaux.Location = New System.Drawing.Point(733, 731)
        Me.grpAntecedentsChirurgicaux.Margin = New System.Windows.Forms.Padding(4)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.grpAntecedentsChirurgicaux.Location = New System.Drawing.Point(733, 731)
        Me.grpAntecedentsChirurgicaux.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAntecedentsChirurgicaux.Name = "grpAntecedentsChirurgicaux"
        Me.TableLayoutPanel1.SetRowSpan(Me.grpAntecedentsChirurgicaux, 3)
        Me.grpAntecedentsChirurgicaux.Size = New System.Drawing.Size(414, 223)
        Me.grpAntecedentsChirurgicaux.TabIndex = 143
        Me.grpAntecedentsChirurgicaux.TabStop = False
        Me.grpAntecedentsChirurgicaux.Text = "Antécédents chirurgicaux"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.75796!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.18093!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.74478!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.74318!))
        Me.TableLayoutPanel2.Controls.Add(Me.cboChirurgicaux, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lstChirurgicaux, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSupprimerChirurgicaux, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnAjouterChirurgicaux, 2, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(408, 201)
        Me.TableLayoutPanel2.TabIndex = 65
        '
        'cboChirurgicaux
        '
        Me.cboChirurgicaux.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.cboChirurgicaux, 4)
        Me.cboChirurgicaux.FormattingEnabled = True
        Me.cboChirurgicaux.Location = New System.Drawing.Point(3, 3)
        Me.cboChirurgicaux.MaxLength = 50
        Me.cboChirurgicaux.Name = "cboChirurgicaux"
        Me.cboChirurgicaux.Size = New System.Drawing.Size(402, 24)
        Me.cboChirurgicaux.TabIndex = 11
        '
        'lstChirurgicaux
        '
        Me.lstChirurgicaux.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.TableLayoutPanel2.SetColumnSpan(Me.lstChirurgicaux, 4)
        Me.lstChirurgicaux.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstChirurgicaux.FullRowSelect = True
        Me.lstChirurgicaux.Location = New System.Drawing.Point(3, 62)
        Me.lstChirurgicaux.MultiSelect = False
        Me.lstChirurgicaux.Name = "lstChirurgicaux"
        Me.lstChirurgicaux.Size = New System.Drawing.Size(402, 139)
        Me.lstChirurgicaux.TabIndex = 62
        Me.lstChirurgicaux.UseCompatibleStateImageBehavior = False
        Me.lstChirurgicaux.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Chirurgie"
        Me.ColumnHeader2.Width = 503
        '
        'btnSupprimerChirurgicaux
        '
        Me.btnSupprimerChirurgicaux.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSupprimerChirurgicaux.Enabled = False
        Me.btnSupprimerChirurgicaux.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupprimerChirurgicaux.Location = New System.Drawing.Point(330, 33)
        Me.btnSupprimerChirurgicaux.Name = "btnSupprimerChirurgicaux"
        Me.btnSupprimerChirurgicaux.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimerChirurgicaux.TabIndex = 63
        Me.btnSupprimerChirurgicaux.Text = "Supprimer"
        Me.btnSupprimerChirurgicaux.UseVisualStyleBackColor = False
        '
        'btnAjouterChirurgicaux
        '
        Me.btnAjouterChirurgicaux.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAjouterChirurgicaux.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAjouterChirurgicaux.Enabled = False
        Me.btnAjouterChirurgicaux.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAjouterChirurgicaux.Location = New System.Drawing.Point(242, 33)
        Me.btnAjouterChirurgicaux.Name = "btnAjouterChirurgicaux"
        Me.btnAjouterChirurgicaux.Size = New System.Drawing.Size(82, 23)
        Me.btnAjouterChirurgicaux.TabIndex = 61
        Me.btnAjouterChirurgicaux.Text = "Ajouter"
        Me.btnAjouterChirurgicaux.UseVisualStyleBackColor = False
        '
        'grpAllergies
        '
        Me.grpAllergies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAllergies.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.grpAllergies, 11)
        Me.grpAllergies.Controls.Add(Me.TableLayoutPanel4)
        Me.grpAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.grpAllergies.Location = New System.Drawing.Point(549, 749)
=======
<<<<<<< HEAD
        Me.grpAllergies.Location = New System.Drawing.Point(549, 749)
=======
        Me.grpAllergies.Location = New System.Drawing.Point(733, 1047)
        Me.grpAllergies.Margin = New System.Windows.Forms.Padding(4)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.grpAllergies.Location = New System.Drawing.Point(733, 1047)
        Me.grpAllergies.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAllergies.Name = "grpAllergies"
        Me.TableLayoutPanel1.SetRowSpan(Me.grpAllergies, 5)
        Me.grpAllergies.Size = New System.Drawing.Size(414, 226)
        Me.grpAllergies.TabIndex = 145
        Me.grpAllergies.TabStop = False
        Me.grpAllergies.Text = "Allergies"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.75796!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.18093!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.74478!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.74318!))
        Me.TableLayoutPanel4.Controls.Add(Me.cboAllergies, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lstAllergies, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.btnSupprimerAllergie, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.btnAjouterAllergie, 2, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(408, 204)
        Me.TableLayoutPanel4.TabIndex = 65
        '
        'cboAllergies
        '
        Me.cboAllergies.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.SetColumnSpan(Me.cboAllergies, 4)
        Me.cboAllergies.FormattingEnabled = True
        Me.cboAllergies.Location = New System.Drawing.Point(3, 3)
        Me.cboAllergies.MaxLength = 50
        Me.cboAllergies.Name = "cboAllergies"
        Me.cboAllergies.Size = New System.Drawing.Size(402, 24)
        Me.cboAllergies.TabIndex = 11
        '
        'lstAllergies
        '
        Me.lstAllergies.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.TableLayoutPanel4.SetColumnSpan(Me.lstAllergies, 4)
        Me.lstAllergies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstAllergies.FullRowSelect = True
        Me.lstAllergies.Location = New System.Drawing.Point(3, 62)
        Me.lstAllergies.MultiSelect = False
        Me.lstAllergies.Name = "lstAllergies"
        Me.lstAllergies.Size = New System.Drawing.Size(402, 139)
        Me.lstAllergies.TabIndex = 62
        Me.lstAllergies.UseCompatibleStateImageBehavior = False
        Me.lstAllergies.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Allergie"
        Me.ColumnHeader4.Width = 503
        '
        'btnSupprimerAllergie
        '
        Me.btnSupprimerAllergie.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSupprimerAllergie.Enabled = False
        Me.btnSupprimerAllergie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupprimerAllergie.Location = New System.Drawing.Point(330, 33)
        Me.btnSupprimerAllergie.Name = "btnSupprimerAllergie"
        Me.btnSupprimerAllergie.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimerAllergie.TabIndex = 63
        Me.btnSupprimerAllergie.Text = "Supprimer"
        Me.btnSupprimerAllergie.UseVisualStyleBackColor = False
        '
        'btnAjouterAllergie
        '
        Me.btnAjouterAllergie.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAjouterAllergie.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAjouterAllergie.Enabled = False
        Me.btnAjouterAllergie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAjouterAllergie.Location = New System.Drawing.Point(242, 33)
        Me.btnAjouterAllergie.Name = "btnAjouterAllergie"
        Me.btnAjouterAllergie.Size = New System.Drawing.Size(82, 23)
        Me.btnAjouterAllergie.TabIndex = 61
        Me.btnAjouterAllergie.Text = "Ajouter"
        Me.btnAjouterAllergie.UseVisualStyleBackColor = False
        '
        'txtComportement
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtComportement, 8)
        Me.txtComportement.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.txtComportement.Location = New System.Drawing.Point(722, 1053)
        Me.txtComportement.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.txtComportement.Location = New System.Drawing.Point(722, 1053)
        Me.txtComportement.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.txtComportement.Location = New System.Drawing.Point(962, 1422)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.txtComportement.Location = New System.Drawing.Point(962, 1422)
        Me.txtComportement.Name = "txtComportement"
        Me.txtComportement.Size = New System.Drawing.Size(229, 32)
        Me.txtComportement.TabIndex = 156
        '
        'lblComportement
        '
        Me.lblComportement.AutoSize = True
        Me.lblComportement.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.lblComportement.Location = New System.Drawing.Point(612, 1051)
        Me.lblComportement.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
<<<<<<< HEAD
        Me.lblComportement.Location = New System.Drawing.Point(612, 1051)
        Me.lblComportement.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
        Me.lblComportement.Location = New System.Drawing.Point(818, 1419)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.lblComportement.Location = New System.Drawing.Point(818, 1419)
        Me.lblComportement.Name = "lblComportement"
        Me.lblComportement.Size = New System.Drawing.Size(102, 41)
        Me.lblComportement.TabIndex = 157
        Me.lblComportement.Text = "Précisez :"
        '
        'lblContention
        '
        Me.lblContention.AutoSize = True
        Me.lblContention.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.lblContention.Location = New System.Drawing.Point(612, 1234)
        Me.lblContention.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
<<<<<<< HEAD
        Me.lblContention.Location = New System.Drawing.Point(612, 1234)
        Me.lblContention.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
        Me.lblContention.Location = New System.Drawing.Point(818, 1644)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.lblContention.Location = New System.Drawing.Point(818, 1644)
        Me.lblContention.Name = "lblContention"
        Me.lblContention.Size = New System.Drawing.Size(102, 41)
        Me.lblContention.TabIndex = 159
        Me.lblContention.Text = "Précisez :"
        '
        'txtContention
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtContention, 8)
        Me.txtContention.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.txtContention.Location = New System.Drawing.Point(722, 1236)
        Me.txtContention.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.txtContention.Location = New System.Drawing.Point(722, 1236)
        Me.txtContention.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.txtContention.Location = New System.Drawing.Point(962, 1647)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.txtContention.Location = New System.Drawing.Point(962, 1647)
        Me.txtContention.Name = "txtContention"
        Me.txtContention.Size = New System.Drawing.Size(229, 32)
        Me.txtContention.TabIndex = 158
        '
        'chkBas
        '
        Me.chkBas.AutoSize = True
        Me.chkBas.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.chkBas.Location = New System.Drawing.Point(612, 1541)
        Me.chkBas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.chkBas.Location = New System.Drawing.Point(612, 1541)
        Me.chkBas.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.chkBas.Location = New System.Drawing.Point(818, 2022)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.chkBas.Location = New System.Drawing.Point(818, 2022)
        Me.chkBas.Name = "chkBas"
        Me.chkBas.Size = New System.Drawing.Size(100, 30)
        Me.chkBas.TabIndex = 160
        Me.chkBas.Text = "En-bas"
        Me.chkBas.UseVisualStyleBackColor = True
        '
        'chkHaut
        '
        Me.chkHaut.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.chkHaut, 2)
        Me.chkHaut.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.chkHaut.Location = New System.Drawing.Point(722, 1541)
        Me.chkHaut.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.chkHaut.Location = New System.Drawing.Point(722, 1541)
        Me.chkHaut.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.chkHaut.Location = New System.Drawing.Point(962, 2022)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.chkHaut.Location = New System.Drawing.Point(962, 2022)
        Me.chkHaut.Name = "chkHaut"
        Me.chkHaut.Size = New System.Drawing.Size(107, 30)
        Me.chkHaut.TabIndex = 161
        Me.chkHaut.Text = "En-haut"
        Me.chkHaut.UseVisualStyleBackColor = True
        '
        'chkDeux
        '
        Me.chkDeux.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.chkDeux, 7)
        Me.chkDeux.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.chkDeux.Location = New System.Drawing.Point(835, 1541)
        Me.chkDeux.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.chkDeux.Location = New System.Drawing.Point(835, 1541)
        Me.chkDeux.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.chkDeux.Location = New System.Drawing.Point(1112, 2022)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.chkDeux.Location = New System.Drawing.Point(1112, 2022)
        Me.chkDeux.Name = "chkDeux"
        Me.chkDeux.Size = New System.Drawing.Size(119, 30)
        Me.chkDeux.TabIndex = 162
        Me.chkDeux.Text = "Les deux"
        Me.chkDeux.UseVisualStyleBackColor = True
        '
        'lblAideTechnique
        '
        Me.lblAideTechnique.AutoSize = True
        Me.lblAideTechnique.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.lblAideTechnique.Location = New System.Drawing.Point(612, 1356)
        Me.lblAideTechnique.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
<<<<<<< HEAD
        Me.lblAideTechnique.Location = New System.Drawing.Point(612, 1356)
        Me.lblAideTechnique.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
=======
        Me.lblAideTechnique.Location = New System.Drawing.Point(818, 1794)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.lblAideTechnique.Location = New System.Drawing.Point(818, 1794)
        Me.lblAideTechnique.Name = "lblAideTechnique"
        Me.lblAideTechnique.Size = New System.Drawing.Size(102, 41)
        Me.lblAideTechnique.TabIndex = 164
        Me.lblAideTechnique.Text = "Précisez :"
        '
        'txtAideTechnique
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtAideTechnique, 8)
        Me.txtAideTechnique.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.txtAideTechnique.Location = New System.Drawing.Point(722, 1358)
        Me.txtAideTechnique.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
<<<<<<< HEAD
        Me.txtAideTechnique.Location = New System.Drawing.Point(722, 1358)
        Me.txtAideTechnique.Margin = New System.Windows.Forms.Padding(2)
=======
        Me.txtAideTechnique.Location = New System.Drawing.Point(962, 1797)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.txtAideTechnique.Location = New System.Drawing.Point(962, 1797)
        Me.txtAideTechnique.Name = "txtAideTechnique"
        Me.txtAideTechnique.Size = New System.Drawing.Size(229, 32)
        Me.txtAideTechnique.TabIndex = 163
        '
        'grpMedicaments
        '
        Me.grpMedicaments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMedicaments.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.grpMedicaments, 11)
        Me.grpMedicaments.Controls.Add(Me.TableLayoutPanel6)
        Me.grpMedicaments.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.grpMedicaments.Location = New System.Drawing.Point(549, 1670)
=======
<<<<<<< HEAD
        Me.grpMedicaments.Location = New System.Drawing.Point(549, 1670)
=======
        Me.grpMedicaments.Location = New System.Drawing.Point(733, 2181)
        Me.grpMedicaments.Margin = New System.Windows.Forms.Padding(4)
>>>>>>> origin/Interfaces
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.grpMedicaments.Location = New System.Drawing.Point(733, 2181)
        Me.grpMedicaments.Margin = New System.Windows.Forms.Padding(4)
        Me.grpMedicaments.Name = "grpMedicaments"
        Me.TableLayoutPanel1.SetRowSpan(Me.grpMedicaments, 5)
        Me.grpMedicaments.Size = New System.Drawing.Size(414, 226)
        Me.grpMedicaments.TabIndex = 166
        Me.grpMedicaments.TabStop = False
        Me.grpMedicaments.Text = "Médicaments"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.AutoSize = True
        Me.TableLayoutPanel6.ColumnCount = 4
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.75796!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.18093!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.74478!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.74318!))
        Me.TableLayoutPanel6.Controls.Add(Me.cboMedicaments, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.lstMedicaments, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.btnSupprimerMedicaments, 3, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.btnAjouterMedicaments, 2, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 19)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(408, 204)
        Me.TableLayoutPanel6.TabIndex = 65
        '
        'cboMedicaments
        '
        Me.cboMedicaments.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.SetColumnSpan(Me.cboMedicaments, 4)
        Me.cboMedicaments.FormattingEnabled = True
        Me.cboMedicaments.Location = New System.Drawing.Point(3, 3)
        Me.cboMedicaments.MaxLength = 50
        Me.cboMedicaments.Name = "cboMedicaments"
        Me.cboMedicaments.Size = New System.Drawing.Size(402, 24)
        Me.cboMedicaments.TabIndex = 11
        '
        'lstMedicaments
        '
        Me.lstMedicaments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6})
        Me.TableLayoutPanel6.SetColumnSpan(Me.lstMedicaments, 4)
        Me.lstMedicaments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstMedicaments.FullRowSelect = True
        Me.lstMedicaments.Location = New System.Drawing.Point(3, 62)
        Me.lstMedicaments.MultiSelect = False
        Me.lstMedicaments.Name = "lstMedicaments"
        Me.lstMedicaments.Size = New System.Drawing.Size(402, 139)
        Me.lstMedicaments.TabIndex = 62
        Me.lstMedicaments.UseCompatibleStateImageBehavior = False
        Me.lstMedicaments.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Médicament"
        Me.ColumnHeader6.Width = 529
        '
        'btnSupprimerMedicaments
        '
        Me.btnSupprimerMedicaments.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSupprimerMedicaments.Enabled = False
        Me.btnSupprimerMedicaments.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupprimerMedicaments.Location = New System.Drawing.Point(330, 33)
        Me.btnSupprimerMedicaments.Name = "btnSupprimerMedicaments"
        Me.btnSupprimerMedicaments.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimerMedicaments.TabIndex = 63
        Me.btnSupprimerMedicaments.Text = "Supprimer"
        Me.btnSupprimerMedicaments.UseVisualStyleBackColor = False
        '
        'btnAjouterMedicaments
        '
        Me.btnAjouterMedicaments.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAjouterMedicaments.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAjouterMedicaments.Enabled = False
        Me.btnAjouterMedicaments.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAjouterMedicaments.Location = New System.Drawing.Point(242, 33)
        Me.btnAjouterMedicaments.Name = "btnAjouterMedicaments"
        Me.btnAjouterMedicaments.Size = New System.Drawing.Size(82, 23)
        Me.btnAjouterMedicaments.TabIndex = 61
        Me.btnAjouterMedicaments.Text = "Ajouter"
        Me.btnAjouterMedicaments.UseVisualStyleBackColor = False
        '
        'btnEnregistrer
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnEnregistrer, 2)
        Me.btnEnregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregistrer.Location = New System.Drawing.Point(340, 2)
<<<<<<< HEAD
        Me.btnEnregistrer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
        Me.btnEnregistrer.Margin = New System.Windows.Forms.Padding(2)
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.TableLayoutPanel1.SetRowSpan(Me.btnEnregistrer, 2)
        Me.btnEnregistrer.Size = New System.Drawing.Size(148, 65)
        Me.btnEnregistrer.TabIndex = 168
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label22, 3)
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(31, 458)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label22, 2)
        Me.Label22.Size = New System.Drawing.Size(158, 31)
        Me.Label22.TabIndex = 169
        Me.Label22.Text = "Pharmacie :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPharmacie
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtPharmacie, 3)
        Me.txtPharmacie.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPharmacie.Location = New System.Drawing.Point(348, 461)
        Me.txtPharmacie.Name = "txtPharmacie"
        Me.TableLayoutPanel1.SetRowSpan(Me.txtPharmacie, 2)
        Me.txtPharmacie.Size = New System.Drawing.Size(304, 38)
        Me.txtPharmacie.TabIndex = 170
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label25, 4)
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(31, 625)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label25, 2)
        Me.Label25.Size = New System.Drawing.Size(274, 31)
        Me.Label25.TabIndex = 171
        Me.Label25.Text = "Date dernière pesée :"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpDernierePesee
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.dtpDernierePesee, 3)
        Me.dtpDernierePesee.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDernierePesee.Location = New System.Drawing.Point(348, 628)
        Me.dtpDernierePesee.Name = "dtpDernierePesee"
        Me.dtpDernierePesee.Size = New System.Drawing.Size(304, 38)
        Me.dtpDernierePesee.TabIndex = 172
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label26, 3)
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(31, 678)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(181, 31)
        Me.Label26.TabIndex = 173
        Me.Label26.Text = "Réanimation :"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkReanimationOui
        '
        Me.chkReanimationOui.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.chkReanimationOui, 2)
        Me.chkReanimationOui.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReanimationOui.Location = New System.Drawing.Point(268, 681)
        Me.chkReanimationOui.Name = "chkReanimationOui"
        Me.chkReanimationOui.Size = New System.Drawing.Size(78, 35)
        Me.chkReanimationOui.TabIndex = 174
        Me.chkReanimationOui.Text = "Oui"
        Me.chkReanimationOui.UseVisualStyleBackColor = True
        '
        'chkReanimationNon
        '
        Me.chkReanimationNon.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.chkReanimationNon, 2)
        Me.chkReanimationNon.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReanimationNon.Location = New System.Drawing.Point(455, 681)
        Me.chkReanimationNon.Name = "chkReanimationNon"
        Me.chkReanimationNon.Size = New System.Drawing.Size(86, 35)
        Me.chkReanimationNon.TabIndex = 175
        Me.chkReanimationNon.Text = "Non"
        Me.chkReanimationNon.UseVisualStyleBackColor = True
        '
        'controlSaisie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
<<<<<<< HEAD
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
=======
        Me.Margin = New System.Windows.Forms.Padding(2)
>>>>>>> e767f810d994d1c169d9b9f87ebea1d1897eadcf
        Me.Name = "controlSaisie"
        Me.Size = New System.Drawing.Size(1021, 2112)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.grpVaccins.ResumeLayout(False)
        Me.grpVaccins.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.grpRessources.ResumeLayout(False)
        Me.grpRessources.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.grpAntecedentsPsychiatriques.ResumeLayout(False)
        Me.grpAntecedentsPsychiatriques.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAntecedentsMedicaux.ResumeLayout(False)
        Me.grpAntecedentsMedicaux.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.grpAntecedentsChirurgicaux.ResumeLayout(False)
        Me.grpAntecedentsChirurgicaux.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.grpAllergies.ResumeLayout(False)
        Me.grpAllergies.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.grpMedicaments.ResumeLayout(False)
        Me.grpMedicaments.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblInfosSupp As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTaille As Label
    Friend WithEvents lblPoids As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pbPhoto As PictureBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtAssuranceMaladie As TextBox
    Friend WithEvents txtTaille As TextBox
    Friend WithEvents txtPoids As TextBox
    Friend WithEvents dtpDateNaissance As DateTimePicker
    Friend WithEvents txtDossierHopital As TextBox
    Friend WithEvents btnAjouterPhoto As Button
    Friend WithEvents btnSupprimerPhoto As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents grpAntecedentsPsychiatriques As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents cboMaladiesMentales As ComboBox
    Friend WithEvents lstPsychiatriques As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnSuppirmerPsychiatriques As Button
    Friend WithEvents btnAjouterPsychiatriques As Button
    Friend WithEvents grpAntecedentsMedicaux As GroupBox
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents cboMaladies As ComboBox
    Friend WithEvents lstMedicaux As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents btnSupprimerMedicaux As Button
    Friend WithEvents btnAjouterMedicaux As Button
    Friend WithEvents chkLunettes As CheckBox
    Friend WithEvents chkProtheses As CheckBox
    Friend WithEvents chkAppareilAuditif As CheckBox
    Friend WithEvents chkProtection As CheckBox
    Friend WithEvents chkAideTechnique As CheckBox
    Friend WithEvents chkCutane As CheckBox
    Friend WithEvents chkContention As CheckBox
    Friend WithEvents chkFugue As CheckBox
    Friend WithEvents chkDesorientation As CheckBox
    Friend WithEvents chkComportement As CheckBox
    Friend WithEvents grpAntecedentsChirurgicaux As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cboChirurgicaux As ComboBox
    Friend WithEvents lstChirurgicaux As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnSupprimerChirurgicaux As Button
    Friend WithEvents btnAjouterChirurgicaux As Button
    Friend WithEvents grpAllergies As GroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents cboAllergies As ComboBox
    Friend WithEvents lstAllergies As ListView
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents btnSupprimerAllergie As Button
    Friend WithEvents btnAjouterAllergie As Button
    Friend WithEvents txtComportement As TextBox
    Friend WithEvents lblComportement As Label
    Friend WithEvents lblContention As Label
    Friend WithEvents txtContention As TextBox
    Friend WithEvents chkBas As CheckBox
    Friend WithEvents chkHaut As CheckBox
    Friend WithEvents chkDeux As CheckBox
    Friend WithEvents lblAideTechnique As Label
    Friend WithEvents txtAideTechnique As TextBox
    Friend WithEvents grpRessources As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lstRessource As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents btnSupprimerRessource As Button
    Friend WithEvents AjouterRessource As Button
    Friend WithEvents grpMedicaments As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents cboMedicaments As ComboBox
    Friend WithEvents lstMedicaments As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents btnSupprimerMedicaments As Button
    Friend WithEvents btnAjouterMedicaments As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtNomRessource As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTelephoneRessource As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPosteRessource As TextBox
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents grpVaccins As GroupBox
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents cboVaccins As ComboBox
    Friend WithEvents lstVaccins As ListView
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents btnSupprimerVaccin As Button
    Friend WithEvents btnAjouterVaccin As Button
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents dtpDernierePesee As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents txtPharmacie As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents chkReanimationOui As CheckBox
    Friend WithEvents chkReanimationNon As CheckBox
End Class
