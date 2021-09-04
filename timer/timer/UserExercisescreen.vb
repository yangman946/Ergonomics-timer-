'2nd form for exercises.
'clarence yang 11SDD
'exercies from http://ergonomictrends.com/best-ergonomic-exercises-stretches-office/

Public Class UserExercisescreen
    'time variables
    Dim timewait As TimeSpan 'the set time, will be assigned
    Dim datewait As DateTime 'the predicted time of completion 
    Dim elapsedt As TimeSpan 'the total time passed

    Dim done As Boolean
    Dim f As MainForm 'our original form
    Dim rnd As New Random()
    Dim intercept As Boolean
    'array for names
    Dim names = New String() {"Wrist Flexion", "Wrist tilt", "Extended Finger Stretch", "Neck Tilt", "Head Turns",
        "Overhead Shoulder Stretch", "Shoulder Roll", "Chest Stretch", "Low Back Stretch", "Back and Side stretch",
        "Seated Back Curl", "Standing Stretch", "Calf Stretch", "Leg Lift", "Hip Stretch"} 'array for names
    'array for information
    Dim info = New String() {"Increases wrist flexability and reduces chance of getting Carpel Tunnel Syndrome!",
        "Reduces chance of RSI in wrists and increases flexibility in stiff joints.", "Relax your stiff fingers and hands from strain.",
        "Relieves stressed neck and neck pain by rejuvenating blood flow to tense areas.",
        "Stretches neck: relieves neck tension.", "Relaxes tension your upper back, shoulders and neck.",
        "Relaxes tension your shoulders, especially after sitting at a desk!", "Untense your hunched chest and shoulders by letting blood to flow through.",
        "Stretches your lower back and releases tension around the spine.", "Side stretch: Great exercise for lower back especially after sitting for hours..",
        "Great exercise that relieves stress in the legs and upper back.", "Great for relieving stress in lower back and glutes: repeat this several times.",
        "Relieves numb and stiff calves, great for increasing blood flow to these areas.", "Releases stubborn tension in quadriceps and hamstrings.", "Great for relaxing the built up tension around the lower spine and hip."}

    'array for instructions
    Dim instructions = New String() {"1) Extend arm outwards with palm facing down" & vbCrLf & "2) Pull fingers as depicted on the diagram" & vbCrLf & "3) Repeat with five second intervals on each hand",
        "1) Fully extend arm with palm facing downwards" & vbCrLf & "2) Tilt wrist to the right" & vbCrLf & "3) hold for three seconds and repeat for left side",
        "1) Extend both hands with palm facing downward" & vbCrLf & "2) Extend fingers outwards" & vbCrLf & "3) Hold for 10 seconds and repeat with fingers bent. (see diagram)",
        "1) Sit at edge of your chair with feet flat on the ground" & vbCrLf & "2) Tilt your head to the right and hold for 5 seconds" & vbCrLf & "3) Repeat for other side",
        "1) Begin facing forward" & vbCrLf & "2) Slowly turn you head to the right and hold for 10 seconds" & vbCrLf & "2) repeat on opposite side",
        "1) Raise one arm overhead and bend it at the elbow" & vbCrLf & "2) stretch it using your opposite hand, hold for 10 seconds" & vbCrLf & "3) Repeat on the other side",
        "1) Begin standing up" & vbCrLf & "2) Slowly roll shoulders backwards" & vbCrLf & "3) Repeat by rolling them forwards",
        "1) Begin standing with hands at your sides" & vbCrLf & "2) Place your hands behind your head and squeeze shoulder blades together" & vbCrLf & "3) Hold for 5-10 seconds",
        "1) Begin standing with arms up" & vbCrLf & "2) Reach towards to ceiling, feeling a stretch along your sides" & vbCrLf & "3) hold for 10 seconds and repeat by stretching to a higher degree",
        "1) Beign standing with hands in the air" & vbCrLf & "2) Interlock Fingers and bend to one side (make sure elbows are straight)" & vbCrLf & "3) Hold for 10 seconds and repeat on other side",
        "1) Begin seated with feet flat on the ground" & vbCrLf & "2) Lift one leg up, grasping it with both hands" & vbCrLf & "3) Bend forward so that your nose reaches to your knee, repeat on other leg.",
        "1) Begin standing with hands on your lower back" & vbCrLf & "2) Lean back slowly and hold for 5-10 seconds" & vbCrLf & "3) Release and repeat",
        "1) Begin standing with one foot a step ahead of the other" & vbCrLf & "2) Lean onto the front foot, allowing the front knee to bend" & vbCrLf & "3) hold for 10 seconds and repeat for other side",
        "1) Begin sitting with extra space in front of you" & vbCrLf & "2) Lift one leg off the floor, keeping it straight for 10 seconds" & vbCrLf & "3) Lower and repeat for other leg",
        "1) Begin sitting with one leg crossed over the other" & vbCrLf & "2) Grasp your bottom knee with the opposite hand and stretch your lower back, holding for 10 seconds" & vbCrLf & "3) repeat on other side"}

    Private Sub UserExercisescreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'on load
        TopMost = True 'make the form the top most form
        beginwait() 'call for initiate
        f = MainForm 'assign our original form
        Panel1.Location = New Point((Width - Panel1.Width) \ 2, 80) 'center metropanel
        'MessageBox.Show((Width - Panel1.Width).ToString())

        done = False
        intercept = False

    End Sub

    Private Sub beginwait() 'initiate
        timewait = New TimeSpan(0, 0, 30) 'set wait for 30 seconds

        datewait = DateTime.Now + timewait 'calculate time to finish
        randChoice() 'choose a random exercise
    End Sub

    Private Sub randChoice() 'choose random choice ///// 
        'randomize and pick a picture

        Dim choice As Int16
        rnd = New Random()

        choice = rnd.Next(0, 14) 'random choice, between exercises
        'set picture box
        'MessageBox.Show("time is up, choice is " + choice.ToString())
        Select Case choice 'selecting an image depending on our random choice
            Case 0
                Panel1.BackgroundImage = My.Resources.i1 'note that a panel is used instead of a picture box, this is because the formatting on a panel is cleaner somehow.
            Case 1
                Panel1.BackgroundImage = My.Resources.i2 'using the images
            Case 2
                Panel1.BackgroundImage = My.Resources.i3
            Case 3
                Panel1.BackgroundImage = My.Resources.i4
            Case 4
                Panel1.BackgroundImage = My.Resources.i5
            Case 5
                Panel1.BackgroundImage = My.Resources.i6
            Case 6
                Panel1.BackgroundImage = My.Resources.i7
            Case 7
                Panel1.BackgroundImage = My.Resources.i8
            Case 8
                Panel1.BackgroundImage = My.Resources.i9
            Case 9
                Panel1.BackgroundImage = My.Resources.i10
            Case 10
                Panel1.BackgroundImage = My.Resources.i11
            Case 11
                Panel1.BackgroundImage = My.Resources.i12
            Case 12
                Panel1.BackgroundImage = My.Resources.i13
            Case 13
                Panel1.BackgroundImage = My.Resources.i14
            Case 14
                Panel1.BackgroundImage = My.Resources.i15



        End Select

        'set our corresponding information and titles through the listed arrays
        MetroLabel1.Text = info(choice)
        Label2.Text = names(choice)
        MetroLabel2.Text = instructions(choice)



    End Sub

    Private Sub WaitTimer_Tick(sender As Object, e As EventArgs) Handles WaitTimer.Tick 'timer tick interval = 1000 
        TopMost = True 'make the form the top most form
        elapsedt = datewait - DateTime.Now 'total time passed
        Countdown.Text = elapsedt.Seconds.ToString() + " seconds remaining" 'output this onto the screen 






        If DateTime.Now > datewait Then 'if time is up: 30 secs
            'finish

            done = True
            Close() 'close the form
        End If
    End Sub



    Private Sub UserExercisescreen_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed 'called on close
        If done Then
            f.loopinit() 'loop on main form

        End If



    End Sub

    Private Sub UserExercisescreen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing ' if the user figures out a way to close it
        If done = False Then
            Dim answer As Integer
            intercept = True
            answer = MsgBox("You haven't finished your exercise. Do you really want to leave?", vbQuestion + vbYesNo, "Confirm") 'ask for confirmation

            If answer = vbYes Then
                'nothing happens, it quits
            Else
                'cancel quitting
                e.Cancel = True

            End If
        ElseIf done = True And intercept = True Then
            Countdown.Text = "Waiting for user to respond"
        End If


    End Sub
End Class