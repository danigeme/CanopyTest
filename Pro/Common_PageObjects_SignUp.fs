﻿module Pro.Common.PageObjects.SignUp

open canopy
open System


let btnCandidate = "//li[@class='chooseCandidate']"

let name = "#Name"
let lastname = "#LastName"
let lastname2 = "#LastName2"
let username = "#UserName"
let pss = "#Password"
//let daypicker = "//div[@class = 'container']/select[@class ='Day']"
//let monthpicker = "//div[@class = 'container']/select[@class ='Month']"
//let yearpicker = "//div[@class = 'container']/select[@class ='Year']"
//let gender = "//li[@class = 'gender']//input[@value='male']"
let daypicker = "//div[@class = 'container']/select"
let monthpicker = "//div[@class = 'container']/select[2]"
let yearpicker = "//div[@class = 'container']/select[3]"
let gender = "//li[@class = 'gender']//input[2]"


let btnRegister = "#RegisterButton"
