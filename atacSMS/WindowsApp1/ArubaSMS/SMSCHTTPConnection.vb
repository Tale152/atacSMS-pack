Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace RS
    Public Class SMSCHTTPConnection
        Implements SMSCConnection
        Private username As String
        Private password As String
        Private hostname As String
        Private port As Integer
        Private connected As Boolean
        Private proxy As String
        Private proxyport As Integer

        Public Sub New(ByVal username As String, ByVal password As String, ByVal proxy As String, ByVal proxyport As Integer)
            Me.username = username
            Me.password = password
            Me.hostname = Config.HOSTNAME
            Me.port = Config.DEFAULT_PORT
            Me.proxy = proxy
            Me.proxyport = proxyport
            login()
        End Sub

        Public Sub New(ByVal username As String, ByVal password As String)
            Me.username = username
            Me.password = password
            Me.hostname = Config.HOSTNAME
            Me.port = Config.DEFAULT_PORT
            Me.proxy = Config.PROXY
            Me.proxyport = Config.PROXY_PORT
            login()
        End Sub
        Public Sub New()
            Me.username = Config.USERNAME
            Me.password = Config.PASSWORD
            Me.hostname = Config.HOSTNAME
            Me.port = Config.DEFAULT_PORT
            Me.proxy = Config.PROXY
            Me.proxyport = Config.PROXY_PORT
            login()
        End Sub
        Public Sub login() Implements SMSCConnection.login
            If Not hostname.StartsWith("http://") Then
                hostname = "http://" & hostname
            End If
            If hostname.EndsWith("/") Then
                hostname = hostname.Substring(0, hostname.Length - 1)
            End If
            If (port <> 80) AndAlso (port <> 0) Then
                hostname = (hostname & ":") & port
            End If
            Me.connected = False
            getCredits()
            ' just to check username+password correctness ...
            Me.connected = True
        End Sub
        Public Sub logout() Implements SMSCConnection.logout
            Me.connected = False
        End Sub

        Public Function getCredits() As List(Of Credit) Implements SMSCConnection.getCredits
            Dim rp As ResponseParser
            Dim credit As Credit
            Dim credits As List(Of Credit)
            Dim credit_type As CreditType
            rp = makeStdHTTPRequest(CREDITS_REQ, getBaseHTTPParams())
            credits = New List(Of Credit)()
            While rp.GoNextLine()
                credit_type = rp.NextCreditType
                credit = New Credit(credit_type, rp.NextNation, rp.NextInt)
                credits.Add(credit)
            End While
            Return credits
        End Function
        Public Function sendSMS(ByVal sms As SMS) As SendResult Implements SMSCConnection.sendSMS
            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("message", sms.Message)
            sparams.Add("message_type", sms.TypeOfSMS.Code)
            If sms.TypeOfSMS.CustomSender Then
                sparams.Add("sender", sms.SMSSender)
            End If
            If Not String.IsNullOrEmpty(sms.OrderId) Then
                sparams.Add("order_id", sms.OrderId)
            End If
            If String.IsNullOrEmpty(sms.StrRecipients) Then
                Dim recipient_list As New StringBuilder()
                Dim isfirst As Boolean = True
                For Each recipient As SMSRecipient In sms.Recipients
                    If isfirst Then
                        isfirst = False
                    Else
                        recipient_list.Append(","c)
                    End If
                    recipient_list.Append(recipient.getNumber())
                Next
                sparams.Add("recipient", recipient_list.ToString())
            Else
                sparams.Add("recipient", sms.StrRecipients)
            End If
            If Not sms.Immediate Then
                sparams.Add("scheduled_delivery_time", DDate.Format(sms.ScheduledDelivery))
            End If
            Dim rp As ResponseParser = makeStdHTTPRequest(SEND_SMS_REQ, sparams)
            Return New SendResult(rp.NextString, rp.NextInt)
        End Function
        Public Function removeScheduledSend(ByVal order_id As String) As Boolean
            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("order_id", order_id)
            makeStdHTTPRequest(REMOVE_DELAYED_REQ, sparams)
            Return True
        End Function
        Public Function getMessageStatus(ByVal order_id As String) As List(Of MessageStatus) Implements SMSCConnection.getMessageStatus
            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("order_id", order_id)
            Dim rp As ResponseParser = makeStdHTTPRequest(MSG_STATUS_REQ, sparams)
            Dim statuses As New List(Of MessageStatus)()
            While rp.GoNextLine()
                statuses.Add(New MessageStatus(rp.NextSMSRecipient, rp.NextMessageStatus_Status, rp.NextDate))
            End While
            Return statuses
        End Function
        Public Function getSMSHistory(ByVal from_date As DateTime, ByVal to_date As DateTime) As List(Of SentSMS) Implements SMSCConnection.getSMSHistory
            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("from", DDate.Format(from_date))
            sparams.Add("to", DDate.Format(to_date))
            Dim rp As ResponseParser = makeStdHTTPRequest(SMS_HISTORY_REQ, sparams)
            Dim sent_smss As New List(Of SentSMS)()
            While rp.GoNextLine()
                sent_smss.Add(New SentSMS(rp.NextString, rp.NextDate, rp.NextSMSType, rp.NextSMSSender, rp.NextInt, rp.NextOptionalDate))
            End While
            Return sent_smss
        End Function

        Public Function lookup(ByVal recipient As SMSRecipient) As LookupResult Implements SMSCConnection.lookup
            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("num", recipient.getNumber())
            Dim rp As ResponseParser = makeStdHTTPRequest(NUMBER_LOOKUP_REQ, sparams)
            Dim valid As Boolean = "valid".Equals(rp.NextString)
            Dim lr As LookupResult
            If valid Then
                lr = New LookupResult(rp.NextString, rp.NextSMSRecipient, rp.NextNation, rp.NextString, rp.NextString)
            Else
                lr = New LookupResult(rp.NextString)
            End If
            Return lr
        End Function

        Public Function getNewSMS_MOs() As List(Of SMS_MO) Implements SMSCConnection.getNewSMS_MOs
            Return getAllSMS_MO(makeStdHTTPRequest(NEW_SMS_MO_REQ, getBaseHTTPParams()))
        End Function
        Public Function getSMS_MOHistory(ByVal from_date As DateTime, ByVal to_date As DateTime) As List(Of SMS_MO) Implements SMSCConnection.getSMS_MOHistory
            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("date_from", DDate.Format(from_date))
            sparams.Add("date_to", DDate.Format(to_date))
            Return getAllSMS_MO(makeStdHTTPRequest(SMS_MO_HIST_REQ, sparams))
        End Function
        Public Function getSMS_MOById(ByVal message_id As Long) As List(Of SMS_MO) Implements SMSCConnection.getSMS_MOById
            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("id", Convert.ToString(message_id))
            Return getAllSMS_MO(makeStdHTTPRequest(SMS_MO_BYID_REQ, sparams))
        End Function

        Public Function createSubaccount(ByVal subaccount As Subaccount) As Subaccount Implements SMSCConnection.createSubaccount
            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("op", "CREATE_SUBACCOUNT")
            sparams.Add("credit_mode", subaccount.Credit_mode.ToString())
            If Not String.IsNullOrEmpty(subaccount.Company_name) Then
                sparams.Add("company_name", subaccount.Company_name)
            End If
            sparams.Add("fiscal_code", subaccount.Fiscal_code)
            sparams.Add("vat_number", subaccount.Vat_number)
            sparams.Add("name", subaccount.Name)
            sparams.Add("surname", subaccount.Surname)
            sparams.Add("email", subaccount.Email)
            sparams.Add("address", subaccount.Address)
            sparams.Add("city", subaccount.City)
            sparams.Add("province", subaccount.Province)
            sparams.Add("zip", subaccount.Zip)
            sparams.Add("mobile", subaccount.Mobile)
            If Not String.IsNullOrEmpty(subaccount.Login) Then
                sparams.Add("sub_login", subaccount.Login)
            End If
            If Not String.IsNullOrEmpty(subaccount.Password) Then
                sparams.Add("sub_password", subaccount.Password)
            End If
            Dim rp As ResponseParser = makeStdHTTPRequest(SUBACCOUNTS_REQ, sparams)
            subaccount.Login = rp.NextString
            subaccount.Password = rp.NextString
            Return subaccount
        End Function
        Public Function getSubaccounts() As List(Of Subaccount) Implements SMSCConnection.getSubaccounts

            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("op", "LIST_SUBACCOUNTS")
            Dim rp As ResponseParser = makeStdHTTPRequest(SUBACCOUNTS_REQ, sparams)
            Dim subaccounts As New List(Of Subaccount)()
            Dim subaccount As Subaccount
            While rp.GoNextLine()
                subaccount = New Subaccount()
                subaccount.Login = rp.NextString
                subaccount.Active = rp.NextBool
                subaccount.Credit_mode = rp.NextInt
                subaccount.SubaccountType = rp.NextString
                subaccount.Company_name = rp.NextString
                subaccount.Fiscal_code = rp.NextString
                subaccount.Vat_number = rp.NextString
                subaccount.Name = rp.NextString
                subaccount.Surname = rp.NextString
                subaccount.Email = rp.NextString
                subaccount.Address = rp.NextString
                subaccount.City = rp.NextString
                subaccount.Province = rp.NextString
                subaccount.Zip = rp.NextString
                subaccount.Mobile = rp.NextString
                subaccounts.Add(subaccount)
            End While
            Return subaccounts
        End Function
        Public Function lockSubaccount(ByVal subaccount As Subaccount) As Subaccount Implements SMSCConnection.lockSubaccount
            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("op", "LOCK_SUBACCOUNT")
            sparams.Add("subaccount", subaccount.Login)
            makeStdHTTPRequest(SUBACCOUNTS_REQ, sparams)
            subaccount.Active = False
            Return subaccount
        End Function
        Public Function unlockSubaccount(ByVal subaccount As Subaccount) As Subaccount Implements SMSCConnection.unlockSubaccount
            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("op", "UNLOCK_SUBACCOUNT")
            sparams.Add("subaccount", subaccount.Login)
            makeStdHTTPRequest(SUBACCOUNTS_REQ, sparams)
            subaccount.Active = True
            Return subaccount
        End Function
        Public Sub moveCredits(ByVal credit_movement As CreditMovement) Implements SMSCConnection.moveCredits
            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("op", "MOVE_CREDITS")
            sparams.Add("subaccount", credit_movement.Subaccount_login)
            sparams.Add("super_to_sub", credit_movement.Super_to_sub.ToString())
            sparams.Add("amount", credit_movement.Amount.ToString())
            sparams.Add("message_type", credit_movement.Sms_type.Code)
            makeStdHTTPRequest(SUBACCOUNTS_REQ, sparams)
        End Sub
        Public Function getSubaccountCredits(ByVal subaccount As Subaccount) As List(Of Credit) Implements SMSCConnection.getSubaccountCredits

            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("op", "GET_CREDITS")
            sparams.Add("subaccount", subaccount.Login)
            Dim rp As ResponseParser = makeStdHTTPRequest(SUBACCOUNTS_REQ, sparams)
            Dim credit As Credit
            Dim credits As List(Of Credit)
            Dim credit_type As CreditType
            credits = New List(Of Credit)()
            While rp.GoNextLine()
                credit_type = rp.NextCreditType
                credit = New Credit(credit_type, rp.NextNation, rp.NextInt)
                credits.Add(credit)
            End While
            Return credits
        End Function
        Public Sub createPurchase(ByVal credit_movement As CreditMovement) Implements SMSCConnection.createPurchase
            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("op", "CREATE_PURCHASE")
            sparams.Add("subaccount", credit_movement.Subaccount_login)
            Dim mt As List(Of String) = New List(Of [String])()
            For Each st As SMSType In credit_movement.Sms_types
                mt.Add(st.Code)
            Next
            sparams.Add("message_types", Str.join(";"c, mt.ToArray()))

            Dim ppm As New List(Of [String])()
            For Each st As Double In credit_movement.PricePerMessage
                ppm.Add(st.ToString())
            Next
            sparams.Add("price_per_messages", Str.join(";"c, ppm.ToArray()))

            sparams.Add("price", credit_movement.Price.ToString())
            makeStdHTTPRequest(SUBACCOUNTS_REQ, sparams)

        End Sub
        Public Sub deletePurchase(ByVal credit_movement As CreditMovement) Implements SMSCConnection.deletePurchase
            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("op", "DELETE_PURCHASE")
            sparams.Add("subaccount", credit_movement.Subaccount_login)
            sparams.Add("id_purchase", credit_movement.Id_purchase.ToString())
            makeStdHTTPRequest(SUBACCOUNTS_REQ, sparams)
        End Sub
        Public Function getPurchases(ByVal subaccount As Subaccount) As List(Of CreditMovement) Implements SMSCConnection.getPurchases
            Dim sparams As Dictionary(Of String, String) = getBaseHTTPParams()
            sparams.Add("op", "GET_PURCHASES")
            sparams.Add("subaccount", subaccount.Login)
            Dim rp As ResponseParser = makeStdHTTPRequest(SUBACCOUNTS_REQ, sparams)
            Dim credits As New List(Of CreditMovement)()
            While rp.GoNextLine()
                Dim cm As New CreditMovement()
                cm.Subaccount_login = subaccount.Login
                cm.Super_to_sub = rp.NextBool

                cm.Amount = CInt([Double].Parse(rp.NextString))

                cm.Recording_date = rp.NextDate
                cm.Id_purchase = rp.NextLong

                cm.Price = [Double].Parse(rp.NextString)
                cm.AvailableAmount = rp.NextInt

                Dim strTypes As String() = rp.NextString.Split(";"c)
                Dim sms_types As SMSType() = New SMSType(strTypes.Length - 1) {}
                For i As Integer = 0 To strTypes.Length - 1
                    sms_types(i) = SMSType.fromCode(strTypes(i))
                Next
                cm.Sms_types = sms_types

                Dim ppm As [String]() = rp.NextString.Split(";"c)
                Dim pricePerMessages As Double() = New Double(ppm.Length - 1) {}
                For i As Integer = 0 To ppm.Length - 1
                    pricePerMessages(i) = [Double].Parse(ppm(i))
                Next
                cm.PricePerMessage = pricePerMessages
                credits.Add(cm)
            End While
            Return credits
        End Function

        Public Function isConnected() As Boolean Implements SMSCConnection.isConnected
            Return Me.connected
        End Function
        Private Function makeStdHTTPRequest(ByVal request As String, ByVal sparams As Dictionary(Of String, String)) As ResponseParser
            Dim http_response As String = Nothing
            Try
                http_response = HTTP.POST(Me.hostname + request, sparams, Me.proxy, Me.proxyport)
            Catch httpe As HTTPException
                Throw New SMSCConnectionException(httpe.Message)
            End Try
            Dim rp As New ResponseParser(http_response)
            If rp.Ok Then
                Return rp
            Else
                Throw New SMSCRemoteException(rp.ErrorCode, rp.ErrorMessage)
            End If
        End Function
        Private Function getBaseHTTPParams() As Dictionary(Of String, String)
            Dim base_sparams As New Dictionary(Of String, String)()
            base_sparams.Add("login", Me.username)
            base_sparams.Add("password", Me.password)
            Return base_sparams
        End Function
        Private Function getAllSMS_MO(ByVal rp As ResponseParser) As List(Of SMS_MO)
            Dim new_smss As New List(Of SMS_MO)()
            While rp.GoNextLine()
                new_smss.Add(New SMS_MO(rp.NextLong, rp.NextSMSRecipient, rp.NextSMSSender, rp.NextString, rp.NextDate, rp.NextString))
            End While
            Return new_smss
        End Function

        Private Const CREDITS_REQ As String = "/Aruba/CREDITS"
        Private Const SEND_SMS_REQ As String = "/Aruba/SENDSMS"
        Private Const REMOVE_DELAYED_REQ = "/Aruba/REMOVE_DELAYED"
        Private Const MSG_STATUS_REQ As String = "/Aruba/SMSSTATUS"
        Private Const SMS_HISTORY_REQ As String = "/Aruba/SMSHISTORY"
        Private Const NUMBER_LOOKUP_REQ As String = "/OENL/NUMBERLOOKUP"
        Private Const NEW_SMS_MO_REQ As String = "/OESRs/SRNEWMESSAGES"
        Private Const SMS_MO_HIST_REQ As String = "/OESRs/SRHISTORY"
        Private Const SMS_MO_BYID_REQ As String = "/OESRs/SRHISTORYBYID"
        Private Const SUBACCOUNTS_REQ As String = "/Aruba/SUBACCOUNTS"
    End Class
End Namespace
