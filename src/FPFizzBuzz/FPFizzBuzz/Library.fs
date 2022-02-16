module FizzBuzz



let (|MULTIPLE_OF_THREE_AND_FIVE|MULTIPLE_OF_THREE|MULTIPLE_OF_FIVE|IS_NUM|) number =
    match number % 5, number % 3 with
    | 0, 0 -> MULTIPLE_OF_THREE_AND_FIVE
    | 0, _ -> MULTIPLE_OF_FIVE
    | _, 0-> MULTIPLE_OF_THREE
    | _ -> IS_NUM number
    
    
let convert =
  function
  | MULTIPLE_OF_THREE_AND_FIVE -> "FizzBuzz"
  | MULTIPLE_OF_THREE -> "Fizz"
  | MULTIPLE_OF_FIVE -> "Buzz"
  | IS_NUM number -> string number

