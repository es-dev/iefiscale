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
            this.editStudioCommerciale = new Library.Template.Controls.TemplateEditCombo();
            this.editRagioneSociale = new Library.Template.Controls.TemplateEditCombo();
            this.editCodiceFiscale = new Library.Template.Controls.TemplateEditCodiceFiscale();
            this.editComune = new Library.Template.Controls.TemplateEditCountry();
            this.editPartitaIVA = new Library.Template.Controls.TemplateEditPartitaIva();
            this.editEmail = new Library.Template.Controls.TemplateEditEmail();
            this.editTelefono = new Library.Template.Controls.TemplateEditText();
            this.editFAX = new Library.Template.Controls.TemplateEditText();
            this.editCAP = new Library.Template.Controls.TemplateEditCap();
            this.editIndirizzo = new Library.Template.Controls.TemplateEditText();
            this.editUltimoAggiornamento = new Library.Template.Controls.TemplateEditDateTime();
            this.editIDAzienda = new Library.Template.Controls.TemplateEditText();
            this.editMdbFile = new Library.Template.Controls.TemplateEditUpload();
            this.editTipoSoftwareFatturazione = new Library.Template.Controls.TemplateEditDropDown();
            this.editTipoContabilita = new Library.Template.Controls.TemplateEditDropDown();
            this.btnImportConfigurazione = new Library.Controls.ButtonSeparatorV();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editTipoContabilita);
            this.container.Controls.Add(this.editTipoSoftwareFatturazione);
            this.container.Controls.Add(this.editMdbFile);
            this.container.Controls.Add(this.editIDAzienda);
            this.container.Controls.Add(this.editUltimoAggiornamento);
            this.container.Controls.Add(this.editIndirizzo);
            this.container.Controls.Add(this.editCAP);
            this.container.Controls.Add(this.editFAX);
            this.container.Controls.Add(this.editTelefono);
            this.container.Controls.Add(this.editEmail);
            this.container.Controls.Add(this.editPartitaIVA);
            this.container.Controls.Add(this.editComune);
            this.container.Controls.Add(this.editCodiceFiscale);
            this.container.Controls.Add(this.editRagioneSociale);
            this.container.Controls.Add(this.editStudioCommerciale);
            this.container.Size = new System.Drawing.Size(923, 700);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editStudioCommerciale, 0);
            this.container.Controls.SetChildIndex(this.editRagioneSociale, 0);
            this.container.Controls.SetChildIndex(this.editCodiceFiscale, 0);
            this.container.Controls.SetChildIndex(this.editComune, 0);
            this.container.Controls.SetChildIndex(this.editPartitaIVA, 0);
            this.container.Controls.SetChildIndex(this.editEmail, 0);
            this.container.Controls.SetChildIndex(this.editTelefono, 0);
            this.container.Controls.SetChildIndex(this.editFAX, 0);
            this.container.Controls.SetChildIndex(this.editCAP, 0);
            this.container.Controls.SetChildIndex(this.editIndirizzo, 0);
            this.container.Controls.SetChildIndex(this.editUltimoAggiornamento, 0);
            this.container.Controls.SetChildIndex(this.editIDAzienda, 0);
            this.container.Controls.SetChildIndex(this.editMdbFile, 0);
            this.container.Controls.SetChildIndex(this.editTipoSoftwareFatturazione, 0);
            this.container.Controls.SetChildIndex(this.editTipoContabilita, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(664, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(608, 3);
            // 
            // panelCommands
            // 
            this.panelCommands.Controls.Add(this.btnImportConfigurazione);
            this.panelCommands.Size = new System.Drawing.Size(101, 747);
            this.panelCommands.Controls.SetChildIndex(this.btnClose, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnSave, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnUpdateCancel, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnDelete, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnHome, 0);
            this.panelCommands.Controls.SetChildIndex(this.btnImportConfigurazione, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 675);
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
            this.editStudioCommerciale.Location = new System.Drawing.Point(34, 66);
            this.editStudioCommerciale.Model = null;
            this.editStudioCommerciale.Name = "editStudioCommerciale";
            this.editStudioCommerciale.ReadOnly = false;
            this.editStudioCommerciale.Required = true;
            this.editStudioCommerciale.Size = new System.Drawing.Size(818, 30);
            this.editStudioCommerciale.TabIndex = 0;
            this.editStudioCommerciale.Value = null;
            this.editStudioCommerciale.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editStudioCommerciale_ComboConfirm);
            this.editStudioCommerciale.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editStudioCommerciale_ComboClick);
            // 
            // editRagioneSociale
            // 
            this.editRagioneSociale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editRagioneSociale.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editRagioneSociale.BackColor = System.Drawing.Color.Transparent;
            this.editRagioneSociale.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editRagioneSociale.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editRagioneSociale.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editRagioneSociale.Changed = true;
            this.editRagioneSociale.Editing = false;
            this.editRagioneSociale.Label = "Ragione sociale";
            this.editRagioneSociale.LabelWidth = 175;
            this.editRagioneSociale.Location = new System.Drawing.Point(34, 107);
            this.editRagioneSociale.Model = null;
            this.editRagioneSociale.Name = "editRagioneSociale";
            this.editRagioneSociale.ReadOnly = false;
            this.editRagioneSociale.Required = true;
            this.editRagioneSociale.Size = new System.Drawing.Size(818, 30);
            this.editRagioneSociale.TabIndex = 1;
            this.editRagioneSociale.Value = null;
            this.editRagioneSociale.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editAnagraficaAzienda_ComboConfirm);
            this.editRagioneSociale.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editAnagraficaAzienda_ComboClick);
            // 
            // editCodiceFiscale
            // 
            this.editCodiceFiscale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCodiceFiscale.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCodiceFiscale.BackColor = System.Drawing.Color.Transparent;
            this.editCodiceFiscale.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCodiceFiscale.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCodiceFiscale.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCodiceFiscale.Changed = true;
            this.editCodiceFiscale.Editing = false;
            this.editCodiceFiscale.Label = "Codice fiscale";
            this.editCodiceFiscale.LabelWidth = 175;
            this.editCodiceFiscale.Location = new System.Drawing.Point(34, 435);
            this.editCodiceFiscale.Name = "editCodiceFiscale";
            this.editCodiceFiscale.ReadOnly = true;
            this.editCodiceFiscale.Required = false;
            this.editCodiceFiscale.Size = new System.Drawing.Size(818, 30);
            this.editCodiceFiscale.TabIndex = 13;
            this.editCodiceFiscale.Text = "TemplateEditPartitaIva";
            this.editCodiceFiscale.Value = "---";
            // 
            // editComune
            // 
            this.editComune.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editComune.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editComune.BackColor = System.Drawing.Color.Transparent;
            this.editComune.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editComune.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editComune.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editComune.Changed = true;
            this.editComune.Editing = false;
            this.editComune.Label = "Comune";
            this.editComune.LabelWidth = 175;
            this.editComune.Location = new System.Drawing.Point(34, 230);
            this.editComune.Name = "editComune";
            this.editComune.ReadOnly = true;
            this.editComune.Required = true;
            this.editComune.Size = new System.Drawing.Size(818, 30);
            this.editComune.TabIndex = 8;
            this.editComune.Text = "EditControl";
            this.editComune.Value = null;
            // 
            // editPartitaIVA
            // 
            this.editPartitaIVA.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editPartitaIVA.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editPartitaIVA.BackColor = System.Drawing.Color.Transparent;
            this.editPartitaIVA.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editPartitaIVA.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editPartitaIVA.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editPartitaIVA.Changed = true;
            this.editPartitaIVA.Editing = false;
            this.editPartitaIVA.Label = "Partita IVA";
            this.editPartitaIVA.LabelWidth = 175;
            this.editPartitaIVA.Location = new System.Drawing.Point(34, 394);
            this.editPartitaIVA.Name = "editPartitaIVA";
            this.editPartitaIVA.ReadOnly = true;
            this.editPartitaIVA.Required = true;
            this.editPartitaIVA.Size = new System.Drawing.Size(818, 30);
            this.editPartitaIVA.TabIndex = 12;
            this.editPartitaIVA.Text = "TemplateEditPartitaIva";
            this.editPartitaIVA.Value = "---";
            // 
            // editEmail
            // 
            this.editEmail.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editEmail.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editEmail.BackColor = System.Drawing.Color.Transparent;
            this.editEmail.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editEmail.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editEmail.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editEmail.Changed = true;
            this.editEmail.Editing = false;
            this.editEmail.Label = "Email";
            this.editEmail.LabelWidth = 175;
            this.editEmail.Location = new System.Drawing.Point(34, 353);
            this.editEmail.Name = "editEmail";
            this.editEmail.ReadOnly = true;
            this.editEmail.Required = false;
            this.editEmail.Size = new System.Drawing.Size(818, 30);
            this.editEmail.TabIndex = 11;
            this.editEmail.Text = "TemplateEditEmail";
            this.editEmail.Value = null;
            // 
            // editTelefono
            // 
            this.editTelefono.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTelefono.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTelefono.BackColor = System.Drawing.Color.Transparent;
            this.editTelefono.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTelefono.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTelefono.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTelefono.Changed = true;
            this.editTelefono.Editing = false;
            this.editTelefono.Label = "Telefono";
            this.editTelefono.LabelWidth = 175;
            this.editTelefono.Location = new System.Drawing.Point(34, 271);
            this.editTelefono.Name = "editTelefono";
            this.editTelefono.ReadOnly = true;
            this.editTelefono.Required = false;
            this.editTelefono.Size = new System.Drawing.Size(818, 30);
            this.editTelefono.TabIndex = 9;
            this.editTelefono.Text = "EditControl";
            this.editTelefono.Value = null;
            // 
            // editFAX
            // 
            this.editFAX.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editFAX.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editFAX.BackColor = System.Drawing.Color.Transparent;
            this.editFAX.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editFAX.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editFAX.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editFAX.Changed = true;
            this.editFAX.Editing = false;
            this.editFAX.Label = "FAX";
            this.editFAX.LabelWidth = 175;
            this.editFAX.Location = new System.Drawing.Point(34, 312);
            this.editFAX.Name = "editFAX";
            this.editFAX.ReadOnly = true;
            this.editFAX.Required = false;
            this.editFAX.Size = new System.Drawing.Size(818, 30);
            this.editFAX.TabIndex = 10;
            this.editFAX.Text = "EditControl";
            this.editFAX.Value = null;
            // 
            // editCAP
            // 
            this.editCAP.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCAP.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCAP.BackColor = System.Drawing.Color.Transparent;
            this.editCAP.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCAP.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCAP.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCAP.Changed = true;
            this.editCAP.Editing = false;
            this.editCAP.Label = "CAP";
            this.editCAP.LabelWidth = 175;
            this.editCAP.Location = new System.Drawing.Point(34, 189);
            this.editCAP.Name = "editCAP";
            this.editCAP.ReadOnly = true;
            this.editCAP.Required = true;
            this.editCAP.Size = new System.Drawing.Size(818, 30);
            this.editCAP.TabIndex = 7;
            this.editCAP.Text = "EditControl";
            this.editCAP.Value = null;
            // 
            // editIndirizzo
            // 
            this.editIndirizzo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIndirizzo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIndirizzo.BackColor = System.Drawing.Color.Transparent;
            this.editIndirizzo.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIndirizzo.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIndirizzo.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIndirizzo.Changed = true;
            this.editIndirizzo.Editing = false;
            this.editIndirizzo.Label = "Indirizzo";
            this.editIndirizzo.LabelWidth = 175;
            this.editIndirizzo.Location = new System.Drawing.Point(34, 148);
            this.editIndirizzo.Name = "editIndirizzo";
            this.editIndirizzo.ReadOnly = true;
            this.editIndirizzo.Required = true;
            this.editIndirizzo.Size = new System.Drawing.Size(818, 30);
            this.editIndirizzo.TabIndex = 6;
            this.editIndirizzo.Text = "EditControl";
            this.editIndirizzo.Value = null;
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
            this.editUltimoAggiornamento.Changed = false;
            this.editUltimoAggiornamento.Editing = false;
            this.editUltimoAggiornamento.Label = "Ultimo aggiornamento";
            this.editUltimoAggiornamento.LabelWidth = 175;
            this.editUltimoAggiornamento.Location = new System.Drawing.Point(34, 640);
            this.editUltimoAggiornamento.Name = "editUltimoAggiornamento";
            this.editUltimoAggiornamento.ReadOnly = true;
            this.editUltimoAggiornamento.Required = false;
            this.editUltimoAggiornamento.Size = new System.Drawing.Size(818, 30);
            this.editUltimoAggiornamento.TabIndex = 14;
            this.editUltimoAggiornamento.Value = null;
            // 
            // editIDAzienda
            // 
            this.editIDAzienda.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIDAzienda.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIDAzienda.BackColor = System.Drawing.Color.Transparent;
            this.editIDAzienda.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIDAzienda.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIDAzienda.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIDAzienda.Changed = true;
            this.editIDAzienda.Editing = false;
            this.editIDAzienda.Label = "ID Azienda";
            this.editIDAzienda.LabelWidth = 175;
            this.editIDAzienda.Location = new System.Drawing.Point(34, 558);
            this.editIDAzienda.Name = "editIDAzienda";
            this.editIDAzienda.ReadOnly = false;
            this.editIDAzienda.Required = true;
            this.editIDAzienda.Size = new System.Drawing.Size(818, 30);
            this.editIDAzienda.TabIndex = 4;
            this.editIDAzienda.Text = "EditControl";
            this.editIDAzienda.Value = null;
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
            this.editMdbFile.Filter = "Mdb file |*.mdb";
            this.editMdbFile.Label = "File configurazione";
            this.editMdbFile.LabelWidth = 175;
            this.editMdbFile.Location = new System.Drawing.Point(34, 599);
            this.editMdbFile.Name = "editMdbFile";
            this.editMdbFile.ReadOnly = false;
            this.editMdbFile.Repository = "Resources\\MDB";
            this.editMdbFile.Required = false;
            this.editMdbFile.Size = new System.Drawing.Size(818, 30);
            this.editMdbFile.TabIndex = 5;
            this.editMdbFile.Title = "File di configurazione azienda";
            this.editMdbFile.Value = null;
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
            this.editTipoSoftwareFatturazione.DisplayValues = null;
            this.editTipoSoftwareFatturazione.Editing = false;
            this.editTipoSoftwareFatturazione.Items = null;
            this.editTipoSoftwareFatturazione.Label = "Software fatturazione";
            this.editTipoSoftwareFatturazione.LabelWidth = 175;
            this.editTipoSoftwareFatturazione.Location = new System.Drawing.Point(34, 476);
            this.editTipoSoftwareFatturazione.Name = "editTipoSoftwareFatturazione";
            this.editTipoSoftwareFatturazione.ReadOnly = false;
            this.editTipoSoftwareFatturazione.Required = true;
            this.editTipoSoftwareFatturazione.Size = new System.Drawing.Size(818, 30);
            this.editTipoSoftwareFatturazione.TabIndex = 2;
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
            this.editTipoContabilita.DisplayValues = null;
            this.editTipoContabilita.Editing = false;
            this.editTipoContabilita.Items = null;
            this.editTipoContabilita.Label = "Tipo contabilità";
            this.editTipoContabilita.LabelWidth = 175;
            this.editTipoContabilita.Location = new System.Drawing.Point(34, 517);
            this.editTipoContabilita.Name = "editTipoContabilita";
            this.editTipoContabilita.ReadOnly = false;
            this.editTipoContabilita.Required = true;
            this.editTipoContabilita.Size = new System.Drawing.Size(818, 30);
            this.editTipoContabilita.TabIndex = 3;
            this.editTipoContabilita.Value = null;
            // 
            // btnImportConfigurazione
            // 
            this.btnImportConfigurazione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnImportConfigurazione.BackColor = System.Drawing.Color.Transparent;
            this.btnImportConfigurazione.ForeColorButton = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(100)))));
            this.btnImportConfigurazione.ImageButton = "";
            this.btnImportConfigurazione.ImageSeparator = "Images.separator_ht_small.png";
            this.btnImportConfigurazione.Location = new System.Drawing.Point(0, 288);
            this.btnImportConfigurazione.Name = "btnImportConfigurazione";
            this.btnImportConfigurazione.Size = new System.Drawing.Size(100, 72);
            this.btnImportConfigurazione.TabIndex = 2;
            this.btnImportConfigurazione.TextButton = "Import dati azienda";
            this.btnImportConfigurazione.Click += new Library.Controls.ButtonSeparatorV.ButtonSeparatorClick(this.btnImportConfigurazione_Click);
            // 
            // AziendaModel
            // 
            this.Size = new System.Drawing.Size(1024, 747);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditCombo editStudioCommerciale;
        private Library.Template.Controls.TemplateEditCombo editRagioneSociale;
        private Library.Template.Controls.TemplateEditText editIndirizzo;
        private Library.Template.Controls.TemplateEditCap editCAP;
        private Library.Template.Controls.TemplateEditText editFAX;
        private Library.Template.Controls.TemplateEditText editTelefono;
        private Library.Template.Controls.TemplateEditEmail editEmail;
        private Library.Template.Controls.TemplateEditPartitaIva editPartitaIVA;
        private Library.Template.Controls.TemplateEditCountry editComune;
        private Library.Template.Controls.TemplateEditCodiceFiscale editCodiceFiscale;
        private Library.Template.Controls.TemplateEditDateTime editUltimoAggiornamento;
        private Library.Template.Controls.TemplateEditText editIDAzienda;
        private Library.Template.Controls.TemplateEditUpload editMdbFile;
        private Library.Template.Controls.TemplateEditDropDown editTipoSoftwareFatturazione;
        private Library.Template.Controls.TemplateEditDropDown editTipoContabilita;
        private Library.Controls.ButtonSeparatorV btnImportConfigurazione;


    }
}
