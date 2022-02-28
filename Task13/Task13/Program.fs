// Learn more about F# at http://fsharp.org

open System
(*Задание 13 Написать функции произведение цифр числа, минимальная и
максимальная цифра с использованием рекурсии вверх и с
использованием хвостовой рекурсии.*)

(*Рекурсия вверх*)
let rec recUpMult number =
    if (number = 0) then 1
    else (number%10)*(recUpMult (number/10))

let rec recUpMax number max =
    if (number = 0) then max
    else if (number%10>max) then recUpMax(number/10)(number%10)
    else recUpMax(number/10) max
   

let rec recUpMin number min =
    if (number = 0) then min
    else if (number%10<min) then recUpMin(number/10)(number%10)
    else recUpMin(number/10) min

(*Рекурсия вниз или хвостовая рекурсия*)
let rec recDownMult number mult =
    if (number = 0) then mult
    else recDownMult (number/10) (mult*(number%10))

let linkRecDownMult number = recDownMult number 1


[<EntryPoint>]
let main argv =
    printfn "Произведение цифр: %d" (recUpMult 123)
    printfn "Макс цифра: %d" (recUpMax 173 0)
    printfn "Мин цифра: %d" (recUpMin 123 3)
    printfn "Рекурсия вниз"
    printfn "Произведение цифр: %d" (linkRecDownMult 123)
    0 // return an integer exit code
