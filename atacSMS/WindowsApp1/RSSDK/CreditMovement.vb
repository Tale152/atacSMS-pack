Namespace RS
    Public Class CreditMovement
        Private m_subaccount_login As [String]
        Private m_super_to_sub As [Boolean]
        Private m_amount As Integer
        Private m_sms_type As SMSType
        Private m_sms_types As SMSType()
        Private m_price As Double
        Private m_pricePerMessage As Double()
        Private m_is_donation As [Boolean] = False
        Private m_id_purchase As Long
        Private m_recording_date As DateTime
        Private m_availableAmount As Integer

        Public Property Subaccount_login() As [String]
            Get
                Return Me.m_subaccount_login
            End Get
            Set(ByVal value As [String])
                Me.m_subaccount_login = value
            End Set
        End Property
        Public Property Super_to_sub() As [Boolean]
            Get
                Return Me.m_super_to_sub
            End Get
            Set(ByVal value As [Boolean])
                Me.m_super_to_sub = value
            End Set
        End Property
        Public Property Amount() As Integer
            Get
                Return Me.m_amount
            End Get
            Set(ByVal value As Integer)
                Me.m_amount = value
            End Set
        End Property
        Public Property Sms_type() As SMSType
            Get
                Return Me.m_sms_type
            End Get
            Set(ByVal value As SMSType)
                Me.m_sms_type = value
            End Set
        End Property
        Public Property Sms_types() As SMSType()
            Get
                Return Me.m_sms_types
            End Get
            Set(ByVal value As SMSType())
                Me.m_sms_types = value
            End Set
        End Property
        Public Property Price() As Double
            Get
                Return Me.m_price
            End Get
            Set(ByVal value As Double)
                Me.m_price = value
            End Set
        End Property
        Public Property PricePerMessage() As Double()
            Get
                Return Me.m_pricePerMessage
            End Get
            Set(ByVal value As Double())
                Me.m_pricePerMessage = value
            End Set
        End Property
        Public Property Is_donation() As [Boolean]
            Get
                Return Me.m_is_donation
            End Get
            Set(ByVal value As [Boolean])
                Me.m_is_donation = value
            End Set
        End Property
        Public Property Id_purchase() As Long
            Get
                Return Me.m_id_purchase
            End Get
            Set(ByVal value As Long)
                Me.m_id_purchase = value
            End Set
        End Property
        Public Property Recording_date() As DateTime
            Get
                Return Me.m_recording_date
            End Get
            Set(ByVal value As DateTime)
                Me.m_recording_date = value
            End Set
        End Property
        Public Property AvailableAmount() As Integer
            Get
                Return Me.m_availableAmount
            End Get
            Set(ByVal value As Integer)
                Me.m_availableAmount = value
            End Set
        End Property

    End Class
End Namespace
