// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System.Reflection

[<EntryPoint>]
let main argv = 
    FormattingXQuant.generateDocs() 
    printfn "%A" argv
    0 // return an integer exit code
