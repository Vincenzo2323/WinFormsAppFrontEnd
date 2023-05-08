namespace WinFormsAppFrontEnd
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.decimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.octalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexadecimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oV10canterburyacukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Binary = new System.Windows.Forms.TabControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Binary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(591, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calculating Conversions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(760, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = ">";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = ">";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decimalToolStripMenuItem,
            this.binaryToolStripMenuItem,
            this.octalToolStripMenuItem,
            this.aSCIIToolStripMenuItem,
            this.hexadecimalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1816, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // decimalToolStripMenuItem
            // 
            this.decimalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.decimalToolStripMenuItem.Name = "decimalToolStripMenuItem";
            this.decimalToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.decimalToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.binaryToolStripMenuItem.Text = "Edit";
            // 
            // octalToolStripMenuItem
            // 
            this.octalToolStripMenuItem.Name = "octalToolStripMenuItem";
            this.octalToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.octalToolStripMenuItem.Text = "View";
            // 
            // aSCIIToolStripMenuItem
            // 
            this.aSCIIToolStripMenuItem.Name = "aSCIIToolStripMenuItem";
            this.aSCIIToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aSCIIToolStripMenuItem.Text = "Tools ";
            // 
            // hexadecimalToolStripMenuItem
            // 
            this.hexadecimalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactDeveloperToolStripMenuItem});
            this.hexadecimalToolStripMenuItem.Name = "hexadecimalToolStripMenuItem";
            this.hexadecimalToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.hexadecimalToolStripMenuItem.Text = "Help";
            // 
            // contactDeveloperToolStripMenuItem
            // 
            this.contactDeveloperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oV10canterburyacukToolStripMenuItem});
            this.contactDeveloperToolStripMenuItem.Name = "contactDeveloperToolStripMenuItem";
            this.contactDeveloperToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.contactDeveloperToolStripMenuItem.Text = "Contact Developer";
            // 
            // oV10canterburyacukToolStripMenuItem
            // 
            this.oV10canterburyacukToolStripMenuItem.Name = "oV10canterburyacukToolStripMenuItem";
            this.oV10canterburyacukToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.oV10canterburyacukToolStripMenuItem.Text = "OV10@canterbury.ac.uk";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Need Help?";
            this.helpProvider1.Tag = "If you require further require further, please email the support devloper- OV10@c" +
    "anterbury.ac.uk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(819, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Text ";
            // 
            // tabControl2
            // 
            this.tabControl2.AccessibleDescription = "Binary";
            this.tabControl2.AccessibleName = "Binary";
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(12, 98);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(604, 340);
            this.tabControl2.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox10);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.textBox8);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(596, 307);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(73, 259);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 29);
            this.button5.TabIndex = 22;
            this.button5.Text = "Octal";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(355, 95);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(185, 27);
            this.textBox5.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(355, 261);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 27);
            this.textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(355, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 27);
            this.textBox3.TabIndex = 19;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(355, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 27);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 27);
            this.textBox1.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(366, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Input";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(342, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = " ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(73, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 29);
            this.button4.TabIndex = 12;
            this.button4.Text = "ASCII";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(73, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 29);
            this.button3.TabIndex = 11;
            this.button3.Text = "Hexadecimal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "Decimal ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Binary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Hexadecimal ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Octal";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Decimal ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Binary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ASCII";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(509, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "Output";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "label17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(129, 269);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(129, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "label15";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(129, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(120, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "label12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // Binary
            // 
            this.Binary.Controls.Add(this.tabPage1);
            this.Binary.Location = new System.Drawing.Point(819, 116);
            this.Binary.Name = "Binary";
            this.Binary.SelectedIndex = 0;
            this.Binary.Size = new System.Drawing.Size(758, 340);
            this.Binary.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(204, 42);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 27);
            this.textBox6.TabIndex = 23;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(204, 95);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(125, 27);
            this.textBox7.TabIndex = 24;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(204, 151);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(125, 27);
            this.textBox8.TabIndex = 25;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(204, 207);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(125, 27);
            this.textBox9.TabIndex = 26;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(204, 261);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(125, 27);
            this.textBox10.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1816, 609);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.Binary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Binary to Decimal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Binary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem decimalToolStripMenuItem;
        private ToolStripMenuItem octalToolStripMenuItem;
        private ToolStripMenuItem hexadecimalToolStripMenuItem;
        private ToolStripMenuItem aSCIIToolStripMenuItem;
        private ToolStripMenuItem binaryToolStripMenuItem;
        private HelpProvider helpProvider1;
        private Label label3;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem contactDeveloperToolStripMenuItem;
        private ToolStripMenuItem oV10canterburyacukToolStripMenuItem;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabControl Binary;
        private TabPage tabPage3;
        private Button button5;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label14;
        private Label label11;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label16;
        private Label label15;
        private Label label13;
        private Label label12;
        private Label label5;
        private Label label18;
        private Label label17;
        private ErrorProvider errorProvider1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
    }
}