﻿
namespace CateringManager
{
    partial class ClientMenu
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
            this.components = new System.ComponentModel.Container();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cateringManagerDataSet1 = new CateringManager.CateringManagerDataSet1();
            this.clientMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientMenuTableAdapter = new CateringManager.CateringManagerDataSet1TableAdapters.ClientMenuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cateringManagerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientMenuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 30;
            this.dgv1.Size = new System.Drawing.Size(318, 698);
            this.dgv1.TabIndex = 0;
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv2.Location = new System.Drawing.Point(518, 0);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.RowHeadersWidth = 62;
            this.dgv2.RowTemplate.Height = 30;
            this.dgv2.Size = new System.Drawing.Size(365, 698);
            this.dgv2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(384, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 83);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加  >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(384, 344);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 76);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删除 <<";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 596);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "确定";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cateringManagerDataSet1
            // 
            this.cateringManagerDataSet1.DataSetName = "CateringManagerDataSet1";
            this.cateringManagerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientMenuBindingSource
            // 
            this.clientMenuBindingSource.DataMember = "ClientMenu";
            this.clientMenuBindingSource.DataSource = this.cateringManagerDataSet1;
            // 
            // clientMenuTableAdapter
            // 
            this.clientMenuTableAdapter.ClearBeforeFill = true;
            // 
            // ClientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 698);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Name = "ClientMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientMenu";
            this.Load += new System.EventHandler(this.ClientMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cateringManagerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientMenuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button button3;
        private CateringManagerDataSet1 cateringManagerDataSet1;
        private System.Windows.Forms.BindingSource clientMenuBindingSource;
        private CateringManagerDataSet1TableAdapters.ClientMenuTableAdapter clientMenuTableAdapter;
    }
}