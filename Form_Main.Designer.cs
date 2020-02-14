namespace HWND_Getter
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_Active = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_HWND = new System.Windows.Forms.TextBox();
            this.textBox_ProcessID = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Left = new System.Windows.Forms.TextBox();
            this.textBox_Right = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Width = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Bottom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Top = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Active
            // 
            this.button_Active.Location = new System.Drawing.Point(273, 14);
            this.button_Active.Name = "button_Active";
            this.button_Active.Size = new System.Drawing.Size(75, 77);
            this.button_Active.TabIndex = 0;
            this.button_Active.Text = "启动";
            this.button_Active.UseVisualStyleBackColor = true;
            this.button_Active.Click += new System.EventHandler(this.button_Active_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "窗口句柄：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "进程ID：";
            // 
            // textBox_HWND
            // 
            this.textBox_HWND.Location = new System.Drawing.Point(77, 14);
            this.textBox_HWND.Name = "textBox_HWND";
            this.textBox_HWND.Size = new System.Drawing.Size(150, 21);
            this.textBox_HWND.TabIndex = 3;
            // 
            // textBox_ProcessID
            // 
            this.textBox_ProcessID.Location = new System.Drawing.Point(77, 43);
            this.textBox_ProcessID.Name = "textBox_ProcessID";
            this.textBox_ProcessID.Size = new System.Drawing.Size(150, 21);
            this.textBox_ProcessID.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "快捷键F4，找到窗体后按F4停止获取即可";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Active);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_ProcessID);
            this.groupBox1.Controls.Add(this.textBox_HWND);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 136);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础功能";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Bottom);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_Top);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_Height);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_Width);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_Right);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_Left);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 163);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "扩展功能";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "最左坐标";
            // 
            // textBox_Left
            // 
            this.textBox_Left.Location = new System.Drawing.Point(65, 14);
            this.textBox_Left.Name = "textBox_Left";
            this.textBox_Left.Size = new System.Drawing.Size(102, 21);
            this.textBox_Left.TabIndex = 6;
            // 
            // textBox_Right
            // 
            this.textBox_Right.Location = new System.Drawing.Point(65, 41);
            this.textBox_Right.Name = "textBox_Right";
            this.textBox_Right.Size = new System.Drawing.Size(102, 21);
            this.textBox_Right.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "最右坐标";
            // 
            // textBox_Height
            // 
            this.textBox_Height.Location = new System.Drawing.Point(65, 113);
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(102, 21);
            this.textBox_Height.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(6, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "窗口高度";
            // 
            // textBox_Width
            // 
            this.textBox_Width.Location = new System.Drawing.Point(65, 86);
            this.textBox_Width.Name = "textBox_Width";
            this.textBox_Width.Size = new System.Drawing.Size(102, 21);
            this.textBox_Width.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "窗口宽度";
            // 
            // textBox_Bottom
            // 
            this.textBox_Bottom.Location = new System.Drawing.Point(246, 41);
            this.textBox_Bottom.Name = "textBox_Bottom";
            this.textBox_Bottom.Size = new System.Drawing.Size(102, 21);
            this.textBox_Bottom.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "最下坐标";
            // 
            // textBox_Top
            // 
            this.textBox_Top.Location = new System.Drawing.Point(246, 14);
            this.textBox_Top.Name = "textBox_Top";
            this.textBox_Top.Size = new System.Drawing.Size(102, 21);
            this.textBox_Top.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "最上坐标";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 329);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "获取鼠标所在处窗口句柄";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Active;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_HWND;
        private System.Windows.Forms.TextBox textBox_ProcessID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Bottom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Top;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Width;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Right;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Left;
        private System.Windows.Forms.Label label4;
    }
}

