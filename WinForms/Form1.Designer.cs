namespace WinForms
{
    partial class Form1
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
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.keyboardActiveBtn = new System.Windows.Forms.Button();
            this.mouseActiveBtn = new System.Windows.Forms.Button();
            this.keyboardActiveLabel = new System.Windows.Forms.Label();
            this.mouseActiveLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.latestApplicationBtn = new System.Windows.Forms.Button();
            this.getAllUsedApplicationBtn = new System.Windows.Forms.Button();
            this.appOutput = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(179, 24);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(112, 35);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(318, 24);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(112, 35);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // keyboardActiveBtn
            // 
            this.keyboardActiveBtn.Location = new System.Drawing.Point(28, 120);
            this.keyboardActiveBtn.Name = "keyboardActiveBtn";
            this.keyboardActiveBtn.Size = new System.Drawing.Size(228, 23);
            this.keyboardActiveBtn.TabIndex = 2;
            this.keyboardActiveBtn.Text = "Get Last Keyboard Active Time";
            this.keyboardActiveBtn.UseVisualStyleBackColor = true;
            this.keyboardActiveBtn.Click += new System.EventHandler(this.keyboardActiveBtn_Click);
            // 
            // mouseActiveBtn
            // 
            this.mouseActiveBtn.Location = new System.Drawing.Point(28, 176);
            this.mouseActiveBtn.Name = "mouseActiveBtn";
            this.mouseActiveBtn.Size = new System.Drawing.Size(228, 23);
            this.mouseActiveBtn.TabIndex = 3;
            this.mouseActiveBtn.Text = "Get Last Mouse Active Time";
            this.mouseActiveBtn.UseVisualStyleBackColor = true;
            this.mouseActiveBtn.Click += new System.EventHandler(this.mouseActiveBtn_Click);
            // 
            // keyboardActiveLabel
            // 
            this.keyboardActiveLabel.AutoSize = true;
            this.keyboardActiveLabel.Location = new System.Drawing.Point(328, 125);
            this.keyboardActiveLabel.Name = "keyboardActiveLabel";
            this.keyboardActiveLabel.Size = new System.Drawing.Size(58, 13);
            this.keyboardActiveLabel.TabIndex = 4;
            this.keyboardActiveLabel.Text = "No Activity";
            // 
            // mouseActiveLabel
            // 
            this.mouseActiveLabel.AutoSize = true;
            this.mouseActiveLabel.Location = new System.Drawing.Point(328, 181);
            this.mouseActiveLabel.Name = "mouseActiveLabel";
            this.mouseActiveLabel.Size = new System.Drawing.Size(58, 13);
            this.mouseActiveLabel.TabIndex = 5;
            this.mouseActiveLabel.Text = "No Activity";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(676, 24);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(112, 35);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // latestApplicationBtn
            // 
            this.latestApplicationBtn.Location = new System.Drawing.Point(28, 234);
            this.latestApplicationBtn.Name = "latestApplicationBtn";
            this.latestApplicationBtn.Size = new System.Drawing.Size(228, 23);
            this.latestApplicationBtn.TabIndex = 7;
            this.latestApplicationBtn.Text = "Get Latest Application";
            this.latestApplicationBtn.UseVisualStyleBackColor = true;
            this.latestApplicationBtn.Click += new System.EventHandler(this.latestApplicationBtn_Click);
            // 
            // getAllUsedApplicationBtn
            // 
            this.getAllUsedApplicationBtn.Location = new System.Drawing.Point(346, 234);
            this.getAllUsedApplicationBtn.Name = "getAllUsedApplicationBtn";
            this.getAllUsedApplicationBtn.Size = new System.Drawing.Size(228, 23);
            this.getAllUsedApplicationBtn.TabIndex = 8;
            this.getAllUsedApplicationBtn.Text = "Get All Used Application";
            this.getAllUsedApplicationBtn.UseVisualStyleBackColor = true;
            this.getAllUsedApplicationBtn.Click += new System.EventHandler(this.getAllUsedApplicationBtn_Click);
            // 
            // appOutput
            // 
            this.appOutput.Location = new System.Drawing.Point(28, 285);
            this.appOutput.Multiline = true;
            this.appOutput.Name = "appOutput";
            this.appOutput.ReadOnly = true;
            this.appOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.appOutput.Size = new System.Drawing.Size(720, 139);
            this.appOutput.TabIndex = 9;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(25, 35);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(85, 13);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Listener active...";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(451, 24);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(112, 35);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.appOutput);
            this.Controls.Add(this.getAllUsedApplicationBtn);
            this.Controls.Add(this.latestApplicationBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.mouseActiveLabel);
            this.Controls.Add(this.keyboardActiveLabel);
            this.Controls.Add(this.mouseActiveBtn);
            this.Controls.Add(this.keyboardActiveBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button keyboardActiveBtn;
        private System.Windows.Forms.Button mouseActiveBtn;
        private System.Windows.Forms.Label keyboardActiveLabel;
        private System.Windows.Forms.Label mouseActiveLabel;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button latestApplicationBtn;
        private System.Windows.Forms.Button getAllUsedApplicationBtn;
        private System.Windows.Forms.TextBox appOutput;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button clearBtn;
    }
}

