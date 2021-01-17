
namespace TransformTool
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbx_inputpath = new System.Windows.Forms.TextBox();
            this.btn_transform = new System.Windows.Forms.Button();
            this.btn_input = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbx_inputpath
            // 
            this.tbx_inputpath.Location = new System.Drawing.Point(25, 57);
            this.tbx_inputpath.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_inputpath.Name = "tbx_inputpath";
            this.tbx_inputpath.Size = new System.Drawing.Size(373, 21);
            this.tbx_inputpath.TabIndex = 0;
            // 
            // btn_transform
            // 
            this.btn_transform.Location = new System.Drawing.Point(116, 106);
            this.btn_transform.Margin = new System.Windows.Forms.Padding(2);
            this.btn_transform.Name = "btn_transform";
            this.btn_transform.Size = new System.Drawing.Size(178, 41);
            this.btn_transform.TabIndex = 2;
            this.btn_transform.Text = "转换";
            this.btn_transform.UseVisualStyleBackColor = true;
            this.btn_transform.Click += new System.EventHandler(this.btn_transform_Click);
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(401, 57);
            this.btn_input.Margin = new System.Windows.Forms.Padding(2);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(56, 20);
            this.btn_input.TabIndex = 3;
            this.btn_input.Text = "浏览";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(321, 120);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "电表";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 179);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.btn_transform);
            this.Controls.Add(this.tbx_inputpath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "数据转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tbx_inputpath;
        private System.Windows.Forms.Button btn_transform;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

