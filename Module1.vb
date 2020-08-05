
Module Module1

    Sub Main()

        Dim mark As String

        Console.WriteLine("Please enter your mark: ")

        mark = Console.ReadLine

        Convert.ToInt16(mark)

        If mark >= 80 Then

            Console.WriteLine("Distinction!")

        ElseIf mark >= 60 Then

            Console.WriteLine("Merit")

        ElseIf mark >= 40 Then

            Console.WriteLine("Pass")

        Else

            Console.WriteLine("Fail")

        End If

        Console.Read()

    End Sub

End Module
