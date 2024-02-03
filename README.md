# FindFirstRepeatingLetter

Tests conventional methods of finding first repeating character vs. using a bit flag.

A couple years ago I spent a lot of time prepping for tech interviews by doing so many coding challenges. Recently while going through random bits of code that I've developed, I stubbled upon this one.

The challenge for this code is a few levels below Easy; Given a string, find the first letter that repeats. To do this, you essentially need two loops: one loop for what you're looking for and one for what you've found.

For me, the challenge wasn't so much trying to find a solution, it was trying to find the absolute best performing solution. I vividly remember having this "think outside the box" moment and wondered what would happen if I used the bits in an Int to track letters that have already been found. Performance wise, it blew every other solution away (below are the top two best performers; BitFlags is nearly 5 times faster with no memory allocation).

I know it's technically not the best solution because it's geared towards the English alphabet, but that's not the point... 

The point I'm getting at is that you can still learn something from the most simplest coding challenges.
