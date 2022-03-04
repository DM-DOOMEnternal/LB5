// Learn more about F# at http://fsharp.org

open System

(*На основе написанных функций построить функции обход делителей   с  
условием   и   обход   взаимнопростых   с   условием. 
Протестировать написанные функции.*) 

let rec euler st eps numFact limFact funFact = 
    match st with 
    |st when (1.0/(funFact numFact) > eps) && numFact<limFact -> euler (st + (1.0/(funFact numFact))) eps (numFact+1.0) limFact funFact 
    |st -> printfn "Число Эйлера для делителя %d: %f" (int limFact) st


let rec factorial num = 
    match num with 
    |num when num>1.0 ->num*factorial(num-1.0) 
    |num -> 1.0 
 
let rec div num constNum  = 
    let eulerDiv = fun (x:float) -> euler 1.0 0.00001 1.0 num factorial
    match num with 
    |num when (int num) = 0 -> 0
    |num when (constNum%(int num)=0) -> (eulerDiv num);div (num-1.0) constNum
    |num -> div (num-1.0) constNum  

(*simple number*)
let rec sn n1 n2 funGCD =
    match n2 with
    |n2 when ((funGCD n1 n2 0)=1)&&n2<>0 -> printfn "Взаимнопростые с %d : %d " n1 n2; sn n1 (n2-1) funGCD
    |n2 when ((funGCD n1 n2 0)<>1) && n2<>0-> sn n1 (n2-1) funGCD
    |n2 -> n2

 (*greatest common divisor- НОД*)
let rec gcd n1 n2 n3 = 
    match n3 with 
    |n3 when n1>0 && n2 >0 && n1>n2 -> gcd (n1%n2) n2 n3 
    |n3 when n1>0 && n2 >0 && n1<n2 -> gcd n1 (n2%n1) n3 
    |n3 -> n1+n2 

[<EntryPoint>] 
let main argv =  
    let divisorEuler = fun f (x:float) (y:int) -> (f x y) 
    let result = divisorEuler div 10.0 10; 
    let simNumGCD = fun g (x1:int) (y1:int) fungcd -> (g x1 y1 fungcd) 
    let result = simNumGCD sn 5 5 gcd
    0 // возвращение целочисленного кода выхода 
  

(*//Эйлер и НОД 

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

    0 // return an integer exit code*) 
