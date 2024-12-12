# Unexpected Behavior with Mutable Variables in F#

This example demonstrates a common pitfall in F#: the behavior of mutable variables within expressions.

## The Bug
The code initializes two mutable variables, `x` and `y`, adds them together, and stores the result in `z`. It then modifies `x`, and one might expect `z` to update accordingly. However, this is not the case.

## The Solution
To achieve the desired behavior, recalculate `z` after modifying `x`. The solution showcases this recalculation using a function.