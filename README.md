# Unexpected Behavior with Mutable Variables in F# Functions

This example demonstrates a common pitfall in F# when using mutable variables within functions.  Because F# evaluates function arguments at the time of the function call, changes to mutable variables after the call do not affect the result.

The `bug.fs` file shows the unexpected behavior, while `bugSolution.fs` provides the correct approach using explicit parameter passing.

This is a good example of how the immutability focus of F# can sometimes lead to subtle problems if not handled carefully.
