namespace Proiect_PAW_ZamosteanuAndraBeatrice
{
    partial class EditForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.tbMoneda = new System.Windows.Forms.TextBox();
            this.tbDetinator = new System.Windows.Forms.TextBox();
            this.tbIban = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.brnCancel = new System.Windows.Forms.Button();
            this.epIban = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDetinator = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMoneda = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSuma = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epIban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDetinator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMoneda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuma)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Suma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Moneda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Detinator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "IBAN";
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(73, 258);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(100, 22);
            this.tbSuma.TabIndex = 12;
            this.tbSuma.Validating += new System.ComponentModel.CancelEventHandler(this.TbSuma_Validating);
            this.tbSuma.Validated += new System.EventHandler(this.TbSuma_Validated);
            // 
            // tbMoneda
            // 
            this.tbMoneda.Location = new System.Drawing.Point(73, 201);
            this.tbMoneda.Name = "tbMoneda";
            this.tbMoneda.Size = new System.Drawing.Size(100, 22);
            this.tbMoneda.TabIndex = 11;
            this.tbMoneda.Validating += new System.ComponentModel.CancelEventHandler(this.TbMoneda_Validating);
            this.tbMoneda.Validated += new System.EventHandler(this.TbMoneda_Validated);
            // 
            // tbDetinator
            // 
            this.tbDetinator.Location = new System.Drawing.Point(73, 144);
            this.tbDetinator.Name = "tbDetinator";
            this.tbDetinator.Size = new System.Drawing.Size(100, 22);
            this.tbDetinator.TabIndex = 10;
            this.tbDetinator.Validating += new System.ComponentModel.CancelEventHandler(this.TbDetinator_Validating);
            this.tbDetinator.Validated += new System.EventHandler(this.TbDetinator_Validated);
            // 
            // tbIban
            // 
            this.tbIban.Location = new System.Drawing.Point(73, 88);
            this.tbIban.Name = "tbIban";
            this.tbIban.Size = new System.Drawing.Size(100, 22);
            this.tbIban.TabIndex = 9;
            this.tbIban.Validating += new System.ComponentModel.CancelEventHandler(this.TbIban_Validating);
            this.tbIban.Validated += new System.EventHandler(this.TbIban_Validated);
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(73, 308);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 32);
            this.btSave.TabIndex = 17;
            this.btSave.Text = "Salveaza";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Editeaza informatiile";
            // 
            // brnCancel
            // 
            this.brnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.brnCancel.Location = new System.Drawing.Point(198, 308);
            this.brnCancel.Name = "brnCancel";
            this.brnCancel.Size = new System.Drawing.Size(78, 32);
            this.brnCancel.TabIndex = 19;
            this.brnCancel.Text = "Cancel";
            this.brnCancel.UseVisualStyleBackColor = true;
            // 
            // epIban
            // 
            this.epIban.ContainerControl = this;
            // 
            // epDetinator
            // 
            this.epDetinator.ContainerControl = this;
            // 
            // epMoneda
            // 
            this.epMoneda.ContainerControl = this;
            // 
            // epSuma
            // 
            this.epSuma.ContainerControl = this;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.tbMoneda);
            this.Controls.Add(this.tbDetinator);
            this.Controls.Add(this.tbIban);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epIban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDetinator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMoneda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSuma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.TextBox tbMoneda;
        private System.Windows.Forms.TextBox tbDetinator;
        private System.Windows.Forms.TextBox tbIban;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button brnCancel;
        private System.Windows.Forms.ErrorProvider epIban;
        private System.Windows.Forms.ErrorProvider epDetinator;
        private System.Windows.Forms.ErrorProvider epMoneda;
        private System.Windows.Forms.ErrorProvider epSuma;
    }
}