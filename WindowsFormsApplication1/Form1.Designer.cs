﻿namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.IbISend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IbISend
            // 
            this.IbISend.AutoSize = true;
            this.IbISend.Location = new System.Drawing.Point(56, 67);
            this.IbISend.Name = "IbISend";
            this.IbISend.Size = new System.Drawing.Size(210, 12);
            this.IbISend.TabIndex = 0;
            this.IbISend.Text = "Receiver로 \'김은택\' 값이 전달됩니다.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 190);
            this.Controls.Add(this.IbISend);
            this.Name = "Form1";
            this.Text = "데이터 전달";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IbISend;
    }
}

