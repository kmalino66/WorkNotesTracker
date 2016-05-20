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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.button_clear = New System.Windows.Forms.Button()
        Me.button_copy = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.comboBox_templates = New System.Windows.Forms.ToolStripComboBox()
        Me.menuItem_loadTemplate = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItem_delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.stripMenu_newTemplate = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(12, 30)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(868, 430)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "~"
        '
        'button_clear
        '
        Me.button_clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_clear.Location = New System.Drawing.Point(805, 463)
        Me.button_clear.Name = "button_clear"
        Me.button_clear.Size = New System.Drawing.Size(75, 23)
        Me.button_clear.TabIndex = 1
        Me.button_clear.Text = "Clear"
        Me.button_clear.UseVisualStyleBackColor = True
        '
        'button_copy
        '
        Me.button_copy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_copy.Location = New System.Drawing.Point(724, 463)
        Me.button_copy.Name = "button_copy"
        Me.button_copy.Size = New System.Drawing.Size(75, 23)
        Me.button_copy.TabIndex = 2
        Me.button_copy.Text = "Copy"
        Me.button_copy.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.comboBox_templates, Me.menuItem_loadTemplate, Me.menuItem_delete, Me.stripMenu_newTemplate})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(892, 27)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(71, 23)
        Me.ToolStripMenuItem1.Text = "Template:"
        '
        'comboBox_templates
        '
        Me.comboBox_templates.Name = "comboBox_templates"
        Me.comboBox_templates.Size = New System.Drawing.Size(121, 23)
        '
        'menuItem_loadTemplate
        '
        Me.menuItem_loadTemplate.Name = "menuItem_loadTemplate"
        Me.menuItem_loadTemplate.Size = New System.Drawing.Size(97, 23)
        Me.menuItem_loadTemplate.Text = "Load Template"
        '
        'menuItem_delete
        '
        Me.menuItem_delete.Name = "menuItem_delete"
        Me.menuItem_delete.Size = New System.Drawing.Size(104, 23)
        Me.menuItem_delete.Text = "Delete Template"
        '
        'stripMenu_newTemplate
        '
        Me.stripMenu_newTemplate.Name = "stripMenu_newTemplate"
        Me.stripMenu_newTemplate.Size = New System.Drawing.Size(122, 23)
        Me.stripMenu_newTemplate.Text = "Save New Template"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 473)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Made by Kyle Malinowski"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 498)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.button_copy)
        Me.Controls.Add(Me.button_clear)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Work Notes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents button_clear As Button
    Friend WithEvents button_copy As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents comboBox_templates As ToolStripComboBox
    Friend WithEvents stripMenu_newTemplate As ToolStripMenuItem
    Friend WithEvents menuItem_loadTemplate As ToolStripMenuItem
    Friend WithEvents menuItem_delete As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
