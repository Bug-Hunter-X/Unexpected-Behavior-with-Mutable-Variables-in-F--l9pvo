let mutable x = 1
let mutable y = 2
let z = x + y
printf "%d\n" z
x <- 3
let z = x + y //Recalculate z
printf "%d\n" z

// Expected output:
// 3
// 5

//Actual output:
// 3
// 5