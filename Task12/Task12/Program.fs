// Learn more about F# at http://fsharp.org

open System
(*Задание 12 Предыдущую программу реализовать в функции main с
помощью только оператора суперпозиции, потом только с помощью
оператора каррирования.*)

let answerUser answer =
    if(answer="F#" || answer ="Prolog") then  printfn "you loser!"
    else printfn "You cool!!"

[<EntryPoint>]
let main argv =
    printfn "You favorite high-level programming?"
    let answer = System.Console.ReadLine()
    printf "Карирование: " 
    answer |> answerUser
    printfn "Суперпозиция %s" (if(answer="F#" || answer ="Prolog") then  "you loser!"
                                else "You cool!!")
    0
