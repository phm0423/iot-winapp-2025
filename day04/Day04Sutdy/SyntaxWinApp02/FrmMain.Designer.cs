﻿namespace SyntaxWinApp02
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            BtnCheck = new Button();
            imageList1 = new ImageList(components);
            label1 = new Label();
            CboArray = new ComboBox();
            label2 = new Label();
            CboList = new ComboBox();
            label3 = new Label();
            CboDictionary = new ComboBox();
            SuspendLayout();
            // 
            // BtnCheck
            // 
            BtnCheck.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCheck.ImageIndex = 0;
            BtnCheck.ImageList = imageList1;
            BtnCheck.Location = new Point(472, 259);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Padding = new Padding(10, 0, 0, 0);
            BtnCheck.Size = new Size(100, 40);
            BtnCheck.TabIndex = 0;
            BtnCheck.Text = "데이터";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cs0006.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 20);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "배열로 할당: ";
            // 
            // CboArray
            // 
            CboArray.FormattingEnabled = true;
            CboArray.Location = new Point(125, 12);
            CboArray.Name = "CboArray";
            CboArray.Size = new Size(121, 23);
            CboArray.TabIndex = 2;
            CboArray.SelectedIndexChanged += CboArray_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 49);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "리스트로 할당: ";
            // 
            // CboList
            // 
            CboList.FormattingEnabled = true;
            CboList.Location = new Point(125, 41);
            CboList.Name = "CboList";
            CboList.Size = new Size(121, 23);
            CboList.TabIndex = 2;
            CboList.SelectedIndexChanged += CboList_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 73);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 1;
            label3.Text = "딕셔너리로 할당: ";
            // 
            // CboDictionary
            // 
            CboDictionary.FormattingEnabled = true;
            CboDictionary.Location = new Point(125, 70);
            CboDictionary.Name = "CboDictionary";
            CboDictionary.Size = new Size(121, 23);
            CboDictionary.TabIndex = 2;
            CboDictionary.SelectedIndexChanged += CboDictionary_SelectedIndexChanged;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(CboDictionary);
            Controls.Add(CboList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CboArray);
            Controls.Add(label1);
            Controls.Add(BtnCheck);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "컬렉션학습 윈앱";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCheck;
        private Label label1;
        private ComboBox CboArray;
        private ImageList imageList1;
        private Label label2;
        private ComboBox CboList;
        private Label label3;
        private ComboBox CboDictionary;
    }
}
