' Copyright 2020 Clarence Yang 
' Timer assessment task by clarence yang for SDD prelim task 1 
' main form
' created 11/3/20
' NOTE: THE ORIGINAL FILE CORRUPTED, as of 15/4/20, a google drive version was recovered

#Region "changelogs"
' CHANGELOG: 
' 
' 11/3/20
' * Drew up main form, with basic features
' * wrote up timer functions: pause, resume and start (custom)
'
' 18/3/20
' * Worked on UI 
' * began 2nd form
' * worked on additional timer functionality
' * added loop
'
' 23/3/20
' * bug fixes
' * UI changes on 2nd form
'
' 29/3/20
' * bug fixes
' * worked on resetting 
' * worked on timer functions and 2nd form
'
' 5/3/20
' * gathered images for exercies
' * integrated timer in second form
' * added additional information for images (as arrays)
' * added randomization.
'
' 9/3/20
' * fixed up UI
' * bug fixes
' * worked on improving image quality.
'
' 15/4/20
' * code changes: bug fixes
' * modified images for user exercise screen
'
' 19/4/20
' * UI updates: added icons
' * minor code changes
'
' 20/4/20
' * Bug fixes: timer pause
' * updates to 2nd form
'
' 21/4/20
' * added instructions to 2nd from
' * various UI changes
'
' 22/4/20
' * bug fixes
' * added system notifications
' 
' 23/4/20
' * bug fixes
'
' 24/4/20
' * bug fixes

#End Region



' icons from www.flaticon.com:
' play icon by: https://www.flaticon.com/authors/those-icons
' pause icon by: https://www.flaticon.com/authors/google
' stop icon by: https://www.flaticon.com/authors/roundicons
' start/logo icon by: https://www.flaticon.com/authors/fjstudio
' all edited by me through photoshop


