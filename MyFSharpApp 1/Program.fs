// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from kailash karki"

let rec printList ijk =
    match ijk with
    | [] -> ()
    | head :: tail ->
        printfn "%A" head
        printList tail
 
 
let listofitems = ["Fox"; "Elephant"; "Snake";"Rat"]
printList listofitems

