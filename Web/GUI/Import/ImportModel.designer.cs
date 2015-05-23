using System.Drawing;

namespace Web.GUI.Import
{
    partial class ImportModel
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
            this.editTXTMovimenti = new Library.Template.Controls.TemplateEditText();
            this.editExport = new Library.Template.Controls.TemplateEditCombo();
            this.editData = new Library.Template.Controls.TemplateEditDate();
            this.editTXTClienti = new Library.Template.Controls.TemplateEditText();
            this.editStato = new Library.Template.Controls.TemplateEditText();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editStato);
            this.container.Controls.Add(this.editTXTClienti);
            this.container.Controls.Add(this.editData);
            this.container.Controls.Add(this.editExport);
            this.container.Controls.Add(this.editTXTMovimenti);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editTXTMovimenti, 0);
            this.container.Controls.SetChildIndex(this.editExport, 0);
            this.container.Controls.SetChildIndex(this.editData, 0);
            this.container.Controls.SetChildIndex(this.editTXTClienti, 0);
            this.container.Controls.SetChildIndex(this.editStato, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // editTXTMovimenti
            // 
            this.editTXTMovimenti.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTXTMovimenti.BackColor = System.Drawing.Color.Transparent;
            this.editTXTMovimenti.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTXTMovimenti.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTXTMovimenti.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTXTMovimenti.Changed = true;
            this.editTXTMovimenti.Editing = false;
            this.editTXTMovimenti.Label = "TXT Movimenti";
            this.editTXTMovimenti.LabelWidth = 175;
            this.editTXTMovimenti.Location = new System.Drawing.Point(25, 112);
            this.editTXTMovimenti.Name = "editTXTMovimenti";
            this.editTXTMovimenti.ReadOnly = false;
            this.editTXTMovimenti.Required = true;
            this.editTXTMovimenti.Size = new System.Drawing.Size(811, 30);
            this.editTXTMovimenti.TabIndex = 2;
            this.editTXTMovimenti.Text = "EditControl";
            this.editTXTMovimenti.Value = null;
            // 
            // editExport
            // 
            this.editExport.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editExport.BackColor = System.Drawing.Color.Transparent;
            this.editExport.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editExport.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editExport.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editExport.Changed = true;
            this.editExport.Editing = false;
            this.editExport.Label = "Export";
            this.editExport.LabelWidth = 175;
            this.editExport.Location = new System.Drawing.Point(25, 66);
            this.editExport.Model = null;
            this.editExport.Name = "editExport";
            this.editExport.ReadOnly = false;
            this.editExport.Required = true;
            this.editExport.Size = new System.Drawing.Size(811, 30);
            this.editExport.TabIndex = 1000;
            this.editExport.Value = null;
            this.editExport.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editExport_ComboConfirm);
            this.editExport.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editExport_ComboClick);
            // 
            // editData
            // 
            this.editData.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editData.BackColor = System.Drawing.Color.Transparent;
            this.editData.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editData.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editData.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editData.Changed = true;
            this.editData.Editing = false;
            this.editData.Label = "Data";
            this.editData.LabelWidth = 175;
            this.editData.Location = new System.Drawing.Point(25, 250);
            this.editData.Name = "editData";
            this.editData.ReadOnly = false;
            this.editData.Required = false;
            this.editData.Size = new System.Drawing.Size(811, 30);
            this.editData.TabIndex = 1001;
            this.editData.Value = null;
            // 
            // editTXTClienti
            // 
            this.editTXTClienti.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTXTClienti.BackColor = System.Drawing.Color.Transparent;
            this.editTXTClienti.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTXTClienti.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTXTClienti.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTXTClienti.Changed = true;
            this.editTXTClienti.Editing = false;
            this.editTXTClienti.Label = "TXT Clienti";
            this.editTXTClienti.LabelWidth = 175;
            this.editTXTClienti.Location = new System.Drawing.Point(25, 158);
            this.editTXTClienti.Name = "editTXTClienti";
            this.editTXTClienti.ReadOnly = false;
            this.editTXTClienti.Required = true;
            this.editTXTClienti.Size = new System.Drawing.Size(811, 30);
            this.editTXTClienti.TabIndex = 2;
            this.editTXTClienti.Text = "EditControl";
            this.editTXTClienti.Value = null;
            // 
            // editStato
            // 
            this.editStato.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editStato.BackColor = System.Drawing.Color.Transparent;
            this.editStato.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editStato.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editStato.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editStato.Changed = true;
            this.editStato.Editing = false;
            this.editStato.Label = "Stato";
            this.editStato.LabelWidth = 175;
            this.editStato.Location = new System.Drawing.Point(25, 204);
            this.editStato.Name = "templateEditText2";
            this.editStato.ReadOnly = false;
            this.editStato.Required = true;
            this.editStato.Size = new System.Drawing.Size(811, 30);
            this.editStato.TabIndex = 2;
            this.editStato.Text = "EditControl";
            this.editStato.Value = null;
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editTXTMovimenti;
        private Library.Template.Controls.TemplateEditCombo editExport;
        private Library.Template.Controls.TemplateEditDate editData;
        private Library.Template.Controls.TemplateEditText editStato;
        private Library.Template.Controls.TemplateEditText editTXTClienti;


    }
}
