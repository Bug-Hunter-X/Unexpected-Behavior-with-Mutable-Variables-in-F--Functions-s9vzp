let mutable x = 10
let mutable y = 20

let add x y = 
    x + y

let mutable z = add x y

printf "%d" z //this will print 30

x <- 100
y <- 200

printf "%d" z //this will still print 30, not 300
