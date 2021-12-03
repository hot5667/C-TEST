
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Cur_label = new System.Windows.Forms.Label();
            this.text_x = new System.Windows.Forms.TextBox();
            this.text_y = new System.Windows.Forms.TextBox();
            this.text_cun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cur_label
            // 
            this.Cur_label.AutoSize = true;
            this.Cur_label.Location = new System.Drawing.Point(12, 9);
            this.Cur_label.Name = "Cur_label";
            this.Cur_label.Size = new System.Drawing.Size(38, 12);
            this.Cur_label.TabIndex = 2;
            this.Cur_label.Text = "label1";
            // 
            // text_x
            // 
            this.text_x.Location = new System.Drawing.Point(69, 6);
            this.text_x.Name = "text_x";
            this.text_x.Size = new System.Drawing.Size(100, 21);
            this.text_x.TabIndex = 3;
            this.text_x.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_y
            // 
            this.text_y.Location = new System.Drawing.Point(190, 6);
            this.text_y.Name = "text_y";
            this.text_y.Size = new System.Drawing.Size(100, 21);
            this.text_y.TabIndex = 4;
            // 
            // text_cun
            // 
            this.text_cun.Location = new System.Drawing.Point(69, 62);
            this.text_cun.Name = "text_cun";
            this.text_cun.Size = new System.Drawing.Size(100, 21);
            this.text_cun.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 300);
            this.Controls.Add(this.text_cun);
            this.Controls.Add(this.text_y);
            this.Controls.Add(this.text_x);
            this.Controls.Add(this.Cur_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Cur_label;
        private System.Windows.Forms.TextBox text_x;
        private System.Windows.Forms.TextBox text_y;
        private System.Windows.Forms.TextBox text_cun;
    }
}

