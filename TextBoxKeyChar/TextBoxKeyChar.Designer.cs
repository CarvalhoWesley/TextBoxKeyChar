namespace TextBoxKeyChar
{
    partial class TextBoxKeyChar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TextBoxKeyChar
            // 
            this.ReadOnly = true;
            this.Size = new System.Drawing.Size(104, 20);
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
