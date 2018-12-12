﻿module Utils

open System.IO
open System.Reflection

let private inPath file =
    let sep = Path.DirectorySeparatorChar.ToString()
    let fullPath = 
        Assembly.GetCallingAssembly().Location
        |> Path.GetDirectoryName 
        |> fun dir -> dir + sep + "inputs" + sep + file + ".txt"
    fullPath

let getLines =
    inPath
    >> File.ReadAllLines 
    >> Array.toList

let getText =
    inPath >> File.ReadAllText

let strSplit sep (str : string) =
    str.Split([| sep |])
    |> Array.toList
