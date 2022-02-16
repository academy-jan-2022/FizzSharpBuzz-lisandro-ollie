module FizzBuzz



let (|IS_FIZZ|IS_BUZZ|IS_NUM|) number =
    if number % 3 = 0 then IS_FIZZ
    elif number % 5 = 0 then IS_BUZZ
    else IS_NUM
    
    
let convert number =
  match number with
  | IS_FIZZ -> "Fizz"
  | IS_BUZZ -> "Buzz"
  | IS_NUM -> number.ToString()

