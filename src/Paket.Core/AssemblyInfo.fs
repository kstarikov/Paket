﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Paket.Core")>]
[<assembly: AssemblyProductAttribute("Paket")>]
[<assembly: AssemblyCompanyAttribute("Paket team")>]
[<assembly: AssemblyDescriptionAttribute("A package dependency manager for .NET with support for NuGet packages and GitHub repositories.")>]
[<assembly: AssemblyVersionAttribute("2.58.13")>]
[<assembly: AssemblyFileVersionAttribute("2.58.13")>]
[<assembly: AssemblyInformationalVersionAttribute("2.58.13")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "2.58.13"
    let [<Literal>] InformationalVersion = "2.58.13"
