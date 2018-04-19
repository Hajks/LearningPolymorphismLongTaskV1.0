namespace LearningPolymorphismLongTaskV1._0
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.goHere = new System.Windows.Forms.Button();
            this.goThroughDoor = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(12, 12);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(727, 371);
            this.descriptionBox.TabIndex = 0;
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(33, 390);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(165, 32);
            this.goHere.TabIndex = 1;
            this.goHere.Text = "Idź tutaj:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // goThroughDoor
            // 
            this.goThroughDoor.Location = new System.Drawing.Point(33, 428);
            this.goThroughDoor.Name = "goThroughDoor";
            this.goThroughDoor.Size = new System.Drawing.Size(693, 32);
            this.goThroughDoor.TabIndex = 3;
            this.goThroughDoor.Text = "Przejdź przez drzwi główne.";
            this.goThroughDoor.UseVisualStyleBackColor = true;
            this.goThroughDoor.Click += new System.EventHandler(this.goThroughDoor_Click);
            // 
            // listBox
            // 
            this.listBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(205, 390);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(521, 28);
            this.listBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 472);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.goThroughDoor);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.descriptionBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.Button goThroughDoor;
        private System.Windows.Forms.ComboBox listBox;
    }
}

