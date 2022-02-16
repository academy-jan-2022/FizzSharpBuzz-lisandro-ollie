module Tests

open Xunit

[<Theory>]
[<InlineData(1, "1")>]
[<InlineData(2, "2")>]
let ``convert given number to string`` (input, expected) =
  let result = FizzBuzz.convert input
  Assert.Equal(expected, result)
