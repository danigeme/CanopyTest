module Pro.Suite.SignUp
open Pro.Core.SignUp

open canopy
open System
open runner
open types
open Pro.Common.Helper.Config

let test ()=
    "Sign up as Professional" &&&& (fun _->
    start browser
    pin FullScreen
    url urlpro
    SignUpTest()
    )


