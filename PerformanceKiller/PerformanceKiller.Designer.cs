namespace PerformanceKiller
{
    partial class PerformanceKiller
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
            this.label_Info = new System.Windows.Forms.Label();
            this.numericUpDown_Cores = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Occupy = new System.Windows.Forms.Button();
            this.button_Free = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_CPU_Frequency = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_FreeAllMemory = new System.Windows.Forms.Button();
            this.button_free500 = new System.Windows.Forms.Button();
            this.button_add500 = new System.Windows.Forms.Button();
            this.label_memory = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Location = new System.Drawing.Point(8, 25);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(50, 13);
            this.label_Info.TabIndex = 9;
            this.label_Info.Text = "CPU Info";
            // 
            // numericUpDown_Cores
            // 
            this.numericUpDown_Cores.Location = new System.Drawing.Point(23, 103);
            this.numericUpDown_Cores.Name = "numericUpDown_Cores";
            this.numericUpDown_Cores.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown_Cores.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "CPU(s)";
            // 
            // button_Occupy
            // 
            this.button_Occupy.Location = new System.Drawing.Point(92, 91);
            this.button_Occupy.Name = "button_Occupy";
            this.button_Occupy.Size = new System.Drawing.Size(59, 23);
            this.button_Occupy.TabIndex = 12;
            this.button_Occupy.Text = "Occupy";
            this.button_Occupy.UseVisualStyleBackColor = true;
            this.button_Occupy.Click += new System.EventHandler(this.button_Occupy_Click);
            // 
            // button_Free
            // 
            this.button_Free.Location = new System.Drawing.Point(184, 100);
            this.button_Free.Name = "button_Free";
            this.button_Free.Size = new System.Drawing.Size(59, 23);
            this.button_Free.TabIndex = 13;
            this.button_Free.Text = "Free All";
            this.button_Free.UseVisualStyleBackColor = true;
            this.button_Free.Click += new System.EventHandler(this.button_Free_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_CPU_Frequency);
            this.groupBox1.Controls.Add(this.label_Info);
            this.groupBox1.Controls.Add(this.button_Occupy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 128);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU Killer";
            // 
            // label_CPU_Frequency
            // 
            this.label_CPU_Frequency.AutoSize = true;
            this.label_CPU_Frequency.Location = new System.Drawing.Point(8, 47);
            this.label_CPU_Frequency.Name = "label_CPU_Frequency";
            this.label_CPU_Frequency.Size = new System.Drawing.Size(82, 13);
            this.label_CPU_Frequency.TabIndex = 13;
            this.label_CPU_Frequency.Text = "CPU Frequency";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_FreeAllMemory);
            this.groupBox2.Controls.Add(this.button_free500);
            this.groupBox2.Controls.Add(this.button_add500);
            this.groupBox2.Controls.Add(this.label_memory);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Memory Killer";
            // 
            // button_FreeAllMemory
            // 
            this.button_FreeAllMemory.Location = new System.Drawing.Point(172, 62);
            this.button_FreeAllMemory.Name = "button_FreeAllMemory";
            this.button_FreeAllMemory.Size = new System.Drawing.Size(59, 23);
            this.button_FreeAllMemory.TabIndex = 3;
            this.button_FreeAllMemory.Text = "Free All";
            this.button_FreeAllMemory.UseVisualStyleBackColor = true;
            this.button_FreeAllMemory.Click += new System.EventHandler(this.button_FreeAllMemory_Click);
            // 
            // button_free500
            // 
            this.button_free500.Location = new System.Drawing.Point(92, 62);
            this.button_free500.Name = "button_free500";
            this.button_free500.Size = new System.Drawing.Size(59, 23);
            this.button_free500.TabIndex = 2;
            this.button_free500.Text = "-500";
            this.button_free500.UseVisualStyleBackColor = true;
            this.button_free500.Click += new System.EventHandler(this.button_free500_Click);
            // 
            // button_add500
            // 
            this.button_add500.Location = new System.Drawing.Point(11, 62);
            this.button_add500.Name = "button_add500";
            this.button_add500.Size = new System.Drawing.Size(59, 23);
            this.button_add500.TabIndex = 1;
            this.button_add500.Text = "+500M";
            this.button_add500.UseVisualStyleBackColor = true;
            this.button_add500.Click += new System.EventHandler(this.button_add500_Click);
            // 
            // label_memory
            // 
            this.label_memory.AutoSize = true;
            this.label_memory.Location = new System.Drawing.Point(8, 26);
            this.label_memory.Name = "label_memory";
            this.label_memory.Size = new System.Drawing.Size(65, 13);
            this.label_memory.TabIndex = 0;
            this.label_memory.Text = "Memory Info";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // PerformanceKiller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 255);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Free);
            this.Controls.Add(this.numericUpDown_Cores);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PerformanceKiller";
            this.Text = "PerformanceKiller";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.NumericUpDown numericUpDown_Cores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Occupy;
        private System.Windows.Forms.Button button_Free;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_memory;
        private System.Windows.Forms.Button button_free500;
        private System.Windows.Forms.Button button_add500;
        private System.Windows.Forms.Button button_FreeAllMemory;
        private System.Windows.Forms.Label label_CPU_Frequency;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

