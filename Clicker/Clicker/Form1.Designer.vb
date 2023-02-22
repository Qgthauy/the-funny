<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnUpgrade = New System.Windows.Forms.Button()
        Me.btnGrandad = New System.Windows.Forms.Button()
        Me.lblPerSecondTitle = New System.Windows.Forms.Label()
        Me.lblClickPrice = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.GlobalTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblClickerNum = New System.Windows.Forms.Label()
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblGrandadUpgradeNum = New System.Windows.Forms.Label()
        Me.lblGrandadPrice = New System.Windows.Forms.Label()
        Me.lblPerSecond = New System.Windows.Forms.Label()
        Me.lblSiloPrice = New System.Windows.Forms.Label()
        Me.lblSiloUpgradeNum = New System.Windows.Forms.Label()
        Me.btnSilo = New System.Windows.Forms.Button()
        Me.btnBiscuit = New System.Windows.Forms.PictureBox()
        Me.Debug = New System.Windows.Forms.MenuStrip()
        Me.DebugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPlus100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.munMinus100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPerSecondPlus100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPerSecondMinus100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowTimer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHideTimer = New System.Windows.Forms.ToolStripMenuItem()
        Me.X1000ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VariablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerSecondToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalAmounToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClickUpgradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClickUpgradeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClickerPriceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClickerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClickerNumToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrandadUpgradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrandadUpgradeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrandadPriceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrandadNumToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpgradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClickUpgradeToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrandadUpgradeToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiloUpgradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoalMineUpgradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiloUpgradeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiloPriceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SiloNumToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoalMineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoalMineUpgradeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoalMinePriceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CoalMineNumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblCoalMinePrice = New System.Windows.Forms.Label()
        Me.lblCoalMineUpgradeNum = New System.Windows.Forms.Label()
        Me.btnCoalMine = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.gbxGrandadUpgrade = New System.Windows.Forms.GroupBox()
        Me.pnlButterFlyClicking = New System.Windows.Forms.Panel()
        Me.lblClickerReq = New System.Windows.Forms.Label()
        Me.lblButterFlyClickingPrice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxClickerUpgrade = New System.Windows.Forms.GroupBox()
        Me.btnButterFlyClicking = New System.Windows.Forms.Button()
        Me.pnlDentures = New System.Windows.Forms.Panel()
        Me.lblDenturesReq = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDenturesPrice = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDenturesUpgrade = New System.Windows.Forms.Button()
        Me.PnlName = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnName = New System.Windows.Forms.Button()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.btnBiscuit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Debug.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.gbxGrandadUpgrade.SuspendLayout()
        Me.pnlButterFlyClicking.SuspendLayout()
        Me.gbxClickerUpgrade.SuspendLayout()
        Me.pnlDentures.SuspendLayout()
        Me.PnlName.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblOutput.Location = New System.Drawing.Point(27, 60)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(161, 40)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.Text = "0 Biscuits"
        '
        'btnUpgrade
        '
        Me.btnUpgrade.Location = New System.Drawing.Point(42, 19)
        Me.btnUpgrade.Name = "btnUpgrade"
        Me.btnUpgrade.Size = New System.Drawing.Size(99, 24)
        Me.btnUpgrade.TabIndex = 2
        Me.btnUpgrade.Text = "Clicker"
        Me.btnUpgrade.UseVisualStyleBackColor = True
        '
        'btnGrandad
        '
        Me.btnGrandad.Location = New System.Drawing.Point(42, 48)
        Me.btnGrandad.Name = "btnGrandad"
        Me.btnGrandad.Size = New System.Drawing.Size(99, 24)
        Me.btnGrandad.TabIndex = 3
        Me.btnGrandad.Text = "Grandad"
        Me.btnGrandad.UseVisualStyleBackColor = True
        '
        'lblPerSecondTitle
        '
        Me.lblPerSecondTitle.AutoSize = True
        Me.lblPerSecondTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPerSecondTitle.Location = New System.Drawing.Point(46, 111)
        Me.lblPerSecondTitle.Name = "lblPerSecondTitle"
        Me.lblPerSecondTitle.Size = New System.Drawing.Size(73, 15)
        Me.lblPerSecondTitle.TabIndex = 4
        Me.lblPerSecondTitle.Text = "Per Second:"
        '
        'lblClickPrice
        '
        Me.lblClickPrice.AutoSize = True
        Me.lblClickPrice.Location = New System.Drawing.Point(151, 22)
        Me.lblClickPrice.Name = "lblClickPrice"
        Me.lblClickPrice.Size = New System.Drawing.Size(19, 15)
        Me.lblClickPrice.TabIndex = 5
        Me.lblClickPrice.Text = "10"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(46, 145)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(13, 15)
        Me.lblTimer.TabIndex = 6
        Me.lblTimer.Text = "0"
        '
        'GlobalTimer
        '
        Me.GlobalTimer.Interval = 1000
        '
        'lblClickerNum
        '
        Me.lblClickerNum.AutoSize = True
        Me.lblClickerNum.Location = New System.Drawing.Point(8, 24)
        Me.lblClickerNum.Name = "lblClickerNum"
        Me.lblClickerNum.Size = New System.Drawing.Size(13, 15)
        Me.lblClickerNum.TabIndex = 7
        Me.lblClickerNum.Text = "0"
        '
        'UpdateTimer
        '
        Me.UpdateTimer.Interval = 1
        '
        'lblGrandadUpgradeNum
        '
        Me.lblGrandadUpgradeNum.AutoSize = True
        Me.lblGrandadUpgradeNum.Location = New System.Drawing.Point(8, 53)
        Me.lblGrandadUpgradeNum.Name = "lblGrandadUpgradeNum"
        Me.lblGrandadUpgradeNum.Size = New System.Drawing.Size(13, 15)
        Me.lblGrandadUpgradeNum.TabIndex = 8
        Me.lblGrandadUpgradeNum.Text = "0"
        '
        'lblGrandadPrice
        '
        Me.lblGrandadPrice.AutoSize = True
        Me.lblGrandadPrice.Location = New System.Drawing.Point(151, 53)
        Me.lblGrandadPrice.Name = "lblGrandadPrice"
        Me.lblGrandadPrice.Size = New System.Drawing.Size(19, 15)
        Me.lblGrandadPrice.TabIndex = 9
        Me.lblGrandadPrice.Text = "20"
        '
        'lblPerSecond
        '
        Me.lblPerSecond.AutoSize = True
        Me.lblPerSecond.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPerSecond.Location = New System.Drawing.Point(118, 111)
        Me.lblPerSecond.Name = "lblPerSecond"
        Me.lblPerSecond.Size = New System.Drawing.Size(14, 15)
        Me.lblPerSecond.TabIndex = 10
        Me.lblPerSecond.Text = "0"
        '
        'lblSiloPrice
        '
        Me.lblSiloPrice.AutoSize = True
        Me.lblSiloPrice.Location = New System.Drawing.Point(151, 86)
        Me.lblSiloPrice.Name = "lblSiloPrice"
        Me.lblSiloPrice.Size = New System.Drawing.Size(25, 15)
        Me.lblSiloPrice.TabIndex = 15
        Me.lblSiloPrice.Text = "100"
        '
        'lblSiloUpgradeNum
        '
        Me.lblSiloUpgradeNum.AutoSize = True
        Me.lblSiloUpgradeNum.Location = New System.Drawing.Point(8, 82)
        Me.lblSiloUpgradeNum.Name = "lblSiloUpgradeNum"
        Me.lblSiloUpgradeNum.Size = New System.Drawing.Size(13, 15)
        Me.lblSiloUpgradeNum.TabIndex = 14
        Me.lblSiloUpgradeNum.Text = "0"
        '
        'btnSilo
        '
        Me.btnSilo.Location = New System.Drawing.Point(42, 78)
        Me.btnSilo.Name = "btnSilo"
        Me.btnSilo.Size = New System.Drawing.Size(99, 23)
        Me.btnSilo.TabIndex = 10
        Me.btnSilo.Text = "Slio"
        Me.btnSilo.UseVisualStyleBackColor = True
        '
        'btnBiscuit
        '
        Me.btnBiscuit.Image = CType(resources.GetObject("btnBiscuit.Image"), System.Drawing.Image)
        Me.btnBiscuit.Location = New System.Drawing.Point(27, 164)
        Me.btnBiscuit.Name = "btnBiscuit"
        Me.btnBiscuit.Size = New System.Drawing.Size(484, 236)
        Me.btnBiscuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBiscuit.TabIndex = 13
        Me.btnBiscuit.TabStop = False
        '
        'Debug
        '
        Me.Debug.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DebugToolStripMenuItem})
        Me.Debug.Location = New System.Drawing.Point(0, 0)
        Me.Debug.Name = "Debug"
        Me.Debug.Size = New System.Drawing.Size(1004, 24)
        Me.Debug.TabIndex = 15
        '
        'DebugToolStripMenuItem
        '
        Me.DebugToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPlus100, Me.munMinus100, Me.mnuPerSecondPlus100, Me.mnuPerSecondMinus100, Me.mnuReset, Me.mnuShowTimer, Me.mnuHideTimer, Me.X1000ToolStripMenuItem, Me.WinToolStripMenuItem, Me.VariablesToolStripMenuItem})
        Me.DebugToolStripMenuItem.Name = "DebugToolStripMenuItem"
        Me.DebugToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.DebugToolStripMenuItem.Text = "Debug"
        '
        'mnuPlus100
        '
        Me.mnuPlus100.Name = "mnuPlus100"
        Me.mnuPlus100.Size = New System.Drawing.Size(165, 22)
        Me.mnuPlus100.Text = "+100"
        '
        'munMinus100
        '
        Me.munMinus100.Name = "munMinus100"
        Me.munMinus100.Size = New System.Drawing.Size(165, 22)
        Me.munMinus100.Text = "-100"
        '
        'mnuPerSecondPlus100
        '
        Me.mnuPerSecondPlus100.Name = "mnuPerSecondPlus100"
        Me.mnuPerSecondPlus100.Size = New System.Drawing.Size(165, 22)
        Me.mnuPerSecondPlus100.Text = "Per Second + 100"
        '
        'mnuPerSecondMinus100
        '
        Me.mnuPerSecondMinus100.Name = "mnuPerSecondMinus100"
        Me.mnuPerSecondMinus100.Size = New System.Drawing.Size(165, 22)
        Me.mnuPerSecondMinus100.Text = "Per Second - 100"
        '
        'mnuReset
        '
        Me.mnuReset.Name = "mnuReset"
        Me.mnuReset.Size = New System.Drawing.Size(165, 22)
        Me.mnuReset.Text = "Reset"
        '
        'mnuShowTimer
        '
        Me.mnuShowTimer.Name = "mnuShowTimer"
        Me.mnuShowTimer.Size = New System.Drawing.Size(165, 22)
        Me.mnuShowTimer.Text = "Show Timer"
        '
        'mnuHideTimer
        '
        Me.mnuHideTimer.Name = "mnuHideTimer"
        Me.mnuHideTimer.Size = New System.Drawing.Size(165, 22)
        Me.mnuHideTimer.Text = "Hide Timer"
        '
        'X1000ToolStripMenuItem
        '
        Me.X1000ToolStripMenuItem.Name = "X1000ToolStripMenuItem"
        Me.X1000ToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.X1000ToolStripMenuItem.Text = "x1000"
        '
        'WinToolStripMenuItem
        '
        Me.WinToolStripMenuItem.Name = "WinToolStripMenuItem"
        Me.WinToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.WinToolStripMenuItem.Text = "win"
        '
        'VariablesToolStripMenuItem
        '
        Me.VariablesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerSecondToolStripMenuItem, Me.TotalAmounToolStripMenuItem, Me.TimeToolStripMenuItem, Me.ClickUpgradeToolStripMenuItem, Me.GrandadUpgradeToolStripMenuItem, Me.UpgradesToolStripMenuItem, Me.SiloToolStripMenuItem, Me.CoalMineToolStripMenuItem})
        Me.VariablesToolStripMenuItem.Name = "VariablesToolStripMenuItem"
        Me.VariablesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.VariablesToolStripMenuItem.Text = "Variables"
        '
        'PerSecondToolStripMenuItem
        '
        Me.PerSecondToolStripMenuItem.Name = "PerSecondToolStripMenuItem"
        Me.PerSecondToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PerSecondToolStripMenuItem.Text = "PerSecond "
        '
        'TotalAmounToolStripMenuItem
        '
        Me.TotalAmounToolStripMenuItem.Name = "TotalAmounToolStripMenuItem"
        Me.TotalAmounToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.TotalAmounToolStripMenuItem.Text = "TotalAmount"
        '
        'TimeToolStripMenuItem
        '
        Me.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        Me.TimeToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.TimeToolStripMenuItem.Text = "time"
        '
        'ClickUpgradeToolStripMenuItem
        '
        Me.ClickUpgradeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClickUpgradeToolStripMenuItem1, Me.ClickerPriceToolStripMenuItem1, Me.ClickerToolStripMenuItem1, Me.ClickerNumToolStripMenuItem1})
        Me.ClickUpgradeToolStripMenuItem.Name = "ClickUpgradeToolStripMenuItem"
        Me.ClickUpgradeToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ClickUpgradeToolStripMenuItem.Text = "Click"
        '
        'ClickUpgradeToolStripMenuItem1
        '
        Me.ClickUpgradeToolStripMenuItem1.Name = "ClickUpgradeToolStripMenuItem1"
        Me.ClickUpgradeToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.ClickUpgradeToolStripMenuItem1.Text = "clickUpgrade"
        '
        'ClickerPriceToolStripMenuItem1
        '
        Me.ClickerPriceToolStripMenuItem1.Name = "ClickerPriceToolStripMenuItem1"
        Me.ClickerPriceToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.ClickerPriceToolStripMenuItem1.Text = "ClickerPrice"
        '
        'ClickerToolStripMenuItem1
        '
        Me.ClickerToolStripMenuItem1.Name = "ClickerToolStripMenuItem1"
        Me.ClickerToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.ClickerToolStripMenuItem1.Text = "Clicker"
        '
        'ClickerNumToolStripMenuItem1
        '
        Me.ClickerNumToolStripMenuItem1.Name = "ClickerNumToolStripMenuItem1"
        Me.ClickerNumToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.ClickerNumToolStripMenuItem1.Text = "ClickerNum"
        '
        'GrandadUpgradeToolStripMenuItem
        '
        Me.GrandadUpgradeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GrandadUpgradeToolStripMenuItem1, Me.GrandadPriceToolStripMenuItem1, Me.GrandadNumToolStripMenuItem1})
        Me.GrandadUpgradeToolStripMenuItem.Name = "GrandadUpgradeToolStripMenuItem"
        Me.GrandadUpgradeToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.GrandadUpgradeToolStripMenuItem.Text = "Grandad"
        '
        'GrandadUpgradeToolStripMenuItem1
        '
        Me.GrandadUpgradeToolStripMenuItem1.Name = "GrandadUpgradeToolStripMenuItem1"
        Me.GrandadUpgradeToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.GrandadUpgradeToolStripMenuItem1.Text = "GrandadUpgrade"
        '
        'GrandadPriceToolStripMenuItem1
        '
        Me.GrandadPriceToolStripMenuItem1.Name = "GrandadPriceToolStripMenuItem1"
        Me.GrandadPriceToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.GrandadPriceToolStripMenuItem1.Text = "GrandadPrice"
        '
        'GrandadNumToolStripMenuItem1
        '
        Me.GrandadNumToolStripMenuItem1.Name = "GrandadNumToolStripMenuItem1"
        Me.GrandadNumToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.GrandadNumToolStripMenuItem1.Text = "GrandadNum"
        '
        'UpgradesToolStripMenuItem
        '
        Me.UpgradesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClickUpgradeToolStripMenuItem2, Me.GrandadUpgradeToolStripMenuItem2, Me.SiloUpgradeToolStripMenuItem, Me.CoalMineUpgradeToolStripMenuItem})
        Me.UpgradesToolStripMenuItem.Name = "UpgradesToolStripMenuItem"
        Me.UpgradesToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.UpgradesToolStripMenuItem.Text = "Upgrades"
        '
        'ClickUpgradeToolStripMenuItem2
        '
        Me.ClickUpgradeToolStripMenuItem2.Name = "ClickUpgradeToolStripMenuItem2"
        Me.ClickUpgradeToolStripMenuItem2.Size = New System.Drawing.Size(170, 22)
        Me.ClickUpgradeToolStripMenuItem2.Text = "ClickUpgrade"
        '
        'GrandadUpgradeToolStripMenuItem2
        '
        Me.GrandadUpgradeToolStripMenuItem2.Name = "GrandadUpgradeToolStripMenuItem2"
        Me.GrandadUpgradeToolStripMenuItem2.Size = New System.Drawing.Size(170, 22)
        Me.GrandadUpgradeToolStripMenuItem2.Text = "GrandadUpgrade"
        '
        'SiloUpgradeToolStripMenuItem
        '
        Me.SiloUpgradeToolStripMenuItem.Name = "SiloUpgradeToolStripMenuItem"
        Me.SiloUpgradeToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SiloUpgradeToolStripMenuItem.Text = "SiloUpgrade"
        '
        'CoalMineUpgradeToolStripMenuItem
        '
        Me.CoalMineUpgradeToolStripMenuItem.Name = "CoalMineUpgradeToolStripMenuItem"
        Me.CoalMineUpgradeToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CoalMineUpgradeToolStripMenuItem.Text = "CoalMineUpgrade"
        '
        'SiloToolStripMenuItem
        '
        Me.SiloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SiloUpgradeToolStripMenuItem1, Me.SiloPriceToolStripMenuItem1, Me.SiloNumToolStripMenuItem1})
        Me.SiloToolStripMenuItem.Name = "SiloToolStripMenuItem"
        Me.SiloToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SiloToolStripMenuItem.Text = "Silo"
        '
        'SiloUpgradeToolStripMenuItem1
        '
        Me.SiloUpgradeToolStripMenuItem1.Name = "SiloUpgradeToolStripMenuItem1"
        Me.SiloUpgradeToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.SiloUpgradeToolStripMenuItem1.Text = "SiloUpgrade"
        '
        'SiloPriceToolStripMenuItem1
        '
        Me.SiloPriceToolStripMenuItem1.Name = "SiloPriceToolStripMenuItem1"
        Me.SiloPriceToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.SiloPriceToolStripMenuItem1.Text = "SiloPrice"
        '
        'SiloNumToolStripMenuItem1
        '
        Me.SiloNumToolStripMenuItem1.Name = "SiloNumToolStripMenuItem1"
        Me.SiloNumToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.SiloNumToolStripMenuItem1.Text = "SiloNum"
        '
        'CoalMineToolStripMenuItem
        '
        Me.CoalMineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CoalMineUpgradeToolStripMenuItem1, Me.CoalMinePriceToolStripMenuItem, Me.CoalMineNumToolStripMenuItem})
        Me.CoalMineToolStripMenuItem.Name = "CoalMineToolStripMenuItem"
        Me.CoalMineToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CoalMineToolStripMenuItem.Text = "Coal Mine"
        '
        'CoalMineUpgradeToolStripMenuItem1
        '
        Me.CoalMineUpgradeToolStripMenuItem1.Name = "CoalMineUpgradeToolStripMenuItem1"
        Me.CoalMineUpgradeToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.CoalMineUpgradeToolStripMenuItem1.Text = "CoalMineUpgrade"
        '
        'CoalMinePriceToolStripMenuItem
        '
        Me.CoalMinePriceToolStripMenuItem.Name = "CoalMinePriceToolStripMenuItem"
        Me.CoalMinePriceToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CoalMinePriceToolStripMenuItem.Text = "CoalMinePrice"
        '
        'CoalMineNumToolStripMenuItem
        '
        Me.CoalMineNumToolStripMenuItem.Name = "CoalMineNumToolStripMenuItem"
        Me.CoalMineNumToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CoalMineNumToolStripMenuItem.Text = "CoalMineNum"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(588, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(404, 465)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblCoalMinePrice)
        Me.TabPage1.Controls.Add(Me.lblCoalMineUpgradeNum)
        Me.TabPage1.Controls.Add(Me.btnCoalMine)
        Me.TabPage1.Controls.Add(Me.btnGrandad)
        Me.TabPage1.Controls.Add(Me.lblSiloPrice)
        Me.TabPage1.Controls.Add(Me.lblGrandadUpgradeNum)
        Me.TabPage1.Controls.Add(Me.lblClickerNum)
        Me.TabPage1.Controls.Add(Me.lblSiloUpgradeNum)
        Me.TabPage1.Controls.Add(Me.lblGrandadPrice)
        Me.TabPage1.Controls.Add(Me.btnSilo)
        Me.TabPage1.Controls.Add(Me.lblClickPrice)
        Me.TabPage1.Controls.Add(Me.btnUpgrade)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(396, 437)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblCoalMinePrice
        '
        Me.lblCoalMinePrice.AutoSize = True
        Me.lblCoalMinePrice.Location = New System.Drawing.Point(151, 111)
        Me.lblCoalMinePrice.Name = "lblCoalMinePrice"
        Me.lblCoalMinePrice.Size = New System.Drawing.Size(25, 15)
        Me.lblCoalMinePrice.TabIndex = 18
        Me.lblCoalMinePrice.Text = "300"
        '
        'lblCoalMineUpgradeNum
        '
        Me.lblCoalMineUpgradeNum.AutoSize = True
        Me.lblCoalMineUpgradeNum.Location = New System.Drawing.Point(8, 111)
        Me.lblCoalMineUpgradeNum.Name = "lblCoalMineUpgradeNum"
        Me.lblCoalMineUpgradeNum.Size = New System.Drawing.Size(13, 15)
        Me.lblCoalMineUpgradeNum.TabIndex = 17
        Me.lblCoalMineUpgradeNum.Text = "0"
        '
        'btnCoalMine
        '
        Me.btnCoalMine.Location = New System.Drawing.Point(42, 107)
        Me.btnCoalMine.Name = "btnCoalMine"
        Me.btnCoalMine.Size = New System.Drawing.Size(99, 23)
        Me.btnCoalMine.TabIndex = 16
        Me.btnCoalMine.Text = "Coal Mine"
        Me.btnCoalMine.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.pnlButterFlyClicking)
        Me.TabPage2.Controls.Add(Me.pnlDentures)
        Me.TabPage2.Controls.Add(Me.gbxClickerUpgrade)
        Me.TabPage2.Controls.Add(Me.gbxGrandadUpgrade)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(396, 437)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'gbxGrandadUpgrade
        '
        Me.gbxGrandadUpgrade.Controls.Add(Me.btnDenturesUpgrade)
        Me.gbxGrandadUpgrade.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gbxGrandadUpgrade.Location = New System.Drawing.Point(23, 122)
        Me.gbxGrandadUpgrade.Name = "gbxGrandadUpgrade"
        Me.gbxGrandadUpgrade.Size = New System.Drawing.Size(356, 100)
        Me.gbxGrandadUpgrade.TabIndex = 6
        Me.gbxGrandadUpgrade.TabStop = False
        Me.gbxGrandadUpgrade.Text = "Grandad Upgrades"
        '
        'pnlButterFlyClicking
        '
        Me.pnlButterFlyClicking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlButterFlyClicking.Controls.Add(Me.lblClickerReq)
        Me.pnlButterFlyClicking.Controls.Add(Me.lblButterFlyClickingPrice)
        Me.pnlButterFlyClicking.Controls.Add(Me.Label4)
        Me.pnlButterFlyClicking.Controls.Add(Me.Label3)
        Me.pnlButterFlyClicking.Controls.Add(Me.Label2)
        Me.pnlButterFlyClicking.Location = New System.Drawing.Point(136, 41)
        Me.pnlButterFlyClicking.Name = "pnlButterFlyClicking"
        Me.pnlButterFlyClicking.Size = New System.Drawing.Size(243, 125)
        Me.pnlButterFlyClicking.TabIndex = 1
        '
        'lblClickerReq
        '
        Me.lblClickerReq.AutoSize = True
        Me.lblClickerReq.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblClickerReq.ForeColor = System.Drawing.Color.Red
        Me.lblClickerReq.Location = New System.Drawing.Point(8, 102)
        Me.lblClickerReq.Name = "lblClickerReq"
        Me.lblClickerReq.Size = New System.Drawing.Size(112, 15)
        Me.lblClickerReq.TabIndex = 19
        Me.lblClickerReq.Text = "Requires 5 Clickers"
        '
        'lblButterFlyClickingPrice
        '
        Me.lblButterFlyClickingPrice.AutoSize = True
        Me.lblButterFlyClickingPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblButterFlyClickingPrice.Location = New System.Drawing.Point(150, 11)
        Me.lblButterFlyClickingPrice.Name = "lblButterFlyClickingPrice"
        Me.lblButterFlyClickingPrice.Size = New System.Drawing.Size(37, 21)
        Me.lblButterFlyClickingPrice.TabIndex = 3
        Me.lblButterFlyClickingPrice.Text = "100"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(3, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cus three fingers are better than one" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 30)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Clicking is three times more " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "efficent"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(-1, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ButterFly Clicking"
        '
        'gbxClickerUpgrade
        '
        Me.gbxClickerUpgrade.Controls.Add(Me.btnButterFlyClicking)
        Me.gbxClickerUpgrade.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gbxClickerUpgrade.Location = New System.Drawing.Point(23, 16)
        Me.gbxClickerUpgrade.Name = "gbxClickerUpgrade"
        Me.gbxClickerUpgrade.Size = New System.Drawing.Size(370, 100)
        Me.gbxClickerUpgrade.TabIndex = 5
        Me.gbxClickerUpgrade.TabStop = False
        Me.gbxClickerUpgrade.Text = "Clicker Upgrades"
        '
        'btnButterFlyClicking
        '
        Me.btnButterFlyClicking.Location = New System.Drawing.Point(6, 26)
        Me.btnButterFlyClicking.Name = "btnButterFlyClicking"
        Me.btnButterFlyClicking.Size = New System.Drawing.Size(108, 32)
        Me.btnButterFlyClicking.TabIndex = 0
        Me.btnButterFlyClicking.Text = "ButterFly Clicking"
        Me.btnButterFlyClicking.UseVisualStyleBackColor = True
        '
        'pnlDentures
        '
        Me.pnlDentures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDentures.Controls.Add(Me.lblDenturesReq)
        Me.pnlDentures.Controls.Add(Me.Label7)
        Me.pnlDentures.Controls.Add(Me.Label6)
        Me.pnlDentures.Controls.Add(Me.lblDenturesPrice)
        Me.pnlDentures.Controls.Add(Me.Label5)
        Me.pnlDentures.Location = New System.Drawing.Point(140, 156)
        Me.pnlDentures.Name = "pnlDentures"
        Me.pnlDentures.Size = New System.Drawing.Size(243, 125)
        Me.pnlDentures.TabIndex = 3
        '
        'lblDenturesReq
        '
        Me.lblDenturesReq.AutoSize = True
        Me.lblDenturesReq.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDenturesReq.ForeColor = System.Drawing.Color.Red
        Me.lblDenturesReq.Location = New System.Drawing.Point(8, 99)
        Me.lblDenturesReq.Name = "lblDenturesReq"
        Me.lblDenturesReq.Size = New System.Drawing.Size(128, 15)
        Me.lblDenturesReq.TabIndex = 4
        Me.lblDenturesReq.Text = "Requires 10 Grandads"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(3, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Grandads are so much happier when they " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "can chew food like normal people"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Grandads are Twice as efficent"
        '
        'lblDenturesPrice
        '
        Me.lblDenturesPrice.AutoSize = True
        Me.lblDenturesPrice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblDenturesPrice.Location = New System.Drawing.Point(150, 18)
        Me.lblDenturesPrice.Name = "lblDenturesPrice"
        Me.lblDenturesPrice.Size = New System.Drawing.Size(37, 21)
        Me.lblDenturesPrice.TabIndex = 1
        Me.lblDenturesPrice.Text = "500"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(8, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Dentures"
        '
        'btnDenturesUpgrade
        '
        Me.btnDenturesUpgrade.Location = New System.Drawing.Point(8, 34)
        Me.btnDenturesUpgrade.Name = "btnDenturesUpgrade"
        Me.btnDenturesUpgrade.Size = New System.Drawing.Size(108, 32)
        Me.btnDenturesUpgrade.TabIndex = 2
        Me.btnDenturesUpgrade.Text = "Dentures"
        Me.btnDenturesUpgrade.UseVisualStyleBackColor = True
        '
        'PnlName
        '
        Me.PnlName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlName.Controls.Add(Me.Label1)
        Me.PnlName.Controls.Add(Me.btnName)
        Me.PnlName.Controls.Add(Me.tbxName)
        Me.PnlName.Location = New System.Drawing.Point(279, 164)
        Me.PnlName.Name = "PnlName"
        Me.PnlName.Size = New System.Drawing.Size(220, 144)
        Me.PnlName.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(14, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Change Bakery Name"
        '
        'btnName
        '
        Me.btnName.Location = New System.Drawing.Point(66, 105)
        Me.btnName.Name = "btnName"
        Me.btnName.Size = New System.Drawing.Size(75, 23)
        Me.btnName.TabIndex = 1
        Me.btnName.Text = "Confirm"
        Me.btnName.UseVisualStyleBackColor = True
        '
        'tbxName
        '
        Me.tbxName.Location = New System.Drawing.Point(54, 63)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(100, 23)
        Me.tbxName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI Historic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(21, 28)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(167, 32)
        Me.lblName.TabIndex = 18
        Me.lblName.Text = "Bakery Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1004, 533)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PnlName)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnBiscuit)
        Me.Controls.Add(Me.lblPerSecond)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblPerSecondTitle)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Debug)
        Me.MainMenuStrip = Me.Debug
        Me.Name = "Form1"
        Me.Text = "Biscuit Presser"
        CType(Me.btnBiscuit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Debug.ResumeLayout(False)
        Me.Debug.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.gbxGrandadUpgrade.ResumeLayout(False)
        Me.pnlButterFlyClicking.ResumeLayout(False)
        Me.pnlButterFlyClicking.PerformLayout()
        Me.gbxClickerUpgrade.ResumeLayout(False)
        Me.pnlDentures.ResumeLayout(False)
        Me.pnlDentures.PerformLayout()
        Me.PnlName.ResumeLayout(False)
        Me.PnlName.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnUpgrade As Button
    Friend WithEvents btnGrandad As Button
    Friend WithEvents lblPerSecondTitle As Label
    Friend WithEvents lblClickPrice As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents GlobalTimer As Timer
    Friend WithEvents lblClickerNum As Label
    Friend WithEvents UpdateTimer As Timer
    Friend WithEvents lblGrandadUpgradeNum As Label
    Friend WithEvents lblGrandadPrice As Label
    Friend WithEvents lblPerSecond As Label
    Friend WithEvents btnBiscuit As PictureBox
    Friend WithEvents lblSiloPrice As Label
    Friend WithEvents lblSiloUpgradeNum As Label
    Friend WithEvents btnSilo As Button
    Friend WithEvents Debug As MenuStrip
    Friend WithEvents DebugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuPlus100 As ToolStripMenuItem
    Friend WithEvents munMinus100 As ToolStripMenuItem
    Friend WithEvents mnuPerSecondPlus100 As ToolStripMenuItem
    Friend WithEvents mnuPerSecondMinus100 As ToolStripMenuItem
    Friend WithEvents mnuReset As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnButterFlyClicking As Button
    Friend WithEvents mnuShowTimer As ToolStripMenuItem
    Friend WithEvents mnuHideTimer As ToolStripMenuItem
    Friend WithEvents lblCoalMinePrice As Label
    Friend WithEvents lblCoalMineUpgradeNum As Label
    Friend WithEvents btnCoalMine As Button
    Friend WithEvents PnlName As Panel
    Friend WithEvents tbxName As TextBox
    Friend WithEvents btnName As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlButterFlyClicking As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblButterFlyClickingPrice As Label
    Friend WithEvents X1000ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlDentures As Panel
    Friend WithEvents btnDenturesUpgrade As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDenturesPrice As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents VariablesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerSecondToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TotalAmounToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClickUpgradeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrandadUpgradeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpgradesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClickUpgradeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClickerPriceToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClickerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClickerNumToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GrandadUpgradeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GrandadPriceToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GrandadNumToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClickUpgradeToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents GrandadUpgradeToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SiloUpgradeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoalMineUpgradeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SiloUpgradeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SiloPriceToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SiloNumToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CoalMineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoalMineUpgradeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CoalMinePriceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoalMineNumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblClickerReq As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblDenturesReq As Label
    Friend WithEvents gbxGrandadUpgrade As GroupBox
    Friend WithEvents gbxClickerUpgrade As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
