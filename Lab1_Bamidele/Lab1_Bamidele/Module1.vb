Module Module1

    Sub Main()
        Dim firstName As String
        Dim MiddleInitial As Char
        Dim lastName As String
        Dim fullName As String
        Dim age As Integer
        Dim isCitizen As Boolean
        Dim canVote As Boolean
        Dim heightFeet As Integer
        Dim heightInches As Decimal
        Dim totalHeightCM As Decimal


        firstName = "Oluwakemi"
        MiddleInitial = "A"
        lastName = "Bamidele"
        fullName = firstName & " " & MiddleInitial & "." & lastName


        age = 32
        heightFeet = 5
        heightInches = 4

        Dim totalHeightInches As Decimal = (heightFeet * 12) + heightInches

        totalHeightCM = 2.54 * totalHeightInches

        isCitizen = True
        canVote = isCitizen And age >= 18









    End Sub

End Module
