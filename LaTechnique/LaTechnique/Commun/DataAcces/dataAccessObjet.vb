﻿Imports MySql.Data.MySqlClient

Public Class dataAccessObjet
#Region "variables"

    'Variable représentant la base de données
    Private v_bd As clsBDconnection
    'Variable représentant le dataSet
    Private v_ds As DataSet
    'Variable représentant le dataAdapteur
    Private v_da As MySqlDataAdapter
    'Variable représentant la requête à faire
    Private v_requete As String
#End Region

#Region "property"

    Public ReadOnly Property ds As DataSet
        Get
            If v_ds Is Nothing Then v_ds = New DataSet
            Return v_ds
        End Get
    End Property

    Public ReadOnly Property da As MySqlDataAdapter
        Get
            If v_da Is Nothing Then v_da = New MySqlDataAdapter
            Return v_da
        End Get
    End Property

    Public ReadOnly Property bd As clsBDconnection
        Get
            If v_bd Is Nothing Then v_bd = New clsBDconnection
            Return v_bd
        End Get
    End Property

    Protected Property requete As String
        Get
            Return v_requete
        End Get
        Set(value As String)
            v_requete = value
        End Set
    End Property
#End Region
End Class
