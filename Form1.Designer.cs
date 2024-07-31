namespace LU1_Process_Demo_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxDisplay = new ListBox();
            btnThreads = new Button();
            btnLoadedModules = new Button();
            btnDetailsAppDomain = new Button();
            btnAssemblessAppDomain = new Button();
            btnStartChrome = new Button();
            btnKillChrome = new Button();
            btnEndTaskManger = new Button();
            SuspendLayout();
            // 
            // listBoxDisplay
            // 
            listBoxDisplay.FormattingEnabled = true;
            listBoxDisplay.Location = new Point(12, 51);
            listBoxDisplay.Name = "listBoxDisplay";
            listBoxDisplay.Size = new Size(679, 740);
            listBoxDisplay.TabIndex = 0;
            // 
            // btnThreads
            // 
            btnThreads.Location = new Point(78, 818);
            btnThreads.Name = "btnThreads";
            btnThreads.Size = new Size(235, 84);
            btnThreads.TabIndex = 1;
            btnThreads.Text = "Threads of Selected Process";
            btnThreads.UseVisualStyleBackColor = true;
            btnThreads.Click += btnThreads_Click;
            // 
            // btnLoadedModules
            // 
            btnLoadedModules.Location = new Point(394, 818);
            btnLoadedModules.Name = "btnLoadedModules";
            btnLoadedModules.Size = new Size(218, 88);
            btnLoadedModules.TabIndex = 2;
            btnLoadedModules.Text = "Loaded Modules of Selected Process";
            btnLoadedModules.UseVisualStyleBackColor = true;
            // 
            // btnDetailsAppDomain
            // 
            btnDetailsAppDomain.Location = new Point(78, 920);
            btnDetailsAppDomain.Name = "btnDetailsAppDomain";
            btnDetailsAppDomain.Size = new Size(235, 89);
            btnDetailsAppDomain.TabIndex = 3;
            btnDetailsAppDomain.Text = "Details of Current AppDomain";
            btnDetailsAppDomain.UseVisualStyleBackColor = true;
            // 
            // btnAssemblessAppDomain
            // 
            btnAssemblessAppDomain.Location = new Point(394, 929);
            btnAssemblessAppDomain.Name = "btnAssemblessAppDomain";
            btnAssemblessAppDomain.Size = new Size(218, 80);
            btnAssemblessAppDomain.TabIndex = 4;
            btnAssemblessAppDomain.Text = "Assembles in the AppDomain";
            btnAssemblessAppDomain.UseVisualStyleBackColor = true;
            // 
            // btnStartChrome
            // 
            btnStartChrome.Location = new Point(28, 1056);
            btnStartChrome.Name = "btnStartChrome";
            btnStartChrome.Size = new Size(193, 79);
            btnStartChrome.TabIndex = 5;
            btnStartChrome.Text = "Start Chrome";
            btnStartChrome.UseVisualStyleBackColor = true;
            btnStartChrome.Click += btnStartChrome_Click;
            // 
            // btnKillChrome
            // 
            btnKillChrome.Location = new Point(269, 1056);
            btnKillChrome.Name = "btnKillChrome";
            btnKillChrome.Size = new Size(178, 79);
            btnKillChrome.TabIndex = 6;
            btnKillChrome.Text = "Kill Chrome";
            btnKillChrome.UseVisualStyleBackColor = true;
            btnKillChrome.Click += btnKillChrome_Click;
            // 
            // btnEndTaskManger
            // 
            btnEndTaskManger.Location = new Point(500, 1056);
            btnEndTaskManger.Name = "btnEndTaskManger";
            btnEndTaskManger.Size = new Size(172, 77);
            btnEndTaskManger.TabIndex = 7;
            btnEndTaskManger.Text = "End Task Manager";
            btnEndTaskManger.UseVisualStyleBackColor = true;
            btnEndTaskManger.Click += btnEndTaskManger_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 1201);
            Controls.Add(btnEndTaskManger);
            Controls.Add(btnKillChrome);
            Controls.Add(btnStartChrome);
            Controls.Add(btnAssemblessAppDomain);
            Controls.Add(btnDetailsAppDomain);
            Controls.Add(btnLoadedModules);
            Controls.Add(btnThreads);
            Controls.Add(listBoxDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxDisplay;
        private Button btnThreads;
        private Button btnLoadedModules;
        private Button btnDetailsAppDomain;
        private Button btnAssemblessAppDomain;
        private Button btnStartChrome;
        private Button btnKillChrome;
        private Button btnEndTaskManger;
    }
}
