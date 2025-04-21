namespace SyntaxWinApp03
{
    partial class FrmMain
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
            BtnMsg = new Button();
            LblPain = new Label();
            TxtPain = new TextBox();
            LblPainPoint = new Label();
            CboPainPoint = new ComboBox();
            BtnDisplay = new Button();
            TxtResult = new TextBox();
            BtnWhile = new Button();
            SuspendLayout();
            // 
            // BtnMsg
            // 
            BtnMsg.Location = new Point(688, 398);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(100, 40);
            BtnMsg.TabIndex = 6;
            BtnMsg.Text = "메시지";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // LblPain
            // 
            LblPain.AutoSize = true;
            LblPain.Location = new Point(12, 23);
            LblPain.Name = "LblPain";
            LblPain.Size = new Size(64, 15);
            LblPain.TabIndex = 1;
            LblPain.Text = "통증여부 -";
            // 
            // TxtPain
            // 
            TxtPain.Location = new Point(82, 20);
            TxtPain.MaxLength = 3;
            TxtPain.Name = "TxtPain";
            TxtPain.PlaceholderText = "네 또는 아니오";
            TxtPain.Size = new Size(100, 23);
            TxtPain.TabIndex = 1;
            TxtPain.TextChanged += TxtPain_TextChanged;
            TxtPain.KeyPress += TxtPain_KeyPress;
            // 
            // LblPainPoint
            // 
            LblPainPoint.AutoSize = true;
            LblPainPoint.Location = new Point(12, 54);
            LblPainPoint.Name = "LblPainPoint";
            LblPainPoint.Size = new Size(64, 15);
            LblPainPoint.TabIndex = 1;
            LblPainPoint.Text = "통증부위 -";
            // 
            // CboPainPoint
            // 
            CboPainPoint.FormattingEnabled = true;
            CboPainPoint.Items.AddRange(new object[] { "머리", "눈", "코", "목", "가슴", "배" });
            CboPainPoint.Location = new Point(82, 51);
            CboPainPoint.Name = "CboPainPoint";
            CboPainPoint.Size = new Size(121, 23);
            CboPainPoint.TabIndex = 2;
            CboPainPoint.Text = "부위선택";
            CboPainPoint.SelectedIndexChanged += CboPainPoint_SelectedIndexChanged;
            CboPainPoint.KeyPress += CboPainPoint_KeyPress;
            // 
            // BtnDisplay
            // 
            BtnDisplay.Location = new Point(582, 398);
            BtnDisplay.Name = "BtnDisplay";
            BtnDisplay.Size = new Size(100, 40);
            BtnDisplay.TabIndex = 5;
            BtnDisplay.Text = "구구단";
            BtnDisplay.UseVisualStyleBackColor = true;
            BtnDisplay.Click += BtnDisplay_Click;
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(12, 80);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(776, 312);
            TxtResult.TabIndex = 3;
            // 
            // BtnWhile
            // 
            BtnWhile.Location = new Point(476, 398);
            BtnWhile.Name = "BtnWhile";
            BtnWhile.Size = new Size(100, 40);
            BtnWhile.TabIndex = 4;
            BtnWhile.Text = "반복";
            BtnWhile.UseVisualStyleBackColor = true;
            BtnWhile.Click += BtnWhile_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnWhile);
            Controls.Add(TxtResult);
            Controls.Add(BtnDisplay);
            Controls.Add(CboPainPoint);
            Controls.Add(TxtPain);
            Controls.Add(LblPainPoint);
            Controls.Add(LblPain);
            Controls.Add(BtnMsg);
            Name = "FrmMain";
            Text = "문법학습 윈앱 03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMsg;
        private Label LblPain;
        private TextBox TxtPain;
        private Label LblPainPoint;
        private ComboBox CboPainPoint;
        private Button BtnDisplay;
        private TextBox TxtResult;
        private Button BtnWhile;
    }
}
