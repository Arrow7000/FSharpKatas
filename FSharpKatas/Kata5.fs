module Kata5

open Xunit
open Swensen.Unquote

(*

    # Sum of odd numbers

    Given the triangle of consecutive odd numbers:

                 1
              3     5
           7     9    11
       13    15    17    19
    21    23    25    27    29
    ...

    Calculate the row sums of this triangle from the row index (starting at index 1) e.g.:

    rowSumOddNumbers 1 = 1
    rowSumOddNumbers 2 = 3 + 5 = 8

*)

// Add implementation here
let rowSumOddNumbers (rowNum : int) : int = 0


[<Fact>]
let ``First row`` () =
    test <@ rowSumOddNumbers 1 = 1 @>

[<Fact>]
let ``Fourth row`` () =
    test <@ rowSumOddNumbers 4 = 64 @>

[<Fact>]
let ``Fifth row`` () =
    test <@ rowSumOddNumbers 5 = 125 @>
