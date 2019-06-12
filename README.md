# OrderExercise
This is a simple order pack exercise

# OrderExercise
This is a simple order pack exercise

This is simple order pack system.
(For each type of pack, the subtotal price should be reasonable instead of the single price).
It can be run in C# environment and suggest to use visual studio.
Invalid input can be caught and unrecognized pack will be ignored.

For testing, you can use follow example:
13 SH3
10 SH3
3 SH3
18 YT2
30 YT2
20 YT2
4 YT2
12 TR
18 TR
10 TR
3 TR
#

The exptected output:
13 SH3 $11.97
2*5 $8.98
1*3 $2.99
10 SH3 $8.98
2*5 $8.98
3 SH3 $2.99
1*3 $2.99
18 YT2 $19.85
1*10 $9.95
2*4 $9.9
30 YT2 $27.9
2*15 $27.9
20 YT2 $19.9
2*10 $19.9
4 YT2 $4.95
1*4 $4.95
12 TR $10.94
1*9 $7.99
1*3 $2.95
18 TR $15.98
2*9 $15.98
10 TR $8.9
2*5 $8.9
3 TR $2.95
1*3 $2.95
