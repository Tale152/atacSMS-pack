Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Globalization

Namespace RS
    Public Class Nation
        Private m_iso3166 As String
        ' Country code in ISO 3166 standard.
        Private m_prefix As String
        ' International phone prefix.
        Public Sub New(ByVal iso3166 As String, ByVal prefix As String)
            Me.m_iso3166 = iso3166.ToUpper()
            Me.m_prefix = Str.stripNonNumeric(prefix)
        End Sub

        Public ReadOnly Property Iso3166() As String
            Get
                Return m_iso3166
            End Get
        End Property
        Public ReadOnly Property Prefix() As String
            Get
                Return m_prefix
            End Get
        End Property

        Public Overloads Overrides Function Equals(ByVal obj As [Object]) As Boolean
            If TypeOf obj Is Nation Then
                Dim tmp_nation As Nation = DirectCast(obj, Nation)
                Return tmp_nation.Iso3166.Equals(Me.Iso3166)
            End If
            If TypeOf obj Is String Then
                Dim iso3166 As String = DirectCast(obj, String)
                Return iso3166.Equals(Me.m_iso3166, StringComparison.OrdinalIgnoreCase)
            End If
            Return False
        End Function

        Public Overloads Overrides Function ToString() As String
            If Nations.NO_NATION.Equals(Me.m_iso3166) Then
                Return "no nation"
            End If
            If Nations.UNKNOWN_NATION.Equals(Me.m_iso3166) Then
                Return "unknown nation"
            End If
            Dim ri As New RegionInfo(Me.m_iso3166.ToUpper())
            Return ri.DisplayName
        End Function

        Public Shared Operator =(ByVal n1 As Nation, ByVal n2 As Nation) As Boolean
            Return n1.Equals(n2)
        End Operator
        Public Shared Operator <>(ByVal n1 As Nation, ByVal n2 As Nation) As Boolean
            Return Not (n1.Equals(n2))
        End Operator

        Public Overloads Overrides Function GetHashCode() As Integer
            Return MyBase.GetHashCode()
        End Function

    End Class

End Namespace
