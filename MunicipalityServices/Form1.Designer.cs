using MaterialSkin.Controls;
using System.Drawing;

namespace MunicipalityServices
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialButton btnReportIssues;
        private MaterialSkin.Controls.MaterialButton btnLocalEvents;
        private MaterialSkin.Controls.MaterialButton btnServiceRequest;
        private MaterialSkin.Controls.MaterialButton btnExit; // Exit button
        private MaterialSwitch toggleThemeSwitch; // Switch to toggle between light and dark theme

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnReportIssues = new MaterialSkin.Controls.MaterialButton();
            this.btnLocalEvents = new MaterialSkin.Controls.MaterialButton();
            this.btnServiceRequest = new MaterialSkin.Controls.MaterialButton();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.toggleThemeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.SuspendLayout();
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReportIssues.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReportIssues.Depth = 0;
            this.btnReportIssues.HighEmphasis = true;
            this.btnReportIssues.Icon = null;
            this.btnReportIssues.Location = new System.Drawing.Point(227, 191);
            this.btnReportIssues.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReportIssues.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReportIssues.Size = new System.Drawing.Size(129, 36);
            this.btnReportIssues.TabIndex = 2;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReportIssues.UseAccentColor = false;
            this.btnReportIssues.UseVisualStyleBackColor = true;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnLocalEvents
            // 
            this.btnLocalEvents.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLocalEvents.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLocalEvents.Depth = 0;
            this.btnLocalEvents.Enabled = false;
            this.btnLocalEvents.HighEmphasis = true;
            this.btnLocalEvents.Icon = null;
            this.btnLocalEvents.Location = new System.Drawing.Point(227, 122);
            this.btnLocalEvents.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLocalEvents.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLocalEvents.Name = "btnLocalEvents";
            this.btnLocalEvents.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLocalEvents.Size = new System.Drawing.Size(125, 36);
            this.btnLocalEvents.TabIndex = 1;
            this.btnLocalEvents.Text = "Local Events";
            this.btnLocalEvents.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLocalEvents.UseAccentColor = false;
            this.btnLocalEvents.UseVisualStyleBackColor = true;
            // 
            // btnServiceRequest
            // 
            this.btnServiceRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnServiceRequest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnServiceRequest.Depth = 0;
            this.btnServiceRequest.Enabled = false;
            this.btnServiceRequest.HighEmphasis = true;
            this.btnServiceRequest.Icon = null;
            this.btnServiceRequest.Location = new System.Drawing.Point(227, 257);
            this.btnServiceRequest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnServiceRequest.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnServiceRequest.Name = "btnServiceRequest";
            this.btnServiceRequest.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnServiceRequest.Size = new System.Drawing.Size(147, 36);
            this.btnServiceRequest.TabIndex = 0;
            this.btnServiceRequest.Text = "Service Request";
            this.btnServiceRequest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnServiceRequest.UseAccentColor = false;
            this.btnServiceRequest.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExit.Depth = 0;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(464, 350);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExit.Size = new System.Drawing.Size(64, 36);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toggleThemeSwitch
            // 
            this.toggleThemeSwitch.AutoSize = true;
            this.toggleThemeSwitch.Depth = 0;
            this.toggleThemeSwitch.Location = new System.Drawing.Point(44, 351);
            this.toggleThemeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.toggleThemeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.toggleThemeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.toggleThemeSwitch.Name = "toggleThemeSwitch";
            this.toggleThemeSwitch.Ripple = true;
            this.toggleThemeSwitch.Size = new System.Drawing.Size(144, 37);
            this.toggleThemeSwitch.TabIndex = 3;
            this.toggleThemeSwitch.Text = "Dark Theme";
            this.toggleThemeSwitch.UseVisualStyleBackColor = true;
            this.toggleThemeSwitch.CheckedChanged += new System.EventHandler(this.toggleThemeSwitch_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 441);
            this.Controls.Add(this.btnServiceRequest);
            this.Controls.Add(this.btnLocalEvents);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.toggleThemeSwitch);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Municipality";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

