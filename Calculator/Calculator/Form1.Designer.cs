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
            this.components = new System.ComponentModel.Container();
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
            this.button_save = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.listbox_history = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기록지우기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // number_7
            // 
            this.number_7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_7.Location = new System.Drawing.Point(18, 308);
            this.number_7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.number_7.Name = "number_7";
            this.number_7.Size = new System.Drawing.Size(45, 45);
            this.number_7.TabIndex = 0;
            this.number_7.Text = "7";
            this.number_7.UseVisualStyleBackColor = true;
            this.number_7.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_4
            // 
            this.number_4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_4.Location = new System.Drawing.Point(18, 360);
            this.number_4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.number_4.Name = "number_4";
            this.number_4.Size = new System.Drawing.Size(45, 45);
            this.number_4.TabIndex = 1;
            this.number_4.Text = "4";
            this.number_4.UseVisualStyleBackColor = true;
            this.number_4.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_1
            // 
            this.number_1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_1.Location = new System.Drawing.Point(18, 412);
            this.number_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.number_1.Name = "number_1";
            this.number_1.Size = new System.Drawing.Size(45, 45);
            this.number_1.TabIndex = 2;
            this.number_1.Text = "1";
            this.number_1.UseVisualStyleBackColor = true;
            this.number_1.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_8
            // 
            this.number_8.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_8.Location = new System.Drawing.Point(70, 308);
            this.number_8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.number_8.Name = "number_8";
            this.number_8.Size = new System.Drawing.Size(45, 45);
            this.number_8.TabIndex = 3;
            this.number_8.Text = "8";
            this.number_8.UseVisualStyleBackColor = true;
            this.number_8.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_5
            // 
            this.number_5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_5.Location = new System.Drawing.Point(70, 360);
            this.number_5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.number_5.Name = "number_5";
            this.number_5.Size = new System.Drawing.Size(45, 45);
            this.number_5.TabIndex = 4;
            this.number_5.Text = "5";
            this.number_5.UseVisualStyleBackColor = true;
            this.number_5.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_2
            // 
            this.number_2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_2.Location = new System.Drawing.Point(70, 412);
            this.number_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.number_2.Name = "number_2";
            this.number_2.Size = new System.Drawing.Size(45, 45);
            this.number_2.TabIndex = 5;
            this.number_2.Text = "2";
            this.number_2.UseVisualStyleBackColor = true;
            this.number_2.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_9
            // 
            this.number_9.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_9.Location = new System.Drawing.Point(121, 308);
            this.number_9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.number_9.Name = "number_9";
            this.number_9.Size = new System.Drawing.Size(45, 45);
            this.number_9.TabIndex = 6;
            this.number_9.Text = "9";
            this.number_9.UseVisualStyleBackColor = true;
            this.number_9.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_6
            // 
            this.number_6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_6.Location = new System.Drawing.Point(121, 360);
            this.number_6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.number_6.Name = "number_6";
            this.number_6.Size = new System.Drawing.Size(45, 45);
            this.number_6.TabIndex = 7;
            this.number_6.Text = "6";
            this.number_6.UseVisualStyleBackColor = true;
            this.number_6.Click += new System.EventHandler(this.ClickNum);
            // 
            // number_3
            // 
            this.number_3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_3.Location = new System.Drawing.Point(121, 412);
            this.number_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.number_3.Name = "number_3";
            this.number_3.Size = new System.Drawing.Size(45, 45);
            this.number_3.TabIndex = 8;
            this.number_3.Text = "3";
            this.number_3.UseVisualStyleBackColor = true;
            this.number_3.Click += new System.EventHandler(this.ClickNum);
            // 
            // button_div
            // 
            this.button_div.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_div.Location = new System.Drawing.Point(173, 308);
            this.button_div.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(45, 45);
            this.button_div.TabIndex = 9;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.ClickOp);
            // 
            // button_mul
            // 
            this.button_mul.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_mul.Location = new System.Drawing.Point(173, 360);
            this.button_mul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(45, 45);
            this.button_mul.TabIndex = 10;
            this.button_mul.Text = "*";
            this.button_mul.UseVisualStyleBackColor = true;
            this.button_mul.Click += new System.EventHandler(this.ClickOp);
            // 
            // button_sub
            // 
            this.button_sub.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_sub.Location = new System.Drawing.Point(173, 412);
            this.button_sub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(45, 45);
            this.button_sub.TabIndex = 11;
            this.button_sub.Text = "-";
            this.button_sub.UseVisualStyleBackColor = true;
            this.button_sub.Click += new System.EventHandler(this.ClickOp);
            // 
            // button_mod
            // 
            this.button_mod.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_mod.Location = new System.Drawing.Point(224, 308);
            this.button_mod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(45, 45);
            this.button_mod.TabIndex = 12;
            this.button_mod.Text = "%";
            this.button_mod.UseVisualStyleBackColor = true;
            this.button_mod.Click += new System.EventHandler(this.ClickOp);
            // 
            // button_rev
            // 
            this.button_rev.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_rev.Location = new System.Drawing.Point(224, 360);
            this.button_rev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_rev.Name = "button_rev";
            this.button_rev.Size = new System.Drawing.Size(45, 45);
            this.button_rev.TabIndex = 13;
            this.button_rev.Text = "1/x";
            this.button_rev.UseVisualStyleBackColor = true;
            this.button_rev.Click += new System.EventHandler(this.ClickReciprocal);
            // 
            // button_equ
            // 
            this.button_equ.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_equ.Location = new System.Drawing.Point(224, 412);
            this.button_equ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_equ.Name = "button_equ";
            this.button_equ.Size = new System.Drawing.Size(45, 98);
            this.button_equ.TabIndex = 14;
            this.button_equ.Text = "=";
            this.button_equ.UseVisualStyleBackColor = true;
            this.button_equ.Click += new System.EventHandler(this.ClickEqual);
            // 
            // number_0
            // 
            this.number_0.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number_0.Location = new System.Drawing.Point(18, 465);
            this.number_0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.number_0.Name = "number_0";
            this.number_0.Size = new System.Drawing.Size(96, 45);
            this.number_0.TabIndex = 15;
            this.number_0.Text = "0";
            this.number_0.UseVisualStyleBackColor = true;
            this.number_0.Click += new System.EventHandler(this.ClickNum);
            // 
            // button_point
            // 
            this.button_point.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_point.Location = new System.Drawing.Point(121, 465);
            this.button_point.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_point.Name = "button_point";
            this.button_point.Size = new System.Drawing.Size(45, 45);
            this.button_point.TabIndex = 16;
            this.button_point.Text = ".";
            this.button_point.UseVisualStyleBackColor = true;
            this.button_point.Click += new System.EventHandler(this.ClickNum);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_add.Location = new System.Drawing.Point(173, 465);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(45, 45);
            this.button_add.TabIndex = 17;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.ClickOp);
            // 
            // textbox_process
            // 
            this.textbox_process.Location = new System.Drawing.Point(18, 220);
            this.textbox_process.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_process.Name = "textbox_process";
            this.textbox_process.ReadOnly = true;
            this.textbox_process.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textbox_process.Size = new System.Drawing.Size(250, 44);
            this.textbox_process.TabIndex = 18;
            this.textbox_process.Text = "";
            // 
            // textbox_result
            // 
            this.textbox_result.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textbox_result.Location = new System.Drawing.Point(18, 261);
            this.textbox_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_result.Multiline = false;
            this.textbox_result.Name = "textbox_result";
            this.textbox_result.ReadOnly = true;
            this.textbox_result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textbox_result.Size = new System.Drawing.Size(250, 38);
            this.textbox_result.TabIndex = 19;
            this.textbox_result.Text = "0";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(17, 6);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(48, 25);
            this.button_save.TabIndex = 22;
            this.button_save.Text = "저장";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_up
            // 
            this.button_up.Location = new System.Drawing.Point(217, 6);
            this.button_up.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(24, 25);
            this.button_up.TabIndex = 23;
            this.button_up.Text = "▲";
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.button_up_Click);
            // 
            // button_down
            // 
            this.button_down.Location = new System.Drawing.Point(245, 6);
            this.button_down.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(24, 25);
            this.button_down.TabIndex = 23;
            this.button_down.Text = "▼";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // listbox_history
            // 
            this.listbox_history.BackColor = System.Drawing.SystemColors.Control;
            this.listbox_history.ContextMenuStrip = this.contextMenuStrip1;
            this.listbox_history.Cursor = System.Windows.Forms.Cursors.Default;
            this.listbox_history.FormattingEnabled = true;
            this.listbox_history.ItemHeight = 15;
            this.listbox_history.Location = new System.Drawing.Point(17, 40);
            this.listbox_history.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listbox_history.Name = "listbox_history";
            this.listbox_history.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listbox_history.Size = new System.Drawing.Size(250, 169);
            this.listbox_history.TabIndex = 24;
            this.listbox_history.Click += new System.EventHandler(this.listbox_history_Click);
            this.listbox_history.DoubleClick += new System.EventHandler(this.listbox_history_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.복사ToolStripMenuItem,
            this.붙여넣기ToolStripMenuItem,
            this.기록지우기ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 110);
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.복사ToolStripMenuItem.Text = "복사";
            this.복사ToolStripMenuItem.Click += new System.EventHandler(this.contextmenu_copyclick);
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            this.붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            this.붙여넣기ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.붙여넣기ToolStripMenuItem.Text = "붙여넣기";
            this.붙여넣기ToolStripMenuItem.Click += new System.EventHandler(this.contextmenu_pasteclick);
            // 
            // 기록지우기ToolStripMenuItem
            // 
            this.기록지우기ToolStripMenuItem.Name = "기록지우기ToolStripMenuItem";
            this.기록지우기ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.기록지우기ToolStripMenuItem.Text = "기록 지우기";
            this.기록지우기ToolStripMenuItem.Click += new System.EventHandler(this.contextmenu_deleteclick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 525);
            this.Controls.Add(this.listbox_history);
            this.Controls.Add(this.button_down);
            this.Controls.Add(this.button_up);
            this.Controls.Add(this.button_save);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressKey);
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.ListBox listbox_history;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기록지우기ToolStripMenuItem;
    }
}