Public Class MainForm

    'variables'
    Dim hours As Integer 'will be set to values in the textboxes
    Dim seconds As Integer
    Dim minutes As Integer
    Dim counting As Boolean
    Dim t As TimeSpan 'timer set value, is formatted to be shown on timer label. Updates on every timer tick
    Dim t1 As TimeSpan 'timer set value, does not update.
    Dim dt As DateTime 'will be set to current time
    Dim index As Int16 'stores button stop - resume states
    Dim shouldLoop As Boolean 'looping variable

    'additional date time calculations
    Dim afkTime As TimeSpan 'a time offset for when the user pauses the timer, because the program must know when to resume
    Dim pauseTime As DateTime 'a datetime variable that will record the time for when the user paused
    Dim isOn As Boolean 'a check to see if the timer is running
    Dim recordedTime As Boolean 'a check to see if the pause time has been appended
    Dim TotalWaitTime As TimeSpan 'the total time a user has paused, will accumulate for every time they pause.

    Dim notified As Boolean 'check for if we notified user with tray notification



    'start button
    Private Sub Start_btn_Click(sender As Object, e As EventArgs) Handles Start_btn.Click 'start button press

        If TextBox1.Text = "0" And TextBox2.Text = "0" And TextBox3.Text = "0" Then 'check if the text box has any value
            MessageBox.Show("please set an input!") 'tell user to input value if theres no value
            Return
        End If
        Try 'we will attempt to convert the strings within the textboxes to integer values

            hours = Convert.ToInt16(TextBox3.Text)
            minutes = Convert.ToInt16(TextBox2.Text)
            seconds = Convert.ToInt16(TextBox1.Text)


            If hours <= 0 And minutes <= 0 And seconds <= 0 Or (hours < 0 Or minutes < 0 Or seconds < 0) Then 'check if the values are valid
                MessageBox.Show("please set a valid input!") 'if so, tell user to input a valid input
                Return 'stop executing
            End If
            dt = DateTime.Now 'set dt as the current time
            notified = False
            t1 = New TimeSpan(hours, minutes, seconds) 'set the timer value
            dt += t1 'get the predicted datetime this timer ends
            counting = True 'the timer should start counting
            isOn = True 'the timer is officially on
            Start_btn.Enabled = False 'the user shouldnt press the start button anymore
            'we disable the textboxes 
            TextBox3.Enabled = False
            TextBox2.Enabled = False
            TextBox1.Enabled = False
            afkTime = New TimeSpan(0, 0, 0) 'reset the afk time


        Catch ex As Exception 'cant convert
            MessageBox.Show("failed to start timer, check your input") 'something went wrong
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'form load
        'reset all variables
        hours = 0
        seconds = 0
        minutes = 0
        counting = False
        index = 0
        shouldLoop = True
        afkTime = New TimeSpan(0, 0, 0)
        TotalWaitTime = New TimeSpan(0, 0, 0)
        ProgressPanel.Width = 0
        isOn = False
        recordedTime = False
        notified = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick 'timer tick interval = 1000


        If counting Then 'should activate if the timer is counting

            If recordedTime = False Then 'if we havent yet applied the offset time
                'append old afk time to new afk time
                TotalWaitTime += afkTime 'we can now get total offset
                afkTime = New TimeSpan(0, 0, 0) 'reset our temporary offset time collector
                recordedTime = True 'turn this on so we dont continue to append
            End If
            'wrote custom timer function
            t = dt - (DateTime.Now - TotalWaitTime) 'calculate time difference between predicted finish time and current finish, with offset applied

            'Label1.Text = $"{t.Hours}:{t.Minutes}:{t.Seconds}" <-- old statement
            If t.Hours = 0 Then 'formatting check, for some reason if t.hours is = 0 it is denoted as '12'
                Label1.Text = "00:" + Format$(TimeSerial(0, t.Minutes, t.Seconds), "mm:ss") 'formatting issue when 0 hours are present

            Else 'default formatting'
                Label1.Text = Format$(TimeSerial(t.Hours, t.Minutes, t.Seconds), "hh:mm:ss") '<-- new statement, got help from: http://www.vbforums.com/showthread.php?751957-Timer-function-to-display-HH-MM-SS
            End If

            'get the percentage of time passed as decimal
            Dim percent As Double
            percent = (t1.TotalSeconds - t.TotalSeconds) / t1.TotalSeconds

            'MessageBox.Show(percent.ToString())
            'apply the percentage to our progress panel width, like a progress bar
            ProgressPanel.Width = percent * 410


            If ((t.TotalSeconds) <= 60) And notified = False Then
                notified = True


                NotifyIcon1.Icon = SystemIcons.Application

                'notify user
                NotifyIcon1.ShowBalloonTip(1000, "Timer almost up: Prepare to rest!", "Save and finish what you are doing, stretching will commence shortly.", ToolTipIcon.Info)



            End If




            If (DateTime.Now - TotalWaitTime) >= dt Then 'when time is up

                counting = False 'disable timer
                Start_btn.Enabled = True 'enable start button
                'MessageBox.Show("timer is up")


                UserExercisescreen.ShowDialog() 'show exercise for the user

                ProgressPanel.Width = 0 'reset our panel




            End If

        Else 'if not counting
            If isOn Then 'if it is not counting and timer is running (so it is in pause mode)

                afkTime = DateTime.Now - pauseTime 'while the program is in pause, we calculate how long it has been in pause.
            End If

        End If

    End Sub

    Public Sub loopinit() 'restart timer. is called from the other class

        notified = False
        afkTime = New TimeSpan(0, 0, 0)
        TotalWaitTime = New TimeSpan(0, 0, 0)
        pauseTime = DateTime.Now 'set the time we paused
        recordedTime = False
        counting = False
        isOn = False
        TextBox3.Enabled = True
        TextBox2.Enabled = True
        TextBox1.Enabled = True
        If shouldLoop = True Then 'should we loop? 

            Start_btn.PerformClick() 'loop by starting timer again
        End If






    End Sub

    'stop or pause
    Private Sub Stop_Btn_Click(sender As Object, e As EventArgs) Handles Stop_Btn.Click
        If index = 0 And counting = True And (DateTime.Now - TotalWaitTime) < dt Then 'if not stopped right now and the timer is still running
            counting = False 'pause timer
            ToolTip1.SetToolTip(Stop_Btn, "Resume") 'set tool tip
            Stop_Btn.BackgroundImage = My.Resources.play_button 'set icon of button to resume
            index = 1 'set state to 1 so nextime we press it should resume
            pauseTime = DateTime.Now 'set the time we paused
            recordedTime = False
        ElseIf index = 1 And counting = False Then 'if it is stopped already
            counting = True 'resume timer
            ToolTip1.SetToolTip(Stop_Btn, "Pause")

            Stop_Btn.BackgroundImage = My.Resources.pause 'set icon of button to pause

            index = 0 'set state to 0 so nextime we press it should stop

        End If

    End Sub

    'reset
    Private Sub Reset_Btn_Click(sender As Object, e As EventArgs) Handles Reset_Btn.Click
        counting = False 'stop timer
        Start_btn.Enabled = True 'enable start button
        TextBox3.Enabled = True
        TextBox2.Enabled = True
        TextBox1.Enabled = True
        index = 0 'set state to 0
        notified = False
        'reset variables
        hours = 0
        minutes = 0
        seconds = 0
        afkTime = New TimeSpan(0, 0, 0)
        TotalWaitTime = New TimeSpan(0, 0, 0)
        isOn = False
        'reset formatting
        Label1.Text = "00:00:00"
        TextBox1.Text = "0"
        TextBox2.Text = "0"
        TextBox3.Text = "0"
        ProgressPanel.Width = 0
    End Sub


    'on form leave
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim answer As Integer
        answer = MsgBox("Do you really want to leave?", vbQuestion + vbYesNo, "Confirm") 'ask for confirmation

        If answer = vbYes Then
            'nothing happens, it quits
        Else
            'cancel quitting
            e.Cancel = True 'got help here: https://stackoverflow.com/questions/2256869/vb-net-abort-formclosing

        End If


    End Sub

    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBox1.CheckedChanged 'loop toggle changed
        If shouldLoop Then 'set boolean accordingly
            shouldLoop = False
        Else
            shouldLoop = True
        End If
    End Sub

    'textbox formatting
    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        If TextBox3.Text = "" Then
            TextBox3.Text = "0" 'set textbox to 0 if no value is inputted
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "" Then
            TextBox2.Text = "0"
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "0"
        End If
    End Sub
End Class
