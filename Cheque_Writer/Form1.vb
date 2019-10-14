Public Class Form1
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnwrite_Click(sender As Object, e As EventArgs) Handles btnwrite.Click
        lbldate.Text = "Date:" & DateString
        lblname.Text = "Sagar Acharya"
        lblamt.Text = txtamt.Text + ".00"
        lblwords.Text = GroupToWords(txtamt.Text) + "Dollars"





    End Sub


    ' Convert a number between 0 and 999 into words.
    Private Function GroupToWords(ByVal num As Integer) As _
        String
        Static one_to_nineteen() As String = {"zero", "one",
            "Two", "Three", "Four", "Five", "Six", "Seven",
            "Eight", "nine", "ten", "eleven", "twelve",
            "thirteen", "fourteen", "fifteen", "sixteen",
            "seventeen", "eightteen", "nineteen"}
        Static multiples_of_ten() As String = {"twenty",
            "thirty", "forty", "fifty", "sixty", "seventy",
            "eighty", "ninety"}

        ' If the number is 0, return an empty string.
        If num = 0 Then Return ""

        ' Handle the hundreds digit.
        Dim digit As Integer
        Dim result As String = ""
        If num > 99 Then
            digit = num \ 100
            num = num Mod 100
            result = one_to_nineteen(digit) & " hundred"
        End If

        ' If num = 0, we have hundreds only.
        If num = 0 Then Return result.Trim()

        ' See if the rest is less than 20.
        If num < 20 Then
            ' Look up the correct name.
            result &= " " & one_to_nineteen(num)
        Else
            ' Handle the tens digit.
            digit = num \ 10
            num = num Mod 10
            result &= " " & multiples_of_ten(digit - 2)

            ' Handle the final digit.
            If num > 0 Then
                result &= " " & one_to_nineteen(num)
            End If
        End If

        Return result.Trim()
    End Function





End Class

