namespace Tyuiu.BorkovNA.Sprint6.Task0.V22
{
    partial class Form_BNA
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
            pictureBox1 = new PictureBox();
            groupBoxInput_BNA = new GroupBox();
            labelX_BNA = new Label();
            textBoxX = new TextBox();
            groupBoxRes_BNA = new GroupBox();
            labelRes_BNA = new Label();
            textBoxRes = new TextBox();
            buttonPush = new Button();
            buttonWho_BNA = new Button();
            groupBoxMain_BNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInput_BNA.SuspendLayout();
            groupBoxRes_BNA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMain_BNA
            // 
            groupBoxMain_BNA.Controls.Add(pictureBox1);
            groupBoxMain_BNA.Location = new Point(12, 12);
            groupBoxMain_BNA.Name = "groupBoxMain_BNA";
            groupBoxMain_BNA.Size = new Size(776, 193);
            groupBoxMain_BNA.TabIndex = 0;
            groupBoxMain_BNA.TabStop = false;
            groupBoxMain_BNA.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Task0;
            pictureBox1.Location = new Point(138, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(504, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBoxInput_BNA
            // 
            groupBoxInput_BNA.Controls.Add(labelX_BNA);
            groupBoxInput_BNA.Controls.Add(textBoxX);
            groupBoxInput_BNA.Location = new Point(12, 211);
            groupBoxInput_BNA.Name = "groupBoxInput_BNA";
            groupBoxInput_BNA.Size = new Size(482, 144);
            groupBoxInput_BNA.TabIndex = 1;
            groupBoxInput_BNA.TabStop = false;
            groupBoxInput_BNA.Text = "Ввод";
            // 
            // labelX_BNA
            // 
            labelX_BNA.AutoSize = true;
            labelX_BNA.Location = new Point(174, 76);
            labelX_BNA.Name = "labelX_BNA";
            labelX_BNA.Size = new Size(111, 20);
            labelX_BNA.TabIndex = 2;
            labelX_BNA.Text = "Переменная Х";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(174, 99);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(125, 27);
            textBoxX.TabIndex = 1;
            // 
            // groupBoxRes_BNA
            // 
            groupBoxRes_BNA.Controls.Add(labelRes_BNA);
            groupBoxRes_BNA.Controls.Add(textBoxRes);
            groupBoxRes_BNA.Location = new Point(500, 211);
            groupBoxRes_BNA.Name = "groupBoxRes_BNA";
            groupBoxRes_BNA.Size = new Size(288, 144);
            groupBoxRes_BNA.TabIndex = 2;
            groupBoxRes_BNA.TabStop = false;
            groupBoxRes_BNA.Text = "Вывод";
            // 
            // labelRes_BNA
            // 
            labelRes_BNA.AutoSize = true;
            labelRes_BNA.Location = new Point(115, 76);
            labelRes_BNA.Name = "labelRes_BNA";
            labelRes_BNA.Size = new Size(75, 20);
            labelRes_BNA.TabIndex = 1;
            labelRes_BNA.Text = "Результат";
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(90, 99);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.Size = new Size(125, 27);
            textBoxRes.TabIndex = 0;
            // 
            // buttonPush
            // 
            buttonPush.Location = new Point(631, 361);
            buttonPush.Name = "buttonPush";
            buttonPush.Size = new Size(157, 77);
            buttonPush.TabIndex = 3;
            buttonPush.Text = "Выполнить";
            buttonPush.UseVisualStyleBackColor = true;
            buttonPush.Click += buttonPush_Click;
            // 
            // buttonWho_BNA
            // 
            buttonWho_BNA.Location = new Point(555, 361);
            buttonWho_BNA.Name = "buttonWho_BNA";
            buttonWho_BNA.Size = new Size(70, 77);
            buttonWho_BNA.TabIndex = 4;
            buttonWho_BNA.Text = "?";
            buttonWho_BNA.UseVisualStyleBackColor = true;
            buttonWho_BNA.Click += buttonWho_BNA_Click;
            // 
            // Form_BNA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonWho_BNA);
            Controls.Add(buttonPush);
            Controls.Add(groupBoxRes_BNA);
            Controls.Add(groupBoxInput_BNA);
            Controls.Add(groupBoxMain_BNA);
            MaximizeBox = false;
            Name = "Form_BNA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 22 | Борков Н. А.";
            groupBoxMain_BNA.ResumeLayout(false);
            groupBoxMain_BNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxInput_BNA.ResumeLayout(false);
            groupBoxInput_BNA.PerformLayout();
            groupBoxRes_BNA.ResumeLayout(false);
            groupBoxRes_BNA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_BNA;
        private PictureBox pictureBox1;
        private GroupBox groupBoxInput_BNA;
        private GroupBox groupBoxRes_BNA;
        private Label labelX_BNA;
        private TextBox textBoxX;
        private Label labelRes_BNA;
        private TextBox textBoxRes;
        private Button buttonPush;
        private Button buttonWho_BNA;
    }
}
