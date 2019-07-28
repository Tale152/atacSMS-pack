Namespace RS
    Public Class Subaccount
        Public Shared HAS_CREDIT As Integer = 0
        Public Shared USE_SUPER_CREDIT As Integer = 1
        Public Shared USE_BOTH_CREDITS As Integer = 2
        Private m_credit_mode As Integer
        Private m_company_name As [String]
        Private m_fiscal_code As [String]
        Private m_vat_number As [String]
        Private m_name As [String]
        Private m_surname As [String]
        Private m_email As [String]
        Private m_address As [String]
        Private m_city As [String]
        Private m_province As [String]
        Private m_zip As [String]
        Private m_mobile As [String]
        Private m_login As [String]
        Private m_password As [String]
        Private m_active As [Boolean]
        Private subaccount_type As SUBACCOUNT_TYPES = DEFAULT_SUBACCOUNT_TYPE

        Public Property Credit_mode() As Integer
            Get
                Return Me.m_credit_mode
            End Get
            Set(ByVal value As Integer)
                Me.m_credit_mode = value
            End Set
        End Property

        Public Sub setSubaccountHasCredits()
            Me.m_credit_mode = HAS_CREDIT
        End Sub
        Public Sub setSubaccountUseSuperaccountCredit()
            Me.m_credit_mode = USE_SUPER_CREDIT
        End Sub
        Public Sub setSubaccountUseBothCredits()
            Me.m_credit_mode = USE_BOTH_CREDITS
        End Sub
        Public Property Company_name() As [String]
            Get
                Return Me.m_company_name
            End Get
            Set(ByVal value As [String])
                Me.m_company_name = value
            End Set
        End Property
        Public Property Fiscal_code() As [String]
            Get
                Return Me.m_fiscal_code
            End Get
            Set(ByVal value As [String])
                Me.m_fiscal_code = value
            End Set
        End Property
        Public Property Vat_number() As [String]
            Get
                Return Me.m_vat_number
            End Get
            Set(ByVal value As [String])
                Me.m_vat_number = value
            End Set
        End Property
        Public Property Name() As [String]
            Get
                Return Me.m_name
            End Get
            Set(ByVal value As [String])
                Me.m_name = value
            End Set
        End Property
        Public Property Surname() As [String]
            Get
                Return Me.m_surname
            End Get
            Set(ByVal value As [String])
                Me.m_surname = value
            End Set
        End Property
        Public Property Email() As [String]
            Get
                Return Me.m_email
            End Get
            Set(ByVal value As [String])
                Me.m_email = value
            End Set
        End Property
        Public Property Address() As [String]
            Get
                Return Me.m_address
            End Get
            Set(ByVal value As [String])
                Me.m_address = value
            End Set
        End Property
        Public Property City() As [String]
            Get
                Return Me.m_city
            End Get
            Set(ByVal value As [String])
                Me.m_city = value
            End Set
        End Property
        Public Property Province() As [String]
            Get
                Return Me.m_province
            End Get
            Set(ByVal value As [String])
                Me.m_province = value
            End Set
        End Property
        Public Property Zip() As [String]
            Get
                Return Me.m_zip
            End Get
            Set(ByVal value As [String])
                Me.m_zip = value
            End Set
        End Property
        Public Property Mobile() As [String]
            Get
                Return Me.m_mobile
            End Get
            Set(ByVal value As [String])
                Me.m_mobile = value
            End Set
        End Property
        Public Property Login() As [String]
            Get
                Return Me.m_login
            End Get
            Set(ByVal value As [String])
                Me.m_login = value
            End Set
        End Property
        Public Property Password() As [String]
            Get
                Return Me.m_password
            End Get
            Set(ByVal value As [String])
                Me.m_password = value
            End Set
        End Property
        Public Property Active() As [Boolean]
            Get
                Return Me.m_active
            End Get
            Set(ByVal value As [Boolean])
                Me.m_active = value
            End Set
        End Property
        Public Property SubaccountType() As [String]
            Get
                Return Me.subaccount_type.ToString().ToLower()
            End Get
            Set(ByVal value As [String])
                If value IsNot Nothing AndAlso value <> "" Then
                    Try
                        Me.subaccount_type = CType([Enum].Parse(GetType(SUBACCOUNT_TYPES), value.ToUpper(), True), SUBACCOUNT_TYPES)
                    Catch generatedExceptionName As Exception
                        Me.subaccount_type = DEFAULT_SUBACCOUNT_TYPE
                    End Try
                End If
            End Set
        End Property

        Public Enum SUBACCOUNT_TYPES
            COMPANY
            [PRIVATE]
        End Enum

        Private Shared DEFAULT_SUBACCOUNT_TYPE As SUBACCOUNT_TYPES = SUBACCOUNT_TYPES.COMPANY

    End Class
End Namespace
