namespace practiceCalculator
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
            this.number_7 = new System.Windows.Forms.Button();
            this.number_4 = new System.Windows.Forms.Button();
            this.number_1 = new System.Windows.Forms.Button();
            this.number_8 = new System.Windows.Forms.Button();
            this.number_5 = new System.Windows.Forms.Button();
            this.number_2 = new System.Windows.Forms.Button();
            this.number_9 = new System.Windows.Forms.Button();
            this.number_6 = new System.Windows.Forms.Button();
            this.number_3 = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.button_mod = new System.Windows.Forms.Button();
            this.button_rev = new System.Windows.Forms.Button();
            this.button_equ = new System.Windows.Forms.Button();
            this.number_0 = new System.Windows.Forms.Button();
            this.button_point = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textbox_process = new System.Windows.Forms.RichTextBox();
            this.textbox_result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // number_7
            // 
            this.number_7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_7.Location = new System.Drawing.Point(16, 142);
            this.number_7.Name = "number_7";
            this.number_7.Size = new System.Drawing.Size(39, 36);
            this.number_7.TabIndex = 0;
            this.number_7.Text = "7";
            this.number_7.UseVisualStyleBackColor = true;
            this.number_7.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_4
            // 
            this.number_4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_4.Location = new System.Drawing.Point(16, 184);
            this.number_4.Name = "number_4";
            this.number_4.Size = new System.Drawing.Size(39, 36);
            this.number_4.TabIndex = 1;
            this.number_4.Text = "4";
            this.number_4.UseVisualStyleBackColor = true;
            this.number_4.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_1
            // 
            this.number_1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_1.Location = new System.Drawing.Point(16, 226);
            this.number_1.Name = "number_1";
            this.number_1.Size = new System.Drawing.Size(39, 36);
            this.number_1.TabIndex = 2;
            this.number_1.Text = "1";
            this.number_1.UseVisualStyleBackColor = true;
            this.number_1.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_8
            // 
            this.number_8.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_8.Location = new System.Drawing.Point(61, 142);
            this.number_8.Name = "number_8";
            this.number_8.Size = new System.Drawing.Size(39, 36);
            this.number_8.TabIndex = 3;
            this.number_8.Text = "8";
            this.number_8.UseVisualStyleBackColor = true;
            this.number_8.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_5
            // 
            this.number_5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_5.Location = new System.Drawing.Point(61, 184);
            this.number_5.Name = "number_5";
            this.number_5.Size = new System.Drawing.Size(39, 36);
            this.number_5.TabIndex = 4;
            this.number_5.Text = "5";
            this.number_5.UseVisualStyleBackColor = true;
            this.number_5.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_2
            // 
            this.number_2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_2.Location = new System.Drawing.Point(61, 226);
            this.number_2.Name = "number_2";
            this.number_2.Size = new System.Drawing.Size(39, 36);
            this.number_2.TabIndex = 5;
            this.number_2.Text = "2";
            this.number_2.UseVisualStyleBackColor = true;
            this.number_2.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_9
            // 
            this.number_9.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_9.Location = new System.Drawing.Point(106, 142);
            this.number_9.Name = "number_9";
            this.number_9.Size = new System.Drawing.Size(39, 36);
            this.number_9.TabIndex = 6;
            this.number_9.Text = "9";
            this.number_9.UseVisualStyleBackColor = true;
            this.number_9.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_6
            // 
            this.number_6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_6.Location = new System.Drawing.Point(106, 184);
            this.number_6.Name = "number_6";
            this.number_6.Size = new System.Drawing.Size(39, 36);
            this.number_6.TabIndex = 7;
            this.number_6.Text = "6";
            this.number_6.UseVisualStyleBackColor = true;
            this.number_6.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_3
            // 
            this.number_3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_3.Location = new System.Drawing.Point(106, 226);
            this.number_3.Name = "number_3";
            this.number_3.Size = new System.Drawing.Size(39, 36);
            this.number_3.TabIndex = 8;
            this.number_3.Text = "3";
            this.number_3.UseVisualStyleBackColor = true;
            this.number_3.Click += new System.EventHandler(this.ClickNum);
            // 
            // button_div
            // 
            this.button_div.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_div.Location = new System.Drawing.Point(151, 142);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(39, 36);
            this.button_div.TabIndex = 9;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.ClickOp);
            // 
            // button_mul
            // 
            this.button_mul.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_mul.Location = new System.Drawing.Point(151, 184);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(39, 36);
            this.button_mul.TabIndex = 10;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = true;
            this.button_mul.Click += new System.EventHandler(this.ClickOp);
            // 
            // button_sub
            // 
            this.button_sub.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_sub.Location = new System.Drawing.Point(151, 226);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(39, 36);
            this.button_sub.TabIndex = 11;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.ClickOp);
            // 
            // button_mod
            // 
            this.button_mod.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_mod.Location = new System.Drawing.Point(196, 142);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(39, 36);
            this.button_mod.TabIndex = 12;
            this.button_mod.Text = "%";
            this.button_mod.UseVisualStyleBackColor = true;
            this.button_mod.Click += new System.EventHandler(this.ClickOp);
            // 
            // button_rev
            // 
            this.button_rev.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_rev.Location = new System.Drawing.Point(196, 184);
            this.button_rev.Name = "button_rev";
            this.button_rev.Size = new System.Drawing.Size(39, 36);
            this.button_rev.TabIndex = 13;
            this.button_rev.Text = "1/x";
            this.button_rev.UseVisualStyleBackColor = true;
            this.button_rev.Click += new System.EventHandler(this.ClickReciprocal);
            // 
            // button_equ
            // 
            this.button_equ.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_equ.Location = new System.Drawing.Point(196, 226);
            this.button_equ.Name = "button_equ";
            this.button_equ.Size = new System.Drawing.Size(39, 78);
            this.button_equ.TabIndex = 14;
            this.button_equ.Text = "=";
            this.button_equ.UseVisualStyleBackColor = true;
            this.button_equ.Click += new System.EventHandler(this.ClickEqual);
            // 
            // number_0
            // 
            this.number_0.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_0.Location = new System.Drawing.Point(16, 268);
            this.number_0.Name = "number_0";
            this.number_0.Size = new System.Drawing.Size(84, 36);
            this.number_0.TabIndex = 15;
            this.number_0.Text = "0";
            this.number_0.UseVisualStyleBackColor = true;
            this.number_0.Click += new System.EventHandler(this.ClickNum);
            // 
            // button_point
            // 
            this.button_point.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_point.Location = new System.Drawing.Point(106, 268);
            this.button_point.Name = "button_point";
            this.button_point.Size = new System.Drawing.Size(39, 36);
            this.button_point.TabIndex = 16;
            this.button_point.Text = ".";
            this.button_point.UseVisualStyleBackColor = true;
            this.button_point.Click += new System.EventHandler(this.ClickOp);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_add.Location = new System.Drawing.Point(151, 268);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(39, 36);
            this.button_add.TabIndex = 17;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.ClickOp);
            // 
            // textbox_process
            // 
            this.textbox_process.Location = new System.Drawing.Point(16, 12);
            this.textbox_process.Name = "textbox_process";
            this.textbox_process.ReadOnly = true;
            this.textbox_process.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textbox_process.Size = new System.Drawing.Size(219, 87);
            this.textbox_process.TabIndex = 18;
            this.textbox_process.Text = "";
            // 
            // textbox_result
            // 
            this.textbox_result.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textbox_result.Location = new System.Drawing.Point(16, 100);
            this.textbox_result.Multiline = false;
            this.textbox_result.Name = "textbox_result";
            this.textbox_result.ReadOnly = true;
            this.textbox_result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textbox_result.Size = new System.Drawing.Size(219, 36);
            this.textbox_result.TabIndex = 19;
            this.textbox_result.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 317);
            this.Controls.Add(this.textbox_result);
            this.Controls.Add(this.textbox_process);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_point);
            this.Controls.Add(this.number_0);
            this.Controls.Add(this.button_equ);
            this.Controls.Add(this.button_rev);
            this.Controls.Add(this.button_mod);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.number_3);
            this.Controls.Add(this.number_6);
            this.Controls.Add(this.number_9);
            this.Controls.Add(this.number_2);
            this.Controls.Add(this.number_5);
            this.Controls.Add(this.number_8);
            this.Controls.Add(this.number_1);
            this.Controls.Add(this.number_4);
            this.Controls.Add(this.number_7);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressKey);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button number_7;
        private System.Windows.Forms.Button number_4;
        private System.Windows.Forms.Button number_1;
        private System.Windows.Forms.Button number_8;
        private System.Windows.Forms.Button number_5;
        private System.Windows.Forms.Button number_2;
        private System.Windows.Forms.Button number_9;
        private System.Windows.Forms.Button number_6;
        private System.Windows.Forms.Button number_3;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_mul;
        private System.Windows.Forms.Button button_sub;
        private System.Windows.Forms.Button button_mod;
        private System.Windows.Forms.Button button_rev;
        private System.Windows.Forms.Button button_equ;
        private System.Windows.Forms.Button number_0;
        private System.Windows.Forms.Button button_point;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.RichTextBox textbox_process;
        private System.Windows.Forms.RichTextBox textbox_result;
    }
}

