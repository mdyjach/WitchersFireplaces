namespace WitchersFireplaces
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            changeLanguageToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            polishToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            buttonDoor = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(125, 251);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 174);
            button2.Name = "button2";
            button2.Size = new Size(23, 75);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 71);
            button3.Name = "button3";
            button3.Size = new Size(23, 75);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(44, 27);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(206, 27);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(284, 71);
            button6.Name = "button6";
            button6.Size = new Size(23, 75);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(284, 174);
            button7.Name = "button7";
            button7.Size = new Size(23, 75);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(319, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeLanguageToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = Resource.FileMenu;
            // 
            // changeLanguageToolStripMenuItem
            // 
            changeLanguageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishToolStripMenuItem, polishToolStripMenuItem });
            changeLanguageToolStripMenuItem.Name = "changeLanguageToolStripMenuItem";
            changeLanguageToolStripMenuItem.Size = new Size(167, 22);
            changeLanguageToolStripMenuItem.Text = Resource.ChangeLanguage;
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(112, 22);
            englishToolStripMenuItem.Text = Resource.English;
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // polishToolStripMenuItem
            // 
            polishToolStripMenuItem.Name = "polishToolStripMenuItem";
            polishToolStripMenuItem.Size = new Size(112, 22);
            polishToolStripMenuItem.Text = Resource.Polish;
            polishToolStripMenuItem.Click += polishToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(167, 22);
            exitToolStripMenuItem.Text = Resource.Exit;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = Resource.HelpMenu;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = Resource.About;
            aboutToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // buttonDoor
            // 
            buttonDoor.BackColor = Color.Black;
            buttonDoor.Enabled = false;
            buttonDoor.ForeColor = Color.White;
            buttonDoor.Location = new Point(125, 27);
            buttonDoor.Name = "buttonDoor";
            buttonDoor.Size = new Size(75, 23);
            //buttonDoor.TabIndex = 8;
            buttonDoor.Text = Resource.Closed;
            //buttonDoor.UseVisualStyleBackColor = false;
            buttonDoor.Click += buttonDoor_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(319, 286);
            Controls.Add(buttonDoor);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            HelpButton = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(335, 350);
            MinimumSize = new Size(335, 325);
            Name = "MainForm";
            Text = Resource.WitchersFireplaces;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button buttonDoor;
        private ToolStripMenuItem changeLanguageToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem polishToolStripMenuItem;
    }
}