open Microsoft.Owin.Hosting
open Startup

// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
  printfn "%A" argv
  let baseUrl = "http://localhost:3000"
  use app = WebApp.Start<Startup>(baseUrl)
  printfn "Server started localhost:3000"
  printfn "Press any key to quit"
  System.Console.ReadKey() |> ignore
  0

