<Query Kind="FSharpProgram" />

open System
open System.Timers
open System.Text
open System.IO

type PrintTime () =
    let limit = DateTime.Now.AddSeconds(5.0) 
    let timer = new Timer(1000.)

    do
        timer.AutoReset <- true
        timer.Elapsed
        |> Observable.add ( fun e -> 
            if e.SignalTime > limit then
                stdout.WriteLine("--- 5 seconds elapsed ---")
                timer.Disposed.Add ( fun _ -> Environment.Exit(0) )
                timer.Dispose ()
            else
                stdout.WriteLine( e.SignalTime )
            )
        |> ignore

    member this.CountUp() =
        timer.Start()
        stdin.ReadLine()

(PrintTime()).CountUp() |> ignore