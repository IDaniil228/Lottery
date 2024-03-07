namespace DZ
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureOfTicket = new System.Windows.Forms.PictureBox();
            this.ListOfEntity = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.bntClose = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.info_5 = new System.Windows.Forms.Label();
            this.info_4 = new System.Windows.Forms.Label();
            this.info_3 = new System.Windows.Forms.Label();
            this.info_1 = new System.Windows.Forms.Label();
            this.info_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Gold;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.pictureOfTicket);
            this.splitContainer1.Panel1.Controls.Add(this.ListOfEntity);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(704, 503);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.SplitterWidth = 15;
            this.splitContainer1.TabIndex = 3;
            // 
            // pictureOfTicket
            // 
            this.pictureOfTicket.Image = global::DZ.Properties.Resources.Ticket;
            this.pictureOfTicket.Location = new System.Drawing.Point(3, 3);
            this.pictureOfTicket.Name = "pictureOfTicket";
            this.pictureOfTicket.Size = new System.Drawing.Size(193, 112);
            this.pictureOfTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOfTicket.TabIndex = 1;
            this.pictureOfTicket.TabStop = false;
            // 
            // ListOfEntity
            // 
            this.ListOfEntity.ImageKey = "Tree.png";
            this.ListOfEntity.Location = new System.Drawing.Point(0, 121);
            this.ListOfEntity.Name = "ListOfEntity";
            this.ListOfEntity.Size = new System.Drawing.Size(196, 382);
            this.ListOfEntity.TabIndex = 0;
            this.ListOfEntity.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ListOfEntity_AfterSelect);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Gold;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.bntClose);
            this.splitContainer2.Panel1.Controls.Add(this.btnShow);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoad);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(486, 503);
            this.splitContainer2.SplitterDistance = 88;
            this.splitContainer2.SplitterWidth = 20;
            this.splitContainer2.TabIndex = 4;
            // 
            // bntClose
            // 
            this.bntClose.BackColor = System.Drawing.Color.Gold;
            this.bntClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntClose.Location = new System.Drawing.Point(321, 12);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(143, 64);
            this.bntClose.TabIndex = 2;
            this.bntClose.Text = "Закрыть";
            this.bntClose.UseVisualStyleBackColor = false;
            this.bntClose.Click += new System.EventHandler(this.bntClose_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Gold;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShow.Location = new System.Drawing.Point(172, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(143, 64);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Показать";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Gold;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoad.Location = new System.Drawing.Point(23, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(143, 64);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.info_5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.info_4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.info_3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.info_1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.info_2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 395);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // info_5
            // 
            this.info_5.AutoSize = true;
            this.info_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_5.Location = new System.Drawing.Point(3, 316);
            this.info_5.Name = "info_5";
            this.info_5.Size = new System.Drawing.Size(480, 79);
            this.info_5.TabIndex = 9;
            this.info_5.Text = "5";
            this.info_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_4
            // 
            this.info_4.AutoSize = true;
            this.info_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_4.Location = new System.Drawing.Point(3, 237);
            this.info_4.Name = "info_4";
            this.info_4.Size = new System.Drawing.Size(480, 79);
            this.info_4.TabIndex = 8;
            this.info_4.Text = "4";
            this.info_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_3
            // 
            this.info_3.AutoSize = true;
            this.info_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_3.Location = new System.Drawing.Point(3, 158);
            this.info_3.Name = "info_3";
            this.info_3.Size = new System.Drawing.Size(480, 79);
            this.info_3.TabIndex = 7;
            this.info_3.Text = "3";
            this.info_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_1
            // 
            this.info_1.AutoSize = true;
            this.info_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_1.Location = new System.Drawing.Point(3, 0);
            this.info_1.Name = "info_1";
            this.info_1.Size = new System.Drawing.Size(480, 79);
            this.info_1.TabIndex = 5;
            this.info_1.Text = "1";
            this.info_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_2
            // 
            this.info_2.AutoSize = true;
            this.info_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_2.Location = new System.Drawing.Point(3, 79);
            this.info_2.Name = "info_2";
            this.info_2.Size = new System.Drawing.Size(480, 79);
            this.info_2.TabIndex = 6;
            this.info_2.Text = "2";
            this.info_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(704, 503);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Лотерея";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfTicket)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView ListOfEntity;
        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label info_1;
        private System.Windows.Forms.Label info_2;
        private System.Windows.Forms.Label info_5;
        private System.Windows.Forms.Label info_4;
        private System.Windows.Forms.Label info_3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureOfTicket;
    }
}

