// Learn more about F# at http://fsharp.org

open System


(*Протестировать написанную функцию. Построить отдельные
функции для вычисления числа Эйлера и НОД.*)

let rec euler startnumber eps numFact funFact =
    match startnumber with
    |startnumber when 1.0/(funFact numFact) > eps -> euler (startnumber + (1.0/(funFact numFact))) eps (numFact+1.0) funFact
    |startnumber -> startnumber

let rec factorial number =
    match number with
    |number when number>1.0 ->number*factorial(number-1.0)
    |number -> 1.0

let rec nod number1 number2 number3 =
    match number3 with
    |number3 when number1>0 && number2 >0 && number1>number2 -> nod (number1%number2) number2 number3
    |number3 when number1>0 && number2 >0 && number1<number2 -> nod number1 (number2%number1) number3
    |number3 -> number1+number2


[<EntryPoint>]
let main argv =
    let eul = fun f (x:float) (eps:float) (i:float) funFact -> printfn "Эйлерово число с точностью %f : %f" eps (f x eps i funFact)
    eul euler 0.0 0.00001 0.0 factorial
    printfn "НОД %d %d: %d" 64 28 (nod 64 28 0)
    0 // return an integer exit code
