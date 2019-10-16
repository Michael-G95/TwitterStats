namespace Social_Media
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHandle = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.tbxHandle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxHandle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(472, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblTitle.Location = new System.Drawing.Point(26, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(528, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Social Media - Twitter Stats";
            // 
            // lblHandle
            // 
            this.lblHandle.AutoSize = true;
            this.lblHandle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.lblHandle.Location = new System.Drawing.Point(37, 83);
            this.lblHandle.Name = "lblHandle";
            this.lblHandle.Size = new System.Drawing.Size(517, 23);
            this.lblHandle.TabIndex = 3;
            this.lblHandle.Text = "Please enter a screen name to display from the web:";
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Transparent;
            this.btnGo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGo.BackgroundImage")));
            this.btnGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGo.Location = new System.Drawing.Point(234, 249);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(100, 100);
            this.btnGo.TabIndex = 4;
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbxHandle
            // 
            this.tbxHandle.Location = new System.Drawing.Point(202, 124);
            this.tbxHandle.Name = "tbxHandle";
            this.tbxHandle.Size = new System.Drawing.Size(190, 20);
            this.tbxHandle.TabIndex = 5;
            this.tbxHandle.TextChanged += new System.EventHandler(this.tbxHandle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(43, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alternatively, choose a name to display saved data:";
            // 
            // cbxHandle
            // 
            this.cbxHandle.BackColor = System.Drawing.Color.White;
            this.cbxHandle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHandle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxHandle.FormattingEnabled = true;
            this.cbxHandle.Location = new System.Drawing.Point(202, 200);
            this.cbxHandle.Name = "cbxHandle";
            this.cbxHandle.Size = new System.Drawing.Size(190, 21);
            this.cbxHandle.TabIndex = 7;
            this.cbxHandle.SelectedIndexChanged += new System.EventHandler(this.cbxHandle_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.cbxHandle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxHandle);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblHandle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Social Media";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lblHandle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxHandle;
        private System.Windows.Forms.ComboBox cbxHandle;
        private System.Windows.Forms.Label label1;
    }
}

