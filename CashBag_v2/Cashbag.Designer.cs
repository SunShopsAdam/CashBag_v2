namespace CashBag_v2
{
    partial class Cashbag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashbag));
            this.sc_main = new System.Windows.Forms.SplitContainer();
            this.tc_bagdisplay = new System.Windows.Forms.TabControl();
            this.tp_viewByStore = new System.Windows.Forms.TabPage();
            this.tv_viewByStore = new System.Windows.Forms.TreeView();
            this.tp_viewByBag = new System.Windows.Forms.TabPage();
            this.tv_viewByBag = new System.Windows.Forms.TreeView();
            this.lblTransferBag = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).BeginInit();
            this.sc_main.Panel1.SuspendLayout();
            this.sc_main.Panel2.SuspendLayout();
            this.sc_main.SuspendLayout();
            this.tc_bagdisplay.SuspendLayout();
            this.tp_viewByStore.SuspendLayout();
            this.tp_viewByBag.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_main
            // 
            this.sc_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_main.Location = new System.Drawing.Point(0, 0);
            this.sc_main.Name = "sc_main";
            this.sc_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_main.Panel1
            // 
            this.sc_main.Panel1.Controls.Add(this.tc_bagdisplay);
            // 
            // sc_main.Panel2
            // 
            this.sc_main.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sc_main.Panel2.Controls.Add(this.btnRefresh);
            this.sc_main.Panel2.Controls.Add(this.textBox1);
            this.sc_main.Panel2.Controls.Add(this.lblTransferBag);
            this.sc_main.Size = new System.Drawing.Size(667, 396);
            this.sc_main.SplitterDistance = 346;
            this.sc_main.SplitterWidth = 1;
            this.sc_main.TabIndex = 1;
            // 
            // tc_bagdisplay
            // 
            this.tc_bagdisplay.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tc_bagdisplay.Controls.Add(this.tp_viewByStore);
            this.tc_bagdisplay.Controls.Add(this.tp_viewByBag);
            this.tc_bagdisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_bagdisplay.Location = new System.Drawing.Point(0, 0);
            this.tc_bagdisplay.Multiline = true;
            this.tc_bagdisplay.Name = "tc_bagdisplay";
            this.tc_bagdisplay.SelectedIndex = 0;
            this.tc_bagdisplay.Size = new System.Drawing.Size(665, 344);
            this.tc_bagdisplay.TabIndex = 0;
            // 
            // tp_viewByStore
            // 
            this.tp_viewByStore.Controls.Add(this.tv_viewByStore);
            this.tp_viewByStore.Location = new System.Drawing.Point(23, 4);
            this.tp_viewByStore.Name = "tp_viewByStore";
            this.tp_viewByStore.Padding = new System.Windows.Forms.Padding(3);
            this.tp_viewByStore.Size = new System.Drawing.Size(638, 336);
            this.tp_viewByStore.TabIndex = 0;
            this.tp_viewByStore.Text = "View By Store";
            this.tp_viewByStore.UseVisualStyleBackColor = true;
            // 
            // tv_viewByStore
            // 
            this.tv_viewByStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_viewByStore.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_viewByStore.Location = new System.Drawing.Point(3, 3);
            this.tv_viewByStore.Name = "tv_viewByStore";
            this.tv_viewByStore.Size = new System.Drawing.Size(632, 330);
            this.tv_viewByStore.TabIndex = 0;
            this.tv_viewByStore.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_viewByStore_AfterSelect);
            // 
            // tp_viewByBag
            // 
            this.tp_viewByBag.Controls.Add(this.tv_viewByBag);
            this.tp_viewByBag.Location = new System.Drawing.Point(23, 4);
            this.tp_viewByBag.Name = "tp_viewByBag";
            this.tp_viewByBag.Padding = new System.Windows.Forms.Padding(3);
            this.tp_viewByBag.Size = new System.Drawing.Size(638, 336);
            this.tp_viewByBag.TabIndex = 1;
            this.tp_viewByBag.Text = "View By Bag";
            this.tp_viewByBag.UseVisualStyleBackColor = true;
            // 
            // tv_viewByBag
            // 
            this.tv_viewByBag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_viewByBag.Location = new System.Drawing.Point(3, 3);
            this.tv_viewByBag.Name = "tv_viewByBag";
            this.tv_viewByBag.Size = new System.Drawing.Size(632, 330);
            this.tv_viewByBag.TabIndex = 0;
            // 
            // lblTransferBag
            // 
            this.lblTransferBag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransferBag.Font = new System.Drawing.Font("Norwester", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferBag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTransferBag.Location = new System.Drawing.Point(0, 0);
            this.lblTransferBag.Name = "lblTransferBag";
            this.lblTransferBag.Size = new System.Drawing.Size(665, 47);
            this.lblTransferBag.TabIndex = 0;
            this.lblTransferBag.Text = "Transfer Bag To";
            this.lblTransferBag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(111, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cashbag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 396);
            this.Controls.Add(this.sc_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cashbag";
            this.Text = "Cashbag";
            this.Load += new System.EventHandler(this.Cashbag_Load);
            this.sc_main.Panel1.ResumeLayout(false);
            this.sc_main.Panel2.ResumeLayout(false);
            this.sc_main.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).EndInit();
            this.sc_main.ResumeLayout(false);
            this.tc_bagdisplay.ResumeLayout(false);
            this.tp_viewByStore.ResumeLayout(false);
            this.tp_viewByBag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_main;
        private System.Windows.Forms.TabControl tc_bagdisplay;
        private System.Windows.Forms.TabPage tp_viewByStore;
        private System.Windows.Forms.TabPage tp_viewByBag;
        private System.Windows.Forms.TreeView tv_viewByStore;
        private System.Windows.Forms.TreeView tv_viewByBag;
        private System.Windows.Forms.Label lblTransferBag;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRefresh;
    }
}

