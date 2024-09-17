using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalityServices
{
    public partial class ReportIssuesForm : MaterialForm
    {
        private MaterialTextBox txtLocation;
        private MaterialComboBox cmbCategory;
        private MaterialMultiLineTextBox richDescription;
        private MaterialButton btnAttach;
        private MaterialButton btnSubmit;
        private MaterialButton btnBack;
        private MaterialLabel lblLocation;
        private MaterialLabel lblCategory;
        private MaterialLabel lblDescription;
        private DataGridView dgvReportedIssues;
        private PictureBox pictureBoxPreview; // PictureBox to preview the attached image

      

        private void InitializeComponent()
        {
            this.txtLocation = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.richDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.btnAttach = new MaterialSkin.Controls.MaterialButton();
            this.btnSubmit = new MaterialSkin.Controls.MaterialButton();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.lblLocation = new MaterialSkin.Controls.MaterialLabel();
            this.lblCategory = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.dgvReportedIssues = new System.Windows.Forms.DataGridView();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportedIssues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.AnimateReadOnly = false;
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation.Depth = 0;
            this.txtLocation.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLocation.Hint = "Enter Location";
            this.txtLocation.LeadingIcon = null;
            this.txtLocation.Location = new System.Drawing.Point(15, 104);
            this.txtLocation.MaxLength = 50;
            this.txtLocation.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLocation.Multiline = false;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(250, 50);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.Text = "";
            this.txtLocation.TrailingIcon = null;
            // 
            // cmbCategory
            // 
            this.cmbCategory.AutoResize = false;
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategory.Depth = 0;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategory.DropDownHeight = 174;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.DropDownWidth = 121;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategory.IntegralHeight = false;
            this.cmbCategory.ItemHeight = 43;
            this.cmbCategory.Items.AddRange(new object[] {
            "Road Damage",
            "Water Leak",
            "Electricity Issue",
            "Sanitation",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(12, 193);
            this.cmbCategory.MaxDropDownItems = 4;
            this.cmbCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(250, 49);
            this.cmbCategory.StartIndex = 0;
            this.cmbCategory.TabIndex = 1;
            // 
            // richDescription
            // 
            this.richDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.richDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richDescription.Depth = 0;
            this.richDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.richDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.richDescription.Hint = "Enter description of the issue...";
            this.richDescription.Location = new System.Drawing.Point(12, 291);
            this.richDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.richDescription.Name = "richDescription";
            this.richDescription.Size = new System.Drawing.Size(250, 96);
            this.richDescription.TabIndex = 2;
            this.richDescription.Text = "";
            // 
            // btnAttach
            // 
            this.btnAttach.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAttach.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAttach.Depth = 0;
            this.btnAttach.HighEmphasis = true;
            this.btnAttach.Icon = null;
            this.btnAttach.Location = new System.Drawing.Point(24, 431);
            this.btnAttach.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAttach.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAttach.Size = new System.Drawing.Size(79, 36);
            this.btnAttach.TabIndex = 3;
            this.btnAttach.Text = "Attach";
            this.btnAttach.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAttach.UseAccentColor = false;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.HighEmphasis = true;
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(166, 431);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubmit.Size = new System.Drawing.Size(75, 36);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSubmit.UseAccentColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(1128, 431);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBack.Size = new System.Drawing.Size(64, 36);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.Depth = 0;
            this.lblLocation.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLocation.Location = new System.Drawing.Point(12, 77);
            this.lblLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(100, 24);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location:";
            // 
            // lblCategory
            // 
            this.lblCategory.Depth = 0;
            this.lblCategory.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCategory.Location = new System.Drawing.Point(12, 166);
            this.lblCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 24);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category:";
            // 
            // lblDescription
            // 
            this.lblDescription.Depth = 0;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescription.Location = new System.Drawing.Point(12, 264);
            this.lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 24);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // dgvReportedIssues
            // 
            this.dgvReportedIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportedIssues.Location = new System.Drawing.Point(300, 90);
            this.dgvReportedIssues.Name = "dgvReportedIssues";
            this.dgvReportedIssues.RowHeadersWidth = 51;
            this.dgvReportedIssues.RowTemplate.Height = 24;
            this.dgvReportedIssues.Size = new System.Drawing.Size(921, 297);
            this.dgvReportedIssues.TabIndex = 6;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(300, 400);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBoxPreview.Size = new System.Drawing.Size(300, 200);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 7;
            this.pictureBoxPreview.TabStop = false;

            // 
            // ReportIssuesForm
            // 
            this.ClientSize = new System.Drawing.Size(1262, 622);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.richDescription);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvReportedIssues);
            this.Controls.Add(this.pictureBoxPreview);
            this.Name = "ReportIssuesForm";
            this.Text = "Report-Issue";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportedIssues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
