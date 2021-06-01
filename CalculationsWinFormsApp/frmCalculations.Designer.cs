
namespace CalculationsWinFormsApp
{
    partial class frmCalculations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculations));
            this.lblFactorial1 = new System.Windows.Forms.Label();
            this.lblFactorial2 = new System.Windows.Forms.Label();
            this.lblAddTwo = new System.Windows.Forms.Label();
            this.lblRunLoops = new System.Windows.Forms.Label();
            this.lblTotalCalculations = new System.Windows.Forms.Label();
            this.btnFactorial1 = new System.Windows.Forms.Button();
            this.btnFactorial2 = new System.Windows.Forms.Button();
            this.btnAddTwo = new System.Windows.Forms.Button();
            this.btnRunLoops = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFactorial1
            // 
            resources.ApplyResources(this.lblFactorial1, "lblFactorial1");
            this.lblFactorial1.Name = "lblFactorial1";
            // 
            // lblFactorial2
            // 
            resources.ApplyResources(this.lblFactorial2, "lblFactorial2");
            this.lblFactorial2.Name = "lblFactorial2";
            // 
            // lblAddTwo
            // 
            resources.ApplyResources(this.lblAddTwo, "lblAddTwo");
            this.lblAddTwo.Name = "lblAddTwo";
            // 
            // lblRunLoops
            // 
            resources.ApplyResources(this.lblRunLoops, "lblRunLoops");
            this.lblRunLoops.Name = "lblRunLoops";
            // 
            // lblTotalCalculations
            // 
            resources.ApplyResources(this.lblTotalCalculations, "lblTotalCalculations");
            this.lblTotalCalculations.Name = "lblTotalCalculations";
            // 
            // btnFactorial1
            // 
            resources.ApplyResources(this.btnFactorial1, "btnFactorial1");
            this.btnFactorial1.Name = "btnFactorial1";
            this.btnFactorial1.UseVisualStyleBackColor = true;
            this.btnFactorial1.Click += new System.EventHandler(this.btnFactorial1_Click);
            // 
            // btnFactorial2
            // 
            resources.ApplyResources(this.btnFactorial2, "btnFactorial2");
            this.btnFactorial2.Name = "btnFactorial2";
            this.btnFactorial2.UseVisualStyleBackColor = true;
            this.btnFactorial2.Click += new System.EventHandler(this.btnFactorial2_Click);
            // 
            // btnAddTwo
            // 
            resources.ApplyResources(this.btnAddTwo, "btnAddTwo");
            this.btnAddTwo.Name = "btnAddTwo";
            this.btnAddTwo.UseVisualStyleBackColor = true;
            this.btnAddTwo.Click += new System.EventHandler(this.btnAddTwo_Click);
            // 
            // btnRunLoops
            // 
            resources.ApplyResources(this.btnRunLoops, "btnRunLoops");
            this.btnRunLoops.Name = "btnRunLoops";
            this.btnRunLoops.UseVisualStyleBackColor = true;
            this.btnRunLoops.Click += new System.EventHandler(this.btnRunLoops_Click);
            // 
            // txtValue
            // 
            resources.ApplyResources(this.txtValue, "txtValue");
            this.txtValue.Name = "txtValue";
            // 
            // frmCalculations
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnRunLoops);
            this.Controls.Add(this.btnAddTwo);
            this.Controls.Add(this.btnFactorial2);
            this.Controls.Add(this.btnFactorial1);
            this.Controls.Add(this.lblTotalCalculations);
            this.Controls.Add(this.lblRunLoops);
            this.Controls.Add(this.lblAddTwo);
            this.Controls.Add(this.lblFactorial2);
            this.Controls.Add(this.lblFactorial1);
            this.Name = "frmCalculations";
            this.Load += new System.EventHandler(this.frmCalculations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFactorial1;
        private System.Windows.Forms.Label lblFactorial2;
        private System.Windows.Forms.Label lblAddTwo;
        private System.Windows.Forms.Label lblRunLoops;
        private System.Windows.Forms.Label lblTotalCalculations;
        private System.Windows.Forms.Button btnFactorial1;
        private System.Windows.Forms.Button btnFactorial2;
        private System.Windows.Forms.Button btnAddTwo;
        private System.Windows.Forms.Button btnRunLoops;
        private System.Windows.Forms.TextBox txtValue;
    }
}

