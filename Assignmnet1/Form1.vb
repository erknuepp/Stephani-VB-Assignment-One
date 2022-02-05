Public Class Form1
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim dblEarth As Double
        Dim dblVenus As Double
        Dim dblMars As Double
        Dim dblJupiter As Double
        Double.TryParse(EarthWeightTextBox.Text, dblEarth)
        dblVenus = dblEarth * 0.91
        dblMars = dblEarth * 0.38
        dblJupiter = dblEarth * 2.53
        VenusWeightTextBox.Text = dblVenus.ToString("N2")
        MarsWeightTextBox.Text = dblMars.ToString("N2")
        JupiterWeightTextBox.Text = dblJupiter.ToString("N2")

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub
End Class
