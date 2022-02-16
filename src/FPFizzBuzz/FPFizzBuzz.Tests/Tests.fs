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
