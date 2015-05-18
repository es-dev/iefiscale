using System.Drawing;

namespace Web.GUI.Azienda
{
    partial class AziendaModel
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
            this.editTipoSoftwareFatturazione = new Library.Template.Controls.TemplateEditText();
            this.editTipoContabilita = new Library.Template.Controls.TemplateEditCap();
            this.editMdbFile = new Library.Template.Controls.TemplateEditText();
            this.editStudioCommerciale = new Library.Template.Controls.TemplateEditCombo();
            this.editAnagraficaAzienda = new Library.Template.Controls.TemplateEditCombo();
            this.editUltimoAggiornamento = new Library.Template.Controls.TemplateEditDate();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editUltimoAggiornamento);
            this.container.Controls.Add(this.editAnagraficaAzienda);
            this.container.Controls.Add(this.editStudioCommerciale);
            this.container.Controls.Add(this.editMdbFile);
            this.container.Controls.Add(this.editTipoContabilita);
            this.container.Controls.Add(this.editTipoSoftwareFatturazione);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editTipoSoftwareFatturazione, 0);
            this.container.Controls.SetChildIndex(this.editTipoContabilita, 0);
            this.container.Controls.SetChildIndex(this.editMdbFile, 0);
            this.container.Controls.SetChildIndex(this.editStudioCommerciale, 0);
            this.container.Controls.SetChildIndex(this.editAnagraficaAzienda, 0);
            this.container.Controls.SetChildIndex(this.editUltimoAggiornamento, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // editTipoSoftwareFatturazione
            // 
            this.editTipoSoftwareFatturazione.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTipoSoftwareFatturazione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTipoSoftwareFatturazione.BackColor = System.Drawing.Color.Transparent;
            this.editTipoSoftwareFatturazione.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTipoSoftwareFatturazione.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTipoSoftwareFatturazione.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTipoSoftwareFatturazione.Changed = true;
            this.editTipoSoftwareFatturazione.Editing = false;
            this.editTipoSoftwareFatturazione.Label = "Software fatturazione";
            this.editTipoSoftwareFatturazione.LabelWidth = 175;
            this.editTipoSoftwareFatturazione.Location = new System.Drawing.Point(25, 156);
            this.editTipoSoftwareFatturazione.Name = "editTipoSoftwareFatturazione";
            this.editTipoSoftwareFatturazione.ReadOnly = false;
            this.editTipoSoftwareFatturazione.Required = true;
            this.editTipoSoftwareFatturazione.Size = new System.Drawing.Size(813, 30);
            this.editTipoSoftwareFatturazione.TabIndex = 2;
            this.editTipoSoftwareFatturazione.Text = "EditControl";
            this.editTipoSoftwareFatturazione.Value = null;
            // 
            // editTipoContabilita
            // 
            this.editTipoContabilita.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTipoContabilita.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTipoContabilita.BackColor = System.Drawing.Color.Transparent;
            this.editTipoContabilita.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTipoContabilita.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTipoContabilita.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTipoContabilita.Changed = true;
            this.editTipoContabilita.Editing = false;
            this.editTipoContabilita.Label = "Tipo contabilità";
            this.editTipoContabilita.LabelWidth = 175;
            this.editTipoContabilita.Location = new System.Drawing.Point(25, 199);
            this.editTipoContabilita.Name = "editTipoContabilita";
            this.editTipoContabilita.ReadOnly = false;
            this.editTipoContabilita.Required = true;
            this.editTipoContabilita.Size = new System.Drawing.Size(813, 30);
            this.editTipoContabilita.TabIndex = 3;
            this.editTipoContabilita.Text = "EditControl";
            this.editTipoContabilita.Value = null;
            // 
            // editMdbFile
            // 
            this.editMdbFile.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editMdbFile.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editMdbFile.BackColor = System.Drawing.Color.Transparent;
            this.editMdbFile.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editMdbFile.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editMdbFile.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editMdbFile.Changed = true;
            this.editMdbFile.Editing = false;
            this.editMdbFile.Label = "Mdb file";
            this.editMdbFile.LabelWidth = 175;
            this.editMdbFile.Location = new System.Drawing.Point(25, 285);
            this.editMdbFile.Name = "editMdbFile";
            this.editMdbFile.ReadOnly = false;
            this.editMdbFile.Required = false;
            this.editMdbFile.Size = new System.Drawing.Size(813, 30);
            this.editMdbFile.TabIndex = 5;
            this.editMdbFile.Text = "EditControl";
            this.editMdbFile.Value = null;
            // 
            // editStudioCommerciale
            // 
            this.editStudioCommerciale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editStudioCommerciale.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editStudioCommerciale.BackColor = System.Drawing.Color.Transparent;
            this.editStudioCommerciale.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editStudioCommerciale.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editStudioCommerciale.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editStudioCommerciale.Changed = true;
            this.editStudioCommerciale.Editing = false;
            this.editStudioCommerciale.Label = "Studio commerciale";
            this.editStudioCommerciale.LabelWidth = 175;
            this.editStudioCommerciale.Location = new System.Drawing.Point(25, 66);
            this.editStudioCommerciale.Model = null;
            this.editStudioCommerciale.Name = "editStudioCommerciale";
            this.editStudioCommerciale.ReadOnly = false;
            this.editStudioCommerciale.Required = true;
            this.editStudioCommerciale.Size = new System.Drawing.Size(811, 30);
            this.editStudioCommerciale.TabIndex = 1000;
            this.editStudioCommerciale.Value = null;
            this.editStudioCommerciale.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editStudioCommerciale_ComboConfirm);
            this.editStudioCommerciale.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editStudioCommerciale_ComboClick);
            // 
            // editAnagraficaAzienda
            // 
            this.editAnagraficaAzienda.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editAnagraficaAzienda.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editAnagraficaAzienda.BackColor = System.Drawing.Color.Transparent;
            this.editAnagraficaAzienda.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editAnagraficaAzienda.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editAnagraficaAzienda.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editAnagraficaAzienda.Changed = true;
            this.editAnagraficaAzienda.Editing = false;
            this.editAnagraficaAzienda.Label = "Anagrafica azienda";
            this.editAnagraficaAzienda.LabelWidth = 175;
            this.editAnagraficaAzienda.Location = new System.Drawing.Point(25, 116);
            this.editAnagraficaAzienda.Model = null;
            this.editAnagraficaAzienda.Name = "editAnagraficaAzienda";
            this.editAnagraficaAzienda.ReadOnly = false;
            this.editAnagraficaAzienda.Required = true;
            this.editAnagraficaAzienda.Size = new System.Drawing.Size(811, 30);
            this.editAnagraficaAzienda.TabIndex = 1000;
            this.editAnagraficaAzienda.Value = null;
            this.editAnagraficaAzienda.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editAnagraficaAzienda_ComboConfirm);
            this.editAnagraficaAzienda.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editAnagraficaAzienda_ComboClick);
            // 
            // editUltimoAggiornamento
            // 
            this.editUltimoAggiornamento.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editUltimoAggiornamento.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editUltimoAggiornamento.BackColor = System.Drawing.Color.Transparent;
            this.editUltimoAggiornamento.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editUltimoAggiornamento.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editUltimoAggiornamento.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editUltimoAggiornamento.Changed = true;
            this.editUltimoAggiornamento.Editing = false;
            this.editUltimoAggiornamento.Label = "Ultimo aggiornamento";
            this.editUltimoAggiornamento.LabelWidth = 175;
            this.editUltimoAggiornamento.Location = new System.Drawing.Point(25, 241);
            this.editUltimoAggiornamento.Name = "editUltimoAggiornamento";
            this.editUltimoAggiornamento.ReadOnly = false;
            this.editUltimoAggiornamento.Required = false;
            this.editUltimoAggiornamento.Size = new System.Drawing.Size(481, 30);
            this.editUltimoAggiornamento.TabIndex = 1001;
            this.editUltimoAggiornamento.Value = null;
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editTipoSoftwareFatturazione;
        private Library.Template.Controls.TemplateEditCap editTipoContabilita;
        private Library.Template.Controls.TemplateEditText editMdbFile;
        private Library.Template.Controls.TemplateEditCombo editStudioCommerciale;
        private Library.Template.Controls.TemplateEditCombo editAnagraficaAzienda;
        private Library.Template.Controls.TemplateEditDate editUltimoAggiornamento;


    }
}
