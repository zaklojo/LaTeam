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
        Me.Label = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTaille = New System.Windows.Forms.Label()
        Me.lblPoids = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtAssuranceMaladie = New System.Windows.Forms.TextBox()
        Me.txtDossierHopital = New System.Windows.Forms.TextBox()
        Me.dtpDateNaissance = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateMaj = New System.Windows.Forms.DateTimePicker()
        Me.btnAjouterPhoto = New System.Windows.Forms.Button()
        Me.btnSupprimerPhoto = New System.Windows.Forms.Button()
        Me.txtPoids = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtTaille = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.grpAntecedentsMedicaux = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboMaladies = New System.Windows.Forms.ComboBox()
        Me.lstMedicaux = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAjouterMedicaux = New System.Windows.Forms.Button()
        Me.btnSupprimerMedicaux = New System.Windows.Forms.Button()
        Me.grpAntecedentsChirurgicaux = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboChirurgicaux = New System.Windows.Forms.ComboBox()
        Me.lstChirurgicaux = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSupprimerChirurgicaux = New System.Windows.Forms.Button()
        Me.btnAjouterChirurgicaux = New System.Windows.Forms.Button()
        Me.grpAntecedentsPsychiatriques = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboMaladiesMentales = New System.Windows.Forms.ComboBox()
        Me.lstPsychiatriques = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSuppirmerPsychiatriques = New System.Windows.Forms.Button()
        Me.btnAjouterPsychiatriques = New System.Windows.Forms.Button()
        Me.grpAllergies = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboAllergies = New System.Windows.Forms.ComboBox()
        Me.lstAllergies = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSupprimerAllergie = New System.Windows.Forms.Button()
        Me.btnAjouterAllergie = New System.Windows.Forms.Button()
        Me.chkComportement = New System.Windows.Forms.CheckBox()
        Me.chkDesorientation = New System.Windows.Forms.CheckBox()
        Me.chkFugue = New System.Windows.Forms.CheckBox()
        Me.chkContention = New System.Windows.Forms.CheckBox()
        Me.chkCutane = New System.Windows.Forms.CheckBox()
        Me.chkAideTechnique = New System.Windows.Forms.CheckBox()
        Me.chkProtection = New System.Windows.Forms.CheckBox()
        Me.chkAppareilAuditif = New System.Windows.Forms.CheckBox()
        Me.chkProtheses = New System.Windows.Forms.CheckBox()
        Me.chkLunettes = New System.Windows.Forms.CheckBox()
        Me.txtComportement = New System.Windows.Forms.TextBox()
        Me.lblComportement = New System.Windows.Forms.Label()
        Me.txtContention = New System.Windows.Forms.TextBox()
        Me.lblContention = New System.Windows.Forms.Label()
        Me.chkBas = New System.Windows.Forms.CheckBox()
        Me.chkHaut = New System.Windows.Forms.CheckBox()
        Me.chkDeux = New System.Windows.Forms.CheckBox()
        Me.lblAideTechnique = New System.Windows.Forms.Label()
        Me.txtAideTechnique = New System.Windows.Forms.TextBox()
        Me.grpRessources = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lstRessource = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSupprimerRessource = New System.Windows.Forms.Button()
        Me.AjouterRessource = New System.Windows.Forms.Button()
        Me.grpMedicaments = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboMedicaments = New System.Windows.Forms.ComboBox()
        Me.lstMedicaments = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSupprimerMedicaments = New System.Windows.Forms.Button()
        Me.btnAjouterMedicaments = New System.Windows.Forms.Button()
        Me.txtNomRessource = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTelephoneRessource = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPosteRessource = New System.Windows.Forms.TextBox()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Label14 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAntecedentsMedicaux.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.grpAntecedentsChirurgicaux.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grpAntecedentsPsychiatriques.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.grpAllergies.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.grpRessources.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
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
        Label14.Location = New System.Drawing.Point(31, 1449)
        Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(694, 50)
        Label14.TabIndex = 30
        Label14.Text = "Risque de fugue : ......................................................"
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label14.UseCompatibleTextRendering = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.ColumnCount = 21
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.grpRessources, 1, 45)
        Me.TableLayoutPanel1.Controls.Add(Me.grpAntecedentsPsychiatriques, 1, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.txtTaille, 3, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPoids, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDateMaj, 11, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrenom, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label21, 1, 42)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 1, 40)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 1, 38)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 1, 36)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 1, 34)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 1, 32)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 1, 30)
        Me.TableLayoutPanel1.Controls.Add(Label14, 1, 28)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 1, 26)
        Me.TableLayoutPanel1.Controls.Add(Me.lblInfosSupp, 1, 24)
        Me.TableLayoutPanel1.Controls.Add(Me.Label, 11, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 1, 22)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 10)
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
        Me.TableLayoutPanel1.Controls.Add(Me.lblPoids, 6, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label23, 4, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTaille, 6, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label24, 4, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.grpAntecedentsMedicaux, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.chkLunettes, 9, 42)
        Me.TableLayoutPanel1.Controls.Add(Me.chkProtheses, 9, 40)
        Me.TableLayoutPanel1.Controls.Add(Me.chkAppareilAuditif, 9, 38)
        Me.TableLayoutPanel1.Controls.Add(Me.chkProtection, 9, 36)
        Me.TableLayoutPanel1.Controls.Add(Me.chkAideTechnique, 9, 34)
        Me.TableLayoutPanel1.Controls.Add(Me.chkCutane, 9, 32)
        Me.TableLayoutPanel1.Controls.Add(Me.chkContention, 9, 30)
        Me.TableLayoutPanel1.Controls.Add(Me.chkFugue, 9, 28)
        Me.TableLayoutPanel1.Controls.Add(Me.chkDesorientation, 9, 26)
        Me.TableLayoutPanel1.Controls.Add(Me.chkComportement, 9, 24)
        Me.TableLayoutPanel1.Controls.Add(Me.grpAntecedentsChirurgicaux, 9, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.grpAllergies, 9, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.txtComportement, 11, 24)
        Me.TableLayoutPanel1.Controls.Add(Me.lblComportement, 10, 24)
        Me.TableLayoutPanel1.Controls.Add(Me.lblContention, 10, 30)
        Me.TableLayoutPanel1.Controls.Add(Me.txtContention, 11, 30)
        Me.TableLayoutPanel1.Controls.Add(Me.chkBas, 10, 40)
        Me.TableLayoutPanel1.Controls.Add(Me.chkHaut, 11, 40)
        Me.TableLayoutPanel1.Controls.Add(Me.chkDeux, 13, 40)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAideTechnique, 10, 34)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAideTechnique, 11, 34)
        Me.TableLayoutPanel1.Controls.Add(Me.grpMedicaments, 9, 45)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 52
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1361, 2215)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'txtPrenom
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtPrenom, 6)
        Me.txtPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrenom.Location = New System.Drawing.Point(348, 213)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(343, 38)
        Me.txtPrenom.TabIndex = 52
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label21, 8)
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(31, 1974)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(694, 50)
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
        Me.Label20.Location = New System.Drawing.Point(31, 1899)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(694, 50)
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
        Me.Label19.Location = New System.Drawing.Point(31, 1824)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(694, 50)
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
        Me.Label18.Location = New System.Drawing.Point(31, 1749)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(694, 50)
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
        Me.Label17.Location = New System.Drawing.Point(31, 1674)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(694, 50)
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
        Me.Label16.Location = New System.Drawing.Point(31, 1599)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(694, 50)
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
        Me.Label15.Location = New System.Drawing.Point(31, 1524)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(694, 50)
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
        Me.Label13.Location = New System.Drawing.Point(31, 1374)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(694, 50)
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
        Me.lblInfosSupp.Location = New System.Drawing.Point(31, 1299)
        Me.lblInfosSupp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfosSupp.Name = "lblInfosSupp"
        Me.lblInfosSupp.Size = New System.Drawing.Size(694, 50)
        Me.lblInfosSupp.TabIndex = 28
        Me.lblInfosSupp.Text = "Troubles du comportement : ....................................."
        Me.lblInfosSupp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label, 10)
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(963, 43)
        Me.Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(359, 31)
        Me.Label.TabIndex = 26
        Me.Label.Text = "Date de denière mise à jour :"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label12, 8)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(31, 1238)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(392, 31)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Informations supplémentaires  :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTaille
        '
        Me.lblTaille.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblTaille, 2)
        Me.lblTaille.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaille.Location = New System.Drawing.Point(456, 545)
        Me.lblTaille.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTaille.Name = "lblTaille"
        Me.lblTaille.Size = New System.Drawing.Size(0, 31)
        Me.lblTaille.TabIndex = 14
        Me.lblTaille.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPoids
        '
        Me.lblPoids.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblPoids, 2)
        Me.lblPoids.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoids.Location = New System.Drawing.Point(456, 483)
        Me.lblPoids.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPoids.Name = "lblPoids"
        Me.lblPoids.Size = New System.Drawing.Size(0, 31)
        Me.lblPoids.TabIndex = 13
        Me.lblPoids.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Button1, 4)
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(4, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Button1, 2)
        Me.Button1.Size = New System.Drawing.Size(257, 78)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label5, 4)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 272)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(254, 31)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Date de naissance :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label3, 4)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 334)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 31)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Assurance maladie :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label4, 3)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 396)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 31)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dossier hôpital :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label6, 2)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 483)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 31)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Poids :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label7, 2)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 545)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 31)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Taille :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 148)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 210)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Prénom :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pbPhoto
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.pbPhoto, 8)
        Me.pbPhoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbPhoto.Location = New System.Drawing.Point(1007, 152)
        Me.pbPhoto.Margin = New System.Windows.Forms.Padding(4)
        Me.pbPhoto.Name = "pbPhoto"
        Me.TableLayoutPanel1.SetRowSpan(Me.pbPhoto, 4)
        Me.pbPhoto.Size = New System.Drawing.Size(277, 240)
        Me.pbPhoto.TabIndex = 25
        Me.pbPhoto.TabStop = False
        '
        'txtNom
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtNom, 6)
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(348, 151)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(343, 38)
        Me.txtNom.TabIndex = 51
        '
        'txtAssuranceMaladie
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtAssuranceMaladie, 3)
        Me.txtAssuranceMaladie.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssuranceMaladie.Location = New System.Drawing.Point(348, 337)
        Me.txtAssuranceMaladie.Name = "txtAssuranceMaladie"
        Me.txtAssuranceMaladie.Size = New System.Drawing.Size(286, 38)
        Me.txtAssuranceMaladie.TabIndex = 54
        '
        'txtDossierHopital
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtDossierHopital, 3)
        Me.txtDossierHopital.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDossierHopital.Location = New System.Drawing.Point(348, 399)
        Me.txtDossierHopital.Name = "txtDossierHopital"
        Me.txtDossierHopital.Size = New System.Drawing.Size(286, 38)
        Me.txtDossierHopital.TabIndex = 55
        '
        'dtpDateNaissance
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.dtpDateNaissance, 3)
        Me.dtpDateNaissance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateNaissance.Location = New System.Drawing.Point(348, 275)
        Me.dtpDateNaissance.Name = "dtpDateNaissance"
        Me.dtpDateNaissance.Size = New System.Drawing.Size(304, 38)
        Me.dtpDateNaissance.TabIndex = 56
        '
        'dtpDateMaj
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.dtpDateMaj, 8)
        Me.dtpDateMaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateMaj.Location = New System.Drawing.Point(962, 89)
        Me.dtpDateMaj.Name = "dtpDateMaj"
        Me.dtpDateMaj.Size = New System.Drawing.Size(306, 38)
        Me.dtpDateMaj.TabIndex = 57
        '
        'btnAjouterPhoto
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnAjouterPhoto, 2)
        Me.btnAjouterPhoto.Location = New System.Drawing.Point(1006, 399)
        Me.btnAjouterPhoto.Name = "btnAjouterPhoto"
        Me.btnAjouterPhoto.Size = New System.Drawing.Size(102, 47)
        Me.btnAjouterPhoto.TabIndex = 58
        Me.btnAjouterPhoto.Text = "Ajouter"
        Me.btnAjouterPhoto.UseVisualStyleBackColor = True
        '
        'btnSupprimerPhoto
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnSupprimerPhoto, 4)
        Me.btnSupprimerPhoto.Location = New System.Drawing.Point(1193, 399)
        Me.btnSupprimerPhoto.Name = "btnSupprimerPhoto"
        Me.btnSupprimerPhoto.Size = New System.Drawing.Size(92, 47)
        Me.btnSupprimerPhoto.TabIndex = 59
        Me.btnSupprimerPhoto.Text = "Supprimer"
        Me.btnSupprimerPhoto.UseVisualStyleBackColor = True
        '
        'txtPoids
        '
        Me.txtPoids.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoids.Location = New System.Drawing.Point(188, 486)
        Me.txtPoids.Name = "txtPoids"
        Me.txtPoids.Size = New System.Drawing.Size(72, 38)
        Me.txtPoids.TabIndex = 60
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label23, 2)
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(269, 483)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(78, 31)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "livres"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTaille
        '
        Me.txtTaille.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaille.Location = New System.Drawing.Point(188, 548)
        Me.txtTaille.Name = "txtTaille"
        Me.txtTaille.Size = New System.Drawing.Size(72, 38)
        Me.txtTaille.TabIndex = 63
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label24, 2)
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(269, 545)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 31)
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
        Me.grpAntecedentsMedicaux.Location = New System.Drawing.Point(31, 611)
        Me.grpAntecedentsMedicaux.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAntecedentsMedicaux.Name = "grpAntecedentsMedicaux"
        Me.grpAntecedentsMedicaux.Padding = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.SetRowSpan(Me.grpAntecedentsMedicaux, 3)
        Me.grpAntecedentsMedicaux.Size = New System.Drawing.Size(620, 273)
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
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(4, 23)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 3
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(612, 246)
        Me.TableLayoutPanel7.TabIndex = 65
        '
        'cboMaladies
        '
        Me.cboMaladies.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.SetColumnSpan(Me.cboMaladies, 4)
        Me.cboMaladies.Enabled = False
        Me.cboMaladies.FormattingEnabled = True
        Me.cboMaladies.Items.AddRange(New Object() {"Maison", "Cellulaire", "Bureau"})
        Me.cboMaladies.Location = New System.Drawing.Point(4, 4)
        Me.cboMaladies.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMaladies.MaxLength = 50
        Me.cboMaladies.Name = "cboMaladies"
        Me.cboMaladies.Size = New System.Drawing.Size(604, 28)
        Me.cboMaladies.TabIndex = 11
        '
        'lstMedicaux
        '
        Me.lstMedicaux.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.TableLayoutPanel7.SetColumnSpan(Me.lstMedicaux, 4)
        Me.lstMedicaux.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstMedicaux.FullRowSelect = True
        Me.lstMedicaux.Location = New System.Drawing.Point(4, 72)
        Me.lstMedicaux.Margin = New System.Windows.Forms.Padding(4)
        Me.lstMedicaux.MultiSelect = False
        Me.lstMedicaux.Name = "lstMedicaux"
        Me.lstMedicaux.Size = New System.Drawing.Size(604, 170)
        Me.lstMedicaux.TabIndex = 62
        Me.lstMedicaux.UseCompatibleStateImageBehavior = False
        Me.lstMedicaux.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Maladie"
        Me.ColumnHeader1.Width = 599
        '
        'btnAjouterMedicaux
        '
        Me.btnAjouterMedicaux.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAjouterMedicaux.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAjouterMedicaux.Enabled = False
        Me.btnAjouterMedicaux.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAjouterMedicaux.Location = New System.Drawing.Point(377, 36)
        Me.btnAjouterMedicaux.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAjouterMedicaux.Name = "btnAjouterMedicaux"
        Me.btnAjouterMedicaux.Size = New System.Drawing.Size(109, 28)
        Me.btnAjouterMedicaux.TabIndex = 61
        Me.btnAjouterMedicaux.Text = "Ajouter"
        Me.btnAjouterMedicaux.UseVisualStyleBackColor = False
        '
        'btnSupprimerMedicaux
        '
        Me.btnSupprimerMedicaux.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSupprimerMedicaux.Enabled = False
        Me.btnSupprimerMedicaux.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupprimerMedicaux.Location = New System.Drawing.Point(494, 36)
        Me.btnSupprimerMedicaux.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSupprimerMedicaux.Name = "btnSupprimerMedicaux"
        Me.btnSupprimerMedicaux.Size = New System.Drawing.Size(114, 28)
        Me.btnSupprimerMedicaux.TabIndex = 63
        Me.btnSupprimerMedicaux.Text = "Supprimer"
        Me.btnSupprimerMedicaux.UseVisualStyleBackColor = False
        '
        'grpAntecedentsChirurgicaux
        '
        Me.grpAntecedentsChirurgicaux.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAntecedentsChirurgicaux.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.grpAntecedentsChirurgicaux, 11)
        Me.grpAntecedentsChirurgicaux.Controls.Add(Me.TableLayoutPanel2)
        Me.grpAntecedentsChirurgicaux.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAntecedentsChirurgicaux.Location = New System.Drawing.Point(733, 611)
        Me.grpAntecedentsChirurgicaux.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAntecedentsChirurgicaux.Name = "grpAntecedentsChirurgicaux"
        Me.grpAntecedentsChirurgicaux.Padding = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.SetRowSpan(Me.grpAntecedentsChirurgicaux, 3)
        Me.grpAntecedentsChirurgicaux.Size = New System.Drawing.Size(551, 275)
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 23)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(543, 248)
        Me.TableLayoutPanel2.TabIndex = 65
        '
        'cboChirurgicaux
        '
        Me.cboChirurgicaux.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.cboChirurgicaux, 4)
        Me.cboChirurgicaux.Enabled = False
        Me.cboChirurgicaux.FormattingEnabled = True
        Me.cboChirurgicaux.Items.AddRange(New Object() {"Maison", "Cellulaire", "Bureau"})
        Me.cboChirurgicaux.Location = New System.Drawing.Point(4, 4)
        Me.cboChirurgicaux.Margin = New System.Windows.Forms.Padding(4)
        Me.cboChirurgicaux.MaxLength = 50
        Me.cboChirurgicaux.Name = "cboChirurgicaux"
        Me.cboChirurgicaux.Size = New System.Drawing.Size(535, 28)
        Me.cboChirurgicaux.TabIndex = 11
        '
        'lstChirurgicaux
        '
        Me.lstChirurgicaux.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.TableLayoutPanel2.SetColumnSpan(Me.lstChirurgicaux, 4)
        Me.lstChirurgicaux.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstChirurgicaux.FullRowSelect = True
        Me.lstChirurgicaux.Location = New System.Drawing.Point(4, 76)
        Me.lstChirurgicaux.Margin = New System.Windows.Forms.Padding(4)
        Me.lstChirurgicaux.MultiSelect = False
        Me.lstChirurgicaux.Name = "lstChirurgicaux"
        Me.lstChirurgicaux.Size = New System.Drawing.Size(535, 170)
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
        Me.btnSupprimerChirurgicaux.Location = New System.Drawing.Point(439, 40)
        Me.btnSupprimerChirurgicaux.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSupprimerChirurgicaux.Name = "btnSupprimerChirurgicaux"
        Me.btnSupprimerChirurgicaux.Size = New System.Drawing.Size(100, 28)
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
        Me.btnAjouterChirurgicaux.Location = New System.Drawing.Point(322, 40)
        Me.btnAjouterChirurgicaux.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAjouterChirurgicaux.Name = "btnAjouterChirurgicaux"
        Me.btnAjouterChirurgicaux.Size = New System.Drawing.Size(109, 28)
        Me.btnAjouterChirurgicaux.TabIndex = 61
        Me.btnAjouterChirurgicaux.Text = "Ajouter"
        Me.btnAjouterChirurgicaux.UseVisualStyleBackColor = False
        '
        'grpAntecedentsPsychiatriques
        '
        Me.grpAntecedentsPsychiatriques.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAntecedentsPsychiatriques.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.grpAntecedentsPsychiatriques, 7)
        Me.grpAntecedentsPsychiatriques.Controls.Add(Me.TableLayoutPanel3)
        Me.grpAntecedentsPsychiatriques.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAntecedentsPsychiatriques.Location = New System.Drawing.Point(31, 927)
        Me.grpAntecedentsPsychiatriques.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAntecedentsPsychiatriques.Name = "grpAntecedentsPsychiatriques"
        Me.grpAntecedentsPsychiatriques.Padding = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.SetRowSpan(Me.grpAntecedentsPsychiatriques, 5)
        Me.grpAntecedentsPsychiatriques.Size = New System.Drawing.Size(620, 277)
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 23)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(612, 250)
        Me.TableLayoutPanel3.TabIndex = 65
        '
        'cboMaladiesMentales
        '
        Me.cboMaladiesMentales.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.SetColumnSpan(Me.cboMaladiesMentales, 4)
        Me.cboMaladiesMentales.Enabled = False
        Me.cboMaladiesMentales.FormattingEnabled = True
        Me.cboMaladiesMentales.Items.AddRange(New Object() {"Maison", "Cellulaire", "Bureau"})
        Me.cboMaladiesMentales.Location = New System.Drawing.Point(4, 4)
        Me.cboMaladiesMentales.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMaladiesMentales.MaxLength = 50
        Me.cboMaladiesMentales.Name = "cboMaladiesMentales"
        Me.cboMaladiesMentales.Size = New System.Drawing.Size(604, 28)
        Me.cboMaladiesMentales.TabIndex = 11
        '
        'lstPsychiatriques
        '
        Me.lstPsychiatriques.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.TableLayoutPanel3.SetColumnSpan(Me.lstPsychiatriques, 4)
        Me.lstPsychiatriques.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPsychiatriques.FullRowSelect = True
        Me.lstPsychiatriques.Location = New System.Drawing.Point(4, 76)
        Me.lstPsychiatriques.Margin = New System.Windows.Forms.Padding(4)
        Me.lstPsychiatriques.MultiSelect = False
        Me.lstPsychiatriques.Name = "lstPsychiatriques"
        Me.lstPsychiatriques.Size = New System.Drawing.Size(604, 170)
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
        Me.btnSuppirmerPsychiatriques.Location = New System.Drawing.Point(494, 40)
        Me.btnSuppirmerPsychiatriques.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSuppirmerPsychiatriques.Name = "btnSuppirmerPsychiatriques"
        Me.btnSuppirmerPsychiatriques.Size = New System.Drawing.Size(114, 28)
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
        Me.btnAjouterPsychiatriques.Location = New System.Drawing.Point(377, 40)
        Me.btnAjouterPsychiatriques.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAjouterPsychiatriques.Name = "btnAjouterPsychiatriques"
        Me.btnAjouterPsychiatriques.Size = New System.Drawing.Size(109, 28)
        Me.btnAjouterPsychiatriques.TabIndex = 61
        Me.btnAjouterPsychiatriques.Text = "Ajouter"
        Me.btnAjouterPsychiatriques.UseVisualStyleBackColor = False
        '
        'grpAllergies
        '
        Me.grpAllergies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAllergies.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.grpAllergies, 11)
        Me.grpAllergies.Controls.Add(Me.TableLayoutPanel4)
        Me.grpAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAllergies.Location = New System.Drawing.Point(733, 927)
        Me.grpAllergies.Margin = New System.Windows.Forms.Padding(4)
        Me.grpAllergies.Name = "grpAllergies"
        Me.grpAllergies.Padding = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.SetRowSpan(Me.grpAllergies, 5)
        Me.grpAllergies.Size = New System.Drawing.Size(551, 277)
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
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(4, 23)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(543, 250)
        Me.TableLayoutPanel4.TabIndex = 65
        '
        'cboAllergies
        '
        Me.cboAllergies.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.SetColumnSpan(Me.cboAllergies, 4)
        Me.cboAllergies.Enabled = False
        Me.cboAllergies.FormattingEnabled = True
        Me.cboAllergies.Items.AddRange(New Object() {"Maison", "Cellulaire", "Bureau"})
        Me.cboAllergies.Location = New System.Drawing.Point(4, 4)
        Me.cboAllergies.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAllergies.MaxLength = 50
        Me.cboAllergies.Name = "cboAllergies"
        Me.cboAllergies.Size = New System.Drawing.Size(535, 28)
        Me.cboAllergies.TabIndex = 11
        '
        'lstAllergies
        '
        Me.lstAllergies.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.TableLayoutPanel4.SetColumnSpan(Me.lstAllergies, 4)
        Me.lstAllergies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstAllergies.FullRowSelect = True
        Me.lstAllergies.Location = New System.Drawing.Point(4, 76)
        Me.lstAllergies.Margin = New System.Windows.Forms.Padding(4)
        Me.lstAllergies.MultiSelect = False
        Me.lstAllergies.Name = "lstAllergies"
        Me.lstAllergies.Size = New System.Drawing.Size(535, 170)
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
        Me.btnSupprimerAllergie.Location = New System.Drawing.Point(439, 40)
        Me.btnSupprimerAllergie.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSupprimerAllergie.Name = "btnSupprimerAllergie"
        Me.btnSupprimerAllergie.Size = New System.Drawing.Size(100, 28)
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
        Me.btnAjouterAllergie.Location = New System.Drawing.Point(322, 40)
        Me.btnAjouterAllergie.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAjouterAllergie.Name = "btnAjouterAllergie"
        Me.btnAjouterAllergie.Size = New System.Drawing.Size(109, 28)
        Me.btnAjouterAllergie.TabIndex = 61
        Me.btnAjouterAllergie.Text = "Ajouter"
        Me.btnAjouterAllergie.UseVisualStyleBackColor = False
        '
        'chkComportement
        '
        Me.chkComportement.AutoSize = True
        Me.chkComportement.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkComportement.Location = New System.Drawing.Point(732, 1302)
        Me.chkComportement.Name = "chkComportement"
        Me.chkComportement.Size = New System.Drawing.Size(78, 35)
        Me.chkComportement.TabIndex = 146
        Me.chkComportement.Text = "Oui"
        Me.chkComportement.UseVisualStyleBackColor = True
        '
        'chkDesorientation
        '
        Me.chkDesorientation.AutoSize = True
        Me.chkDesorientation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDesorientation.Location = New System.Drawing.Point(732, 1377)
        Me.chkDesorientation.Name = "chkDesorientation"
        Me.chkDesorientation.Size = New System.Drawing.Size(78, 35)
        Me.chkDesorientation.TabIndex = 147
        Me.chkDesorientation.Text = "Oui"
        Me.chkDesorientation.UseVisualStyleBackColor = True
        '
        'chkFugue
        '
        Me.chkFugue.AutoSize = True
        Me.chkFugue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFugue.Location = New System.Drawing.Point(732, 1452)
        Me.chkFugue.Name = "chkFugue"
        Me.chkFugue.Size = New System.Drawing.Size(78, 35)
        Me.chkFugue.TabIndex = 148
        Me.chkFugue.Text = "Oui"
        Me.chkFugue.UseVisualStyleBackColor = True
        '
        'chkContention
        '
        Me.chkContention.AutoSize = True
        Me.chkContention.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkContention.Location = New System.Drawing.Point(732, 1527)
        Me.chkContention.Name = "chkContention"
        Me.chkContention.Size = New System.Drawing.Size(78, 35)
        Me.chkContention.TabIndex = 149
        Me.chkContention.Text = "Oui"
        Me.chkContention.UseVisualStyleBackColor = True
        '
        'chkCutane
        '
        Me.chkCutane.AutoSize = True
        Me.chkCutane.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCutane.Location = New System.Drawing.Point(732, 1602)
        Me.chkCutane.Name = "chkCutane"
        Me.chkCutane.Size = New System.Drawing.Size(78, 35)
        Me.chkCutane.TabIndex = 150
        Me.chkCutane.Text = "Oui"
        Me.chkCutane.UseVisualStyleBackColor = True
        '
        'chkAideTechnique
        '
        Me.chkAideTechnique.AutoSize = True
        Me.chkAideTechnique.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAideTechnique.Location = New System.Drawing.Point(732, 1677)
        Me.chkAideTechnique.Name = "chkAideTechnique"
        Me.chkAideTechnique.Size = New System.Drawing.Size(78, 35)
        Me.chkAideTechnique.TabIndex = 151
        Me.chkAideTechnique.Text = "Oui"
        Me.chkAideTechnique.UseVisualStyleBackColor = True
        '
        'chkProtection
        '
        Me.chkProtection.AutoSize = True
        Me.chkProtection.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProtection.Location = New System.Drawing.Point(732, 1752)
        Me.chkProtection.Name = "chkProtection"
        Me.chkProtection.Size = New System.Drawing.Size(78, 35)
        Me.chkProtection.TabIndex = 152
        Me.chkProtection.Text = "Oui"
        Me.chkProtection.UseVisualStyleBackColor = True
        '
        'chkAppareilAuditif
        '
        Me.chkAppareilAuditif.AutoSize = True
        Me.chkAppareilAuditif.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAppareilAuditif.Location = New System.Drawing.Point(732, 1827)
        Me.chkAppareilAuditif.Name = "chkAppareilAuditif"
        Me.chkAppareilAuditif.Size = New System.Drawing.Size(78, 35)
        Me.chkAppareilAuditif.TabIndex = 153
        Me.chkAppareilAuditif.Text = "Oui"
        Me.chkAppareilAuditif.UseVisualStyleBackColor = True
        '
        'chkProtheses
        '
        Me.chkProtheses.AutoSize = True
        Me.chkProtheses.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProtheses.Location = New System.Drawing.Point(732, 1902)
        Me.chkProtheses.Name = "chkProtheses"
        Me.chkProtheses.Size = New System.Drawing.Size(78, 35)
        Me.chkProtheses.TabIndex = 154
        Me.chkProtheses.Text = "Oui"
        Me.chkProtheses.UseVisualStyleBackColor = True
        '
        'chkLunettes
        '
        Me.chkLunettes.AutoSize = True
        Me.chkLunettes.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLunettes.Location = New System.Drawing.Point(732, 1977)
        Me.chkLunettes.Name = "chkLunettes"
        Me.chkLunettes.Size = New System.Drawing.Size(78, 35)
        Me.chkLunettes.TabIndex = 155
        Me.chkLunettes.Text = "Oui"
        Me.chkLunettes.UseVisualStyleBackColor = True
        '
        'txtComportement
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtComportement, 8)
        Me.txtComportement.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComportement.Location = New System.Drawing.Point(962, 1302)
        Me.txtComportement.Name = "txtComportement"
        Me.txtComportement.Size = New System.Drawing.Size(306, 38)
        Me.txtComportement.TabIndex = 156
        '
        'lblComportement
        '
        Me.lblComportement.AutoSize = True
        Me.lblComportement.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComportement.Location = New System.Drawing.Point(818, 1299)
        Me.lblComportement.Name = "lblComportement"
        Me.lblComportement.Size = New System.Drawing.Size(134, 31)
        Me.lblComportement.TabIndex = 157
        Me.lblComportement.Text = "Précisez :"
        '
        'txtContention
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtContention, 8)
        Me.txtContention.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContention.Location = New System.Drawing.Point(962, 1527)
        Me.txtContention.Name = "txtContention"
        Me.txtContention.Size = New System.Drawing.Size(306, 38)
        Me.txtContention.TabIndex = 158
        '
        'lblContention
        '
        Me.lblContention.AutoSize = True
        Me.lblContention.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContention.Location = New System.Drawing.Point(818, 1524)
        Me.lblContention.Name = "lblContention"
        Me.lblContention.Size = New System.Drawing.Size(134, 31)
        Me.lblContention.TabIndex = 159
        Me.lblContention.Text = "Précisez :"
        '
        'chkBas
        '
        Me.chkBas.AutoSize = True
        Me.chkBas.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBas.Location = New System.Drawing.Point(818, 1902)
        Me.chkBas.Name = "chkBas"
        Me.chkBas.Size = New System.Drawing.Size(122, 35)
        Me.chkBas.TabIndex = 160
        Me.chkBas.Text = "En-bas"
        Me.chkBas.UseVisualStyleBackColor = True
        '
        'chkHaut
        '
        Me.chkHaut.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.chkHaut, 2)
        Me.chkHaut.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHaut.Location = New System.Drawing.Point(962, 1902)
        Me.chkHaut.Name = "chkHaut"
        Me.chkHaut.Size = New System.Drawing.Size(131, 35)
        Me.chkHaut.TabIndex = 161
        Me.chkHaut.Text = "En-haut"
        Me.chkHaut.UseVisualStyleBackColor = True
        '
        'chkDeux
        '
        Me.chkDeux.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.chkDeux, 7)
        Me.chkDeux.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDeux.Location = New System.Drawing.Point(1112, 1902)
        Me.chkDeux.Name = "chkDeux"
        Me.chkDeux.Size = New System.Drawing.Size(145, 35)
        Me.chkDeux.TabIndex = 162
        Me.chkDeux.Text = "Les deux"
        Me.chkDeux.UseVisualStyleBackColor = True
        '
        'lblAideTechnique
        '
        Me.lblAideTechnique.AutoSize = True
        Me.lblAideTechnique.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAideTechnique.Location = New System.Drawing.Point(818, 1674)
        Me.lblAideTechnique.Name = "lblAideTechnique"
        Me.lblAideTechnique.Size = New System.Drawing.Size(134, 31)
        Me.lblAideTechnique.TabIndex = 164
        Me.lblAideTechnique.Text = "Précisez :"
        '
        'txtAideTechnique
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtAideTechnique, 8)
        Me.txtAideTechnique.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAideTechnique.Location = New System.Drawing.Point(962, 1677)
        Me.txtAideTechnique.Name = "txtAideTechnique"
        Me.txtAideTechnique.Size = New System.Drawing.Size(306, 38)
        Me.txtAideTechnique.TabIndex = 163
        '
        'grpRessources
        '
        Me.grpRessources.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRessources.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.grpRessources, 7)
        Me.grpRessources.Controls.Add(Me.TableLayoutPanel5)
        Me.grpRessources.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRessources.Location = New System.Drawing.Point(31, 2061)
        Me.grpRessources.Margin = New System.Windows.Forms.Padding(4)
        Me.grpRessources.Name = "grpRessources"
        Me.grpRessources.Padding = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.SetRowSpan(Me.grpRessources, 5)
        Me.grpRessources.Size = New System.Drawing.Size(620, 352)
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
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(4, 23)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 7
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(612, 325)
        Me.TableLayoutPanel5.TabIndex = 65
        '
        'lstRessource
        '
        Me.lstRessource.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.TableLayoutPanel5.SetColumnSpan(Me.lstRessource, 4)
        Me.lstRessource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstRessource.FullRowSelect = True
        Me.lstRessource.Location = New System.Drawing.Point(4, 152)
        Me.lstRessource.Margin = New System.Windows.Forms.Padding(4)
        Me.lstRessource.MultiSelect = False
        Me.lstRessource.Name = "lstRessource"
        Me.lstRessource.Size = New System.Drawing.Size(604, 170)
        Me.lstRessource.TabIndex = 62
        Me.lstRessource.UseCompatibleStateImageBehavior = False
        Me.lstRessource.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nom"
        Me.ColumnHeader5.Width = 209
        '
        'btnSupprimerRessource
        '
        Me.btnSupprimerRessource.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSupprimerRessource.Enabled = False
        Me.btnSupprimerRessource.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSupprimerRessource.Location = New System.Drawing.Point(494, 116)
        Me.btnSupprimerRessource.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSupprimerRessource.Name = "btnSupprimerRessource"
        Me.btnSupprimerRessource.Size = New System.Drawing.Size(114, 28)
        Me.btnSupprimerRessource.TabIndex = 63
        Me.btnSupprimerRessource.Text = "Supprimer"
        Me.btnSupprimerRessource.UseVisualStyleBackColor = False
        '
        'AjouterRessource
        '
        Me.AjouterRessource.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AjouterRessource.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TableLayoutPanel5.SetColumnSpan(Me.AjouterRessource, 2)
        Me.AjouterRessource.Enabled = False
        Me.AjouterRessource.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AjouterRessource.Location = New System.Drawing.Point(370, 116)
        Me.AjouterRessource.Margin = New System.Windows.Forms.Padding(4)
        Me.AjouterRessource.Name = "AjouterRessource"
        Me.AjouterRessource.Size = New System.Drawing.Size(116, 28)
        Me.AjouterRessource.TabIndex = 61
        Me.AjouterRessource.Text = "Ajouter"
        Me.AjouterRessource.UseVisualStyleBackColor = False
        '
        'grpMedicaments
        '
        Me.grpMedicaments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMedicaments.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.grpMedicaments, 11)
        Me.grpMedicaments.Controls.Add(Me.TableLayoutPanel6)
        Me.grpMedicaments.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMedicaments.Location = New System.Drawing.Point(733, 2061)
        Me.grpMedicaments.Margin = New System.Windows.Forms.Padding(4)
        Me.grpMedicaments.Name = "grpMedicaments"
        Me.grpMedicaments.Padding = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.SetRowSpan(Me.grpMedicaments, 5)
        Me.grpMedicaments.Size = New System.Drawing.Size(551, 277)
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
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(4, 23)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(543, 250)
        Me.TableLayoutPanel6.TabIndex = 65
        '
        'cboMedicaments
        '
        Me.cboMedicaments.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.SetColumnSpan(Me.cboMedicaments, 4)
        Me.cboMedicaments.Enabled = False
        Me.cboMedicaments.FormattingEnabled = True
        Me.cboMedicaments.Items.AddRange(New Object() {"Maison", "Cellulaire", "Bureau"})
        Me.cboMedicaments.Location = New System.Drawing.Point(4, 4)
        Me.cboMedicaments.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMedicaments.MaxLength = 50
        Me.cboMedicaments.Name = "cboMedicaments"
        Me.cboMedicaments.Size = New System.Drawing.Size(535, 28)
        Me.cboMedicaments.TabIndex = 11
        '
        'lstMedicaments
        '
        Me.lstMedicaments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6})
        Me.TableLayoutPanel6.SetColumnSpan(Me.lstMedicaments, 4)
        Me.lstMedicaments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstMedicaments.FullRowSelect = True
        Me.lstMedicaments.Location = New System.Drawing.Point(4, 76)
        Me.lstMedicaments.Margin = New System.Windows.Forms.Padding(4)
        Me.lstMedicaments.MultiSelect = False
        Me.lstMedicaments.Name = "lstMedicaments"
        Me.lstMedicaments.Size = New System.Drawing.Size(535, 170)
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
        Me.btnSupprimerMedicaments.Location = New System.Drawing.Point(439, 40)
        Me.btnSupprimerMedicaments.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSupprimerMedicaments.Name = "btnSupprimerMedicaments"
        Me.btnSupprimerMedicaments.Size = New System.Drawing.Size(100, 28)
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
        Me.btnAjouterMedicaments.Location = New System.Drawing.Point(322, 40)
        Me.btnAjouterMedicaments.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAjouterMedicaments.Name = "btnAjouterMedicaments"
        Me.btnAjouterMedicaments.Size = New System.Drawing.Size(109, 28)
        Me.btnAjouterMedicaments.TabIndex = 61
        Me.btnAjouterMedicaments.Text = "Ajouter"
        Me.btnAjouterMedicaments.UseVisualStyleBackColor = False
        '
        'txtNomRessource
        '
        Me.txtNomRessource.Location = New System.Drawing.Point(3, 23)
        Me.txtNomRessource.Name = "txtNomRessource"
        Me.txtNomRessource.Size = New System.Drawing.Size(190, 26)
        Me.txtNomRessource.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 20)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Nom"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(210, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Prenom"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(210, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(174, 26)
        Me.TextBox1.TabIndex = 67
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 20)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Téléphone"
        '
        'txtTelephoneRessource
        '
        Me.txtTelephoneRessource.Location = New System.Drawing.Point(3, 75)
        Me.txtTelephoneRessource.Name = "txtTelephoneRessource"
        Me.txtTelephoneRessource.Size = New System.Drawing.Size(190, 26)
        Me.txtTelephoneRessource.TabIndex = 69
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(210, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 20)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Poste"
        '
        'txtPosteRessource
        '
        Me.txtPosteRessource.Location = New System.Drawing.Point(210, 75)
        Me.txtPosteRessource.Name = "txtPosteRessource"
        Me.txtPosteRessource.Size = New System.Drawing.Size(102, 26)
        Me.txtPosteRessource.TabIndex = 71
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
        'controlSaisie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "controlSaisie"
        Me.Size = New System.Drawing.Size(1361, 2215)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAntecedentsMedicaux.ResumeLayout(False)
        Me.grpAntecedentsMedicaux.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.grpAntecedentsChirurgicaux.ResumeLayout(False)
        Me.grpAntecedentsChirurgicaux.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.grpAntecedentsPsychiatriques.ResumeLayout(False)
        Me.grpAntecedentsPsychiatriques.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.grpAllergies.ResumeLayout(False)
        Me.grpAllergies.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.grpRessources.ResumeLayout(False)
        Me.grpRessources.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
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
    Friend WithEvents Label As Label
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
    Friend WithEvents dtpDateMaj As DateTimePicker
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
End Class
