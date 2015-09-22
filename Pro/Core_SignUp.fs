module Pro.Core.SignUp
open Pro.Common.PageObjects.SignUp

open canopy
open runner
open System
open types

let SignUpTest() =
    Console.WriteLine("Sign up as Professional")
    Console.WriteLine("Wait for 5 secs")
    sleep 5
    click btnCandidate
    Console.WriteLine("Fill the Form")
    name << "Danny"
    lastname << "#Alv C"
    lastname2 << "#Mtz"
    username << "danny@mailinator.com"
    pss << "training"
    daypicker << "15"
    monthpicker << "12"
    yearpicker << "1992"
    click gender
    click btnRegister

()

