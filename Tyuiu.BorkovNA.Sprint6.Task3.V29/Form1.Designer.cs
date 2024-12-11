namespace Tyuiu.BorkovNA.Sprint6.Task3.V29
{
    partial class FormMain
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
            groupBoxMain_BNA = new GroupBox();
            groupBoxRes_BNA = new GroupBox();
            GridRes = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            labelRes_BNA = new Label();
            buttonPush = new Button();
            buttonWho_BNA = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            groupBoxMain_BNA.SuspendLayout();
            groupBoxRes_BNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridRes).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMain_BNA
            // 
            groupBoxMain_BNA.Controls.Add(textBox6);
            groupBoxMain_BNA.Controls.Add(textBox5);
            groupBoxMain_BNA.Controls.Add(textBox4);
            groupBoxMain_BNA.Controls.Add(textBox3);
            groupBoxMain_BNA.Controls.Add(textBox2);
            groupBoxMain_BNA.Controls.Add(textBox1);
            groupBoxMain_BNA.Location = new Point(12, 12);
            groupBoxMain_BNA.Name = "groupBoxMain_BNA";
            groupBoxMain_BNA.Size = new Size(776, 249);
            groupBoxMain_BNA.TabIndex = 3;
            groupBoxMain_BNA.TabStop = false;
            groupBoxMain_BNA.Text = "Условие";
            // 
            // groupBoxRes_BNA
            // 
            groupBoxRes_BNA.Controls.Add(GridRes);
            groupBoxRes_BNA.Controls.Add(labelRes_BNA);
            groupBoxRes_BNA.Location = new Point(12, 267);
            groupBoxRes_BNA.Name = "groupBoxRes_BNA";
            groupBoxRes_BNA.Size = new Size(776, 304);
            groupBoxRes_BNA.TabIndex = 5;
            groupBoxRes_BNA.TabStop = false;
            groupBoxRes_BNA.Text = "Вывод";
            // 
            // GridRes
            // 
            GridRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridRes.Columns.AddRange(new DataGridViewColumn[] { X, FX, Column1, Column2, Column3 });
            GridRes.Location = new Point(10, 50);
            GridRes.Name = "GridRes";
            GridRes.RowHeadersWidth = 51;
            GridRes.Size = new Size(688, 240);
            GridRes.TabIndex = 2;
            // 
            // X
            // 
            X.HeaderText = "1";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 125;
            // 
            // FX
            // 
            FX.HeaderText = "2";
            FX.MinimumWidth = 6;
            FX.Name = "FX";
            FX.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "3";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "4";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "5";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // labelRes_BNA
            // 
            labelRes_BNA.AutoSize = true;
            labelRes_BNA.Location = new Point(115, 21);
            labelRes_BNA.Name = "labelRes_BNA";
            labelRes_BNA.Size = new Size(75, 20);
            labelRes_BNA.TabIndex = 1;
            labelRes_BNA.Text = "Результат";
            // 
            // buttonPush
            // 
            buttonPush.Location = new Point(503, 577);
            buttonPush.Name = "buttonPush";
            buttonPush.Size = new Size(157, 77);
            buttonPush.TabIndex = 6;
            buttonPush.Text = "Выполнить";
            buttonPush.UseVisualStyleBackColor = true;
            buttonPush.Click += buttonPush_Click;
            // 
            // buttonWho_BNA
            // 
            buttonWho_BNA.Location = new Point(427, 577);
            buttonWho_BNA.Name = "buttonWho_BNA";
            buttonWho_BNA.Size = new Size(70, 77);
            buttonWho_BNA.TabIndex = 7;
            buttonWho_BNA.Text = "?";
            buttonWho_BNA.UseVisualStyleBackColor = true;
            buttonWho_BNA.Click += buttonWho_BNA_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(466, 52);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в пятом столбце.";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 86);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(133, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "-2 -13 -15  -9 -17";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(10, 112);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(133, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = " 13 -20 -15  27  18";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(10, 136);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(133, 27);
            textBox4.TabIndex = 3;
            textBox4.Text = "-12  -1 -20  13   0";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(10, 158);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(133, 27);
            textBox5.TabIndex = 4;
            textBox5.Text = "15  32  18 -12 -18";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(10, 181);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(133, 27);
            textBox6.TabIndex = 5;
            textBox6.Text = "16   5   3  -5  -8";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 671);
            Controls.Add(buttonWho_BNA);
            Controls.Add(buttonPush);
            Controls.Add(groupBoxRes_BNA);
            Controls.Add(groupBoxMain_BNA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 29 | Борков Н. А.";
            Load += FormMain_Load;
            groupBoxMain_BNA.ResumeLayout(false);
            groupBoxMain_BNA.PerformLayout();
            groupBoxRes_BNA.ResumeLayout(false);
            groupBoxRes_BNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridRes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_BNA;
        private GroupBox groupBoxRes_BNA;
        private DataGridView GridRes;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label labelRes_BNA;
        private Button buttonPush;
        private Button buttonWho_BNA;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}
