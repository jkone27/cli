module rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

[<AllowNullLiteral>]
[<Interface>]
type Locale =
    abstract member hello: config: Locale.hello.config -> string

module Locale =

    module hello =

        [<Global>]
        [<AllowNullLiteral>]
        type config
            [<ParamObject; Emit("$0")>]
            (
                verbose: bool
            ) =

            member val verbose : bool = nativeOnly with get, set

(***)
#r "nuget: Fable.Core"
#r "nuget: Glutinum.Types"
(***)
