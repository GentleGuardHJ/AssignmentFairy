namespace Kiosk
{
    partial class SideForm
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
            this.FrnchFries = new System.Windows.Forms.Button();
            this.CheeseSticks = new System.Windows.Forms.Button();
            this.McNuggets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FrnchFries
            // 
            this.FrnchFries.Location = new System.Drawing.Point(20, 20);
            this.FrnchFries.Name = "FrnchFries";
            this.FrnchFries.Size = new System.Drawing.Size(100, 100);
            this.FrnchFries.TabIndex = 0;
            this.FrnchFries.Text = "FrnchFries";
            this.FrnchFries.UseVisualStyleBackColor = true;
            // 
            // CheeseSticks
            // 
            this.CheeseSticks.Location = new System.Drawing.Point(140, 20);
            this.CheeseSticks.Name = "CheeseSticks";
            this.CheeseSticks.Size = new System.Drawing.Size(100, 100);
            this.CheeseSticks.TabIndex = 1;
            this.CheeseSticks.Text = "CheeseSticks";
            this.CheeseSticks.UseVisualStyleBackColor = true;
            this.CheeseSticks.Click += new System.EventHandler(this.CheeseSticks_Click);
            // 
            // McNuggets
            // 
            this.McNuggets.Location = new System.Drawing.Point(260, 20);
            this.McNuggets.Name = "McNuggets";
            this.McNuggets.Size = new System.Drawing.Size(100, 100);
            this.McNuggets.TabIndex = 2;
            this.McNuggets.Text = "McNuggets";
            this.McNuggets.UseVisualStyleBackColor = true;
            // 
            // SideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.McNuggets);
            this.Controls.Add(this.CheeseSticks);
            this.Controls.Add(this.FrnchFries);
            this.Name = "SideForm";
            this.Size = new System.Drawing.Size(500, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FrnchFries;
        private System.Windows.Forms.Button CheeseSticks;
        private System.Windows.Forms.Button McNuggets;
    }
}
