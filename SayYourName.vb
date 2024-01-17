'Owen Fujii
'RCET 2265
'Spring 2024
'SayYourName
'https://github.com/Masaharu41/SayYourName.git

Option Explicit On
Option Strict On

Module SayYourName

    Sub Main()
        Dim userName As String

        Console.Write("What is Your Name? ")
        Console.WriteLine()
        userName = Console.ReadLine()

        Console.WriteLine($"Hello there {userName}!")

        Console.Read()
    End Sub

End Module
