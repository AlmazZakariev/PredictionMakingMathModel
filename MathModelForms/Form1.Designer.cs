
namespace MathModelForms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnRegressionEq = new System.Windows.Forms.Button();
            this.btnCorrelationField = new System.Windows.Forms.Button();
            this.btnPrediction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(26, 33);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(750, 311);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btnRegressionEq
            // 
            this.btnRegressionEq.Location = new System.Drawing.Point(31, 369);
            this.btnRegressionEq.Name = "btnRegressionEq";
            this.btnRegressionEq.Size = new System.Drawing.Size(75, 35);
            this.btnRegressionEq.TabIndex = 1;
            this.btnRegressionEq.Text = "Уравнение регрессии";
            this.btnRegressionEq.UseVisualStyleBackColor = true;
            this.btnRegressionEq.Click += new System.EventHandler(this.btnRegressionEq_Click);
            // 
            // btnCorrelationField
            // 
            this.btnCorrelationField.Location = new System.Drawing.Point(134, 369);
            this.btnCorrelationField.Name = "btnCorrelationField";
            this.btnCorrelationField.Size = new System.Drawing.Size(75, 35);
            this.btnCorrelationField.TabIndex = 2;
            this.btnCorrelationField.Text = "Корреляционное поле";
            this.btnCorrelationField.UseVisualStyleBackColor = true;
            this.btnCorrelationField.Click += new System.EventHandler(this.btnCorrelationField_Click);
            // 
            // btnPrediction
            // 
            this.btnPrediction.Location = new System.Drawing.Point(235, 369);
            this.btnPrediction.Name = "btnPrediction";
            this.btnPrediction.Size = new System.Drawing.Size(75, 35);
            this.btnPrediction.TabIndex = 3;
            this.btnPrediction.Text = "Прогноз";
            this.btnPrediction.UseVisualStyleBackColor = true;
            this.btnPrediction.Click += new System.EventHandler(this.btnPrediction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Уравнение регрессии:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Коэффициент коррелияции Пирсона:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Коэффициент детерминации:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrediction);
            this.Controls.Add(this.btnCorrelationField);
            this.Controls.Add(this.btnRegressionEq);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Прогноз развития covid-19 в Великобритании";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnRegressionEq;
        private System.Windows.Forms.Button btnCorrelationField;
        private System.Windows.Forms.Button btnPrediction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

