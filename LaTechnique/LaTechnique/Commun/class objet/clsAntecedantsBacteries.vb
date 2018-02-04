﻿Public Class clsAntecedantsBacteries


    'Variables
    Private v_id_bacterie As Integer
    Private v_assurance_maladie As String

    'Propriétés
    Public Property id_bacterie As Integer
        Get
            Return v_id_bacterie
        End Get
        Set(ByVal value As Integer)
            v_id_bacterie = value
        End Set
    End Property

    Public Property assurance_maladie As Integer
        Get
            Return v_assurance_maladie
        End Get
        Set(ByVal value As Integer)
            v_assurance_maladie = value
        End Set
    End Property

    'Mapping
    Public Overloads Sub mapping(ByVal dataAccess As dataAccessObjet, ligne As Integer)
        With dataAccess.ds
            id_bacterie = verifierColonneDataSet(.Tables(0), ligne, constantes_antecedants_bacteries.STR_ID_ANTECEDANTS_BACTERIES)
            assurance_maladie = verifierColonneDataSet(.Tables(0), ligne, constantes_antecedants_bacteries.STR_ASSURANCE_MALADIE)
        End With
    End Sub

End Class
