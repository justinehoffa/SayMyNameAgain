﻿
Option Strict On
Option Explicit On
Option Compare Text

'Justine Hffa
'RCET0265
'Fall 2020
'Say My Name Again
'https://github.com/justinehoffa/SayMyNameAgain

Module SayMyNameAgain

        Sub Main()
            Dim userInput As String

            Console.WriteLine("What is your name?")
            userInput = Console.ReadLine()

        If userInput = "Emily" Then
            Console.WriteLine("Hi Emily.")

        ElseIf userInput = "Joe" Then
            Console.WriteLine("Hi, Joe.")

        ElseIf userInput = "Justine" Then
            Console.WriteLine("ew")

        ElseIf userInput = "Tim" Then
            Console.WriteLine("Hi, Tim!")

        End If

            Console.ReadLine()

        End Sub
    End Module

