open System
let cards = [21; 3; 1; 7; 9; 23]
let cardFace card = 
       let no = card % 13
       if no = 14 || no = 1 then "Ace"
       elif no = 13 then "King"
       elif no = 12 then "Queen"
       elif no = 11 then "Jack"
       else string no

let suit card =
    let no = card / 13
    if no = 0 then "Hearts"
    elif no = 1 then "Spades"
    elif no = 2 then "Diamonds"
    else "Clubs"

let shuffle list =
    let random = new System.Random()
    list |> List.sortBy (fun x -> random.Next())

let take list = List.take list 
let printCard card = printfn "%s of %s" (cardFace card) (suit card)

let printAll list = List.iter(fun x -> printCard(x)) list
