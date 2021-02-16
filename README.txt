Hello!

My name is Nicholas Dobos and I am submitting this DealerOn code submission. I chose the Mars Rover submission.

I will start by giving a brief explanation. The console app will prompt you to input one character or integer at a time. This will build up the input the same way
the example shows as follows.

5 5
1 2 N
LMLMLMLMM

The console app will start with the first 5, then the second. Then it will ask you to input an x and y coordinate, as well as a heading for your rover.
Finally, it will ask you to input a command, or directions, to the rover. If the rover is not longer within that 6x6 grid at the end, you crash. If not, then 
the app will provide you the position of the rover following the command. It will resemble something like this:

1 3 N

I understand that technically, you would want to track the position of every move the rover makes, and if it ever leaves the grid, then it should crash 
(or calculate all positions beforehand, and refuse to execute self-destructive behavior), but I felt like scope-creep was starting to take hold, and I wanted to keep it 
as close to the example as possible.

Also, there seems to be something weird going on with parsing out the heading character in the console app, so I had to put a break; in the while loop. 
This is a workaround that, given more time, I would have fixed.

Another thing to take note of, is that the original problem has two rovers that move 'one after another'. I have boiled this down to the bare minimum to get one rover
to move, so the console app could be as friendly to the user as possible.

I have also provided some unit tests.

I hope you find this satisfactory.

Hope to hear from you soon,

-Nick