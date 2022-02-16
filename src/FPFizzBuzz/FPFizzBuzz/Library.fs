module FizzBuzz



let (|IS_FIZZ_BUZZ|IS_FIZZ|IS_BUZZ|IS_NUM|) number =
    if number % 15 = 0 then IS_FIZZ_BUZZ
    elif number % 3 = 0 then IS_FIZZ
    elif number % 5 = 0 then IS_BUZZ
    else IS_NUM
    
    
let convert number =
  match number with
  | IS_FIZZ_BUZZ -> "FizzBuzz"
  | IS_FIZZ -> "Fizz"
  | IS_BUZZ -> "Buzz"
  | IS_NUM -> number.ToString()

