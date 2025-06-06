﻿namespace AutodeskApplication
{
    partial class AdminAssetEditForm
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
            this.tableLayoutEditForm = new System.Windows.Forms.TableLayoutPanel();
            this.txtEditAssetName = new System.Windows.Forms.TextBox();
            this.lblAssetName = new System.Windows.Forms.Label();
            this.lblAssetDescription = new System.Windows.Forms.Label();
            this.txtEditDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBrowseModel = new System.Windows.Forms.Button();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pic2DPreview = new System.Windows.Forms.PictureBox();
            this.eleHost3D = new System.Windows.Forms.Integration.ElementHost();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.elementHost3D = new System.Windows.Forms.Integration.ElementHost();
            this.lblImagePath = new System.Windows.Forms.Label();
            this.lblModelPath = new System.Windows.Forms.Label();
            this.tableLayoutEditForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2DPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutEditForm
            // 
            this.tableLayoutEditForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutEditForm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutEditForm.ColumnCount = 5;
            this.tableLayoutEditForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.47561F));
            this.tableLayoutEditForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.52439F));
            this.tableLayoutEditForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutEditForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tableLayoutEditForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutEditForm.Controls.Add(this.txtEditAssetName, 1, 1);
            this.tableLayoutEditForm.Controls.Add(this.lblAssetName, 0, 1);
            this.tableLayoutEditForm.Controls.Add(this.lblAssetDescription, 2, 1);
            this.tableLayoutEditForm.Controls.Add(this.txtEditDescription, 3, 1);
            this.tableLayoutEditForm.Controls.Add(this.label3, 0, 2);
            this.tableLayoutEditForm.Controls.Add(this.Label5, 2, 2);
            this.tableLayoutEditForm.Controls.Add(this.btnSave, 2, 5);
            this.tableLayoutEditForm.Controls.Add(this.btnBrowseModel, 1, 4);
            this.tableLayoutEditForm.Controls.Add(this.btnBrowseImage, 3, 4);
            this.tableLayoutEditForm.Controls.Add(this.label6, 2, 0);
            this.tableLayoutEditForm.Controls.Add(this.pic2DPreview, 3, 2);
            this.tableLayoutEditForm.Controls.Add(this.eleHost3D, 1, 2);
            this.tableLayoutEditForm.Location = new System.Drawing.Point(-1, 0);
            this.tableLayoutEditForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutEditForm.Name = "tableLayoutEditForm";
            this.tableLayoutEditForm.RowCount = 6;
            this.tableLayoutEditForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.78161F));
            this.tableLayoutEditForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.70115F));
            this.tableLayoutEditForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.17241F));
            this.tableLayoutEditForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.965517F));
            this.tableLayoutEditForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.37931F));
            this.tableLayoutEditForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutEditForm.Size = new System.Drawing.Size(1370, 960);
            this.tableLayoutEditForm.TabIndex = 0;
            // 
            // txtEditAssetName
            // 
            this.txtEditAssetName.Location = new System.Drawing.Point(118, 140);
            this.txtEditAssetName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditAssetName.Name = "txtEditAssetName";
            this.txtEditAssetName.Size = new System.Drawing.Size(330, 26);
            this.txtEditAssetName.TabIndex = 1;
            // 
            // lblAssetName
            // 
            this.lblAssetName.AutoSize = true;
            this.lblAssetName.Location = new System.Drawing.Point(4, 135);
            this.lblAssetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssetName.Name = "lblAssetName";
            this.lblAssetName.Size = new System.Drawing.Size(100, 20);
            this.lblAssetName.TabIndex = 0;
            this.lblAssetName.Text = "Asset Name:";
            // 
            // lblAssetDescription
            // 
            this.lblAssetDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssetDescription.AutoSize = true;
            this.lblAssetDescription.Location = new System.Drawing.Point(660, 135);
            this.lblAssetDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssetDescription.Name = "lblAssetDescription";
            this.lblAssetDescription.Size = new System.Drawing.Size(93, 20);
            this.lblAssetDescription.TabIndex = 0;
            this.lblAssetDescription.Text = "Description:";
            this.lblAssetDescription.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEditDescription
            // 
            this.txtEditDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditDescription.Location = new System.Drawing.Point(761, 140);
            this.txtEditDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditDescription.Multiline = true;
            this.txtEditDescription.Name = "txtEditDescription";
            this.txtEditDescription.Size = new System.Drawing.Size(360, 132);
            this.txtEditDescription.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "3D Preview:";
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(661, 277);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(92, 20);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "2D Preview:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(489, 809);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(262, 75);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnBrowseModel
            // 
            this.btnBrowseModel.Location = new System.Drawing.Point(118, 637);
            this.btnBrowseModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseModel.Name = "btnBrowseModel";
            this.btnBrowseModel.Size = new System.Drawing.Size(363, 57);
            this.btnBrowseModel.TabIndex = 2;
            this.btnBrowseModel.Text = "Browse 3D";
            this.btnBrowseModel.UseVisualStyleBackColor = true;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(761, 637);
            this.btnBrowseImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(328, 52);
            this.btnBrowseImage.TabIndex = 2;
            this.btnBrowseImage.Text = "Browse 2D";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(489, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 135);
            this.label6.TabIndex = 3;
            this.label6.Text = "Edit Models";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic2DPreview
            // 
            this.pic2DPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic2DPreview.Location = new System.Drawing.Point(761, 282);
            this.pic2DPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic2DPreview.Name = "pic2DPreview";
            this.pic2DPreview.Size = new System.Drawing.Size(360, 273);
            this.pic2DPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic2DPreview.TabIndex = 4;
            this.pic2DPreview.TabStop = false;
            // 
            // eleHost3D
            // 
            this.eleHost3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eleHost3D.Location = new System.Drawing.Point(118, 282);
            this.eleHost3D.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eleHost3D.Name = "eleHost3D";
            this.eleHost3D.Size = new System.Drawing.Size(363, 273);
            this.eleHost3D.TabIndex = 5;
            this.eleHost3D.Text = "elementHost1";
            this.eleHost3D.Child = null;
            // 
            // picPreview
            // 
            this.picPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPreview.Location = new System.Drawing.Point(590, 182);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(299, 177);
            this.picPreview.TabIndex = 6;
            this.picPreview.TabStop = false;
            // 
            // elementHost3D
            // 
            this.elementHost3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost3D.Location = new System.Drawing.Point(87, 182);
            this.elementHost3D.Name = "elementHost3D";
            this.elementHost3D.Size = new System.Drawing.Size(299, 177);
            this.elementHost3D.TabIndex = 0;
            this.elementHost3D.Text = "elementHost1";
            this.elementHost3D.Child = null;
            // 
            // lblImagePath
            // 
            this.lblImagePath.AutoSize = true;
            this.lblImagePath.Location = new System.Drawing.Point(590, 362);
            this.lblImagePath.Name = "lblImagePath";
            this.lblImagePath.Size = new System.Drawing.Size(61, 13);
            this.lblImagePath.TabIndex = 7;
            this.lblImagePath.Text = "Image Path";
            // 
            // lblModelPath
            // 
            this.lblModelPath.AutoSize = true;
            this.lblModelPath.Location = new System.Drawing.Point(87, 362);
            this.lblModelPath.Name = "lblModelPath";
            this.lblModelPath.Size = new System.Drawing.Size(61, 13);
            this.lblModelPath.TabIndex = 8;
            this.lblModelPath.Text = "Model Path";
            // 
            // AdminAssetEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutEditForm);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminAssetEditForm";
            this.Size = new System.Drawing.Size(1368, 960);
            this.Load += new System.EventHandler(this.AdminAssetEditForm_Load);
            this.tableLayoutEditForm.ResumeLayout(false);
            this.tableLayoutEditForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2DPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutEditForm;
        private System.Windows.Forms.Label lblAssetName;
        private System.Windows.Forms.TextBox txtEditAssetName;
        private System.Windows.Forms.Label lblAssetDescription;
        private System.Windows.Forms.TextBox txtEditDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseModel;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Integration.ElementHost elementHost3D;
        private System.Windows.Forms.Label lblImagePath;
        private System.Windows.Forms.Label lblModelPath;
        private System.Windows.Forms.PictureBox pic2DPreview;
        private System.Windows.Forms.Integration.ElementHost eleHost3D;
    }
}