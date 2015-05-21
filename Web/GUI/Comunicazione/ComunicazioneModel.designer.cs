using System.Drawing;

namespace Web.GUI.Comunicazione
{
    partial class ComunicazioneModel
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Visual WebGui Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.editNumero = new Library.Template.Controls.TemplateEditText();
            this.editContabilita = new Library.Template.Controls.TemplateEditCombo();
            this.editScadenzaIVA = new Library.Template.Controls.TemplateEditDate();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editScadenzaIVA);
            this.container.Controls.Add(this.editContabilita);
            this.container.Controls.Add(this.editNumero);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editNumero, 0);
            this.container.Controls.SetChildIndex(this.editContabilita, 0);
            this.container.Controls.SetChildIndex(this.editScadenzaIVA, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // editNumero
            // 
            this.editNumero.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editNumero.BackColor = System.Drawing.Color.Transparent;
            this.editNumero.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editNumero.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editNumero.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editNumero.Changed = true;
            this.editNumero.Editing = false;
            this.editNumero.Label = "Numero";
            this.editNumero.LabelWidth = 175;
            this.editNumero.Location = new System.Drawing.Point(25, 118);
            this.editNumero.Name = "editNumero";
            this.editNumero.ReadOnly = false;
            this.editNumero.Required = true;
            this.editNumero.Size = new System.Drawing.Size(809, 30);
            this.editNumero.TabIndex = 2;
            this.editNumero.Text = "EditControl";
            this.editNumero.Value = null;
            // 
            // editContabilita
            // 
            this.editContabilita.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editContabilita.BackColor = System.Drawing.Color.Transparent;
            this.editContabilita.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editContabilita.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editContabilita.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editContabilita.Changed = true;
            this.editContabilita.Editing = false;
            this.editContabilita.Label = "Contabilità";
            this.editContabilita.LabelWidth = 175;
            this.editContabilita.Location = new System.Drawing.Point(25, 66);
            this.editContabilita.Model = null;
            this.editContabilita.Name = "editContabilita";
            this.editContabilita.ReadOnly = false;
            this.editContabilita.Required = true;
            this.editContabilita.Size = new System.Drawing.Size(811, 30);
            this.editContabilita.TabIndex = 1000;
            this.editContabilita.Value = null;
            this.editContabilita.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editContabilita_ComboConfirm);
            this.editContabilita.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editContabilita_ComboClick);
            // 
            // editScadenzaIVA
            // 
            this.editScadenzaIVA.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editScadenzaIVA.BackColor = System.Drawing.Color.Transparent;
            this.editScadenzaIVA.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editScadenzaIVA.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editScadenzaIVA.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editScadenzaIVA.Changed = true;
            this.editScadenzaIVA.Editing = false;
            this.editScadenzaIVA.Label = "Scadneza IVA";
            this.editScadenzaIVA.LabelWidth = 175;
            this.editScadenzaIVA.Location = new System.Drawing.Point(25, 168);
            this.editScadenzaIVA.Name = "editScadenzaIVA";
            this.editScadenzaIVA.ReadOnly = false;
            this.editScadenzaIVA.Required = false;
            this.editScadenzaIVA.Size = new System.Drawing.Size(809, 30);
            this.editScadenzaIVA.TabIndex = 1001;
            this.editScadenzaIVA.Value = null;
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editNumero;
        private Library.Template.Controls.TemplateEditCombo editContabilita;
        private Library.Template.Controls.TemplateEditDate editScadenzaIVA;


    }
}
