using System.Drawing;

namespace Web.GUI.Export
{
    partial class ExportModel
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
            this.editProgressivo = new Library.Template.Controls.TemplateEditText();
            this.editComunicazione = new Library.Template.Controls.TemplateEditCombo();
            this.editData = new Library.Template.Controls.TemplateEditDate();
            this.editXMLFile = new Library.Template.Controls.TemplateEditText();
            this.editStato = new Library.Template.Controls.TemplateEditText();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editStato);
            this.container.Controls.Add(this.editXMLFile);
            this.container.Controls.Add(this.editData);
            this.container.Controls.Add(this.editComunicazione);
            this.container.Controls.Add(this.editProgressivo);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editProgressivo, 0);
            this.container.Controls.SetChildIndex(this.editComunicazione, 0);
            this.container.Controls.SetChildIndex(this.editData, 0);
            this.container.Controls.SetChildIndex(this.editXMLFile, 0);
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
            // editProgressivo
            // 
            this.editProgressivo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editProgressivo.BackColor = System.Drawing.Color.Transparent;
            this.editProgressivo.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editProgressivo.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editProgressivo.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editProgressivo.Changed = true;
            this.editProgressivo.Editing = false;
            this.editProgressivo.Label = "Progressivo";
            this.editProgressivo.LabelWidth = 175;
            this.editProgressivo.Location = new System.Drawing.Point(25, 112);
            this.editProgressivo.Name = "editProgressivo";
            this.editProgressivo.ReadOnly = false;
            this.editProgressivo.Required = true;
            this.editProgressivo.Size = new System.Drawing.Size(811, 30);
            this.editProgressivo.TabIndex = 2;
            this.editProgressivo.Text = "EditControl";
            this.editProgressivo.Value = null;
            // 
            // editComunicazione
            // 
            this.editComunicazione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editComunicazione.BackColor = System.Drawing.Color.Transparent;
            this.editComunicazione.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editComunicazione.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editComunicazione.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editComunicazione.Changed = true;
            this.editComunicazione.Editing = false;
            this.editComunicazione.Label = "Comunicazione";
            this.editComunicazione.LabelWidth = 175;
            this.editComunicazione.Location = new System.Drawing.Point(25, 66);
            this.editComunicazione.Model = null;
            this.editComunicazione.Name = "editComunicazione";
            this.editComunicazione.ReadOnly = false;
            this.editComunicazione.Required = true;
            this.editComunicazione.Size = new System.Drawing.Size(811, 30);
            this.editComunicazione.TabIndex = 1000;
            this.editComunicazione.Value = null;
            this.editComunicazione.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editComunicazione_ComboConfirm);
            this.editComunicazione.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editComunicazione_ComboClick);
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
            // editXMLFile
            // 
            this.editXMLFile.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editXMLFile.BackColor = System.Drawing.Color.Transparent;
            this.editXMLFile.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editXMLFile.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editXMLFile.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editXMLFile.Changed = true;
            this.editXMLFile.Editing = false;
            this.editXMLFile.Label = "XML File";
            this.editXMLFile.LabelWidth = 175;
            this.editXMLFile.Location = new System.Drawing.Point(25, 158);
            this.editXMLFile.Name = "templateEditText1";
            this.editXMLFile.ReadOnly = false;
            this.editXMLFile.Required = true;
            this.editXMLFile.Size = new System.Drawing.Size(811, 30);
            this.editXMLFile.TabIndex = 2;
            this.editXMLFile.Text = "EditControl";
            this.editXMLFile.Value = null;
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

        private Library.Template.Controls.TemplateEditText editProgressivo;
        private Library.Template.Controls.TemplateEditCombo editComunicazione;
        private Library.Template.Controls.TemplateEditDate editData;
        private Library.Template.Controls.TemplateEditText editStato;
        private Library.Template.Controls.TemplateEditText editXMLFile;


    }
}
