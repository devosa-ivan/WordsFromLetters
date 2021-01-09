namespace WordsFromLetters
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_actual = new System.Windows.Forms.Label();
            this.label_plus = new System.Windows.Forms.Label();
            this.label_minus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_timer = new System.Windows.Forms.ToolStripMenuItem();
            this.button_select_word = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox_display_text = new System.Windows.Forms.RichTextBox();
            this.súgóHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_actual
            // 
            this.label_actual.AutoSize = true;
            this.label_actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_actual.Location = new System.Drawing.Point(280, 24);
            this.label_actual.Name = "label_actual";
            this.label_actual.Size = new System.Drawing.Size(212, 226);
            this.label_actual.TabIndex = 0;
            this.label_actual.Text = "+";
            // 
            // label_plus
            // 
            this.label_plus.AutoSize = true;
            this.label_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_plus.Location = new System.Drawing.Point(638, 96);
            this.label_plus.Name = "label_plus";
            this.label_plus.Size = new System.Drawing.Size(100, 107);
            this.label_plus.TabIndex = 1;
            this.label_plus.Text = "+";
            // 
            // label_minus
            // 
            this.label_minus.AutoSize = true;
            this.label_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_minus.Location = new System.Drawing.Point(56, 96);
            this.label_minus.Name = "label_minus";
            this.label_minus.Size = new System.Drawing.Size(100, 107);
            this.label_minus.TabIndex = 2;
            this.label_minus.Text = "+";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_timer,
            this.súgóHelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem_timer
            // 
            this.toolStripMenuItem_timer.Name = "toolStripMenuItem_timer";
            this.toolStripMenuItem_timer.Size = new System.Drawing.Size(161, 20);
            this.toolStripMenuItem_timer.Text = "Időzítő be/ki | Timer on/off";
            this.toolStripMenuItem_timer.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // button_select_word
            // 
            this.button_select_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_select_word.Location = new System.Drawing.Point(210, 256);
            this.button_select_word.Name = "button_select_word";
            this.button_select_word.Size = new System.Drawing.Size(370, 79);
            this.button_select_word.TabIndex = 5;
            this.button_select_word.Text = "+";
            this.button_select_word.UseVisualStyleBackColor = true;
            this.button_select_word.Click += new System.EventHandler(this.Button_select_word_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_minus.Location = new System.Drawing.Point(44, 256);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(112, 79);
            this.button_minus.TabIndex = 6;
            this.button_minus.Text = "<";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.Button_minus_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_plus.Location = new System.Drawing.Point(628, 256);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(110, 79);
            this.button_plus.TabIndex = 7;
            this.button_plus.Text = ">";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.Button_plus_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(789, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel1.Text = "0";
            this.toolStripStatusLabel1.ToolTipText = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel2.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel3.Text = "0";
            // 
            // richTextBox_display_text
            // 
            this.richTextBox_display_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox_display_text.Location = new System.Drawing.Point(42, 354);
            this.richTextBox_display_text.Name = "richTextBox_display_text";
            this.richTextBox_display_text.ReadOnly = true;
            this.richTextBox_display_text.Size = new System.Drawing.Size(696, 153);
            this.richTextBox_display_text.TabIndex = 9;
            this.richTextBox_display_text.Text = "";
            // 
            // súgóHelpToolStripMenuItem
            // 
            this.súgóHelpToolStripMenuItem.Name = "súgóHelpToolStripMenuItem";
            this.súgóHelpToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.súgóHelpToolStripMenuItem.Text = "Súgó | Help";
            this.súgóHelpToolStripMenuItem.Click += new System.EventHandler(this.SúgóHelpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 556);
            this.Controls.Add(this.richTextBox_display_text);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_select_word);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label_minus);
            this.Controls.Add(this.label_plus);
            this.Controls.Add(this.label_actual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WFL 1.0 - Words From Letters -  ©2019, Dr. Devosa Iván";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_actual;
        private System.Windows.Forms.Label label_plus;
        private System.Windows.Forms.Label label_minus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_timer;
        private System.Windows.Forms.Button button_select_word;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.RichTextBox richTextBox_display_text;
        private System.Windows.Forms.ToolStripMenuItem súgóHelpToolStripMenuItem;
    }
}

