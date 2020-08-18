namespace SnakeGame
{
    partial class DialogSetName
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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtNameValue = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(129, 43);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(159, 57);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player:";
            // 
            // txtNameValue
            // 
            this.txtNameValue.BackColor = System.Drawing.Color.Ivory;
            this.txtNameValue.Location = new System.Drawing.Point(92, 129);
            this.txtNameValue.Name = "txtNameValue";
            this.txtNameValue.Size = new System.Drawing.Size(233, 20);
            this.txtNameValue.TabIndex = 1;
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(92, 191);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(233, 49);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "Submit";
            this.btnClick.UseVisualStyleBackColor = true;
            // 
            // DialogSetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(422, 281);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.txtNameValue);
            this.Controls.Add(this.lblPlayerName);
            this.Name = "DialogSetName";
            this.Text = "DialogSetName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtNameValue;
        private System.Windows.Forms.Button btnClick;
    }
}