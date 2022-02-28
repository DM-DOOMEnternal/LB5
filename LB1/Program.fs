// Learn more about F# at http://fsharp.org

open System


(*Спросить у пользователя, какой язык у него любимый, если
это F# или Prolog, ответь пользователю, что он — подлиза, для других
языков придумать комментарий, реализовать функцию, принимающую
аргументом ответ пользователя и возвращающую наш ответ
пользователю.*)

let answerUser answer =
    if(answer="F#" || answer ="Prolog") then printfn "you loser!"
    else printf("You cool!!")


[<EntryPoint>]
let main argv =
    printfn "You favorite high-level programming?"
    let str = System.Console.ReadLine();
    answerUser str
    0 // return an integer exit code
