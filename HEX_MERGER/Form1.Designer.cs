namespace HEX_MERGER
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
            this.btnBrowesFile1 = new System.Windows.Forms.Button();
            this.txtFile1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMainFile = new System.Windows.Forms.TextBox();
            this.btnMainFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowBottloader = new System.Windows.Forms.Button();
            this.btnShowMain = new System.Windows.Forms.Button();
            this.lblSizeMain = new System.Windows.Forms.Label();
            this.lblSizeBootloader = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowOutput = new System.Windows.Forms.Button();
            this.lblSizeOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMerge = new System.Windows.Forms.Button();
            this.hexBox = new Be.Windows.Forms.HexBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowesFile1
            // 
            this.btnBrowesFile1.Location = new System.Drawing.Point(219, 18);
            this.btnBrowesFile1.Name = "btnBrowesFile1";
            this.btnBrowesFile1.Size = new System.Drawing.Size(52, 21);
            this.btnBrowesFile1.TabIndex = 0;
            this.btnBrowesFile1.Text = "Browes";
            this.btnBrowesFile1.UseVisualStyleBackColor = true;
            this.btnBrowesFile1.Click += new System.EventHandler(this.btnBrowesFile1_Click);
            // 
            // txtFile1
            // 
            this.txtFile1.Location = new System.Drawing.Point(54, 18);
            this.txtFile1.Name = "txtFile1";
            this.txtFile1.Size = new System.Drawing.Size(159, 20);
            this.txtFile1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "File 2:";
            // 
            // txtMainFile
            // 
            this.txtMainFile.Location = new System.Drawing.Point(54, 64);
            this.txtMainFile.Name = "txtMainFile";
            this.txtMainFile.Size = new System.Drawing.Size(159, 20);
            this.txtMainFile.TabIndex = 4;
            // 
            // btnMainFile
            // 
            this.btnMainFile.Location = new System.Drawing.Point(219, 64);
            this.btnMainFile.Name = "btnMainFile";
            this.btnMainFile.Size = new System.Drawing.Size(52, 21);
            this.btnMainFile.TabIndex = 3;
            this.btnMainFile.Text = "Browes";
            this.btnMainFile.UseVisualStyleBackColor = true;
            this.btnMainFile.Click += new System.EventHandler(this.btnMainFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowBottloader);
            this.groupBox1.Controls.Add(this.btnShowMain);
            this.groupBox1.Controls.Add(this.lblSizeMain);
            this.groupBox1.Controls.Add(this.lblSizeBootloader);
            this.groupBox1.Controls.Add(this.txtFile1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBrowesFile1);
            this.groupBox1.Controls.Add(this.txtMainFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnMainFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 109);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // btnShowBottloader
            // 
            this.btnShowBottloader.Location = new System.Drawing.Point(277, 18);
            this.btnShowBottloader.Name = "btnShowBottloader";
            this.btnShowBottloader.Size = new System.Drawing.Size(28, 37);
            this.btnShowBottloader.TabIndex = 9;
            this.btnShowBottloader.Text = ">";
            this.btnShowBottloader.UseVisualStyleBackColor = true;
            this.btnShowBottloader.Click += new System.EventHandler(this.btnShowBottloader_Click);
            // 
            // btnShowMain
            // 
            this.btnShowMain.Location = new System.Drawing.Point(277, 64);
            this.btnShowMain.Name = "btnShowMain";
            this.btnShowMain.Size = new System.Drawing.Size(28, 37);
            this.btnShowMain.TabIndex = 8;
            this.btnShowMain.Text = ">";
            this.btnShowMain.UseVisualStyleBackColor = true;
            this.btnShowMain.Click += new System.EventHandler(this.btnShowMain_Click);
            // 
            // lblSizeMain
            // 
            this.lblSizeMain.AutoSize = true;
            this.lblSizeMain.Location = new System.Drawing.Point(57, 87);
            this.lblSizeMain.Name = "lblSizeMain";
            this.lblSizeMain.Size = new System.Drawing.Size(46, 13);
            this.lblSizeMain.TabIndex = 7;
            this.lblSizeMain.Text = "             ";
            // 
            // lblSizeBootloader
            // 
            this.lblSizeBootloader.AutoSize = true;
            this.lblSizeBootloader.Location = new System.Drawing.Point(57, 41);
            this.lblSizeBootloader.Name = "lblSizeBootloader";
            this.lblSizeBootloader.Size = new System.Drawing.Size(46, 13);
            this.lblSizeBootloader.TabIndex = 6;
            this.lblSizeBootloader.Text = "             ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowOutput);
            this.groupBox2.Controls.Add(this.lblSizeOutput);
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Controls.Add(this.btnOutput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 71);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // btnShowOutput
            // 
            this.btnShowOutput.Location = new System.Drawing.Point(277, 19);
            this.btnShowOutput.Name = "btnShowOutput";
            this.btnShowOutput.Size = new System.Drawing.Size(28, 37);
            this.btnShowOutput.TabIndex = 9;
            this.btnShowOutput.Text = ">";
            this.btnShowOutput.UseVisualStyleBackColor = true;
            this.btnShowOutput.Click += new System.EventHandler(this.btnShowOutput_Click);
            // 
            // lblSizeOutput
            // 
            this.lblSizeOutput.AutoSize = true;
            this.lblSizeOutput.Location = new System.Drawing.Point(57, 42);
            this.lblSizeOutput.Name = "lblSizeOutput";
            this.lblSizeOutput.Size = new System.Drawing.Size(46, 13);
            this.lblSizeOutput.TabIndex = 8;
            this.lblSizeOutput.Text = "             ";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(54, 19);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(159, 20);
            this.txtOutput.TabIndex = 1;
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(219, 19);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(52, 21);
            this.btnOutput.TabIndex = 0;
            this.btnOutput.Text = "Browes";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "File:";
            // 
            // btnMerge
            // 
            this.btnMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.Image = global::HEX_MERGER.Properties.Resources._001_combine_data;
            this.btnMerge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMerge.Location = new System.Drawing.Point(12, 222);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(139, 48);
            this.btnMerge.TabIndex = 8;
            this.btnMerge.Text = "Merge   ";
            this.btnMerge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // hexBox
            // 
            this.hexBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBox.LineInfoVisible = true;
            this.hexBox.Location = new System.Drawing.Point(329, 12);
            this.hexBox.Name = "hexBox";
            this.hexBox.ReadOnly = true;
            this.hexBox.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexBox.Size = new System.Drawing.Size(393, 305);
            this.hexBox.StringViewVisible = true;
            this.hexBox.TabIndex = 9;
            this.hexBox.VScrollBarVisible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 329);
            this.Controls.Add(this.hexBox);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Hex Merger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowesFile1;
        private System.Windows.Forms.TextBox txtFile1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMainFile;
        private System.Windows.Forms.Button btnMainFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Label lblSizeMain;
        private System.Windows.Forms.Label lblSizeBootloader;
        private System.Windows.Forms.Label lblSizeOutput;
        private System.Windows.Forms.Button btnShowBottloader;
        private System.Windows.Forms.Button btnShowMain;
        private System.Windows.Forms.Button btnShowOutput;
        private Be.Windows.Forms.HexBox hexBox;
    }
}

