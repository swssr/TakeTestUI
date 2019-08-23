namespace MCQFormUI
{
    partial class TestForm
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
            this.ssTest = new System.Windows.Forms.StatusStrip();
            this.tsslCorrect = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIncorrect = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlIntro = new System.Windows.Forms.Panel();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.txtWelcome = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optA = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.optB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.optC = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.optD = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lvwSummary = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAnlysis = new System.Windows.Forms.Label();
            this.ssTest.SuspendLayout();
            this.pnlIntro.SuspendLayout();
            this.pnlQuestion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssTest
            // 
            this.ssTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCorrect,
            this.tsslIncorrect,
            this.tsslPercent});
            this.ssTest.Location = new System.Drawing.Point(0, 402);
            this.ssTest.Name = "ssTest";
            this.ssTest.Size = new System.Drawing.Size(596, 22);
            this.ssTest.TabIndex = 0;
            this.ssTest.Text = "statusStrip1";
            // 
            // tsslCorrect
            // 
            this.tsslCorrect.Name = "tsslCorrect";
            this.tsslCorrect.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslIncorrect
            // 
            this.tsslIncorrect.Name = "tsslIncorrect";
            this.tsslIncorrect.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslPercent
            // 
            this.tsslPercent.Name = "tsslPercent";
            this.tsslPercent.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlIntro
            // 
            this.pnlIntro.Controls.Add(this.btnStart);
            this.pnlIntro.Controls.Add(this.txtWelcome);
            this.pnlIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIntro.Location = new System.Drawing.Point(0, 0);
            this.pnlIntro.Name = "pnlIntro";
            this.pnlIntro.Size = new System.Drawing.Size(596, 424);
            this.pnlIntro.TabIndex = 1;
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.Controls.Add(this.btnSubmit);
            this.pnlQuestion.Controls.Add(this.groupBox1);
            this.pnlQuestion.Controls.Add(this.txtQuestion);
            this.pnlQuestion.Controls.Add(this.lblQuestionNumber);
            this.pnlQuestion.Controls.Add(this.label1);
            this.pnlQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuestion.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(596, 424);
            this.pnlQuestion.TabIndex = 2;
            // 
            // txtWelcome
            // 
            this.txtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.Location = new System.Drawing.Point(12, 12);
            this.txtWelcome.Multiline = true;
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.ReadOnly = true;
            this.txtWelcome.Size = new System.Drawing.Size(570, 172);
            this.txtWelcome.TabIndex = 0;
            this.txtWelcome.TabStop = false;
            this.txtWelcome.Text = "Hi. Welcome to the astronomy Test. Test your knowledge and see if you qualify for" +
    " a role in our starfleet program. Click start now.";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(504, 329);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 60);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question:";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Location = new System.Drawing.Point(88, 12);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(0, 13);
            this.lblQuestionNumber.TabIndex = 1;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(12, 38);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(570, 119);
            this.txtQuestion.TabIndex = 2;
            this.txtQuestion.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.optC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.optB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.optA);
            this.groupBox1.Location = new System.Drawing.Point(12, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 160);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Possible Answers";
            // 
            // optA
            // 
            this.optA.AutoSize = true;
            this.optA.Location = new System.Drawing.Point(64, 27);
            this.optA.Name = "optA";
            this.optA.Size = new System.Drawing.Size(14, 13);
            this.optA.TabIndex = 0;
            this.optA.TabStop = true;
            this.optA.UseVisualStyleBackColor = true;
            this.optA.Click += new System.EventHandler(this.optA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "B";
            // 
            // optB
            // 
            this.optB.AutoSize = true;
            this.optB.Location = new System.Drawing.Point(64, 59);
            this.optB.Name = "optB";
            this.optB.Size = new System.Drawing.Size(14, 13);
            this.optB.TabIndex = 3;
            this.optB.TabStop = true;
            this.optB.UseVisualStyleBackColor = true;
            this.optB.Click += new System.EventHandler(this.optB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "C";
            // 
            // optC
            // 
            this.optC.AutoSize = true;
            this.optC.Location = new System.Drawing.Point(64, 90);
            this.optC.Name = "optC";
            this.optC.Size = new System.Drawing.Size(14, 13);
            this.optC.TabIndex = 5;
            this.optC.TabStop = true;
            this.optC.UseVisualStyleBackColor = true;
            this.optC.Click += new System.EventHandler(this.optC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "D";
            // 
            // optD
            // 
            this.optD.AutoSize = true;
            this.optD.Location = new System.Drawing.Point(64, 120);
            this.optD.Name = "optD";
            this.optD.Size = new System.Drawing.Size(14, 13);
            this.optD.TabIndex = 7;
            this.optD.TabStop = true;
            this.optD.UseVisualStyleBackColor = true;
            this.optD.Click += new System.EventHandler(this.optD_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(504, 331);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 60);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlSummary
            // 
            this.pnlSummary.Controls.Add(this.lblAnlysis);
            this.pnlSummary.Controls.Add(this.label6);
            this.pnlSummary.Controls.Add(this.lvwSummary);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSummary.Location = new System.Drawing.Point(0, 0);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(596, 424);
            this.pnlSummary.TabIndex = 3;
            // 
            // lvwSummary
            // 
            this.lvwSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwSummary.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwSummary.Location = new System.Drawing.Point(0, 0);
            this.lvwSummary.MultiSelect = false;
            this.lvwSummary.Name = "lvwSummary";
            this.lvwSummary.Size = new System.Drawing.Size(596, 323);
            this.lvwSummary.TabIndex = 0;
            this.lvwSummary.UseCompatibleStateImageBehavior = false;
            this.lvwSummary.View = System.Windows.Forms.View.Details;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Qualification Analysis:";
            // 
            // lblAnlysis
            // 
            this.lblAnlysis.AutoSize = true;
            this.lblAnlysis.Location = new System.Drawing.Point(127, 355);
            this.lblAnlysis.Name = "lblAnlysis";
            this.lblAnlysis.Size = new System.Drawing.Size(0, 13);
            this.lblAnlysis.TabIndex = 2;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 424);
            this.Controls.Add(this.ssTest);
            this.Controls.Add(this.pnlIntro);
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.pnlSummary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Choice Test";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ssTest.ResumeLayout(false);
            this.ssTest.PerformLayout();
            this.pnlIntro.ResumeLayout(false);
            this.pnlIntro.PerformLayout();
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssTest;
        private System.Windows.Forms.ToolStripStatusLabel tsslCorrect;
        private System.Windows.Forms.ToolStripStatusLabel tsslIncorrect;
        private System.Windows.Forms.ToolStripStatusLabel tsslPercent;
        private System.Windows.Forms.Panel pnlIntro;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtWelcome;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton optC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton optB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optA;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblAnlysis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvwSummary;
    }
}

