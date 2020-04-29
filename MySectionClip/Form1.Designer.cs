namespace MySectionClip
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.clear = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.replace = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.back_to_last = new System.Windows.Forms.Button();
            this.labelStatusDescription = new System.Windows.Forms.Label();
            this.checkFormFirst = new System.Windows.Forms.CheckBox();
            this.controlFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.OpacitySetting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(542, 335);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.Font = new System.Drawing.Font("宋体", 10F);
            this.clear.Location = new System.Drawing.Point(566, 353);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(137, 27);
            this.clear.TabIndex = 1;
            this.clear.Text = "清空富文本窗口";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // copy
            // 
            this.copy.AutoSize = true;
            this.copy.Font = new System.Drawing.Font("宋体", 10F);
            this.copy.Location = new System.Drawing.Point(709, 353);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(137, 27);
            this.copy.TabIndex = 2;
            this.copy.Text = "复制到剪贴板";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(560, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 179);
            this.label1.TabIndex = 3;
            this.label1.Text = "说明:\r\n该程序是否最前展示=ctrl+q(全局热键)\r\n清空=因为用的少,删除清空的热键\r\n自动监听ctrl+c把剪贴板内容复制到富文本窗口\r\n粘贴(在程序界面" +
    ")ctrl+x(全局热键)\r\n(注意复制是复制富文本窗口中的内容,允许编辑)\r\n使用:先ctrl+c多次复制你需要的文本觉得复制完后\r\nctrl+x把富文本中的" +
    "内容保存到剪贴板\r\n再ctrl+v保存到word上\r\n";
            // 
            // replace
            // 
            this.replace.AutoSize = true;
            this.replace.Font = new System.Drawing.Font("宋体", 10F);
            this.replace.Location = new System.Drawing.Point(618, 287);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(86, 27);
            this.replace.TabIndex = 4;
            this.replace.Text = "批量替换";
            this.replace.UseVisualStyleBackColor = true;
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(709, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 25);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(566, 287);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(48, 25);
            this.textBox2.TabIndex = 6;
            // 
            // back_to_last
            // 
            this.back_to_last.AutoSize = true;
            this.back_to_last.Font = new System.Drawing.Font("宋体", 10F);
            this.back_to_last.Location = new System.Drawing.Point(18, 21);
            this.back_to_last.Name = "back_to_last";
            this.back_to_last.Size = new System.Drawing.Size(189, 27);
            this.back_to_last.TabIndex = 8;
            this.back_to_last.Text = "返回上一步操作(未完)";
            this.back_to_last.UseVisualStyleBackColor = true;
            this.back_to_last.Visible = false;
            this.back_to_last.Click += new System.EventHandler(this.back_to_last_Click);
            // 
            // labelStatusDescription
            // 
            this.labelStatusDescription.Location = new System.Drawing.Point(12, 353);
            this.labelStatusDescription.Name = "labelStatusDescription";
            this.labelStatusDescription.Size = new System.Drawing.Size(542, 20);
            this.labelStatusDescription.TabIndex = 10;
            this.labelStatusDescription.Text = "源码及说明访问https://github.com/CloudFlowing/MySectionClip";
            this.labelStatusDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkFormFirst
            // 
            this.checkFormFirst.AutoSize = true;
            this.checkFormFirst.Checked = true;
            this.checkFormFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFormFirst.Location = new System.Drawing.Point(563, 231);
            this.checkFormFirst.Name = "checkFormFirst";
            this.checkFormFirst.Size = new System.Drawing.Size(164, 19);
            this.checkFormFirst.TabIndex = 11;
            this.checkFormFirst.Text = "该窗口是否锚定最前";
            this.checkFormFirst.UseVisualStyleBackColor = true;
            this.checkFormFirst.CheckedChanged += new System.EventHandler(this.checkFormFirst_CheckedChanged);
            // 
            // controlFilter
            // 
            this.controlFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlFilter.DropDownWidth = 200;
            this.controlFilter.FormattingEnabled = true;
            this.controlFilter.Items.AddRange(new object[] {
            "格式过滤器:多个\\n-->空格",
            "格式过滤器:多个\\n-->空",
            "格式过滤器:多个\\n-->一个\\n"});
            this.controlFilter.Location = new System.Drawing.Point(746, 258);
            this.controlFilter.Name = "controlFilter";
            this.controlFilter.Size = new System.Drawing.Size(120, 23);
            this.controlFilter.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(560, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "自动过滤器规则控制:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(566, 322);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 25);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // OpacitySetting
            // 
            this.OpacitySetting.AutoSize = true;
            this.OpacitySetting.Font = new System.Drawing.Font("宋体", 10F);
            this.OpacitySetting.Location = new System.Drawing.Point(618, 320);
            this.OpacitySetting.Name = "OpacitySetting";
            this.OpacitySetting.Size = new System.Drawing.Size(103, 27);
            this.OpacitySetting.TabIndex = 15;
            this.OpacitySetting.Text = "透明度设置";
            this.OpacitySetting.UseVisualStyleBackColor = true;
            this.OpacitySetting.Click += new System.EventHandler(this.Opacity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 381);
            this.Controls.Add(this.OpacitySetting);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.controlFilter);
            this.Controls.Add(this.checkFormFirst);
            this.Controls.Add(this.labelStatusDescription);
            this.Controls.Add(this.back_to_last);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.Text = "MySectionClip1.2";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button replace;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button back_to_last;
        private System.Windows.Forms.Label labelStatusDescription;
        private System.Windows.Forms.CheckBox checkFormFirst;
        private System.Windows.Forms.ComboBox controlFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button OpacitySetting;
    }
}

