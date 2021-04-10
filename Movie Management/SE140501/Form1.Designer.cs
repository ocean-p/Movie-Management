
namespace SE140501
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtgenre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlength = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnew = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.movielist = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtgenre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtlength);
            this.groupBox1.Controls.Add(this.txtyear);
            this.groupBox1.Controls.Add(this.txttitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(52, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 222);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie Detail";
            // 
            // txtgenre
            // 
            this.txtgenre.Location = new System.Drawing.Point(74, 182);
            this.txtgenre.Name = "txtgenre";
            this.txtgenre.Size = new System.Drawing.Size(157, 23);
            this.txtgenre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Genre";
            // 
            // txtlength
            // 
            this.txtlength.Location = new System.Drawing.Point(74, 130);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(157, 23);
            this.txtlength.TabIndex = 5;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(74, 84);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(157, 23);
            this.txtyear.TabIndex = 4;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(74, 32);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(157, 23);
            this.txttitle.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title";
            // 
            // btnew
            // 
            this.btnew.Location = new System.Drawing.Point(72, 329);
            this.btnew.Name = "btnew";
            this.btnew.Size = new System.Drawing.Size(73, 25);
            this.btnew.TabIndex = 3;
            this.btnew.Text = "New";
            this.btnew.UseVisualStyleBackColor = true;
            this.btnew.Click += new System.EventHandler(this.btnew_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(204, 329);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(73, 25);
            this.btadd.TabIndex = 4;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(72, 376);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(73, 24);
            this.btupdate.TabIndex = 5;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(204, 376);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(73, 24);
            this.btdelete.TabIndex = 6;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // movielist
            // 
            this.movielist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.movielist.FullRowSelect = true;
            this.movielist.HideSelection = false;
            this.movielist.Location = new System.Drawing.Point(438, 24);
            this.movielist.MultiSelect = false;
            this.movielist.Name = "movielist";
            this.movielist.Size = new System.Drawing.Size(406, 388);
            this.movielist.TabIndex = 7;
            this.movielist.UseCompatibleStateImageBehavior = false;
            this.movielist.View = System.Windows.Forms.View.Details;
            this.movielist.SelectedIndexChanged += new System.EventHandler(this.humanlist_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TITLE";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "YEAR";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LENGTH";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "GENRE";
            this.columnHeader4.Width = 100;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(72, 421);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(205, 27);
            this.btexit.TabIndex = 8;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 473);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.movielist);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.btnew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtlength;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnew;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.ListView movielist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtgenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btexit;
    }
}

