// =============================================
// Exercise:
//
// For each of the following definitions,
// say whether it is a simple value or a function,
// and if a function, what is the function signature?
//
// NOTE: I have commented these out because if you are using VS Code or Rider,
// you will see the answers already!
//
// To check your answer, uncomment and run them.
//
// In all cases, make sure you understand WHY the signatures
// are what they are.
// =============================================

// Simple value or function?
// If a function, what is the function signature?
// let testA = 2
// Simple value

// Simple value or function?
// If a function, what is the function signature?
// let testB x = 2 + x
// Function val testB: x:int -> int

// let testC x = 2.0 + x
// Function val testC: x:float -> float

// let testD = "hello"
// Simple value

// let testE = printfn "hello"
// Simple value

// let testF () = 42
// Function val testF: unit -> int

// let testG () = printfn "hello"
// Function val testG: unit -> unit

// let testH x = String.length x
// Function val testH: x:string -> int

// let testI x = sprintf "%i" x
// Function val testI: x:int -> string

// let testJ x = printfn "%i" x
// Function val testJ: x:int -> unit

// let testK x =
//     printfn "x is %f" x
//     x  // return x
// Function val testK: x:float -> float

// let testL (f:int -> string) x =
//     f x
// Function val testL: f:(int -> string) -> x:int -> string


// let testM f (x:int) :string =
//     f x
// Function val testM: f:(int -> string) -> x:int -> string

// Trick question! Hint: what does :string modify?
// let testN x :string = x 1
// Function val testM: x:(int -> string) -> string

// let testO x = 1
// Function val testO: x:'a -> int

// hint: what kind of thing is x?
// let testP x = x 1
// Function val testP: x:(int -> 'a) -> 'a

// let testQ x y = x
// Function val testQ: x:'a -> y:'b -> 'a

// let testR x y z = z
// Function val testR: x:'a -> y:'b -> z:'c -> 'c

// let testS x = (x=x)
// Function val testS: x:'a -> bool


// =============================================
// Exercise:
//
// For each of the following signatures, create a function
// that will be *inferred* to have that signature.
//
// Avoid using explicit type annotations!
// =============================================

// val sigA = int -> int

// Here's an example of a possible answer for "sigA":
(*
let sigA x = x + 1
*)

// val sigB = int -> unit

// Here's an example of a possible answer for "sigB":
(*
let sigB x = printfn "%i" x
*)

// val sigC = int -> string
let sigC x = sprintf "%i" x

// val sigD = unit -> string
let sigD () = "hi"

// val sigE = string -> string
let sigE x = sprintf "%s" x

// val sigF = int -> bool -> float -> string
let sigF x y z = sprintf "%i %b %f" x y z 

// =============================================
// Exercise:
//
// Make the following functions compile by adding
// type annotations. Try to use the minimum annotations possible!
//
// Reminder of how to do type annotations
// let aFunction (param1:string) (param2:bool) :string =
//                ^1st param      ^2nd param    ^return type
//
// =============================================

// Remove spaces from front and back of a string
// The "s" parameter is a string and it returns a string
let trim (s: string) = s.Trim()

// Return the length of string
// The "s" parameter is a string and it returns an int
let len (s: string) = s.Length

// Replace a substring with new substring
// The s, oldStr,newStr parameters are all string
// and it returns a string
let replace (oldStr: string) newStr (s: string) = s.Replace(oldStr,newStr)
(*
This one is tricky because .NET has two overloads
  Replace(string,string)
  Replace(char,char)
So we need to say what type the parameters are too.
*)


// =============================================
// Exercise (HARD):
// Below are four generic signatures.
// Try to create four functions that are inferred to have these signatures.
//
// Avoid using explicit type annotations!
// =============================================

// val sigW = 'a -> int
let sigW x = 1

// val sigX = int -> 'a

// val sigY = 'a -> 'a
let sigY x = x

// val sigZ = 'a -> 'b