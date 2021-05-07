<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TestDefinitionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASMTesterDataSet = New WindowsApp1.ASMTesterDataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TestDefinitionsTableAdapter = New WindowsApp1.ASMTesterDataSetTableAdapters.TestDefinitionsTableAdapter()
        Me.TestTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AbortTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ButtonSaveReport = New System.Windows.Forms.Button()
        Me.Report = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBoxWorkOrder = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonRESET = New System.Windows.Forms.Button()
        Me.Labelpartnumber = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TestParmPressureDrop = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TestParmO3inVar = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TestParmO3In = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TestParmTempVar = New System.Windows.Forms.TextBox()
        Me.TestParmTemp = New System.Windows.Forms.TextBox()
        Me.TestParmPressure = New System.Windows.Forms.TextBox()
        Me.TestParmFlowVar = New System.Windows.Forms.TextBox()
        Me.TestParmPressureVar = New System.Windows.Forms.TextBox()
        Me.TestParmFlow = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.PartNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConverterTempDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConverterTempVarianceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AirMassFlowlbsperminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AirMassFlowVarianceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaticPressureDropinwcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OzoneInletConcentrationPPMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OzoneInletConcentrationVarianceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InletPressureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InletPressureVarianceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Part_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AxGXButtonAbort = New AxGADGETXLIB1Lib.AxGXButton()
        Me.AxGXButtonAllRed = New AxGADGETXLIB1Lib.AxGXButton()
        Me.AxGXButtontest = New AxGADGETXLIB1Lib.AxGXButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.AirFlowDisplay = New AxDBUILib.AxD7Segment()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.HeatOvertempDisplay = New AxDBUILib.AxD7Segment()
        Me.Windaq = New AxWINDAQLib.AxWinDaq()
        Me.PipeFlow1 = New AxGADGETXLib.AxGadget()
        Me.PipeFlow2 = New AxGADGETXLib.AxGadget()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PressureDropDisplay = New AxDBUILib.AxD7Segment()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PressureChart = New AxDBGRAPHLib.AxDChart()
        Me.TempChart = New AxDBGRAPHLib.AxDChart()
        Me.FlowChart = New AxDBGRAPHLib.AxDChart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelTestInfo = New System.Windows.Forms.Label()
        Me.LabeltargetO3 = New System.Windows.Forms.Label()
        Me.Labeltargetpressure = New System.Windows.Forms.Label()
        Me.Labeltargettemp = New System.Windows.Forms.Label()
        Me.Labeltargetflow = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.O3EfficiencyDisplay = New AxDBUILib.AxD7Segment()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.O3OutDisplay = New AxDBUILib.AxD7Segment()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.O3InDisplay = New AxDBUILib.AxD7Segment()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PressureDisplay = New AxDBUILib.AxD7Segment()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TempDisplay = New AxDBUILib.AxD7Segment()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowDisplay = New AxDBUILib.AxD7Segment()
        Me.AxDPipe5 = New AxDBEQUIPLib.AxDPipe()
        Me.AxDPipe4 = New AxDBEQUIPLib.AxDPipe()
        Me.AxDPipe3 = New AxDBEQUIPLib.AxDPipe()
        Me.AxDPipe1 = New AxDBEQUIPLib.AxDPipe()
        Me.AxDPipe2 = New AxDBEQUIPLib.AxDPipe()
        Me.AxSFStandard1 = New AxSYMFACXLib.AxSFStandard()
        Me.AxSFStandard2 = New AxSYMFACXLib.AxSFStandard()
        Me.AxSFStandard3 = New AxSYMFACXLib.AxSFStandard()
        Me.blower = New AxSYMFACXLib.AxSFStandard()
        Me.Heater = New AxSYMFACXLib.AxSFStandard()
        CType(Me.TestDefinitionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASMTesterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.AxGXButtonAbort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxGXButtonAllRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxGXButtontest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirFlowDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeatOvertempDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Windaq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PipeFlow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PipeFlow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PressureDropDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PressureChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TempChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlowChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.O3EfficiencyDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.O3OutDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.O3InDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PressureDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TempDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlowDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxDPipe5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxDPipe4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxDPipe3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxDPipe1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxDPipe2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxSFStandard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxSFStandard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxSFStandard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Heater, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestDefinitionsBindingSource
        '
        Me.TestDefinitionsBindingSource.DataMember = "TestDefinitions"
        Me.TestDefinitionsBindingSource.DataSource = Me.ASMTesterDataSet
        '
        'ASMTesterDataSet
        '
        Me.ASMTesterDataSet.DataSetName = "ASMTesterDataSet"
        Me.ASMTesterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'TestDefinitionsTableAdapter
        '
        Me.TestDefinitionsTableAdapter.ClearBeforeFill = True
        '
        'TestTimer
        '
        Me.TestTimer.Interval = 60000
        '
        'AbortTimer
        '
        Me.AbortTimer.Interval = 600000
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "rtf"
        Me.SaveFileDialog1.Filter = "Text Files (*.rtf) | *.rtf"
        Me.SaveFileDialog1.InitialDirectory = "c:\OM2 Test Reports"
        Me.SaveFileDialog1.Title = "Save Report"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Silver
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.ButtonSaveReport)
        Me.TabPage3.Controls.Add(Me.Report)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(772, 539)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Report"
        '
        'ButtonSaveReport
        '
        Me.ButtonSaveReport.Location = New System.Drawing.Point(679, 70)
        Me.ButtonSaveReport.Name = "ButtonSaveReport"
        Me.ButtonSaveReport.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSaveReport.TabIndex = 1
        Me.ButtonSaveReport.Text = "Save Report"
        Me.ButtonSaveReport.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.Report.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Report.Location = New System.Drawing.Point(13, 15)
        Me.Report.Name = "Report"
        Me.Report.Size = New System.Drawing.Size(660, 510)
        Me.Report.TabIndex = 0
        Me.Report.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.TextBoxWorkOrder)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.DataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(772, 539)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Test Definitions"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(507, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(150, 20)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Work Order Number"
        '
        'TextBoxWorkOrder
        '
        Me.TextBoxWorkOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxWorkOrder.Location = New System.Drawing.Point(260, 28)
        Me.TextBoxWorkOrder.Name = "TextBoxWorkOrder"
        Me.TextBoxWorkOrder.Size = New System.Drawing.Size(246, 26)
        Me.TextBoxWorkOrder.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.ButtonRESET)
        Me.GroupBox1.Controls.Add(Me.Labelpartnumber)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.TestParmPressureDrop)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TestParmO3inVar)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TestParmO3In)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TestParmTempVar)
        Me.GroupBox1.Controls.Add(Me.TestParmTemp)
        Me.GroupBox1.Controls.Add(Me.TestParmPressure)
        Me.GroupBox1.Controls.Add(Me.TestParmFlowVar)
        Me.GroupBox1.Controls.Add(Me.TestParmPressureVar)
        Me.GroupBox1.Controls.Add(Me.TestParmFlow)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(260, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(505, 345)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test Parameters  Part Number"
        '
        'ButtonRESET
        '
        Me.ButtonRESET.Location = New System.Drawing.Point(392, 276)
        Me.ButtonRESET.Name = "ButtonRESET"
        Me.ButtonRESET.Size = New System.Drawing.Size(75, 37)
        Me.ButtonRESET.TabIndex = 19
        Me.ButtonRESET.Text = "Reset"
        Me.ButtonRESET.UseVisualStyleBackColor = True
        '
        'Labelpartnumber
        '
        Me.Labelpartnumber.AutoSize = True
        Me.Labelpartnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpartnumber.Location = New System.Drawing.Point(247, 0)
        Me.Labelpartnumber.Name = "Labelpartnumber"
        Me.Labelpartnumber.Size = New System.Drawing.Size(0, 24)
        Me.Labelpartnumber.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 151)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(111, 20)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Pressure Drop"
        '
        'TestParmPressureDrop
        '
        Me.TestParmPressureDrop.Enabled = False
        Me.TestParmPressureDrop.Location = New System.Drawing.Point(6, 177)
        Me.TestParmPressureDrop.Name = "TestParmPressureDrop"
        Me.TestParmPressureDrop.Size = New System.Drawing.Size(57, 26)
        Me.TestParmPressureDrop.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(306, 89)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 20)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Variance"
        '
        'TestParmO3inVar
        '
        Me.TestParmO3inVar.Enabled = False
        Me.TestParmO3inVar.Location = New System.Drawing.Point(310, 112)
        Me.TestParmO3inVar.Name = "TestParmO3inVar"
        Me.TestParmO3inVar.Size = New System.Drawing.Size(53, 26)
        Me.TestParmO3inVar.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(181, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 20)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "O3 Inlet"
        '
        'TestParmO3In
        '
        Me.TestParmO3In.Enabled = False
        Me.TestParmO3In.Location = New System.Drawing.Point(185, 112)
        Me.TestParmO3In.Name = "TestParmO3In"
        Me.TestParmO3In.Size = New System.Drawing.Size(57, 26)
        Me.TestParmO3In.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(79, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 20)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Variance"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 20)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Pressure"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(180, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 20)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Temperature"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(298, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 20)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Variance"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(75, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Variance"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(2, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 20)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Flow"
        '
        'TestParmTempVar
        '
        Me.TestParmTempVar.Enabled = False
        Me.TestParmTempVar.Location = New System.Drawing.Point(310, 53)
        Me.TestParmTempVar.Name = "TestParmTempVar"
        Me.TestParmTempVar.Size = New System.Drawing.Size(53, 26)
        Me.TestParmTempVar.TabIndex = 5
        '
        'TestParmTemp
        '
        Me.TestParmTemp.Enabled = False
        Me.TestParmTemp.Location = New System.Drawing.Point(185, 53)
        Me.TestParmTemp.Name = "TestParmTemp"
        Me.TestParmTemp.Size = New System.Drawing.Size(57, 26)
        Me.TestParmTemp.TabIndex = 4
        '
        'TestParmPressure
        '
        Me.TestParmPressure.Enabled = False
        Me.TestParmPressure.Location = New System.Drawing.Point(6, 112)
        Me.TestParmPressure.Name = "TestParmPressure"
        Me.TestParmPressure.Size = New System.Drawing.Size(57, 26)
        Me.TestParmPressure.TabIndex = 3
        '
        'TestParmFlowVar
        '
        Me.TestParmFlowVar.Enabled = False
        Me.TestParmFlowVar.Location = New System.Drawing.Point(81, 53)
        Me.TestParmFlowVar.Name = "TestParmFlowVar"
        Me.TestParmFlowVar.Size = New System.Drawing.Size(46, 26)
        Me.TestParmFlowVar.TabIndex = 2
        '
        'TestParmPressureVar
        '
        Me.TestParmPressureVar.Enabled = False
        Me.TestParmPressureVar.Location = New System.Drawing.Point(80, 112)
        Me.TestParmPressureVar.Name = "TestParmPressureVar"
        Me.TestParmPressureVar.Size = New System.Drawing.Size(46, 26)
        Me.TestParmPressureVar.TabIndex = 1
        '
        'TestParmFlow
        '
        Me.TestParmFlow.Enabled = False
        Me.TestParmFlow.Location = New System.Drawing.Point(6, 53)
        Me.TestParmFlow.Name = "TestParmFlow"
        Me.TestParmFlow.Size = New System.Drawing.Size(57, 26)
        Me.TestParmFlow.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(216, 24)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Select Test (Dbl Click)"
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PartNumberDataGridViewTextBoxColumn, Me.TestTypeDataGridViewTextBoxColumn, Me.ConverterTempDataGridViewTextBoxColumn, Me.ConverterTempVarianceDataGridViewTextBoxColumn, Me.AirMassFlowlbsperminDataGridViewTextBoxColumn, Me.AirMassFlowVarianceDataGridViewTextBoxColumn, Me.StaticPressureDropinwcDataGridViewTextBoxColumn, Me.OzoneInletConcentrationPPMDataGridViewTextBoxColumn, Me.OzoneInletConcentrationVarianceDataGridViewTextBoxColumn, Me.InletPressureDataGridViewTextBoxColumn, Me.InletPressureVarianceDataGridViewTextBoxColumn, Me.Part_Number})
        Me.DataGridView.DataSource = Me.TestDefinitionsBindingSource
        Me.DataGridView.Location = New System.Drawing.Point(10, 30)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(244, 492)
        Me.DataGridView.TabIndex = 0
        '
        'PartNumberDataGridViewTextBoxColumn
        '
        Me.PartNumberDataGridViewTextBoxColumn.DataPropertyName = "Part_Number"
        Me.PartNumberDataGridViewTextBoxColumn.HeaderText = "Part_Number"
        Me.PartNumberDataGridViewTextBoxColumn.Name = "PartNumberDataGridViewTextBoxColumn"
        '
        'TestTypeDataGridViewTextBoxColumn
        '
        Me.TestTypeDataGridViewTextBoxColumn.DataPropertyName = "Test_Type"
        Me.TestTypeDataGridViewTextBoxColumn.HeaderText = "Test_Type"
        Me.TestTypeDataGridViewTextBoxColumn.Name = "TestTypeDataGridViewTextBoxColumn"
        '
        'ConverterTempDataGridViewTextBoxColumn
        '
        Me.ConverterTempDataGridViewTextBoxColumn.DataPropertyName = "Converter_Temp"
        Me.ConverterTempDataGridViewTextBoxColumn.HeaderText = "Converter_Temp"
        Me.ConverterTempDataGridViewTextBoxColumn.Name = "ConverterTempDataGridViewTextBoxColumn"
        '
        'ConverterTempVarianceDataGridViewTextBoxColumn
        '
        Me.ConverterTempVarianceDataGridViewTextBoxColumn.DataPropertyName = "Converter_Temp_Variance"
        Me.ConverterTempVarianceDataGridViewTextBoxColumn.HeaderText = "Converter_Temp_Variance"
        Me.ConverterTempVarianceDataGridViewTextBoxColumn.Name = "ConverterTempVarianceDataGridViewTextBoxColumn"
        '
        'AirMassFlowlbsperminDataGridViewTextBoxColumn
        '
        Me.AirMassFlowlbsperminDataGridViewTextBoxColumn.DataPropertyName = "Air_Mass_Flow_lbs_per_min"
        Me.AirMassFlowlbsperminDataGridViewTextBoxColumn.HeaderText = "Air_Mass_Flow_lbs_per_min"
        Me.AirMassFlowlbsperminDataGridViewTextBoxColumn.Name = "AirMassFlowlbsperminDataGridViewTextBoxColumn"
        '
        'AirMassFlowVarianceDataGridViewTextBoxColumn
        '
        Me.AirMassFlowVarianceDataGridViewTextBoxColumn.DataPropertyName = "Air_Mass_Flow_Variance"
        Me.AirMassFlowVarianceDataGridViewTextBoxColumn.HeaderText = "Air_Mass_Flow_Variance"
        Me.AirMassFlowVarianceDataGridViewTextBoxColumn.Name = "AirMassFlowVarianceDataGridViewTextBoxColumn"
        '
        'StaticPressureDropinwcDataGridViewTextBoxColumn
        '
        Me.StaticPressureDropinwcDataGridViewTextBoxColumn.DataPropertyName = "Static_Pressure_Drop_in_wc"
        Me.StaticPressureDropinwcDataGridViewTextBoxColumn.HeaderText = "Static_Pressure_Drop_in_wc"
        Me.StaticPressureDropinwcDataGridViewTextBoxColumn.Name = "StaticPressureDropinwcDataGridViewTextBoxColumn"
        '
        'OzoneInletConcentrationPPMDataGridViewTextBoxColumn
        '
        Me.OzoneInletConcentrationPPMDataGridViewTextBoxColumn.DataPropertyName = "Ozone_Inlet_Concentration_PPM"
        Me.OzoneInletConcentrationPPMDataGridViewTextBoxColumn.HeaderText = "Ozone_Inlet_Concentration_PPM"
        Me.OzoneInletConcentrationPPMDataGridViewTextBoxColumn.Name = "OzoneInletConcentrationPPMDataGridViewTextBoxColumn"
        '
        'OzoneInletConcentrationVarianceDataGridViewTextBoxColumn
        '
        Me.OzoneInletConcentrationVarianceDataGridViewTextBoxColumn.DataPropertyName = "Ozone_Inlet_Concentration_Variance"
        Me.OzoneInletConcentrationVarianceDataGridViewTextBoxColumn.HeaderText = "Ozone_Inlet_Concentration_Variance"
        Me.OzoneInletConcentrationVarianceDataGridViewTextBoxColumn.Name = "OzoneInletConcentrationVarianceDataGridViewTextBoxColumn"
        '
        'InletPressureDataGridViewTextBoxColumn
        '
        Me.InletPressureDataGridViewTextBoxColumn.DataPropertyName = "Inlet_Pressure"
        Me.InletPressureDataGridViewTextBoxColumn.HeaderText = "Inlet_Pressure"
        Me.InletPressureDataGridViewTextBoxColumn.Name = "InletPressureDataGridViewTextBoxColumn"
        '
        'InletPressureVarianceDataGridViewTextBoxColumn
        '
        Me.InletPressureVarianceDataGridViewTextBoxColumn.DataPropertyName = "Inlet_Pressure_Variance"
        Me.InletPressureVarianceDataGridViewTextBoxColumn.HeaderText = "Inlet_Pressure_Variance"
        Me.InletPressureVarianceDataGridViewTextBoxColumn.Name = "InletPressureVarianceDataGridViewTextBoxColumn"
        '
        'Part_Number
        '
        Me.Part_Number.DataPropertyName = "Part_Number"
        Me.Part_Number.HeaderText = "Part_Number"
        Me.Part_Number.Name = "Part_Number"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(780, 565)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.AxGXButtonAbort)
        Me.TabPage1.Controls.Add(Me.AxGXButtonAllRed)
        Me.TabPage1.Controls.Add(Me.AxGXButtontest)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.AirFlowDisplay)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.HeatOvertempDisplay)
        Me.TabPage1.Controls.Add(Me.Windaq)
        Me.TabPage1.Controls.Add(Me.PipeFlow1)
        Me.TabPage1.Controls.Add(Me.PipeFlow2)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.PressureDropDisplay)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.AxDPipe5)
        Me.TabPage1.Controls.Add(Me.AxDPipe4)
        Me.TabPage1.Controls.Add(Me.AxDPipe3)
        Me.TabPage1.Controls.Add(Me.AxDPipe1)
        Me.TabPage1.Controls.Add(Me.AxDPipe2)
        Me.TabPage1.Controls.Add(Me.AxSFStandard1)
        Me.TabPage1.Controls.Add(Me.AxSFStandard2)
        Me.TabPage1.Controls.Add(Me.AxSFStandard3)
        Me.TabPage1.Controls.Add(Me.blower)
        Me.TabPage1.Controls.Add(Me.Heater)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(772, 539)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Test"
        '
        'AxGXButtonAbort
        '
        Me.AxGXButtonAbort.Enabled = True
        Me.AxGXButtonAbort.Location = New System.Drawing.Point(397, 472)
        Me.AxGXButtonAbort.Name = "AxGXButtonAbort"
        Me.AxGXButtonAbort.OcxState = CType(resources.GetObject("AxGXButtonAbort.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxGXButtonAbort.Size = New System.Drawing.Size(207, 40)
        Me.AxGXButtonAbort.TabIndex = 37
        Me.AxGXButtonAbort.Visible = False
        '
        'AxGXButtonAllRed
        '
        Me.AxGXButtonAllRed.Enabled = True
        Me.AxGXButtonAllRed.Location = New System.Drawing.Point(13, 475)
        Me.AxGXButtonAllRed.Name = "AxGXButtonAllRed"
        Me.AxGXButtonAllRed.OcxState = CType(resources.GetObject("AxGXButtonAllRed.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxGXButtonAllRed.Size = New System.Drawing.Size(64, 50)
        Me.AxGXButtonAllRed.TabIndex = 36
        Me.AxGXButtonAllRed.Visible = False
        '
        'AxGXButtontest
        '
        Me.AxGXButtontest.Enabled = True
        Me.AxGXButtontest.Location = New System.Drawing.Point(150, 472)
        Me.AxGXButtontest.Name = "AxGXButtontest"
        Me.AxGXButtontest.OcxState = CType(resources.GetObject("AxGXButtontest.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxGXButtontest.Size = New System.Drawing.Size(207, 40)
        Me.AxGXButtontest.TabIndex = 34
        Me.AxGXButtontest.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(131, 228)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 13)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Air flow scfm"
        '
        'AirFlowDisplay
        '
        Me.AirFlowDisplay.Enabled = True
        Me.AirFlowDisplay.Location = New System.Drawing.Point(134, 244)
        Me.AirFlowDisplay.Name = "AirFlowDisplay"
        Me.AirFlowDisplay.OcxState = CType(resources.GetObject("AirFlowDisplay.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AirFlowDisplay.Size = New System.Drawing.Size(95, 28)
        Me.AirFlowDisplay.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(125, 367)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Heater Over Temp"
        '
        'HeatOvertempDisplay
        '
        Me.HeatOvertempDisplay.Enabled = True
        Me.HeatOvertempDisplay.Location = New System.Drawing.Point(127, 383)
        Me.HeatOvertempDisplay.Name = "HeatOvertempDisplay"
        Me.HeatOvertempDisplay.OcxState = CType(resources.GetObject("HeatOvertempDisplay.OcxState"), System.Windows.Forms.AxHost.State)
        Me.HeatOvertempDisplay.Size = New System.Drawing.Size(102, 28)
        Me.HeatOvertempDisplay.TabIndex = 30
        '
        'Windaq
        '
        Me.Windaq.Enabled = True
        Me.Windaq.Location = New System.Drawing.Point(663, 475)
        Me.Windaq.Name = "Windaq"
        Me.Windaq.OcxState = CType(resources.GetObject("Windaq.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Windaq.Size = New System.Drawing.Size(100, 50)
        Me.Windaq.TabIndex = 29
        '
        'PipeFlow1
        '
        Me.PipeFlow1.Enabled = True
        Me.PipeFlow1.Location = New System.Drawing.Point(133, 278)
        Me.PipeFlow1.Name = "PipeFlow1"
        Me.PipeFlow1.OcxState = CType(resources.GetObject("PipeFlow1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PipeFlow1.Size = New System.Drawing.Size(96, 27)
        Me.PipeFlow1.TabIndex = 27
        '
        'PipeFlow2
        '
        Me.PipeFlow2.Enabled = True
        Me.PipeFlow2.Location = New System.Drawing.Point(564, 282)
        Me.PipeFlow2.Name = "PipeFlow2"
        Me.PipeFlow2.OcxState = CType(resources.GetObject("PipeFlow2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PipeFlow2.Size = New System.Drawing.Size(75, 21)
        Me.PipeFlow2.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(346, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Pressure Drop psi"
        '
        'PressureDropDisplay
        '
        Me.PressureDropDisplay.Enabled = True
        Me.PressureDropDisplay.Location = New System.Drawing.Point(348, 335)
        Me.PressureDropDisplay.Name = "PressureDropDisplay"
        Me.PressureDropDisplay.OcxState = CType(resources.GetObject("PressureDropDisplay.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PressureDropDisplay.Size = New System.Drawing.Size(102, 28)
        Me.PressureDropDisplay.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.PressureChart)
        Me.Panel2.Controls.Add(Me.TempChart)
        Me.Panel2.Controls.Add(Me.FlowChart)
        Me.Panel2.Location = New System.Drawing.Point(387, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(346, 247)
        Me.Panel2.TabIndex = 11
        '
        'PressureChart
        '
        Me.PressureChart.Enabled = True
        Me.PressureChart.Location = New System.Drawing.Point(13, 162)
        Me.PressureChart.Name = "PressureChart"
        Me.PressureChart.OcxState = CType(resources.GetObject("PressureChart.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PressureChart.Size = New System.Drawing.Size(321, 76)
        Me.PressureChart.TabIndex = 21
        '
        'TempChart
        '
        Me.TempChart.Enabled = True
        Me.TempChart.Location = New System.Drawing.Point(12, 85)
        Me.TempChart.Name = "TempChart"
        Me.TempChart.OcxState = CType(resources.GetObject("TempChart.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TempChart.Size = New System.Drawing.Size(321, 76)
        Me.TempChart.TabIndex = 20
        '
        'FlowChart
        '
        Me.FlowChart.Enabled = True
        Me.FlowChart.Location = New System.Drawing.Point(10, 7)
        Me.FlowChart.Name = "FlowChart"
        Me.FlowChart.OcxState = CType(resources.GetObject("FlowChart.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FlowChart.Size = New System.Drawing.Size(321, 76)
        Me.FlowChart.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.LabelTestInfo)
        Me.Panel1.Controls.Add(Me.LabeltargetO3)
        Me.Panel1.Controls.Add(Me.Labeltargetpressure)
        Me.Panel1.Controls.Add(Me.Labeltargettemp)
        Me.Panel1.Controls.Add(Me.Labeltargetflow)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.O3EfficiencyDisplay)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.O3OutDisplay)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.O3InDisplay)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PressureDisplay)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TempDisplay)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.FlowDisplay)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 224)
        Me.Panel1.TabIndex = 10
        '
        'LabelTestInfo
        '
        Me.LabelTestInfo.AutoSize = True
        Me.LabelTestInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTestInfo.Location = New System.Drawing.Point(10, 191)
        Me.LabelTestInfo.Name = "LabelTestInfo"
        Me.LabelTestInfo.Size = New System.Drawing.Size(90, 24)
        Me.LabelTestInfo.TabIndex = 34
        Me.LabelTestInfo.Text = "Test Info"
        '
        'LabeltargetO3
        '
        Me.LabeltargetO3.AutoSize = True
        Me.LabeltargetO3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabeltargetO3.Location = New System.Drawing.Point(11, 164)
        Me.LabeltargetO3.Name = "LabeltargetO3"
        Me.LabeltargetO3.Size = New System.Drawing.Size(61, 18)
        Me.LabeltargetO3.TabIndex = 28
        Me.LabeltargetO3.Text = "Target:"
        '
        'Labeltargetpressure
        '
        Me.Labeltargetpressure.AutoSize = True
        Me.Labeltargetpressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltargetpressure.Location = New System.Drawing.Point(239, 60)
        Me.Labeltargetpressure.Name = "Labeltargetpressure"
        Me.Labeltargetpressure.Size = New System.Drawing.Size(61, 18)
        Me.Labeltargetpressure.TabIndex = 27
        Me.Labeltargetpressure.Text = "Target:"
        '
        'Labeltargettemp
        '
        Me.Labeltargettemp.AutoSize = True
        Me.Labeltargettemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltargettemp.Location = New System.Drawing.Point(123, 60)
        Me.Labeltargettemp.Name = "Labeltargettemp"
        Me.Labeltargettemp.Size = New System.Drawing.Size(61, 18)
        Me.Labeltargettemp.TabIndex = 26
        Me.Labeltargettemp.Text = "Target:"
        '
        'Labeltargetflow
        '
        Me.Labeltargetflow.AutoSize = True
        Me.Labeltargetflow.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltargetflow.Location = New System.Drawing.Point(11, 60)
        Me.Labeltargetflow.Name = "Labeltargetflow"
        Me.Labeltargetflow.Size = New System.Drawing.Size(56, 18)
        Me.Labeltargetflow.TabIndex = 25
        Me.Labeltargetflow.Text = "Target"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(239, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "O3 Efficiency %"
        '
        'O3EfficiencyDisplay
        '
        Me.O3EfficiencyDisplay.Enabled = True
        Me.O3EfficiencyDisplay.Location = New System.Drawing.Point(241, 128)
        Me.O3EfficiencyDisplay.Name = "O3EfficiencyDisplay"
        Me.O3EfficiencyDisplay.OcxState = CType(resources.GetObject("O3EfficiencyDisplay.OcxState"), System.Windows.Forms.AxHost.State)
        Me.O3EfficiencyDisplay.Size = New System.Drawing.Size(102, 28)
        Me.O3EfficiencyDisplay.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(125, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "O3 Out ppm"
        '
        'O3OutDisplay
        '
        Me.O3OutDisplay.Enabled = True
        Me.O3OutDisplay.Location = New System.Drawing.Point(127, 128)
        Me.O3OutDisplay.Name = "O3OutDisplay"
        Me.O3OutDisplay.OcxState = CType(resources.GetObject("O3OutDisplay.OcxState"), System.Windows.Forms.AxHost.State)
        Me.O3OutDisplay.Size = New System.Drawing.Size(102, 28)
        Me.O3OutDisplay.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "O3 In ppm"
        '
        'O3InDisplay
        '
        Me.O3InDisplay.Enabled = True
        Me.O3InDisplay.Location = New System.Drawing.Point(13, 128)
        Me.O3InDisplay.Name = "O3InDisplay"
        Me.O3InDisplay.OcxState = CType(resources.GetObject("O3InDisplay.OcxState"), System.Windows.Forms.AxHost.State)
        Me.O3InDisplay.Size = New System.Drawing.Size(102, 28)
        Me.O3InDisplay.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(241, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Pressure psia"
        '
        'PressureDisplay
        '
        Me.PressureDisplay.Enabled = True
        Me.PressureDisplay.Location = New System.Drawing.Point(241, 25)
        Me.PressureDisplay.Name = "PressureDisplay"
        Me.PressureDisplay.OcxState = CType(resources.GetObject("PressureDisplay.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PressureDisplay.Size = New System.Drawing.Size(102, 28)
        Me.PressureDisplay.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Temp F"
        '
        'TempDisplay
        '
        Me.TempDisplay.Enabled = True
        Me.TempDisplay.Location = New System.Drawing.Point(126, 25)
        Me.TempDisplay.Name = "TempDisplay"
        Me.TempDisplay.OcxState = CType(resources.GetObject("TempDisplay.OcxState"), System.Windows.Forms.AxHost.State)
        Me.TempDisplay.Size = New System.Drawing.Size(102, 28)
        Me.TempDisplay.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Flow lb/min"
        '
        'FlowDisplay
        '
        Me.FlowDisplay.Enabled = True
        Me.FlowDisplay.Location = New System.Drawing.Point(12, 25)
        Me.FlowDisplay.Name = "FlowDisplay"
        Me.FlowDisplay.OcxState = CType(resources.GetObject("FlowDisplay.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FlowDisplay.Size = New System.Drawing.Size(102, 28)
        Me.FlowDisplay.TabIndex = 12
        '
        'AxDPipe5
        '
        Me.AxDPipe5.Enabled = True
        Me.AxDPipe5.Location = New System.Drawing.Point(562, 319)
        Me.AxDPipe5.Name = "AxDPipe5"
        Me.AxDPipe5.OcxState = CType(resources.GetObject("AxDPipe5.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxDPipe5.Size = New System.Drawing.Size(104, 148)
        Me.AxDPipe5.TabIndex = 9
        '
        'AxDPipe4
        '
        Me.AxDPipe4.Enabled = True
        Me.AxDPipe4.Location = New System.Drawing.Point(562, 277)
        Me.AxDPipe4.Name = "AxDPipe4"
        Me.AxDPipe4.OcxState = CType(resources.GetObject("AxDPipe4.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxDPipe4.Size = New System.Drawing.Size(104, 56)
        Me.AxDPipe4.TabIndex = 8
        '
        'AxDPipe3
        '
        Me.AxDPipe3.Enabled = True
        Me.AxDPipe3.Location = New System.Drawing.Point(181, 434)
        Me.AxDPipe3.Name = "AxDPipe3"
        Me.AxDPipe3.OcxState = CType(resources.GetObject("AxDPipe3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxDPipe3.Size = New System.Drawing.Size(382, 32)
        Me.AxDPipe3.TabIndex = 7
        '
        'AxDPipe1
        '
        Me.AxDPipe1.Enabled = True
        Me.AxDPipe1.Location = New System.Drawing.Point(86, 417)
        Me.AxDPipe1.Name = "AxDPipe1"
        Me.AxDPipe1.OcxState = CType(resources.GetObject("AxDPipe1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxDPipe1.Size = New System.Drawing.Size(104, 50)
        Me.AxDPipe1.TabIndex = 6
        '
        'AxDPipe2
        '
        Me.AxDPipe2.Enabled = True
        Me.AxDPipe2.Location = New System.Drawing.Point(134, 277)
        Me.AxDPipe2.Name = "AxDPipe2"
        Me.AxDPipe2.OcxState = CType(resources.GetObject("AxDPipe2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxDPipe2.Size = New System.Drawing.Size(97, 32)
        Me.AxDPipe2.TabIndex = 4
        '
        'AxSFStandard1
        '
        Me.AxSFStandard1.Enabled = True
        Me.AxSFStandard1.Location = New System.Drawing.Point(354, 255)
        Me.AxSFStandard1.Name = "AxSFStandard1"
        Me.AxSFStandard1.OcxState = CType(resources.GetObject("AxSFStandard1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxSFStandard1.Size = New System.Drawing.Size(83, 74)
        Me.AxSFStandard1.TabIndex = 0
        '
        'AxSFStandard2
        '
        Me.AxSFStandard2.Enabled = True
        Me.AxSFStandard2.Location = New System.Drawing.Point(231, 256)
        Me.AxSFStandard2.Name = "AxSFStandard2"
        Me.AxSFStandard2.OcxState = CType(resources.GetObject("AxSFStandard2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxSFStandard2.Size = New System.Drawing.Size(126, 72)
        Me.AxSFStandard2.TabIndex = 2
        '
        'AxSFStandard3
        '
        Me.AxSFStandard3.Enabled = True
        Me.AxSFStandard3.Location = New System.Drawing.Point(435, 256)
        Me.AxSFStandard3.Name = "AxSFStandard3"
        Me.AxSFStandard3.OcxState = CType(resources.GetObject("AxSFStandard3.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxSFStandard3.Size = New System.Drawing.Size(126, 72)
        Me.AxSFStandard3.TabIndex = 3
        '
        'blower
        '
        Me.blower.Enabled = True
        Me.blower.Location = New System.Drawing.Point(65, 273)
        Me.blower.Name = "blower"
        Me.blower.OcxState = CType(resources.GetObject("blower.OcxState"), System.Windows.Forms.AxHost.State)
        Me.blower.Size = New System.Drawing.Size(74, 78)
        Me.blower.TabIndex = 5
        '
        'Heater
        '
        Me.Heater.Enabled = True
        Me.Heater.Location = New System.Drawing.Point(64, 344)
        Me.Heater.Name = "Heater"
        Me.Heater.OcxState = CType(resources.GetObject("Heater.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Heater.Size = New System.Drawing.Size(71, 73)
        Me.Heater.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OM2 3/4/2020"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TestDefinitionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASMTesterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.AxGXButtonAbort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxGXButtonAllRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxGXButtontest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirFlowDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeatOvertempDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Windaq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PipeFlow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PipeFlow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PressureDropDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PressureChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TempChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlowChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.O3EfficiencyDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.O3OutDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.O3InDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PressureDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TempDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlowDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxDPipe5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxDPipe4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxDPipe3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxDPipe1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxDPipe2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxSFStandard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxSFStandard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxSFStandard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Heater, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ASMTesterDataSet As ASMTesterDataSet
    Friend WithEvents TestDefinitionsBindingSource As BindingSource
    Friend WithEvents TestDefinitionsTableAdapter As ASMTesterDataSetTableAdapters.TestDefinitionsTableAdapter
    Friend WithEvents TestTimer As Timer
    Friend WithEvents AbortTimer As Timer
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ButtonSaveReport As Button
    Friend WithEvents Report As RichTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBoxWorkOrder As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonRESET As Button
    Friend WithEvents Labelpartnumber As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TestParmPressureDrop As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TestParmO3inVar As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TestParmO3In As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TestParmTempVar As TextBox
    Friend WithEvents TestParmTemp As TextBox
    Friend WithEvents TestParmPressure As TextBox
    Friend WithEvents TestParmFlowVar As TextBox
    Friend WithEvents TestParmPressureVar As TextBox
    Friend WithEvents TestParmFlow As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents PartNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConverterTempDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConverterTempVarianceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AirMassFlowlbsperminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AirMassFlowVarianceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaticPressureDropinwcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OzoneInletConcentrationPPMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OzoneInletConcentrationVarianceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InletPressureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InletPressureVarianceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Part_Number As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents AxGXButtonAbort As AxGADGETXLIB1Lib.AxGXButton
    Friend WithEvents AxGXButtonAllRed As AxGADGETXLIB1Lib.AxGXButton
    Friend WithEvents AxGXButtontest As AxGADGETXLIB1Lib.AxGXButton
    Friend WithEvents Label19 As Label
    Friend WithEvents AirFlowDisplay As AxDBUILib.AxD7Segment
    Friend WithEvents Label8 As Label
    Friend WithEvents HeatOvertempDisplay As AxDBUILib.AxD7Segment
    Friend WithEvents Windaq As AxWINDAQLib.AxWinDaq
    Friend WithEvents PipeFlow1 As AxGADGETXLib.AxGadget
    Friend WithEvents PipeFlow2 As AxGADGETXLib.AxGadget
    Friend WithEvents Label7 As Label
    Friend WithEvents PressureDropDisplay As AxDBUILib.AxD7Segment
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PressureChart As AxDBGRAPHLib.AxDChart
    Friend WithEvents TempChart As AxDBGRAPHLib.AxDChart
    Friend WithEvents FlowChart As AxDBGRAPHLib.AxDChart
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelTestInfo As Label
    Friend WithEvents LabeltargetO3 As Label
    Friend WithEvents Labeltargetpressure As Label
    Friend WithEvents Labeltargettemp As Label
    Friend WithEvents Labeltargetflow As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents O3EfficiencyDisplay As AxDBUILib.AxD7Segment
    Friend WithEvents Label5 As Label
    Friend WithEvents O3OutDisplay As AxDBUILib.AxD7Segment
    Friend WithEvents Label4 As Label
    Friend WithEvents O3InDisplay As AxDBUILib.AxD7Segment
    Friend WithEvents Label3 As Label
    Friend WithEvents PressureDisplay As AxDBUILib.AxD7Segment
    Friend WithEvents Label2 As Label
    Friend WithEvents TempDisplay As AxDBUILib.AxD7Segment
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowDisplay As AxDBUILib.AxD7Segment
    Friend WithEvents AxDPipe5 As AxDBEQUIPLib.AxDPipe
    Friend WithEvents AxDPipe4 As AxDBEQUIPLib.AxDPipe
    Friend WithEvents AxDPipe3 As AxDBEQUIPLib.AxDPipe
    Friend WithEvents AxDPipe1 As AxDBEQUIPLib.AxDPipe
    Friend WithEvents AxDPipe2 As AxDBEQUIPLib.AxDPipe
    Friend WithEvents AxSFStandard1 As AxSYMFACXLib.AxSFStandard
    Friend WithEvents AxSFStandard2 As AxSYMFACXLib.AxSFStandard
    Friend WithEvents AxSFStandard3 As AxSYMFACXLib.AxSFStandard
    Friend WithEvents blower As AxSYMFACXLib.AxSFStandard
    Friend WithEvents Heater As AxSYMFACXLib.AxSFStandard
End Class
