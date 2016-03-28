namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("My1stTestRepo")>]
[<assembly: AssemblyProductAttribute("My1stTestRepo")>]
[<assembly: AssemblyDescriptionAttribute("Test Repo")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
