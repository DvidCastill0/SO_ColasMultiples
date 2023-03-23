
namespace SOporLotes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gv_Waiting = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ProcessName = new System.Windows.Forms.TextBox();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddProcess = new System.Windows.Forms.Button();
            this.gv_Finally = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_InProgressProcess = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_TimeInProgress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ProcessTime = new System.Windows.Forms.NumericUpDown();
            this.tb_Llegada = new System.Windows.Forms.NumericUpDown();
            this.btn_RR = new System.Windows.Forms.Button();
            this.btn_FCFS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Quantum = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Priority = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Waiting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Finally)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ProcessTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Llegada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Quantum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Priority)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Waiting
            // 
            this.gv_Waiting.AllowUserToAddRows = false;
            this.gv_Waiting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Waiting.Location = new System.Drawing.Point(11, 156);
            this.gv_Waiting.Name = "gv_Waiting";
            this.gv_Waiting.RowHeadersVisible = false;
            this.gv_Waiting.Size = new System.Drawing.Size(343, 150);
            this.gv_Waiting.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Proceso:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ProcessName
            // 
            this.tb_ProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ProcessName.Location = new System.Drawing.Point(213, 12);
            this.tb_ProcessName.Name = "tb_ProcessName";
            this.tb_ProcessName.Size = new System.Drawing.Size(433, 30);
            this.tb_ProcessName.TabIndex = 2;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.Location = new System.Drawing.Point(532, 64);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(84, 25);
            this.lbl_Time.TabIndex = 3;
            this.lbl_Time.Text = "Tiempo:";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cola de Procesos (En Espera)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_AddProcess
            // 
            this.btn_AddProcess.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_AddProcess.Location = new System.Drawing.Point(667, 12);
            this.btn_AddProcess.Name = "btn_AddProcess";
            this.btn_AddProcess.Size = new System.Drawing.Size(108, 33);
            this.btn_AddProcess.TabIndex = 6;
            this.btn_AddProcess.Text = "Crear Proceso";
            this.btn_AddProcess.UseVisualStyleBackColor = false;
            this.btn_AddProcess.Click += new System.EventHandler(this.btn_AddProcess_Click);
            // 
            // gv_Finally
            // 
            this.gv_Finally.AllowUserToAddRows = false;
            this.gv_Finally.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Finally.Location = new System.Drawing.Point(418, 156);
            this.gv_Finally.Name = "gv_Finally";
            this.gv_Finally.RowHeadersVisible = false;
            this.gv_Finally.Size = new System.Drawing.Size(343, 150);
            this.gv_Finally.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cola de Procesos (Finalizados)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 357);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(750, 30);
            this.progressBar1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proceso en progreso:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_InProgressProcess
            // 
            this.lbl_InProgressProcess.AutoSize = true;
            this.lbl_InProgressProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InProgressProcess.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_InProgressProcess.Location = new System.Drawing.Point(374, 329);
            this.lbl_InProgressProcess.Name = "lbl_InProgressProcess";
            this.lbl_InProgressProcess.Size = new System.Drawing.Size(33, 25);
            this.lbl_InProgressProcess.TabIndex = 11;
            this.lbl_InProgressProcess.Text = "---";
            this.lbl_InProgressProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tiempo Transcurrido:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TimeInProgress
            // 
            this.lbl_TimeInProgress.AutoSize = true;
            this.lbl_TimeInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TimeInProgress.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_TimeInProgress.Location = new System.Drawing.Point(230, 439);
            this.lbl_TimeInProgress.Name = "lbl_TimeInProgress";
            this.lbl_TimeInProgress.Size = new System.Drawing.Size(45, 25);
            this.lbl_TimeInProgress.TabIndex = 13;
            this.lbl_TimeInProgress.Text = "000";
            this.lbl_TimeInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(281, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "seg.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ProcessTime
            // 
            this.tb_ProcessTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ProcessTime.Location = new System.Drawing.Point(622, 62);
            this.tb_ProcessTime.Name = "tb_ProcessTime";
            this.tb_ProcessTime.Size = new System.Drawing.Size(72, 30);
            this.tb_ProcessTime.TabIndex = 16;
            // 
            // tb_Llegada
            // 
            this.tb_Llegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Llegada.Location = new System.Drawing.Point(428, 62);
            this.tb_Llegada.Name = "tb_Llegada";
            this.tb_Llegada.Size = new System.Drawing.Size(71, 30);
            this.tb_Llegada.TabIndex = 20;
            // 
            // btn_RR
            // 
            this.btn_RR.Location = new System.Drawing.Point(417, 393);
            this.btn_RR.Name = "btn_RR";
            this.btn_RR.Size = new System.Drawing.Size(94, 23);
            this.btn_RR.TabIndex = 21;
            this.btn_RR.Text = "Colas Multiples";
            this.btn_RR.UseVisualStyleBackColor = true;
            this.btn_RR.Click += new System.EventHandler(this.btn_RR_Click);
            // 
            // btn_FCFS
            // 
            this.btn_FCFS.Location = new System.Drawing.Point(260, 393);
            this.btn_FCFS.Name = "btn_FCFS";
            this.btn_FCFS.Size = new System.Drawing.Size(94, 23);
            this.btn_FCFS.TabIndex = 22;
            this.btn_FCFS.Text = "Prioridades";
            this.btn_FCFS.UseVisualStyleBackColor = true;
            this.btn_FCFS.Click += new System.EventHandler(this.btn_FCFS_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 735);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "FCFS";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_Quantum
            // 
            this.tb_Quantum.Enabled = false;
            this.tb_Quantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantum.Location = new System.Drawing.Point(684, 437);
            this.tb_Quantum.Name = "tb_Quantum";
            this.tb_Quantum.Size = new System.Drawing.Size(72, 30);
            this.tb_Quantum.TabIndex = 24;
            this.tb_Quantum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(579, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantum:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Priority
            // 
            this.tb_Priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Priority.Location = new System.Drawing.Point(204, 60);
            this.tb_Priority.Name = "tb_Priority";
            this.tb_Priority.Size = new System.Drawing.Size(72, 30);
            this.tb_Priority.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Prioridad:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Llegada:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Priority);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Quantum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_FCFS);
            this.Controls.Add(this.btn_RR);
            this.Controls.Add(this.tb_Llegada);
            this.Controls.Add(this.tb_ProcessTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_TimeInProgress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_InProgressProcess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gv_Finally);
            this.Controls.Add(this.btn_AddProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.tb_ProcessName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gv_Waiting);
            this.Name = "Form1";
            this.Text = "Administrador de Procesos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Waiting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Finally)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ProcessTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Llegada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Quantum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Priority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Waiting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ProcessName;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddProcess;
        private System.Windows.Forms.DataGridView gv_Finally;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_InProgressProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_TimeInProgress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown tb_ProcessTime;
        private System.Windows.Forms.NumericUpDown tb_Llegada;
        private System.Windows.Forms.Button btn_RR;
        private System.Windows.Forms.Button btn_FCFS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown tb_Quantum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown tb_Priority;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}

