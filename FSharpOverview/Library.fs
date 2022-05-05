namespace FSharpOverview

module Functions =

    // Simple Values
    let hello = "Hello, world!"
    let mutable year = 2022

    // Function Vales
    let hello1 x = $"Hello " + x + "!"
    let hello2 x = $"Hello {x}!"
    let hello3 (x: string) = $"Hello {x}!" // explicit type 'string' for an argument 'x'
    let hello4 (x: int) = $"Hello {x}!" // explicit type 'int' for an argument 'x'
    let hello5 x : string = $"Hello {x}!" // explicit output type

    // More function values
    let sum1 x y = x + y
    let sum2 x = fun y -> x + y // lambda-expression (or anonymous function)

    // Functions as input and output
    type operation = int -> int -> int
    let operationAsInput (op: operation) x y = op x y
    let operationAsOutput: operation = fun x -> fun y -> x * y
    let result = operationAsInput operationAsOutput 10 5 // result = 50

    // Operators
    let sumInfix x y = x + y
    let sumPrefix x y = (+) x y

    let incrementInfix x = x + 1
    let incrementPrefix = (+) 1
