﻿namespace Kiosk
{
    partial class DrinkForm
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrangeJuice = new System.Windows.Forms.Button();
            this.CocaColaZero = new System.Windows.Forms.Button();
            this.CocaCola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrangeJuice
            // 
            this.OrangeJuice.Location = new System.Drawing.Point(260, 20);
            this.OrangeJuice.Name = "OrangeJuice";
            this.OrangeJuice.Size = new System.Drawing.Size(100, 100);
            this.OrangeJuice.TabIndex = 5;
            this.OrangeJuice.Text = "OrangeJuice";
            this.OrangeJuice.UseVisualStyleBackColor = true;
            // 
            // CocaColaZero
            // 
            this.CocaColaZero.Location = new System.Drawing.Point(140, 20);
            this.CocaColaZero.Name = "CocaColaZero";
            this.CocaColaZero.Size = new System.Drawing.Size(100, 100);
            this.CocaColaZero.TabIndex = 4;
            this.CocaColaZero.Text = "CocaColaZero";
            this.CocaColaZero.UseVisualStyleBackColor = true;
            // 
            // CocaCola
            // 
            this.CocaCola.Location = new System.Drawing.Point(20, 20);
            this.CocaCola.Name = "CocaCola";
            this.CocaCola.Size = new System.Drawing.Size(100, 100);
            this.CocaCola.TabIndex = 3;
            this.CocaCola.Text = "CocaCola";
            this.CocaCola.UseVisualStyleBackColor = true;
            // 
            // DrinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrangeJuice);
            this.Controls.Add(this.CocaColaZero);
            this.Controls.Add(this.CocaCola);
            this.Name = "DrinkForm";
            this.Size = new System.Drawing.Size(500, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OrangeJuice;
        private System.Windows.Forms.Button CocaColaZero;
        private System.Windows.Forms.Button CocaCola;
    }
}
