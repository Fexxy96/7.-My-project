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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        ComboBox2 = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        Label4 = New Label()
        ComboBox3 = New ComboBox()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Algerian", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        Label1.Location = New Point(84, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 21)
        Label1.TabIndex = 0
        Label1.Text = "Order Form"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Diesiel", "Petrol 93", "Petrol 95", "Parrafin", "Additives"})
        ComboBox1.Location = New Point(46, 87)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 2
        Label2.Text = "Products"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Botswana 6 Kruma Road", "McDonald Clayville", "Cocacola Clayville", "Afrisam Malborough", "Sterkleweis ", "Afrisam City deep", "Putco Dobsonville", "Putco Roodeport", "Putco Witswatersrand", "Spar Midrand", "Pick n pay Kempton park"})
        ComboBox2.Location = New Point(46, 264)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 3
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(46, 327)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(46, 235)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 15)
        Label3.TabIndex = 5
        Label3.Text = "Destination"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(46, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 6
        Label4.Text = "Amount"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"10 000 litres", "15 000 Litres", "20 000 litres", "25 000 litres", "30 000 Litres", "35 000 Litres", "40 000 Litres", "45 000 Litres(max)"})
        ComboBox3.Location = New Point(46, 175)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(121, 23)
        ComboBox3.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(52, 304)
        Label5.Name = "Label5"
        Label5.Size = New Size(125, 15)
        Label5.TabIndex = 8
        Label5.Text = "Expected delivery date"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(81, 407)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 9
        Button1.Text = "Place order"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(304, 408)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 10
        Button2.Text = "Finish"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(ComboBox3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker1)
        Controls.Add(ComboBox2)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
