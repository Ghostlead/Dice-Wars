﻿Public Class Form
    Public rnddicecolour As Integer
    Public rnddicenumber As Integer
    Public dicecolour As Integer
    Public comp1 As Integer
    Public comp2 As Integer
    Public dice As Random
    Dim rnd = New Random()
    Public decider As Integer
    Public playerturn As Integer
    Public attack As Boolean
    Public defend As Boolean

    Private Sub setup(buttontoedit)
        rnddicenumber = rnd.Next(9) + 1
        rnddicecolour = rnd.next(4) + 1
        If rnddicecolour = 1 Then
            buttontoedit.backcolor = System.Drawing.Color.Pink
            Label5.Text = Int(Label5.Text) + 1
        ElseIf rnddicecolour = 2 Then
            buttontoedit.backcolor = System.Drawing.Color.Red
            Label8.Text = Int(Label8.Text) + 1
        ElseIf rnddicecolour = 3 Then
            buttontoedit.backcolor = System.Drawing.Color.Blue
            Label7.Text = Int(Label7.Text) + 1
        ElseIf rnddicecolour = 4 Then
            buttontoedit.backcolor = System.Drawing.Color.Green
            Label6.Text = Int(Label6.Text) + 1
        End If
        buttontoedit.Text = Str(rnddicenumber)
    End Sub
    Private Sub store(buttonclick)
        If attack = False And comp1 = 0 Then
            comp1 = buttonclick.text
            buttonclick.text = "1"
            Button27.BackColor = buttonclick.backcolor
        End If
        If attack = True And defend = False And comp2 = 0 Then
            comp2 = buttonclick.text
        End If
        attack = True
        If attack = True And defend = True Then
            compare(buttonclick)
        End If
        defend = True
    End Sub
    Private Sub compare(buttoncomp)
        If comp1 > comp2 Then
            buttoncomp.text = Str(comp1) - 1
            buttoncomp.backcolor = Button27.BackColor
        End If
        If comp1 < comp2 Then
            MsgBox("You failed and your enemy gains a dice")
            buttoncomp.text = Str(comp2) + 1
        End If
        If comp1 = comp2 Then
            decider = rnd.next(10)
            If decider > 5 Then
                buttoncomp.text = comp1
            Else : buttoncomp.text = comp2
            End If
        End If
        comp1 = 0
        comp2 = 0
        attack = False
        defend = False
    End Sub

    'Private Sub check(buttonclick)
    '    If attack = False Then
    '        store(buttonclick)
    '    ElseIf defend = False Then
    '        turn(buttonclick)
    '    End If
    'End Sub

    'Private Sub check(turn)
    ' Dim o As Object
    'While attack = False
    'comp1 = turn.text
    'Button27.BackColor = turn.backcolor
    'attack = True
    'End While
    'While attack = True And defend = False
    'comp2 = turn.text
    'defend = True
    'End While
    'If comp1 > comp2 Then
    'turn.text = comp1
    'turn.BackColor = Button27.BackColor
    'ElseIf comp1 < comp2 Then
    'turn.text = comp2
    'ElseIf comp1 = comp2 Then
    'decider = rnd.next(11)
    'If decider > 5 Then
    'turn.text = comp1
    'turn.BackColor = Button27.BackColor
    'Else : turn.text = comp2
    'End If
    'End If
    'If comp1 > 0 And comp2 > 0 Then
    'comp1 = 0
    'comp2 = 0
    'attack = False
    'defend = False
    'For Each o In Me.Controls
    'If TypeOf o Is Button Then
    'DirectCast(o, Button).Enabled = True
    'End If
    'Next
    'End If
    'If playerturn = 4 Then
    'playerturn = 1
    'End If
    'End Sub
    Private Sub colorscore(button)
        If button.backcolor = System.Drawing.Color.Pink Then
            Label5.Text = Int(Label5.Text) + 1
        End If
        If button.backcolor = System.Drawing.Color.Red Then
            Label8.Text = Int(Label8.Text) + 1
        End If
        If button.backcolor = System.Drawing.Color.Blue Then
            Label7.Text = Int(Label7.Text) + 1
        End If
        If button.backcolor = System.Drawing.Color.Green Then
            Label6.Text = Int(Label6.Text) + 1
        End If
    End Sub
    Private Sub attackset(buttonclick)
        If attack = True And comp2 = 0 Then
            buttonclick.Text = 1
        End If
    End Sub
    Private Sub enabler(buttonenable)
        If attack = True And defend = True Then
            Dim d As Object
            For Each d In Me.Controls
                If TypeOf d Is Button Then
                    DirectCast(d, Button).Enabled = True
                End If
            Next
        End If
    End Sub
    'Private Sub turn(buttonturn)
    '    Select Case playerturn
    '        Case 1
    '            If playerturn = 1 And defend = False Then
    '                If buttonturn.backcolor = System.Drawing.Color.Pink Then
    '                    compare(buttonturn)
    '                    playerturn = playerturn + 1
    '                Else
    '                    MsgBox("Its not your turn")
    '                    enabler(buttonturn)
    '                    playerturn = 1
    '                End If
    '            End If
    '        Case 2
    '           If playerturn = 2 And defend = False Then
    '                If buttonturn.backcolor = System.Drawing.Color.Green Then
    '                    compare(buttonturn)
    '                    playerturn = playerturn + 1
    '               Else
    '                    MsgBox("Its not your turn")
    '                    enabler(buttonturn)
    '                    playerturn = 2
    '                End If
    '            End If
    '        Case 3
    '            If playerturn = 3 And defend = False Then
    '                If buttonturn.backcolor = System.Drawing.Color.Blue Then
    '                    compare(buttonturn)
    '                    playerturn = playerturn + 1
    '                Else
    '                    MsgBox("Its not your turn")
    '                    enabler(buttonturn)
    '                    playerturn = 3
    '                End If
    '            End If
    '        Case Else
    '            If playerturn = 4 And defend = False Then
    '                If buttonturn.backcolor = System.Drawing.Color.Red Then
    '                    compare(buttonturn)
    '                    playerturn = playerturn + 1
    '                Else
    '                    MsgBox("Its not your turn")
    '                    enabler(buttonturn)
    '                    playerturn = 4
    '                End If
    '                playerturn = 1
    '            End If
    '    End Select
    'End Sub
    Private Sub colorpink(buttoncomp)
        If buttoncomp.backcolor <> System.Drawing.Color.Pink Then
            Dim d As Object
            For Each d In Me.Controls
                If TypeOf d Is Button Then
                    DirectCast(d, Button).Enabled = False
                End If
            Next
        End If
    End Sub
    'Private Sub store(buttoncomp)
    '    If attack = False Then
    '        comp1 = buttoncomp.text
    '        Button27.BackColor = buttoncomp.BackColor
    '        attack = True
    '    End If
    'End Sub

    '   Private Sub compare(buttoncomp)
    '   Dim o As Object
    '       If defend = False Then
    '          comp2 = buttoncomp.text
    '         defend = True
    '    End If
    '       If comp1 > comp2 Then
    '       buttoncomp.text = comp1
    '       buttoncomp.BackColor = Button27.BackColor
    '   ElseIf comp1 < comp2 Then
    '       buttoncomp.text = comp2
    '       ElseIf comp1 = comp2 Then
    '           decider = rnd.next(11)
    '            If decider > 5 Then
    '                buttoncomp.text = comp1
    '               buttoncomp.BackColor = Button27.BackColor
    '          Else : buttoncomp.text = comp2
    '         End If
    '    End If
    '   If comp1 > 0 And comp2 > 0 Then
    '      comp1 = 0
    '     comp2 = 0
    '    attack = False
    '   defend = False
    '  For Each o In Me.Controls
    '     If TypeOf o Is Button Then
    '        DirectCast(o, Button).Enabled = True
    '   End If
    '            Next
    '        End If
    '        If playerturn = 4 Then
    '            playerturn = 1
    '        End If
    'End Sub

    'Private Sub score(buttoncolour)
    '   If buttoncolour.backcolour = Color.Pink Then
    '      Label5.Text = Int(Label5.Text) + 1
    ' ElseIf buttoncolour.backcolour = Color.Red Then
    '    Label8.Text = Int(Label8.Text) + 1
    'End If
    'End Sub

    Private Sub Disabler(buttondisable)
        Dim o As Object
        For Each o In Me.Controls
            If TypeOf o Is Button Then
                DirectCast(o, Button).Enabled = False
            End If
        Next
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setup(Button1)
        setup(Button2)
        setup(Button3)
        setup(Button4)
        setup(Button5)
        setup(Button6)
        setup(Button7)
        setup(Button8)
        setup(Button9)
        setup(Button10)
        setup(Button11)
        setup(Button12)
        setup(Button13)
        setup(Button14)
        setup(Button15)
        setup(Button16)
        setup(Button17)
        setup(Button18)
        setup(Button19)
        setup(Button20)
        setup(Button21)
        setup(Button22)
        setup(Button23)
        setup(Button24)
        setup(Button25)
        'score(Button1)
        'score(Button2)
        comp1 = 0
        comp2 = 0
        playerturn = 1
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Disabler(Button1)
        store(Button1)
        attackset(Button1)
        Button2.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True

        enabler(Button1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Disabler(Button2)
        store(Button2)
        attackset(Button2)
        Button1.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button3.Enabled = True
        Button8.Enabled = True
        enabler(Button2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Disabler(Button3)
        store(Button3)
        attackset(Button3)
        Button2.Enabled = True
        Button4.Enabled = True
        Button9.Enabled = True
        Button7.Enabled = True
        Button3.Enabled = True
        Button8.Enabled = True
        enabler(Button3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Disabler(Button4)
        store(Button4)
        attackset(Button4)
        Button4.Enabled = True
        Button8.Enabled = True
        Button7.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        enabler(Button4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Disabler(Button5)
        store(Button5)
        attackset(Button5)
        Button4.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        enabler(Button5)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Disabler(Button10)
        store(Button10)
        attackset(Button10)
        Button1.Enabled = True
        Button9.Enabled = True
        Button2.Enabled = True
        Button14.Enabled = True
        Button15.Enabled = True
        enabler(Button10)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Disabler(Button9)
        store(Button9)
        attackset(Button9)
        Button1.Enabled = True
        Button3.Enabled = True
        Button2.Enabled = True
        Button14.Enabled = True
        Button15.Enabled = True
        Button13.Enabled = True
        Button10.Enabled = True
        Button8.Enabled = True
        enabler(Button9)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Disabler(Button8)
        store(Button8)
        attackset(Button8)
        Button4.Enabled = True
        Button3.Enabled = True
        Button2.Enabled = True
        Button9.Enabled = True
        Button7.Enabled = True
        Button13.Enabled = True
        Button14.Enabled = True
        Button12.Enabled = True
        enabler(Button8)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Disabler(Button7)
        store(Button7)
        attackset(Button7)
        Button4.Enabled = True
        Button3.Enabled = True
        Button5.Enabled = True
        Button8.Enabled = True
        Button6.Enabled = True
        Button13.Enabled = True
        Button11.Enabled = True
        Button12.Enabled = True
        enabler(Button7)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Disabler(Button6)
        store(Button6)
        attackset(Button6)
        Button4.Enabled = True
        Button5.Enabled = True
        Button7.Enabled = True
        Button12.Enabled = True
        Button11.Enabled = True
        enabler(Button6)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Disabler(Button15)
        store(Button15)
        attackset(Button15)
        Button10.Enabled = True
        Button9.Enabled = True
        Button14.Enabled = True
        Button20.Enabled = True
        Button19.Enabled = True
        enabler(Button15)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Disabler(Button14)
        store(Button14)
        attackset(Button14)
        Button10.Enabled = True
        Button9.Enabled = True
        Button8.Enabled = True
        Button13.Enabled = True
        Button15.Enabled = True
        Button20.Enabled = True
        Button19.Enabled = True
        Button18.Enabled = True
        enabler(Button14)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Disabler(Button13)
        store(Button13)
        attackset(Button13)
        Button7.Enabled = True
        Button9.Enabled = True
        Button8.Enabled = True
        Button14.Enabled = True
        Button12.Enabled = True
        Button17.Enabled = True
        Button19.Enabled = True
        Button18.Enabled = True
        enabler(Button13)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Disabler(Button12)
        store(Button12)
        attackset(Button12)
        Button8.Enabled = True
        Button7.Enabled = True
        Button6.Enabled = True
        Button13.Enabled = True
        Button11.Enabled = True
        Button16.Enabled = True
        Button17.Enabled = True
        Button18.Enabled = True
        enabler(Button12)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Disabler(Button11)
        store(Button11)
        attackset(Button11)
        Button7.Enabled = True
        Button6.Enabled = True
        Button12.Enabled = True
        Button17.Enabled = True
        Button16.Enabled = True
        enabler(Button11)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Disabler(Button20)
        store(Button20)
        attackset(Button20)
        Button15.Enabled = True
        Button14.Enabled = True
        Button19.Enabled = True
        Button25.Enabled = True
        Button24.Enabled = True
        enabler(Button20)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Disabler(Button19)
        store(Button19)
        attackset(Button19)
        Button15.Enabled = True
        Button13.Enabled = True
        Button14.Enabled = True
        Button18.Enabled = True
        Button20.Enabled = True
        Button25.Enabled = True
        Button24.Enabled = True
        Button23.Enabled = True
        enabler(Button19)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Disabler(Button18)
        store(Button18)
        attackset(Button18)
        Button14.Enabled = True
        Button13.Enabled = True
        Button12.Enabled = True
        Button19.Enabled = True
        Button17.Enabled = True
        Button24.Enabled = True
        Button23.Enabled = True
        Button22.Enabled = True
        enabler(Button18)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Disabler(Button17)
        store(Button17)
        attackset(Button17)
        Button13.Enabled = True
        Button12.Enabled = True
        Button11.Enabled = True
        Button18.Enabled = True
        Button16.Enabled = True
        Button23.Enabled = True
        Button22.Enabled = True
        Button21.Enabled = True
        enabler(Button17)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Disabler(Button16)
        store(Button16)
        attackset(Button16)
        Button12.Enabled = True
        Button11.Enabled = True
        Button21.Enabled = True
        Button17.Enabled = True
        Button22.Enabled = True
        enabler(Button12)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Disabler(Button25)
        store(Button25)
        attackset(Button25)
        Button24.Enabled = True
        Button19.Enabled = True
        Button20.Enabled = True
        enabler(Button25)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Disabler(Button24)
        store(Button24)
        attackset(Button24)
        Button25.Enabled = True
        Button23.Enabled = True
        Button20.Enabled = True
        Button18.Enabled = True
        Button19.Enabled = True
        enabler(Button24)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Disabler(Button23)
        store(Button23)
        attackset(Button23)
        Button24.Enabled = True
        Button22.Enabled = True
        Button17.Enabled = True
        Button18.Enabled = True
        Button19.Enabled = True
        enabler(Button23)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Disabler(Button22)
        store(Button22)
        attackset(Button22)
        Button21.Enabled = True
        Button23.Enabled = True
        Button16.Enabled = True
        Button18.Enabled = True
        Button17.Enabled = True
        enabler(Button22)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Disabler(Button21)
        store(Button21)
        attackset(Button21)
        Button16.Enabled = True
        Button22.Enabled = True
        Button17.Enabled = True
        enabler(Button21)
    End Sub
End Class