// =================================
// Exercise: ConstrainedTypes
//
// Given the definition of the constrained types below,
// write functions that implement the constructor and property getter.
// =================================

open System

// a useful helper function
let notImplemented() = failwith "not implemented"

//----------------------------------------------------------
// Exercise: Create a `NonZeroInteger`  type that can only
// contain non-zero integers.  i <> 0
//----------------------------------------------------------

module ConstrainedTypes =

    /// Must be <> 0
    type NonZeroInteger = private NonZeroInteger of int

    module NonZeroInteger =
        // TODO: Implement public constructor
        let create i =
            //what goes here?
            if i <> 0 then Some (NonZeroInteger i)
            else None

        // TODO: Implement a function that returns the value
        let value nzInt =
            //what goes here?
            match nzInt with
            | NonZeroInteger nzInt -> nzInt


// --------------------------------
// test NonZeroInteger
// --------------------------------

open ConstrainedTypes

// NonZeroInteger 1 // uncomment for error
let nonZeroOpt0 = NonZeroInteger.create 0
let nonZeroOpt1 = NonZeroInteger.create 1

