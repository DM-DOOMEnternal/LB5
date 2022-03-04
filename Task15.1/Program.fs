// Learn more about F# at http://fsharp.org

open System

(*Написать функцию обход взаимно простых компонентов
числа, которая выполняет операции над числами, взаимно простыми с
данным, принимает три аргумента, число, функция (например, сумма,
произведение, минимум, максимум, количество) и инициализирующее
значение. Функция должна иметь два Int аргумента и возвращать Int.*)
let rec countSimple constNumber number init funSearchSimple =
    match constNumber with
    |constNumber when number = 0 -> init
    |constNumber when (funSearchSimple constNumber number=1) -> countSimple constNumber (number-1) (init+1) funSearchSimple
    |constNumber -> countSimple constNumber (number-1) init funSearchSimple

let rec searchSimpleNumber number1 number2 =
    match number1 with
    |number1 when number1=number2 && number1=1 -> 1
    |number1 when (number1>number2) -> searchSimpleNumber (number1-number2) number2
    |number1 when (number1<number2) -> searchSimpleNumber (number2-number1) number1
    |number1 -> 0

let linkcount number init funSearchSimple = countSimple number number init funSearchSimple

[<EntryPoint>]
let main argv =
    let count = fun f (x:int) (y:int) countfun -> printfn "Количесво взаимно простых с %d : %d " x (f x y countfun)
    count linkcount 58 0 searchSimpleNumber
    0 // return an integer exit code
