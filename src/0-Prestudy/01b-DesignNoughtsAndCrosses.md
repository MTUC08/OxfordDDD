// ================================
// Designing Noughts And Crosses
// ================================

For this exercise, come up with a design for playing "Noughts And Crosses" aka "Tic-Tac-Toe".
I chose this because it's simple and everybody knows the rules.

As always, there are no "right" answers -- I am interested in seeing different approaches. We will be discussing these answers in the first session of the course.

# 1. Write down a "design" for playing Noughts And Crosses

A game is conducted by two players on a 3x3 board. One player plays noughts, the other plays crosses.

Play begins in the first game with the player playing noughts. It then continues with the player playing crosses,
and continues alternating each turn between the players until the game ends.

Each turn, the acting player places a piece on the board, marking it with either a nought or a cross.


The game concludes where one of the 3 ending conditions is hit:
* 3 noughts make up a line in the vertical, horizontal, or diagonal direction
* 3 crosses make up a line in the vertical, horizontal, or diagonal direction
* all 9 spaces are marked

# 2. How is your design different from code?

The design describes the components that make up the game and the requirements for the implementation.
The code would actually implement it, and go into the specific details, 
e.g. how are players assigned to play either noughts or crosses? How is game state tracked? 
How is the ending condition detected? etc.