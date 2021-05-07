
Imports System.Text
Imports System.Runtime.InteropServices
'Comments
'   added final DAC calibration parms 3/26/2020
'    c"\Om2test\caldata.ini
Public Class Form1
    Private Declare Auto Function GetPrivateProfileString Lib "kernel32" (ByVal lpAppName As String,
                ByVal lpKeyName As String,                   'section name
                ByVal lpDefault As String,                   'key to be retrieved
                ByVal lpReturnedString As StringBuilder,
                ByVal nSize As Integer,
                ByVal lpFileName As String) As Integer       'file name
    Public a As Integer
    Public DataArray(16) As DataPoint
    Public InletPressure, RelativeHumidity, OzoneInPressure, OzoneInconcentration, Flow, BlowerSpeed, ProcessTemp, HeatOverTemp As Double
    Public DiffPressure, RawAirFlow, RawAirPressure, AirBearingPressure, AtmosphericPressure, AmbientTemp, OzoneOutconcentration, InletPressurePV As Double
    Public F(5), T(5), P(5), OI(5), OO(5), PD(5) As Double
    Public Partnumber, Testtype As String
    Public OzoneEfficiency, PressureDrop As Double
    Public FilterFactor = 5
    Public TestState As State = State.Nottesting
    Public TestTime As Integer = 60000   'one minute
    Public TestTime2 As Integer = 5000   ' 5 secs
    Public AbortTime As Integer = 600000  '10 minute
    Public O3InM, O3InB, FlowM, FlowB, TempM, TempB, PdifM, PdifB, InPressM, InPressB, O3outM, O3outB As Double

    Private Sub AxGXButtonAllRed_OnChange(sender As Object, e As AxGADGETXLIB1Lib._DGXButtonEvents_OnChangeEvent) Handles AxGXButtonAllRed.OnChange
        Dim res As Integer
        Dim sb As StringBuilder
        sb = New StringBuilder(500)
        res = GetPrivateProfileString("Default", "username", "", sb, sb.Capacity, "C:\Om2Test\OM2 Test 2\OM2 Test 2\OM2Cal.ini")
        Report.AppendText(vbCrLf)
        Report.AppendText("test")
        Report.AppendText(vbCrLf)
        Report.AppendText("GetPrivateProfileStirng returned : " & res.ToString())
        Report.AppendText(vbCrLf)
        Report.AppendText("KeyName is : " & sb.ToString())
    End Sub
    Public Enum State
        Nottesting = 0
        Waiting1 = 1
        Waiting2 = 2
        Waiting3 = 3
        Waiting4 = 4
        Waiting5 = 5
        TestDone = 6
    End Enum
    Public Structure DataPoint
        Public OldValue As Double
        Public NewValue As Double
    End Structure
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonSaveReport.Click
        SaveFileDialog1.FileName = TextBoxWorkOrder.Text
        SaveFileDialog1.ShowDialog()
        Report.SaveFile(SaveFileDialog1.FileName)
    End Sub
    Private Sub DataGridView_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView.MouseDoubleClick
        Try
            Partnumber = DataGridView.SelectedRows(0).Cells(0).Value.ToString()
            Testtype = DataGridView.SelectedRows(0).Cells(1).Value.ToString()
            Labelpartnumber.Text = DataGridView.SelectedRows(0).Cells(0).Value.ToString() & "  " & DataGridView.SelectedRows(0).Cells(1).Value.ToString()
            LabelTestInfo.Text = DataGridView.SelectedRows(0).Cells(0).Value.ToString() & "  " & DataGridView.SelectedRows(0).Cells(1).Value.ToString()
            '
            TestParmTemp.Text = DataGridView.SelectedRows(0).Cells(2).Value.ToString()
            Labeltargettemp.Text = "Target: " & TestParmTemp.Text
            TestParmTempVar.Text = DataGridView.SelectedRows(0).Cells(3).Value.ToString()
            '
            TestParmFlow.Text = DataGridView.SelectedRows(0).Cells(4).Value.ToString()
            Labeltargetflow.Text = "Target: " & TestParmFlow.Text
            TestParmFlowVar.Text = DataGridView.SelectedRows(0).Cells(5).Value.ToString()
            '
            TestParmPressureDrop.Text = DataGridView.SelectedRows(0).Cells(6).Value.ToString()
            '
            TestParmO3In.Text = DataGridView.SelectedRows(0).Cells(7).Value.ToString()
            LabeltargetO3.Text = "Target: " & TestParmO3In.Text
            TestParmO3inVar.Text = DataGridView.SelectedRows(0).Cells(8).Value.ToString()
            '
            TestParmPressure.Text = DataGridView.SelectedRows(0).Cells(9).Value.ToString()
            Labeltargetpressure.Text = "Target: " & TestParmPressure.Text
            TestParmPressureVar.Text = DataGridView.SelectedRows(0).Cells(10).Value.ToString()
        Catch
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonRESET.Click
        LabelTestInfo.Text = ""
        Labelpartnumber.Text = ""
        '
        TestParmTemp.Text = ""
        Labeltargettemp.Text = TestParmTemp.Text
        TestParmTempVar.Text = ""
        '
        TestParmFlow.Text = ""
        Labeltargetflow.Text = TestParmFlow.Text
        TestParmFlowVar.Text = ""
        '
        TestParmPressureDrop.Text = ""
        '
        TestParmO3In.Text = ""
        LabeltargetO3.Text = TestParmO3In.Text
        TestParmO3inVar.Text = ""
        '
        TestParmPressure.Text = ""
        Labeltargetpressure.Text = TestParmPressure.Text
        TestParmPressureVar.Text = ""
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RtnNumberChars As Integer
        Dim sb As StringBuilder
        sb = New StringBuilder(500)
        '
        'TODO: This line of code loads data into the 'ASMTesterDataSet.TestDefinitions' table. You can move, or remove it, as needed.
        Me.TestDefinitionsTableAdapter.Fill(Me.ASMTesterDataSet.TestDefinitions)
        Windaq.DeviceDriver = "DI350NT.dll"
        Windaq.EventLevel = 1
        Windaq.Start()
        For i = 0 To 15
            DataArray(i).OldValue = 0
        Next
        '
        LabelTestInfo.Text = ""
        Labeltargetflow.Text = ""
        LabeltargetO3.Text = ""
        Labeltargetpressure.Text = ""
        Labeltargettemp.Text = ""
        '
        '   Load cal data from caldata.ini file
        '
        RtnNumberChars = GetPrivateProfileString("CalData", "O3inSlope", "1.0", sb, sb.Capacity, "C:\Om2Test\CalData.ini")
        O3InM = sb.ToString()
        RtnNumberChars = GetPrivateProfileString("CalData", "O3inOffset", "0.0", sb, sb.Capacity, "C:\Om2Test\CalData.ini")
        O3InB = sb.ToString()
        '
        RtnNumberChars = GetPrivateProfileString("CalData", "FlowSlope", "1.0", sb, sb.Capacity, "C:\Om2Test\CalData.ini")
        FlowM = sb.ToString()
        RtnNumberChars = GetPrivateProfileString("CalData", "FlowOffset", "0.0", sb, sb.Capacity, "C:\Om2Test\CalData.ini")
        FlowB = sb.ToString()
        '
        RtnNumberChars = GetPrivateProfileString("CalData", "TempSlope", "1.0", sb, sb.Capacity, "C:\Om2Test\CalData.ini")
        TempM = sb.ToString()
        RtnNumberChars = GetPrivateProfileString("CalData", "TempOffset", "0.0", sb, sb.Capacity, "C:\Om2Test\CalData.ini")
        TempB = sb.ToString()
        '
        RtnNumberChars = GetPrivateProfileString("CalData", "PressDiffSlope", "1.0", sb, sb.Capacity, "C:\Om2Test\CalData.ini")
        PdifM = sb.ToString()
        RtnNumberChars = GetPrivateProfileString("CalData", "PressDiffOffset", "0.0", sb, sb.Capacity, "C:\Om2Test\CalData.ini")
        PdifB = sb.ToString()
        '
        RtnNumberChars = GetPrivateProfileString("CalData", "InPressSlope", "1.0", sb, sb.Capacity, "C:\Om2Test\CalData.ini")
        InPressM = sb.ToString()
        RtnNumberChars = GetPrivateProfileString("CalData", "InPressOffset", "0.0", sb, sb.Capacity, "C:\Om2Test\CalData.ini")
        InPressB = sb.ToString()
        '
        RtnNumberChars = GetPrivateProfileString("CalData", "O3OutSlope", "1.0", sb, sb.Capacity, "C:\Om2Test\CalData.ini")
        O3outM = sb.ToString()
        RtnNumberChars = GetPrivateProfileString("CalData", "O3OutOffset", "0.0", sb, sb.Capacity, "C:\Om2Test\CalData.ini")
        O3outB = sb.ToString()
        '

    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Windaq.Stop()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim MyData As Object
        MyData = Windaq.GetDataFrame(1, 1)
        MyData = CType(MyData, Array)    ' read data from hardware (windaq)
        ' filter
        Dim maxDim0 As Integer = UBound(MyData, 1)
        Dim maxDim1 As Integer = UBound(MyData, 2)
        For i As Integer = 0 To maxDim0
            DataArray(i).NewValue = (MyData(i, 0) - DataArray(i).OldValue) / FilterFactor + DataArray(i).OldValue
            DataArray(i).OldValue = DataArray(i).NewValue
        Next
        ' load up our variables
        InletPressure = DataArray(0).NewValue
        RelativeHumidity = DataArray(1).NewValue
        OzoneInPressure = DataArray(2).NewValue
        '
        OzoneInconcentration = DataArray(3).NewValue
        OzoneInconcentration = OzoneInconcentration * (O3InM) + (O3InB)
        '
        Flow = DataArray(4).NewValue
        Flow = Flow * (FlowM) + (FlowB)
        '
        BlowerSpeed = DataArray(5).NewValue
        ProcessTemp = DataArray(6).NewValue
        ProcessTemp = ProcessTemp * (TempM) + (TempB)
        '
        HeatOverTemp = DataArray(7).NewValue
        PressureDrop = DataArray(8).NewValue
        PressureDrop = PressureDrop * (PdifM) + (PdifB)
        '
        RawAirFlow = DataArray(9).NewValue
        RawAirPressure = DataArray(10).NewValue
        AirBearingPressure = DataArray(11).NewValue
        AtmosphericPressure = DataArray(12).NewValue
        AmbientTemp = DataArray(13).NewValue
        InletPressurePV = DataArray(14).NewValue
        InletPressurePV = InletPressurePV * (InPressM) + (InPressB)
        '
        OzoneOutconcentration = DataArray(15).NewValue
        OzoneOutconcentration = OzoneOutconcentration * (O3outM) + (O3outB)
        '
        '
        'put data on graphic
        PressureChart.PlotChart(InletPressurePV)
        PressureChart.Caption = "Inlet Air Pressure: " & Format(InletPressurePV, "0.00") & " psia "
        PressureChart.SetYAxisMinMax(InletPressurePV - 0.2 * InletPressurePV, InletPressurePV + 0.2 * InletPressurePV)
        PressureDisplay.Value = InletPressurePV
        TempChart.PlotChart(ProcessTemp)
        TempChart.Caption = "Process Temperature: " & Format(ProcessTemp, "0.00") & " DegF "
        TempChart.SetYAxisMinMax(ProcessTemp - 0.2 * ProcessTemp, ProcessTemp + 0.2 * ProcessTemp)
        TempDisplay.Value = ProcessTemp
        FlowChart.PlotChart(Flow)
        FlowChart.Caption = "Flow: " & Format(Flow, "0.00") & " lb/min"
        FlowChart.SetYAxisMinMax(Flow - 0.2 * Flow, Flow + 0.2 * Flow)
        FlowChart.SetYAxisMinMax(Flow - 0.2 * Flow, Flow + 0.2 * Flow)
        FlowDisplay.Value = Flow
        '       If OzoneInconcentration < 0.01 Then OzoneInconcentration = 0
        '       If OzoneOutconcentration < 0.01 Then OzoneOutconcentration = 0
        ''      If OzoneOutconcentration > OzoneInconcentration Then
        '       OzoneOutconcentration = 0.00
        '       OzoneInconcentration = 0.00
        '       End If
        If OzoneInconcentration <> 0 Then
            OzoneEfficiency = ((OzoneInconcentration - OzoneOutconcentration) / OzoneInconcentration) * 100
        Else
            OzoneEfficiency = 0
        End If
        O3InDisplay.Value = OzoneInconcentration
        O3OutDisplay.Value = OzoneOutconcentration
        O3EfficiencyDisplay.Value = OzoneEfficiency
        '
        If RawAirFlow > 3.0 Then
            PipeFlow1.Discrete01 = 1
            PipeFlow2.Discrete01 = 1
            blower.AnimationMode = SYMFACXLib.AnimationModeEnum.AnimationModeAnalogFill
        Else
            PipeFlow1.Discrete01 = 0
            PipeFlow2.Discrete01 = 0
            blower.AnimationMode = SYMFACXLib.AnimationModeEnum.AnimationModeNone
        End If
        AirFlowDisplay.Value = RawAirFlow
        PressureDropDisplay.Value = PressureDrop
        HeatOvertempDisplay.Value = HeatOverTemp
        '
        CheckForPass()

    End Sub
    Private Sub CheckForPass()
        Dim passfail = 1
        If Labelpartnumber.Text = "" Then
            ParmsInitial()
            Exit Sub
        End If
        '
        If AxGXButtonAllRed.ButtonDown Then
            FlowDisplay.ForeColor = Color.Green
            TempDisplay.ForeColor = Color.Green
            PressureDisplay.ForeColor = Color.Green
            O3InDisplay.ForeColor = Color.Green
            PressureDropDisplay.ForeColor = Color.Green
            HeatOvertempDisplay.ForeColor = Color.Green
            Heater.AnimationMode = 0
            AxGXButtontest.Visible = True
            AxGXButtonAbort.Visible = True
            Exit Sub
        End If

        If FlowDisplay.Value >= (CDbl(TestParmFlow.Text) - CDbl(TestParmFlowVar.Text)) And FlowDisplay.Value <= (CDbl(TestParmFlow.Text) + CDbl(TestParmFlowVar.Text)) Then
            FlowDisplay.ForeColor = Color.Green
        Else
            FlowDisplay.ForeColor = Color.Yellow
            passfail = 0
        End If
        '
        If TempDisplay.Value >= (CDbl(TestParmTemp.Text) - CDbl(TestParmTempVar.Text)) And TempDisplay.Value <= (CDbl(TestParmTemp.Text) + CDbl(TestParmTempVar.Text)) Then
            TempDisplay.ForeColor = Color.Green
        Else
            TempDisplay.ForeColor = Color.Yellow
            passfail = 0
        End If
        '
        If PressureDisplay.Value >= (CDbl(TestParmPressure.Text) - CDbl(TestParmPressureVar.Text)) And PressureDisplay.Value <= (CDbl(TestParmPressure.Text) + CDbl(TestParmPressureVar.Text)) Then
            PressureDisplay.ForeColor = Color.Green
        Else
            PressureDisplay.ForeColor = Color.Yellow
            passfail = 0
        End If
        '
        If O3InDisplay.Value >= (CDbl(TestParmO3In.Text) - CDbl(TestParmO3inVar.Text)) And O3InDisplay.Value <= (CDbl(TestParmO3In.Text)) + CDbl(TestParmO3inVar.Text) Then
            O3InDisplay.ForeColor = Color.Green
        Else
            O3InDisplay.ForeColor = Color.Yellow
            passfail = 0
        End If
        '
        If PressureDropDisplay.Value < CDbl((TestParmPressureDrop.Text)) Then
            PressureDropDisplay.ForeColor = Color.Green
        Else
            PressureDropDisplay.ForeColor = Color.Yellow
            passfail = 0
        End If
        If HeatOverTemp < 700.0 Then
            HeatOvertempDisplay.ForeColor = Color.Green
            Heater.AnimationMode = 0
        Else
            HeatOvertempDisplay.ForeColor = Color.Red
            Heater.AnimationMode = 1
            passfail = 0

        End If

        If passfail = 1 Then
            AxGXButtontest.Visible = Visible
            AxGXButtonAbort.Visible = Visible
        Else
            If TestState = State.Nottesting Then
                AxGXButtontest.Visible = False
                AxGXButtonAbort.Visible = False
                '                Report.Clear()
            Else                    '
                '  do nothing
            End If
        End If
    End Sub
    Private Sub ParmsInitial()
        FlowDisplay.ForeColor = Color.Yellow
        TempDisplay.ForeColor = Color.Yellow
        PressureDisplay.ForeColor = Color.Yellow
        O3InDisplay.ForeColor = Color.Yellow
        PressureDropDisplay.ForeColor = Color.Yellow
        AxGXButtonAbort.Visible = False
        AxGXButtontest.Enabled = True
        AxGXButtontest.Visible = False
        Report.Clear()
        AbortTimer.Interval = AbortTime
        AbortTimer.Enabled = False
        TestTimer.Enabled = False
        TestState = State.Nottesting
    End Sub
    Private Function AllGreen()
        AllGreen = False
        If FlowDisplay.ForeColor = Color.Green And
            TempDisplay.ForeColor = Color.Green And
            PressureDisplay.ForeColor = Color.Green And
            O3InDisplay.ForeColor = Color.Green And
            PressureDropDisplay.ForeColor = Color.Green And
            HeatOvertempDisplay.ForeColor = Color.Green Then
            Return True
        End If
    End Function
    Private Sub AxGXButtonAbort_OnChange(sender As Object, e As AxGADGETXLIB1Lib._DGXButtonEvents_OnChangeEvent) Handles AxGXButtonAbort.OnChange
        Report.Clear()
        AbortTimer.Enabled = False
        TestTimer.Enabled = False
        AxGXButtontest.Visible = False
        AxGXButtonAbort.Visible = False
        AxGXButtontest.Enabled = True
        TestState = State.Nottesting
    End Sub
    Private Sub AxGXButtontest_ClickEvent(sender As Object, e As EventArgs) Handles AxGXButtontest.ClickEvent
        If TextBoxWorkOrder.Text = "" Then TextBoxWorkOrder.Text = "Blank"
        TestState = State.Waiting1
        AxGXButtontest.Enabled = False
        Report.Clear()
        Report.SelectAll()
        Report.SelectionTabs = New Integer() {15, 115, 215, 315, 415, 515, 615, 715}
        Report.AcceptsTab = True
        Report.Select(0, 0)
        Report.AppendText(vbCrLf)
        Report.AppendText(vbTab & "Testing work order " & TextBoxWorkOrder.Text & "  Partnumber " & Partnumber & "  Test Type  " & Testtype & "  On   " & Now.ToLongDateString)
        Report.AppendText(vbCrLf)
        Report.AppendText(vbTab & "Relative Humidity is " & RelativeHumidity.ToString("n2") & " %" & "   Ambient Temp is " & AmbientTemp.ToString("n2") & " Deg F")
        Report.AppendText(vbCrLf)
        TestTimer.Interval = TestTime
        AbortTimer.Interval = AbortTime
        AbortTimer.Enabled = True
        TestTimer.Enabled = True
    End Sub
    Private Sub TestTimer_Tick(sender As Object, e As EventArgs) Handles TestTimer.Tick
        Dim avf, avt, avp, avoi, avoo, avpd As Double
        TestTimer.Enabled = False
        If TestState = State.Waiting1 Then
            If AllGreen() Then
                Report.AppendText(vbCrLf)
                Report.AppendText(vbCrLf & vbTab)
                Report.AppendText("Test one at " & Now.ToLongDateString & " " & Now.ToLongTimeString)
                WriteTestData(1)
                TestState = State.Waiting2
                TestTimer.Interval = TestTime
                TestTimer.Enabled = True
                Exit Sub
            End If
            TestTimer.Interval = TestTime2
            TestTimer.Enabled = True
        End If
        If TestState = State.Waiting2 Then
            If AllGreen() Then
                Report.AppendText(vbCrLf)
                Report.AppendText(vbCrLf)
                Report.AppendText("    Test two at " & Now.ToLongDateString & " " & Now.ToLongTimeString)
                WriteTestData(2)
                TestState = State.Waiting3
                TestTimer.Interval = TestTime
                TestTimer.Enabled = True
                Exit Sub
            End If
            TestTimer.Interval = TestTime2
            TestTimer.Enabled = True
        End If
        If TestState = State.Waiting3 Then
            If AllGreen() Then
                Report.AppendText(vbCrLf)
                Report.AppendText(vbCrLf)
                Report.AppendText("    Test three at " & Now.ToLongDateString & " " & Now.ToLongTimeString)
                WriteTestData(3)
                TestState = State.Waiting4
                TestTimer.Interval = TestTime
                TestTimer.Enabled = True
                Exit Sub
            End If
            TestTimer.Interval = TestTime2
            TestTimer.Enabled = True
        End If
        If TestState = State.Waiting4 Then
            If AllGreen() Then
                Report.AppendText(vbCrLf)
                Report.AppendText(vbCrLf)
                Report.AppendText("    Test four at " & Now.ToLongDateString & " " & Now.ToLongTimeString)
                WriteTestData(4)
                TestState = State.Waiting5
                TestTimer.Interval = TestTime
                TestTimer.Enabled = True
                Exit Sub
            End If
            TestTimer.Interval = TestTime2
            TestTimer.Enabled = True
        End If
        If TestState = State.Waiting5 Then
            If AllGreen() Then
                Report.AppendText(vbCrLf)
                Report.AppendText(vbCrLf)
                Report.AppendText("    Test five at " & Now.ToLongDateString & " " & Now.ToLongTimeString)
                WriteTestData(5)
                TestState = State.TestDone
                TestTimer.Interval = TestTime
                TestTimer.Enabled = True
                AbortTimer.Enabled = False
                Exit Sub
            End If
            TestTimer.Interval = TestTime
            TestTimer.Enabled = True
        End If
        If TestState = State.TestDone Then
            TestTimer.Enabled = False
            AbortTimer.Enabled = False
            avf = (F(1) + F(2) + F(3) + F(4) + F(5)) / 5          'Flow
            avt = (T(1) + T(2) + T(3) + T(4) + T(5)) / 5          'Temp
            avp = (P(1) + P(2) + P(3) + P(4) + P(5)) / 5          'Pressure
            avoi = (OI(1) + OI(2) + OI(3) + OI(4) + OI(5)) / 5    'O3 in
            avoo = (OO(1) + OO(2) + OO(3) + OO(4) + OO(5)) / 5    'O3out
            avpd = (PD(1) + PD(2) + PD(3) + PD(4) + PD(5)) / 5    'Pessure diferential
            Report.AppendText(vbCrLf)
            Report.AppendText(vbCrLf)
            Report.AppendText(vbCrLf)
            Report.AppendText(vbTab & "Test Done  at " & Now.ToLongDateString & " " & Now.ToLongTimeString)
            Report.AppendText(vbCrLf)
            Report.AppendText(vbTab & "AVERAGES")
            Report.AppendText(vbCrLf)
            Report.AppendText(vbTab & "Flow(lb/min)" & vbTab & "Temperature(F)" & vbTab & "Pressure(Psia)" & vbTab & "O3 in(ppm)" & vbTab & "O3 out(ppm)" & vbTab & "Pressure Drop")
            Report.AppendText(vbCrLf)
            Report.AppendText(vbTab & avf.ToString("n2") & vbTab & avt.ToString("n1") & vbTab & avp.ToString("n1") & vbTab & avoi.ToString("n3") & vbTab & avoo.ToString("n3") & vbTab & avpd.ToString("n2"))
            TestState = State.Nottesting
            AxGXButtontest.Visible = False
            AxGXButtonAbort.Visible = False
            MessageBox.Show("Test Done")
            Exit Sub
        End If
        If TestState = State.Nottesting Then
        End If

    End Sub
    Private Sub AbortTimer_Tick(sender As Object, e As EventArgs) Handles AbortTimer.Tick
        MsgBox("Test timed out ")
        Report.Clear()

        AbortTimer.Enabled = False
        TestTimer.Enabled = False
        AxGXButtontest.Visible = False
        AxGXButtonAbort.Visible = False
        AxGXButtontest.Enabled = True
        TestState = State.Nottesting

    End Sub
    Private Sub WriteTestData(i)
        Report.AppendText(vbCrLf)
        Report.AppendText(vbTab & "Flow(lb/min)" & vbTab & "Temperature(F)" & vbTab & "Pressure(Psia)" & vbTab & "O3 in(ppm)" & vbTab & "O3 out(ppm)" & vbTab & "Pressure Drop")
        Report.AppendText(vbCrLf)
        Report.AppendText(vbTab & Flow.ToString("n2") & vbTab & ProcessTemp.ToString("n1") & vbTab & InletPressurePV.ToString("n1") & vbTab & OzoneInconcentration.ToString("n3") & vbTab & OzoneOutconcentration.ToString("n3") & vbTab & PressureDrop.ToString("n2"))
        F(i) = Flow
        T(i) = ProcessTemp
        P(i) = InletPressurePV
        OI(i) = OzoneInconcentration
        OO(i) = OzoneOutconcentration
        PD(i) = PressureDrop
    End Sub



End Class
