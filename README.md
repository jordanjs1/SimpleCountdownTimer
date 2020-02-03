# SimpleCountdownTimer
A very simple countdown timer written in C# Windows Forms using .NET Framework 4.8. The computer I'm working on had no countdown timer program, so I developed one in a hour.
The program can countdown from a maximum of 999h 59m 59s, but this is not a theoretical limit and can easily be changed.
The program uses Windows Multimedia API (winmm.dll) to implement a timer and a class is used as a wrapper. The timer class just implements a timer, the countdown mechanism itself is implemented in the program.

## How to Build
Nothing special needed, just clone the code to your development environment and build. You'll need .NET Framework 4.8.

## Notes
* There are a lot of optimizations, code cleanups and other improvements that can be made, like providing "Pause" and "Stop" events from the timer class, implementing countdown feature inside the timer class, etc. The program, in its current form, serves well to me. If I plan to improve, I will also make a list that contains these optimizations and code cleanups, and more I came up thinking.
