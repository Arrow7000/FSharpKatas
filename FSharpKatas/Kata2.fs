module Kata2

open Xunit
open Swensen.Unquote


(*

    # Averages of numbers

    The accounts of the "Fat to Fit Club (FFC)" association are supervised by John as a volunteered accountant. The association is funded through financial donations from generous benefactors. John has a list of the first n donations: [14, 30, 5, 7, 9, 11, 15] He wants to know how much the next benefactor should give to the association so that the average of the first n + 1 donations should reach an average of 30. After doing the math he found 149. He thinks that he made a mistake. Could you help him?

    if dons = [14, 30, 5, 7, 9, 11, 15] then (forAverage dons 30) = 149

    The function forAverage should return the expected donation (rounded up to the next integer) that will permit to reach the average navg.

    Should the last donation be a non positive number (<= 0) John wants us to return None so that he clearly sees that his expectations are not great enough.

*)


// Add function implementation
let forAverage (dons : int list) (expectedAvg : int) : int option = None





let dons = [ 14; 30; 5; 7; 9; 11; 15 ]

[<Fact>]
let ``For average of 30`` () =
    let result = forAverage dons 30
    test <@ result = Some 149 @>

[<Fact>]
let ``For average of 92`` () =
    let result = forAverage dons 92
    test <@ result = Some 645 @>

[<Fact>]
let ``For negative requirement`` () =
    let result = forAverage (400 :: dons) 30
    test <@ result = None @>
