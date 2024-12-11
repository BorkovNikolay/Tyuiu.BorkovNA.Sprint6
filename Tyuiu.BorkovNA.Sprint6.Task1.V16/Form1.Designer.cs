namespace Tyuiu.BorkovNA.Sprint6.Task1.V16
{
    partial class FormMain_BNA
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
            groupBoxInput_BNA = new GroupBox();
            textBoxB = new TextBox();
            labelB = new Label();
            labelA_BNA = new Label();
            textBoxA = new TextBox();
            groupBoxRes_BNA = new GroupBox();
            labelRes_BNA = new Label();
            textBoxRes = new TextBox();
            buttonPush = new Button();
            buttonWho_BNA = new Button();
            groupBoxMain_BNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondit).BeginInit();
            groupBoxInput_BNA.SuspendLayout();
            groupBoxRes_BNA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMain_BNA
            // 
            groupBoxMain_BNA.Controls.Add(pictureBoxCondit);
            groupBoxMain_BNA.Location = new Point(12, 12);
            groupBoxMain_BNA.Name = "groupBoxMain_BNA";
            groupBoxMain_BNA.Size = new Size(776, 249);
            groupBoxMain_BNA.TabIndex = 1;
            groupBoxMain_BNA.TabStop = false;
            groupBoxMain_BNA.Text = "Условие";
            // 
            // pictureBoxCondit
            // 
            pictureBoxCondit.Image = Properties.Resources.Task1;
            pictureBoxCondit.Location = new Point(59, 26);
            pictureBoxCondit.Name = "pictureBoxCondit";
            pictureBoxCondit.Size = new Size(637, 212);
            pictureBoxCondit.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxCondit.TabIndex = 0;
            pictureBoxCondit.TabStop = false;
            // 
            // groupBoxInput_BNA
            // 
            groupBoxInput_BNA.Controls.Add(textBoxB);
            groupBoxInput_BNA.Controls.Add(labelB);
            groupBoxInput_BNA.Controls.Add(labelA_BNA);
            groupBoxInput_BNA.Controls.Add(textBoxA);
            groupBoxInput_BNA.Location = new Point(12, 267);
            groupBoxInput_BNA.Name = "groupBoxInput_BNA";
            groupBoxInput_BNA.Size = new Size(482, 144);
            groupBoxInput_BNA.TabIndex = 2;
            groupBoxInput_BNA.TabStop = false;
            groupBoxInput_BNA.Text = "Ввод";
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(288, 97);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(125, 27);
            textBoxB.TabIndex = 4;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(302, 64);
            labelB.Name = "labelB";
            labelB.Size = new Size(111, 20);
            labelB.TabIndex = 3;
            labelB.Text = "Переменная B";
            // 
            // labelA_BNA
            // 
            labelA_BNA.AutoSize = true;
            labelA_BNA.Location = new Point(59, 64);
            labelA_BNA.Name = "labelA_BNA";
            labelA_BNA.Size = new Size(112, 20);
            labelA_BNA.TabIndex = 2;
            labelA_BNA.Text = "Переменная A";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(59, 97);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(125, 27);
            textBoxA.TabIndex = 1;
            textBoxA.TextChanged += textBoxA_TextChanged;
            // 
            // groupBoxRes_BNA
            // 
            groupBoxRes_BNA.Controls.Add(labelRes_BNA);
            groupBoxRes_BNA.Controls.Add(textBoxRes);
            groupBoxRes_BNA.Location = new Point(500, 267);
            groupBoxRes_BNA.Name = "groupBoxRes_BNA";
            groupBoxRes_BNA.Size = new Size(288, 346);
            groupBoxRes_BNA.TabIndex = 3;
            groupBoxRes_BNA.TabStop = false;
            groupBoxRes_BNA.Text = "Вывод";
            // 
            // labelRes_BNA
            // 
            labelRes_BNA.AutoSize = true;
            labelRes_BNA.Location = new Point(115, 33);
            labelRes_BNA.Name = "labelRes_BNA";
            labelRes_BNA.Size = new Size(75, 20);
            labelRes_BNA.TabIndex = 1;
            labelRes_BNA.Text = "Результат";
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(6, 54);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.Size = new Size(276, 286);
            textBoxRes.TabIndex = 0;
            // 
            // buttonPush
            // 
            buttonPush.Location = new Point(314, 530);
            buttonPush.Name = "buttonPush";
            buttonPush.Size = new Size(157, 77);
            buttonPush.TabIndex = 4;
            buttonPush.Text = "Выполнить";
            buttonPush.UseVisualStyleBackColor = true;
            buttonPush.Click += buttonPush_Click;
            // 
            // buttonWho_BNA
            // 
            buttonWho_BNA.Location = new Point(238, 530);
            buttonWho_BNA.Name = "buttonWho_BNA";
            buttonWho_BNA.Size = new Size(70, 77);
            buttonWho_BNA.TabIndex = 5;
            buttonWho_BNA.Text = "?";
            buttonWho_BNA.UseVisualStyleBackColor = true;
            buttonWho_BNA.Click += buttonWho_BNA_Click;
            // 
            // FormMain_BNA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 625);
            Controls.Add(buttonWho_BNA);
            Controls.Add(buttonPush);
            Controls.Add(groupBoxRes_BNA);
            Controls.Add(groupBoxInput_BNA);
            Controls.Add(groupBoxMain_BNA);
            Name = "FormMain_BNA";
            Text = "Спринт 6 | Таск 1 | Вариант 16 | Борков Н. А.";
            groupBoxMain_BNA.ResumeLayout(false);
            groupBoxMain_BNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondit).EndInit();
            groupBoxInput_BNA.ResumeLayout(false);
            groupBoxInput_BNA.PerformLayout();
            groupBoxRes_BNA.ResumeLayout(false);
            groupBoxRes_BNA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_BNA;
        private PictureBox pictureBoxCondit;
        private GroupBox groupBoxInput_BNA;
        private TextBox textBoxB;
        private Label labelB;
        private Label labelA_BNA;
        private TextBox textBoxA;
        private GroupBox groupBoxRes_BNA;
        private Label labelRes_BNA;
        private TextBox textBoxRes;
        private Button buttonPush;
        private Button buttonWho_BNA;
    }
}
