Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace RS
    Public Interface SMSCConnection
        Sub login()
        Sub logout()
        Function isConnected() As Boolean

        '*
        '         * The function uses the connection to the server
        '         * to send the object <code>SMS</code>.
        '         * Returns an object <code>SendResult</code> with
        '         * information about the sending result.
        '         

        Function sendSMS(ByVal sms As SMS) As SendResult

        '*
        '         * The function uses the connection to the server
        '         * to obtain the array of <code>MessageStatus</code> objects
        '         * relative to the specified ID message passed as argument.
        '         * Each <code>MessageStatus</code> object provides
        '         * for a single recipient.
        '         

        Function getMessageStatus(ByVal order_id As [String]) As List(Of MessageStatus)

        '*
        '         * The function asks the server if the number passed
        '         * as argument is a valid recipient.
        '         

        Function lookup(ByVal recipient As SMSRecipient) As LookupResult

        '*
        '         * The function uses the connection to the server
        '         * to retrieve the informations relative to the credits.
        '         * With this informations builds an array of 
        '         * objects <code>Credit</code>, one for each
        '         * different type of credit.
        '         

        Function getCredits() As List(Of Credit)

        '*
        '         * The function uses the connection to the server
        '         * to retrieve the informations relative to the Mobile Originated SMSs.
        '         

        Function getNewSMS_MOs() As List(Of SMS_MO)

        '*
        '         * The function uses the connection to the server
        '         * to retrieve the informations relative to the Mobile Originated SMSs.
        '         * received in the gap between the two dates passed as arguments.
        '         

        Function getSMS_MOHistory(ByVal from_date As DateTime, ByVal to_date As DateTime) As List(Of SMS_MO)

        Function getSMS_MOById(ByVal id_message As Long) As List(Of SMS_MO)

        '*
        '         * The function uses the connection to the server to
        '         * retrieve the array of <code>SMS</code> executed in the 
        '         * gap between the two dates passed as arguments.
        '         

        Function getSMSHistory(ByVal from_date As DateTime, ByVal to_date As DateTime) As List(Of SentSMS)

        '*
        '         * Create a subaccount; no client-side check for parameter validity
        '         * is done, instead, server interface will try to "adjust" the passed
        '         * parameters, otherwise an error is sent to the client and, consequently,
        '         * an exception is thrown.
        '         

        Function createSubaccount(ByVal subaccount As Subaccount) As Subaccount

        '*
        '         * Requests to the server the list of the subaccounts configured for
        '         * the logged-in superaccount.
        '         

        Function getSubaccounts() As List(Of Subaccount)

        '*
        '         * Locks the subaccount; the subaccount can't login anymore, but
        '         * no data is deleted.
        '         

        Function lockSubaccount(ByVal subaccount As Subaccount) As Subaccount

        '*
        '         * Unlocks a previously locked subaccount.
        '         

        Function unlockSubaccount(ByVal subaccount As Subaccount) As Subaccount

        '*
        '         * Move credits from the superaccount to the subaccount or the opposite,
        '         * depending on the value of the "super_to_sub" field of the CreditMovement
        '         * object.
        '         

        Sub moveCredits(ByVal credit_movement As CreditMovement)
        '*
        '         * The function retrieves the array of <code>Credit</code> of the specified subaccount
        '         
        Function getSubaccountCredits(ByVal subaccount As Subaccount) As List(Of Credit)
        '*
        '         * The function creates a new purchase for the specificed subaccount
        '         

        Sub createPurchase(ByVal credit_movement As CreditMovement)
        '*
        '         * The function clears a purchase of the specificed subaccount
        '         

        Sub deletePurchase(ByVal credit_movement As CreditMovement)
        '*
        '         * The function retrieves the array of <code>CreditMovements</code> of the specified subaccount
        '         

        Function getPurchases(ByVal subaccount As Subaccount) As List(Of CreditMovement)

    End Interface
End Namespace
