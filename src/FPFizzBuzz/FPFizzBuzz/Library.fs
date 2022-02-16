module FizzBuzz

open Microsoft.FSharp.Core
let y (x:string) = match x with | x when x.Contains("hi") -> "HELLO" | x when x.Contains("hello") -> "HI" | x -> x


let (|IS_MULTIPLE_OF|_|) multiplier number =
    match number % multiplier with
    | 0 -> Some ()
    | _ -> None

let (|CONTAINS|_|) container number =
    match string number with
    | x when x.Contains(string container) -> Some ()
    | _ -> None

let convert number =
  match number with
  | IS_MULTIPLE_OF 15 -> "FizzBuzz"
  | IS_MULTIPLE_OF 3 -> "Fizz"
  | IS_MULTIPLE_OF 5 -> "Buzz"
  | CONTAINS 3 -> "Fizz"
  | number -> string number




let (|MULTIPLE_OF_THREE_AND_FIVE|MULTIPLE_OF_THREE|MULTIPLE_OF_FIVE|IS_NUM|) number =
    match number % 5, number % 3 with
    | 0, 0 -> MULTIPLE_OF_THREE_AND_FIVE
    | 0, _ -> MULTIPLE_OF_FIVE
    | _, 0-> MULTIPLE_OF_THREE
    | _ -> IS_NUM number
    
    

