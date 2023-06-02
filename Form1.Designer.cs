namespace Vjezba_10
{
    partial class TechSpecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechSpecs));
            this.comboBoxKomponente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxKomponente
            // 
            this.comboBoxKomponente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxKomponente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxKomponente.FormattingEnabled = true;
            this.comboBoxKomponente.Items.AddRange(new object[] {
            "CPU",
            "GPU",
            "RAM",
            "HDD / SSD",
            "Mrežni adapteri"});
            this.comboBoxKomponente.Location = new System.Drawing.Point(467, 89);
            this.comboBoxKomponente.Name = "comboBoxKomponente";
            this.comboBoxKomponente.Size = new System.Drawing.Size(145, 28);
            this.comboBoxKomponente.TabIndex = 0;
            this.comboBoxKomponente.SelectedIndexChanged += new System.EventHandler(this.comboBoxKomponente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(190, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izaberite komponentu računala:";
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.ItemHeight = 16;
            this.listBoxInfo.Location = new System.Drawing.Point(0, 206);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(800, 244);
            this.listBoxInfo.TabIndex = 2;
            // 
            // TechSpecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKomponente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TechSpecs";
            this.Text = "Detalji o komponentama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKomponente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxInfo;
    }
}

