open System

let init =
    printfn "[FSharp Easy List Sort]\n"

let input =
    printfn "Enter a number between 0 and 9 based on a space."
    let str = Console.ReadLine()
    str

let listSort list =
    printfn "\n[RESULT]"
    printfn "After : %A" list
    let sortedList = List.sort list
    printfn "Before : %A" sortedList

let stringToList str =
    let mutable list = []
    for i in str do
        if i <> ' ' then
        list  <- [int i - 48] |> List.append list
    list

[<EntryPoint>]
let main argv =
    let init = init
    let str = input
    let list = stringToList str
    listSort list
    0