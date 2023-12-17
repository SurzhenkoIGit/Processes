
namespace AsyncMath
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_int1 = new System.Windows.Forms.TextBox();
            this.txb_int2 = new System.Windows.Forms.TextBox();
            this.cmb_operator = new System.Windows.Forms.ComboBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.lb_CurTasks = new System.Windows.Forms.ListBox();
            this.lb_Results = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_int1
            // 
            this.txb_int1.Location = new System.Drawing.Point(49, 37);
            this.txb_int1.Name = "txb_int1";
            this.txb_int1.Size = new System.Drawing.Size(100, 20);
            this.txb_int1.TabIndex = 0;
            // 
            // txb_int2
            // 
            this.txb_int2.Location = new System.Drawing.Point(266, 37);
            this.txb_int2.Name = "txb_int2";
            this.txb_int2.Size = new System.Drawing.Size(100, 20);
            this.txb_int2.TabIndex = 1;
            // 
            // cmb_operator
            // 
            this.cmb_operator.FormattingEnabled = true;
            this.cmb_operator.Location = new System.Drawing.Point(185, 36);
            this.cmb_operator.Name = "cmb_operator";
            this.cmb_operator.Size = new System.Drawing.Size(44, 21);
            this.cmb_operator.TabIndex = 2;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(169, 87);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 3;
            this.btn_run.Text = "Запуск";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // lb_CurTasks
            // 
            this.lb_CurTasks.FormattingEnabled = true;
            this.lb_CurTasks.Location = new System.Drawing.Point(443, 87);
            this.lb_CurTasks.Name = "lb_CurTasks";
            this.lb_CurTasks.Size = new System.Drawing.Size(120, 316);
            this.lb_CurTasks.TabIndex = 4;
            // 
            // lb_Results
            // 
            this.lb_Results.FormattingEnabled = true;
            this.lb_Results.Location = new System.Drawing.Point(646, 87);
            this.lb_Results.Name = "lb_Results";
            this.lb_Results.Size = new System.Drawing.Size(120, 316);
            this.lb_Results.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Текущие задачи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Результаты";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Results);
            this.Controls.Add(this.lb_CurTasks);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.cmb_operator);
            this.Controls.Add(this.txb_int2);
            this.Controls.Add(this.txb_int1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_int1;
        private System.Windows.Forms.TextBox txb_int2;
        private System.Windows.Forms.ComboBox cmb_operator;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.ListBox lb_CurTasks;
        private System.Windows.Forms.ListBox lb_Results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

