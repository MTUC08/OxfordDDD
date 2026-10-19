// Demonstrates the TicTacToe domain written as code
module rec TicTacToe =

// ---->^  The "rec" means the definitions in this file can be out of order
// In this case, you must highlight the entire file to evalulate the code


(*
Need help with syntax?
See A2.02a-TypedDomainModel-Help.fsx for the syntax you might need
*)


//============================================
// Your code starts here
// Indent everything one tab so that the "module rec" above works
//============================================

    type Player = X | O
    type Position =
        | TopLeft
        | TopMiddle
        | TopRight
        | MiddleLeft
        | Center
        | MiddleRight
        | BottomLeft
        | BottomMiddle
        | BottomRight
    type Grid = (Position * Player option) list
    type StartGame = unit -> Grid * Player
    
    type GameState =
        | InProgress
        | Tie
        | XWins
        | OWins
    type MakeMove = Player * Position * Grid -> Grid * Player * GameState
    
    // type 

