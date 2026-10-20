// ================================================
// DDD Exercise: Refactoring designs to use states
// ================================================

(*
Much code has implicit states that you can recognize by
fields called "IsSomething", or nullable date

This is a sign that state transitions are present
but not being modelled properly.
*)

(*
Exercise 3a

An ecommerce site has customers
* if they have registered, they have a name and an ID
* if they have not registered, they just have a name
The original design uses a flag to tell the two cases apart

An illegal state is possible! The registered flag can be true
but there is no ID assigned.

Your task: redesign this type into two states:
* RegisteredCustomer (with an id)
* OR GuestCustomer (without an id)
Also, replace "int" and "string" with words from the domain
*)

type undefined = exn  // placeholder type

// contains the original code
module Customer_Before =

    type Customer =
        {
        CustomerName: string
        // redesign to rid of this bool
        IsRegistered: bool
        // redesign to rid of this option
        RegistrationId: int option
        }

// contains the redesigned code
module Customer_After =

    type CustomerName = string
    type RegistrationId = RegistrationId of int
    type RegisteredCustomer = {
        Name: CustomerName
        RegistrationId: RegistrationId
    }
    
    type Customer =
        | GuestCustomer of CustomerName
        | RegisteredCustomer of RegisteredCustomer
    
    

(*
Exercise 3b

An internet connection is either connected or disconnected.
The original design uses a flag to tell the two cases apart

Illegal states are possible!
* The IsConnected can be true but ConnectionStartedUtc is not assigned.
* The IsConnected can be false but ConnectionHandle is assigned.


Your task: Redesign this type into two states: Connected and Disconnected
Also, replace "int" and "string" with words from the domain

*)

// contains the original code
module Connection_Before =

    type Connection =
       {
       IsConnected: bool
       ConnectionStartedUtc: System.DateTime option
       ConnectionHandle: int option
       ReasonForDisconnection: string
       }

// contains the redesigned code
module Connection_After =
    type ConnectionHandle = ConnectionHandle of int
    
    type ConnectedConnection = {
        ConnectionHandle: ConnectionHandle
        ConnectionStartedUtc: System.DateTime
    }
    
    type DisconnectedConnection = {
        ReasonForDisconnection: string
    }

    type Connection =
        | Connected of ConnectedConnection
        | Disconnected of DisconnectedConnection

(*
// Exercise 3c

An Order is either New OR Paid or Completed.
* If it is New, it has an Id and a list of items
* If it is Paid, the Amount and PaidDate are also set.
* If it is Completed, the ShippedDate is also set.

Question: What are the illegal states?

Your task: redesign this type into three states.
Can you guess what the states are from the enum?
How does the refactored version help improve the documentation?

*)

// contains the original code
module Order_Before =

    type OrderStateEnum = New | Paid | Shipped
    type Order =
       {
       OrderId: int
       Items : string list
       OrderState: OrderStateEnum
       PaidAmount: float option
       PaidDate: System.DateTime option
       ShippedDate: System.DateTime option
       }

// contains the redesigned code
module Order_After =
    type OrderId = OrderId of int
    type Item = Item of string
    type OrderItems = Item list
    type Amount = float
    type Date = System.DateTime
    type NewOrder = {
        OrderId: OrderId
        Items: OrderItems
    }
    type PaidOrder = {
        OrderId: OrderId
        Items: OrderItems
        PaidAmount: Amount
        PaidDate: Date
    }
    type CompletedOrder = {
        OrderId: OrderId
        Items: OrderItems
        PaidAmount: Amount
        PaidDate: Date
        ShippedDate: Date
    }

    type Order =
        | New of NewOrder
        | Paid of PaidOrder
        | Completed of CompletedOrder

(*
Questions for discussion:

* When does it make sense to use a type alias rather than a separate type?
* When does it make sense to define a new type rather than use a tuple?

All these questions and more are discussed in the "answer" file!
*)