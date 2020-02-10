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
            this.SuspendLayout();
            // 
            // button_Active
            // 
            this.button_Active.Location = new System.Drawing.Point(156, 154);
            this.button_Active.Name = "button_Active";
            this.button_Active.Size = new System.Drawing.Size(75, 23);
            this.button_Active.TabIndex = 0;
            this.button_Active.Text = "启动";
            this.button_Active.UseVisualStyleBackColor = true;
            this.button_Active.Click += new System.EventHandler(this.button_Active_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "窗口句柄：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "进程ID：";
            // 
            // textBox_HWND
            // 
            this.textBox_HWND.Location = new System.Drawing.Point(120, 24);
            this.textBox_HWND.Name = "textBox_HWND";
            this.textBox_HWND.Size = new System.Drawing.Size(150, 21);
            this.textBox_HWND.TabIndex = 3;
            // 
            // textBox_ProcessID
            // 
            this.textBox_ProcessID.Location = new System.Drawing.Point(120, 63);
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
            this.label3.Location = new System.Drawing.Point(48, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "快捷键F4，找到窗体后按F4停止获取即可";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 189);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ProcessID);
            this.Controls.Add(this.textBox_HWND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Active);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "获取鼠标所在处窗口句柄";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Active;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_HWND;
        private System.Windows.Forms.TextBox textBox_ProcessID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

