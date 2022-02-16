module Tests

open Xunit

[<Theory>]
[<InlineData(1, "1")>]
[<InlineData(2, "2")>]
let ``convert given number to string`` (input, expected) =
  let result = FizzBuzz.convert input
  Assert.Equal(expected, result)


[<Theory>]
[<InlineData(3, "Fizz")>]
[<InlineData(9, "Fizz")>]
let ``convert multiple of 3 to Fizz`` (input, expected) =
  let result = FizzBuzz.convert input
  Assert.Equal(expected, result)
  
[<Theory>]
[<InlineData(5, "Buzz")>]
[<InlineData(10, "Buzz")>]
let ``convert multiple of 5 to Buzz`` (input, expected) =
  let result = FizzBuzz.convert input
  Assert.Equal(expected, result)

[<Theory>]
[<InlineData(15, "FizzBuzz")>]
[<InlineData(30, "FizzBuzz")>]
let ``convert to FizzBuzz when multiple of 3 and 5`` (input, expected) =
  let result = FizzBuzz.convert input
  Assert.Equal(expected, result)

[<Theory>]
[<InlineData(32, "Fizz")>]

let ``convert to Fizz when contains 3`` (input, expected) =
  let result = FizzBuzz.convert input
  Assert.Equal(expected, result)
