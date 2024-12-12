let mutable x = 1
let mutable y = 2
let z = x + y
printf "%d\n" z
x <- 3
printf "%d\n" z

// Expected output:
// 3
// 3

//Actual output:
// 3
// 3