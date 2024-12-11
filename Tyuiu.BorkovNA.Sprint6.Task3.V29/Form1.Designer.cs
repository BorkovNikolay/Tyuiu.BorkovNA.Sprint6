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
            pictureBoxCondit = new PictureBox();
            groupBoxRes_BNA = new GroupBox();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            labelRes_BNA = new Label();
            buttonPush = new Button();
            buttonWho_BNA = new Button();
            groupBoxMain_BNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondit).BeginInit();
            groupBoxRes_BNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMain_BNA
            // 
            groupBoxMain_BNA.Controls.Add(pictureBoxCondit);
            groupBoxMain_BNA.Location = new Point(12, 12);
            groupBoxMain_BNA.Name = "groupBoxMain_BNA";
            groupBoxMain_BNA.Size = new Size(776, 249);
            groupBoxMain_BNA.TabIndex = 3;
            groupBoxMain_BNA.TabStop = false;
            groupBoxMain_BNA.Text = "Условие";
            // 
            // pictureBoxCondit
            // 
            pictureBoxCondit.Location = new Point(59, 26);
            pictureBoxCondit.Name = "pictureBoxCondit";
            pictureBoxCondit.Size = new Size(639, 218);
            pictureBoxCondit.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxCondit.TabIndex = 0;
            pictureBoxCondit.TabStop = false;
            // 
            // groupBoxRes_BNA
            // 
            groupBoxRes_BNA.Controls.Add(dataGridView1);
            groupBoxRes_BNA.Controls.Add(labelRes_BNA);
            groupBoxRes_BNA.Location = new Point(12, 267);
            groupBoxRes_BNA.Name = "groupBoxRes_BNA";
            groupBoxRes_BNA.Size = new Size(776, 304);
            groupBoxRes_BNA.TabIndex = 5;
            groupBoxRes_BNA.TabStop = false;
            groupBoxRes_BNA.Text = "Вывод";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, FX, Column1, Column2, Column3 });
            dataGridView1.Location = new Point(10, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(688, 240);
            dataGridView1.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondit).EndInit();
            groupBoxRes_BNA.ResumeLayout(false);
            groupBoxRes_BNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_BNA;
        private PictureBox pictureBoxCondit;
        private GroupBox groupBoxRes_BNA;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label labelRes_BNA;
        private Button buttonPush;
        private Button buttonWho_BNA;
    }
}
