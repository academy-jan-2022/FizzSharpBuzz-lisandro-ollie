module FizzBuzz

let convert number =
  if number % 3 = 0
  then "Fizz"
  elif number % 5 = 0
  then "Buzz"
  
  else number.ToString()
