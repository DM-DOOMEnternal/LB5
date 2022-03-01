// Learn more about F# at http://fsharp.org

open System
(*Написать функцию обход делителей числа, которая выполняет операции над делителями числа, 
принимает три аргумента,
число,
функция (например, сумма, произведение, минимум, максимум)
инициализирующее значение. 
Функция должна иметь два Int аргумента и возвращать Int.*)

let rec sumDivisor number init funSearchDivisor =
    match number with
    |number when number = 0 -> init
    |number when number<>0 -> sumDivisor (number/10) (init+funSearchDivisor (number%10) 0 (number%10) ) funSearchDivisor
    |number -> sumDivisor(number/10) init funSearchDivisor


let rec searchSumDivisor number init  currentnumber =
    match number with
    |number when number = 0 -> init
    |number when (currentnumber%number=0) -> searchSumDivisor (number-1) (init+number) currentnumber
    |number -> searchSumDivisor (number-1) init currentnumber
    

[<EntryPoint>]
let main argv =
    let answer = fun f (x:int) (y:int) sumfun -> printfn "Сумма делителей числа %d : %d" x (f x y sumfun)
    answer sumDivisor 1234 0 searchSumDivisor
    0 // return an integer exit code
