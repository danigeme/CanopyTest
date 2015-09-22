module Pro.RunTest

open Pro.Suite.SignUp

open canopy
open runner
open System

context "SignUp as a Candidate"
open Pro.Suite.SignUp 
test()
run()
let x = Console.ReadLine()