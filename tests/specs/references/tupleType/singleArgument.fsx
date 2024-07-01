module rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

[<Erase>]
type Exports =
    [<Import("transformation", "REPLACE_ME_WITH_MODULE_NAME")>]
    static member transformation (coefficients: float) : unit = nativeOnly

(***)
#r "nuget: Fable.Core"
(***)