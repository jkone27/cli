module rec Glutinum

open Fable.Core
open Fable.Core.JsInterop
open System

[<Erase>]
type Exports =
    [<Import("Fuse", "REPLACE_ME_WITH_MODULE_NAME"); EmitConstructor>]
    static member Fuse () : Fuse = nativeOnly

[<AllowNullLiteral>]
[<Interface>]
type Fuse =
    static member inline version
        with get () : string =
            emitJsExpr () $$"""
import { Fuse } from "module";
Fuse.version"""
        and set (value: string) =
            emitJsExpr (value) $$"""
import { Fuse } from "module";
Fuse.version = $0"""

(***)
#r "nuget: Fable.Core"
(***)