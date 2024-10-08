﻿module getnumericvalue

open System

let overload1 () =
    // <Snippet2>
    let utf32 = 0x10107       // AEGEAN NUMBER ONE
    let surrogate = Char.ConvertFromUtf32 utf32
    for ch in surrogate do
        printfn $"U+{Convert.ToUInt16 ch:X4}: {Char.GetNumericValue ch}    "

    // The example displays the following output:
    //       U+D800: -1
    //       U+DD07: -1
    //  </Snippet2>

let overload2 () =
    // <Snippet3>
    // Define a UTF32 value for each character in the
    // Aegean numbering system.
    for utf32 in 0x10107..0x10133 do
        let surrogate = Char.ConvertFromUtf32 utf32
        for i = 0 to surrogate.Length - 1 do
            printf $"U+{Convert.ToUInt16 surrogate[i]:X4} at position {i}: {Char.GetNumericValue(surrogate, i)}     "
        printfn ""

    // The example displays the following output:
    //       U+D800 at position 0: 1     U+DD07 at position 1: -1
    //       U+D800 at position 0: 2     U+DD08 at position 1: -1
    //       U+D800 at position 0: 3     U+DD09 at position 1: -1
    //       U+D800 at position 0: 4     U+DD0A at position 1: -1
    //       U+D800 at position 0: 5     U+DD0B at position 1: -1
    //       U+D800 at position 0: 6     U+DD0C at position 1: -1
    //       U+D800 at position 0: 7     U+DD0D at position 1: -1
    //       U+D800 at position 0: 8     U+DD0E at position 1: -1
    //       U+D800 at position 0: 9     U+DD0F at position 1: -1
    //       U+D800 at position 0: 10     U+DD10 at position 1: -1
    //       U+D800 at position 0: 20     U+DD11 at position 1: -1
    //       U+D800 at position 0: 30     U+DD12 at position 1: -1
    //       U+D800 at position 0: 40     U+DD13 at position 1: -1
    //       U+D800 at position 0: 50     U+DD14 at position 1: -1
    //       U+D800 at position 0: 60     U+DD15 at position 1: -1
    //       U+D800 at position 0: 70     U+DD16 at position 1: -1
    //       U+D800 at position 0: 80     U+DD17 at position 1: -1
    //       U+D800 at position 0: 90     U+DD18 at position 1: -1
    //       U+D800 at position 0: 100     U+DD19 at position 1: -1
    //       U+D800 at position 0: 200     U+DD1A at position 1: -1
    //       U+D800 at position 0: 300     U+DD1B at position 1: -1
    //       U+D800 at position 0: 400     U+DD1C at position 1: -1
    //       U+D800 at position 0: 500     U+DD1D at position 1: -1
    //       U+D800 at position 0: 600     U+DD1E at position 1: -1
    //       U+D800 at position 0: 700     U+DD1F at position 1: -1
    //       U+D800 at position 0: 800     U+DD20 at position 1: -1
    //       U+D800 at position 0: 900     U+DD21 at position 1: -1
    //       U+D800 at position 0: 1000     U+DD22 at position 1: -1
    //       U+D800 at position 0: 2000     U+DD23 at position 1: -1
    //       U+D800 at position 0: 3000     U+DD24 at position 1: -1
    //       U+D800 at position 0: 4000     U+DD25 at position 1: -1
    //       U+D800 at position 0: 5000     U+DD26 at position 1: -1
    //       U+D800 at position 0: 6000     U+DD27 at position 1: -1
    //       U+D800 at position 0: 7000     U+DD28 at position 1: -1
    //       U+D800 at position 0: 8000     U+DD29 at position 1: -1
    //       U+D800 at position 0: 9000     U+DD2A at position 1: -1
    //       U+D800 at position 0: 10000     U+DD2B at position 1: -1
    //       U+D800 at position 0: 20000     U+DD2C at position 1: -1
    //       U+D800 at position 0: 30000     U+DD2D at position 1: -1
    //       U+D800 at position 0: 40000     U+DD2E at position 1: -1
    //       U+D800 at position 0: 50000     U+DD2F at position 1: -1
    //       U+D800 at position 0: 60000     U+DD30 at position 1: -1
    //       U+D800 at position 0: 70000     U+DD31 at position 1: -1
    //       U+D800 at position 0: 80000     U+DD32 at position 1: -1
    //       U+D800 at position 0: 90000     U+DD33 at position 1: -1
    //  </Snippet3>
overload1 ()
printfn ""
overload2 ()