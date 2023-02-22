Imports System.Reflection.Emit
Imports System.Security.Cryptography.X509Certificates
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Imports System.Drawing

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GlobalTimer.Start()
        ClickerNum = 1
        ClickerPrice = 10
        GrandadPrice = 20
        SiloPrice = 100
        CoalMinePrice = 300
        clickUpgrade = 1
        Clicker = 1
        GrandadUpgrade = 1

        UpdateTimer.Start()
        TabPage1.Text = ("Buildings")
        TabPage2.Text = ("Upgrades")

        lblTimer.Hide()
        PnlName.Hide()

        pnlButterFlyClicking.Hide()

        pnlDentures.Hide()
    End Sub

    Dim PerSecond As Integer
    Dim TotalAmount As Integer
    Dim time As Integer


    Dim clickUpgrade As Integer, GrandadUpgrade As Integer, SiloUpgrade As Integer, CoalMineUpgrade As Integer
    Dim Upgrades As Integer

    Dim ClickerPrice As Integer, Clicker As Integer, ClickerNum As Integer

    Dim Grandad As Integer, GrandadPrice As Integer, GrandadNum As Integer

    Dim Silo As Integer, SiloPrice As Integer, SiloNum As Integer

    Dim CoalMine As Integer, CoalMinePrice As Integer, CoalMineNum As Integer



    Private Sub Name_Click(sender As Object, e As EventArgs) Handles lblName.Click
        PnlName.Show()
    End Sub

    Public Sub GlobalTimer_Tick(sender As Object, e As EventArgs) Handles GlobalTimer.Tick
        time += 1
        Select Case PerSecond
            Case Grandad > 0
                TotalAmount += Grandad
            Case Silo > 0
                TotalAmount += Silo
            Case CoalMine > 0
                TotalAmount += CoalMine

        End Select


        lblOutput.Text = (TotalAmount + Grandad + Silo + CoalMine & " Biscuits")


    End Sub

    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        lblTimer.Text += 1
        PerSecond = Grandad + Silo + CoalMine
        If TotalAmount < 0 Then
            TotalAmount = 0
        End If
        lblPerSecond.Text = PerSecond
    End Sub

    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click
        PnlName.Hide()

        lblName.Text = tbxName.Text
        If lblName.Text = "" Then
            lblName.Text = "nothing"
        End If
    End Sub

    Private Sub btnBiscuit_MouseEnter(sender As Object, e As EventArgs) Handles btnBiscuit.MouseEnter
        Dim bmp As Bitmap = New Bitmap(btnBiscuit.Image)
        bmp.RotateFlip(RotateFlipType.Rotate180FlipY)

        btnBiscuit.Image = bmp
    End Sub

    Private Sub btnBiscuit_MouseLeave(sender As Object, e As EventArgs) Handles btnBiscuit.MouseLeave
        Dim bmp As Bitmap = New Bitmap(btnBiscuit.Image)
        bmp.RotateFlip(RotateFlipType.Rotate180FlipX)

        btnBiscuit.Image = bmp
    End Sub

    Private Sub mnuHideTimer_Click(sender As Object, e As EventArgs) Handles mnuHideTimer.Click
        lblTimer.Hide()
    End Sub

    Public Sub mnuPlus100_Click(sender As Object, e As EventArgs) Handles mnuPlus100.Click
        TotalAmount += 100
    End Sub

    Public Sub munMinus100_Click(sender As Object, e As EventArgs) Handles munMinus100.Click
        TotalAmount -= 100
    End Sub

    Public Sub mnuPerSecondPlus100_Click(sender As Object, e As EventArgs) Handles mnuPerSecondPlus100.Click
        PerSecond += 100
        lblPerSecond.Text = PerSecond
    End Sub

    Public Sub mnuPerSecondMinus100_Click(sender As Object, e As EventArgs) Handles mnuPerSecondMinus100.Click
        PerSecond -= 100
        lblPerSecond.Text = PerSecond
    End Sub

    Private Sub mnuReset_Click(sender As Object, e As EventArgs) Handles mnuReset.Click
        Application.Restart()
        Me.Refresh()
    End Sub

    Private Sub mnuShowTimer_Click(sender As Object, e As EventArgs) Handles mnuShowTimer.Click
        lblTimer.Show()
    End Sub

    Private Sub X1000ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles X1000ToolStripMenuItem.Click
        TotalAmount *= 1000
    End Sub

    Private Sub WinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WinToolStripMenuItem.Click
        TotalAmount = 2147483647
    End Sub



    Private Sub btnBiscuit_Click(sender As Object, e As EventArgs) Handles btnBiscuit.Click
        Dim bmp As Bitmap = New Bitmap(btnBiscuit.Image)
        bmp.RotateFlip(RotateFlipType.Rotate270FlipX)

        btnBiscuit.Image = bmp
        Dim a = Val(lblOutput.Text)
        Try

            TotalAmount += Clicker * clickUpgrade
            lblOutput.Text = (a & " Biscuits")
            btnUpgrade.Text = ("Upgrade click")
            btnGrandad.Text = ("Grandad")
            btnSilo.Text = ("Silo")
            btnCoalMine.Text = ("Coal Mine")
        Catch ex As Exception
            MessageBox.Show("You won, now go outside")
        End Try

    End Sub



    'building code'
    Private Sub btnUpgrade_Click(sender As Object, e As EventArgs) Handles btnUpgrade.Click
        If TotalAmount >= ClickerPrice Then
            lblClickerNum.Text += 1
            ClickerNum += 1
            Clicker += 1

            ClickerPrice += 2 * ClickerNum
            TotalAmount -= ClickerPrice + 8

            lblClickPrice.Text += 2 * ClickerNum
            lblOutput.Text = (TotalAmount & " Biscuits")


        Else
            btnUpgrade.Text = ("Can't Afford")
        End If

    End Sub

    Public Sub btnGrandad_Click(sender As Object, e As EventArgs) Handles btnGrandad.Click
        If TotalAmount >= GrandadPrice Then

            Grandad += 1 * GrandadUpgrade
            lblGrandadUpgradeNum.Text += 1
            GrandadNum += 1

            GrandadPrice += 5 * GrandadNum
            TotalAmount -= GrandadPrice

            lblGrandadPrice.Text += 5 * GrandadNum
            lblOutput.Text = (TotalAmount & " Biscuits")
        Else
            btnGrandad.Text = ("Can't Afford")
        End If




    End Sub

    Private Sub btnSilo_Click(sender As Object, e As EventArgs) Handles btnSilo.Click
        If TotalAmount >= SiloPrice Then

            Silo += 5
            lblSiloUpgradeNum.Text += 1
            SiloNum += 1

            SiloPrice += 9 * SiloNum
            TotalAmount -= SiloPrice

            lblSiloPrice.Text += 9 * SiloNum
            lblOutput.Text = (TotalAmount & " Biscuits")
        Else
            btnSilo.Text = ("Can't Afford")
        End If
    End Sub

    Private Sub btnCoalMine_Click(sender As Object, e As EventArgs) Handles btnCoalMine.Click
        If TotalAmount >= CoalMinePrice Then

            CoalMine += 15
            lblCoalMineUpgradeNum.Text += 1
            CoalMineNum += 1

            CoalMinePrice += 15 * CoalMineNum
            TotalAmount -= CoalMinePrice

            lblCoalMinePrice.Text += 15 * CoalMineNum
            lblOutput.Text = (TotalAmount & " Biscuits")
        Else
            btnCoalMine.Text = ("Can't Afford")
        End If
    End Sub



    'upgrade code'
    Private Sub btnButterFlyClicking_MouseEnter(sender As Object, e As EventArgs) Handles btnButterFlyClicking.MouseEnter
        pnlButterFlyClicking.Show()

        If TotalAmount < 100 Then
            lblButterFlyClickingPrice.ForeColor = Color.Red
        Else
            lblButterFlyClickingPrice.ForeColor = Color.Black
        End If
        If ClickerNum < 5 Then
            lblClickerReq.ForeColor = Color.Red
        Else
            lblClickerReq.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnButterFlyClicking_MouseLeave(sender As Object, e As EventArgs) Handles btnButterFlyClicking.MouseLeave
        pnlButterFlyClicking.Hide()
    End Sub

    Private Sub btnButterFlyClicking_Click(sender As Object, e As EventArgs) Handles btnButterFlyClicking.Click
        If TotalAmount >= 100 And ClickerNum >= 5 Then
            clickUpgrade += 2
            btnButterFlyClicking.Text = "Purchased"
            lblClickerReq.Text = "Purchased"
            lblButterFlyClickingPrice.Text = "Purchased"
            TotalAmount -= 100
        End If
    End Sub



    Private Sub btnDenturesUpgrade_MouseEnter(sender As Object, e As EventArgs) Handles btnDenturesUpgrade.MouseEnter
        pnlDentures.Show()
        If TotalAmount < 500 Then
            lblDenturesPrice.ForeColor = Color.Red
        Else
            lblDenturesPrice.ForeColor = Color.Black
        End If
        If GrandadNum < 10 Then
            lblDenturesReq.ForeColor = Color.Red
        Else
            lblDenturesReq.ForeColor = Color.Black
        End If
    End Sub
    Private Sub btnDenturesUpgrade_MouseLeave(sender As Object, e As EventArgs) Handles btnDenturesUpgrade.MouseLeave
        pnlDentures.Hide()
    End Sub
    Private Sub btnDenturesUpgrade_Click(sender As Object, e As EventArgs) Handles btnDenturesUpgrade.Click
        If TotalAmount >= 500 And GrandadNum >= 10 Then
            GrandadUpgrade += 1
            btnDenturesUpgrade.Text = "Purchased"
            lblDenturesReq.Text = "Purchased"
            lblDenturesPrice.Text = "Purchased"
            TotalAmount -= 500
        End If

    End Sub


End Class
