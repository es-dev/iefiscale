using System.Drawing;

namespace Web.GUI.Documento
{
    partial class DocumentoModel
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
            this.editExport = new Library.Template.Controls.TemplateEditCombo();
            this.editNumero = new Library.Template.Controls.TemplateEditText();
            this.editIDConto = new Library.Template.Controls.TemplateEditText();
            this.editTipo = new Library.Template.Controls.TemplateEditText();
            this.editIDIVA = new Library.Template.Controls.TemplateEditText();
            this.editIDRegistroIVA = new Library.Template.Controls.TemplateEditText();
            this.editIDCausale = new Library.Template.Controls.TemplateEditText();
            this.editIDMovimento = new Library.Template.Controls.TemplateEditText();
            this.editLocalita = new Library.Template.Controls.TemplateEditText();
            this.editIDCliente = new Library.Template.Controls.TemplateEditText();
            this.editData = new Library.Template.Controls.TemplateEditDate();
            this.editImponibile = new Library.Template.Controls.TemplateEditDecimal();
            this.editIVA = new Library.Template.Controls.TemplateEditDecimal();
            this.editTotale = new Library.Template.Controls.TemplateEditDecimal();
            this.editDataRegistrazione = new Library.Template.Controls.TemplateEditDate();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editDataRegistrazione);
            this.container.Controls.Add(this.editTotale);
            this.container.Controls.Add(this.editIVA);
            this.container.Controls.Add(this.editImponibile);
            this.container.Controls.Add(this.editData);
            this.container.Controls.Add(this.editIDCliente);
            this.container.Controls.Add(this.editIDMovimento);
            this.container.Controls.Add(this.editIDCausale);
            this.container.Controls.Add(this.editIDRegistroIVA);
            this.container.Controls.Add(this.editIDIVA);
            this.container.Controls.Add(this.editTipo);
            this.container.Controls.Add(this.editIDConto);
            this.container.Controls.Add(this.editNumero);
            this.container.Controls.Add(this.editExport);
            this.container.Size = new System.Drawing.Size(923, 693);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editExport, 0);
            this.container.Controls.SetChildIndex(this.editNumero, 0);
            this.container.Controls.SetChildIndex(this.editIDConto, 0);
            this.container.Controls.SetChildIndex(this.editTipo, 0);
            this.container.Controls.SetChildIndex(this.editIDIVA, 0);
            this.container.Controls.SetChildIndex(this.editIDRegistroIVA, 0);
            this.container.Controls.SetChildIndex(this.editIDCausale, 0);
            this.container.Controls.SetChildIndex(this.editIDMovimento, 0);
            this.container.Controls.SetChildIndex(this.editIDCliente, 0);
            this.container.Controls.SetChildIndex(this.editData, 0);
            this.container.Controls.SetChildIndex(this.editImponibile, 0);
            this.container.Controls.SetChildIndex(this.editIVA, 0);
            this.container.Controls.SetChildIndex(this.editTotale, 0);
            this.container.Controls.SetChildIndex(this.editDataRegistrazione, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(1030, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(974, 3);
            // 
            // panelCommands
            // 
            this.panelCommands.Size = new System.Drawing.Size(101, 740);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 668);
            // 
            // editExport
            // 
            this.editExport.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
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
            this.editExport.TabIndex = 0;
            this.editExport.Value = null;
            this.editExport.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editExport_ComboConfirm);
            this.editExport.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editExport_ComboClick);
            // 
            // editNumero
            // 
            this.editNumero.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editNumero.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editNumero.BackColor = System.Drawing.Color.Transparent;
            this.editNumero.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editNumero.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editNumero.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editNumero.Changed = true;
            this.editNumero.Editing = false;
            this.editNumero.Label = "Numero";
            this.editNumero.LabelWidth = 175;
            this.editNumero.Location = new System.Drawing.Point(25, 238);
            this.editNumero.Name = "editNumero";
            this.editNumero.ReadOnly = false;
            this.editNumero.Required = true;
            this.editNumero.Size = new System.Drawing.Size(811, 30);
            this.editNumero.TabIndex = 4;
            this.editNumero.Text = "TemplateEditPartitaIva";
            this.editNumero.Value = "---";
            // 
            // editIDConto
            // 
            this.editIDConto.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIDConto.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIDConto.BackColor = System.Drawing.Color.Transparent;
            this.editIDConto.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIDConto.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIDConto.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIDConto.Changed = true;
            this.editIDConto.Editing = false;
            this.editIDConto.Label = "Id conto";
            this.editIDConto.LabelWidth = 175;
            this.editIDConto.Location = new System.Drawing.Point(25, 367);
            this.editIDConto.Name = "editIDConto";
            this.editIDConto.ReadOnly = false;
            this.editIDConto.Required = true;
            this.editIDConto.Size = new System.Drawing.Size(811, 30);
            this.editIDConto.TabIndex = 7;
            this.editIDConto.Text = "EditControl";
            this.editIDConto.Value = null;
            // 
            // editTipo
            // 
            this.editTipo.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTipo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTipo.BackColor = System.Drawing.Color.Transparent;
            this.editTipo.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTipo.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTipo.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTipo.Changed = true;
            this.editTipo.Editing = false;
            this.editTipo.Label = "Tipo";
            this.editTipo.LabelWidth = 175;
            this.editTipo.Location = new System.Drawing.Point(25, 195);
            this.editTipo.Name = "editTipo";
            this.editTipo.ReadOnly = false;
            this.editTipo.Required = true;
            this.editTipo.Size = new System.Drawing.Size(811, 30);
            this.editTipo.TabIndex = 3;
            this.editTipo.Text = "TemplateEditPartitaIva";
            this.editTipo.Value = "---";
            // 
            // editIDIVA
            // 
            this.editIDIVA.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIDIVA.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIDIVA.BackColor = System.Drawing.Color.Transparent;
            this.editIDIVA.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIDIVA.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIDIVA.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIDIVA.Changed = true;
            this.editIDIVA.Editing = false;
            this.editIDIVA.Label = "Id IVA";
            this.editIDIVA.LabelWidth = 175;
            this.editIDIVA.Location = new System.Drawing.Point(25, 453);
            this.editIDIVA.Name = "editIDIVA";
            this.editIDIVA.ReadOnly = false;
            this.editIDIVA.Required = false;
            this.editIDIVA.Size = new System.Drawing.Size(811, 30);
            this.editIDIVA.TabIndex = 9;
            this.editIDIVA.Text = "TemplateEditEmail";
            this.editIDIVA.Value = null;
            // 
            // editIDRegistroIVA
            // 
            this.editIDRegistroIVA.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIDRegistroIVA.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIDRegistroIVA.BackColor = System.Drawing.Color.Transparent;
            this.editIDRegistroIVA.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIDRegistroIVA.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIDRegistroIVA.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIDRegistroIVA.Changed = true;
            this.editIDRegistroIVA.Editing = false;
            this.editIDRegistroIVA.Label = "Id registro IVA";
            this.editIDRegistroIVA.LabelWidth = 175;
            this.editIDRegistroIVA.Location = new System.Drawing.Point(25, 410);
            this.editIDRegistroIVA.Name = "editIDRegistroIVA";
            this.editIDRegistroIVA.ReadOnly = false;
            this.editIDRegistroIVA.Required = true;
            this.editIDRegistroIVA.Size = new System.Drawing.Size(811, 30);
            this.editIDRegistroIVA.TabIndex = 8;
            this.editIDRegistroIVA.Text = "EditControl";
            this.editIDRegistroIVA.Value = null;
            // 
            // editIDCausale
            // 
            this.editIDCausale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIDCausale.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIDCausale.BackColor = System.Drawing.Color.Transparent;
            this.editIDCausale.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIDCausale.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIDCausale.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIDCausale.Changed = true;
            this.editIDCausale.Editing = false;
            this.editIDCausale.Label = "Id causale";
            this.editIDCausale.LabelWidth = 175;
            this.editIDCausale.Location = new System.Drawing.Point(25, 324);
            this.editIDCausale.Name = "editIDCausale";
            this.editIDCausale.ReadOnly = false;
            this.editIDCausale.Required = true;
            this.editIDCausale.Size = new System.Drawing.Size(811, 30);
            this.editIDCausale.TabIndex = 6;
            this.editIDCausale.Text = "EditControl";
            this.editIDCausale.Value = null;
            // 
            // editIDMovimento
            // 
            this.editIDMovimento.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIDMovimento.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIDMovimento.BackColor = System.Drawing.Color.Transparent;
            this.editIDMovimento.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIDMovimento.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIDMovimento.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIDMovimento.Changed = true;
            this.editIDMovimento.Editing = false;
            this.editIDMovimento.Label = "ID movimento";
            this.editIDMovimento.LabelWidth = 175;
            this.editIDMovimento.Location = new System.Drawing.Point(25, 152);
            this.editIDMovimento.Name = "editIDMovimento";
            this.editIDMovimento.ReadOnly = false;
            this.editIDMovimento.Required = true;
            this.editIDMovimento.Size = new System.Drawing.Size(811, 30);
            this.editIDMovimento.TabIndex = 2;
            this.editIDMovimento.Text = "EditControl";
            this.editIDMovimento.Value = null;
            // 
            // editLocalita
            // 
            this.editLocalita.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editLocalita.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editLocalita.BackColor = System.Drawing.Color.Transparent;
            this.editLocalita.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editLocalita.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editLocalita.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editLocalita.Changed = true;
            this.editLocalita.Editing = false;
            this.editLocalita.Label = "Località";
            this.editLocalita.LabelWidth = 175;
            this.editLocalita.Location = new System.Drawing.Point(55, 266);
            this.editLocalita.Name = "editLocalita";
            this.editLocalita.ReadOnly = false;
            this.editLocalita.Required = false;
            this.editLocalita.Size = new System.Drawing.Size(813, 30);
            this.editLocalita.TabIndex = 5;
            this.editLocalita.Text = "EditControl";
            this.editLocalita.Value = null;
            // 
            // editIDCliente
            // 
            this.editIDCliente.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIDCliente.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIDCliente.BackColor = System.Drawing.Color.Transparent;
            this.editIDCliente.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIDCliente.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIDCliente.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIDCliente.Changed = true;
            this.editIDCliente.Editing = false;
            this.editIDCliente.Label = "Id cliente";
            this.editIDCliente.LabelWidth = 175;
            this.editIDCliente.Location = new System.Drawing.Point(25, 109);
            this.editIDCliente.Name = "editIDCliente";
            this.editIDCliente.ReadOnly = false;
            this.editIDCliente.Required = true;
            this.editIDCliente.Size = new System.Drawing.Size(811, 30);
            this.editIDCliente.TabIndex = 1;
            this.editIDCliente.Text = "EditControl";
            this.editIDCliente.Value = null;
            // 
            // editData
            // 
            this.editData.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editData.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editData.BackColor = System.Drawing.Color.Transparent;
            this.editData.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editData.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editData.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editData.Changed = true;
            this.editData.Editing = false;
            this.editData.Label = "Data";
            this.editData.LabelWidth = 175;
            this.editData.Location = new System.Drawing.Point(25, 281);
            this.editData.Name = "editData";
            this.editData.ReadOnly = false;
            this.editData.Required = false;
            this.editData.Size = new System.Drawing.Size(811, 30);
            this.editData.TabIndex = 5;
            this.editData.Value = null;
            // 
            // editImponibile
            // 
            this.editImponibile.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editImponibile.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editImponibile.BackColor = System.Drawing.Color.Transparent;
            this.editImponibile.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editImponibile.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editImponibile.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editImponibile.Changed = true;
            this.editImponibile.Editing = false;
            this.editImponibile.Label = "Imponibile";
            this.editImponibile.LabelWidth = 175;
            this.editImponibile.Location = new System.Drawing.Point(25, 496);
            this.editImponibile.Name = "templateEditNumeric1";
            this.editImponibile.ReadOnly = false;
            this.editImponibile.Required = false;
            this.editImponibile.Size = new System.Drawing.Size(811, 30);
            this.editImponibile.TabIndex = 10;
            this.editImponibile.Value = null;
            // 
            // editIVA
            // 
            this.editIVA.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editIVA.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editIVA.BackColor = System.Drawing.Color.Transparent;
            this.editIVA.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editIVA.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editIVA.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editIVA.Changed = true;
            this.editIVA.Editing = false;
            this.editIVA.Label = "IVA";
            this.editIVA.LabelWidth = 175;
            this.editIVA.Location = new System.Drawing.Point(25, 539);
            this.editIVA.Name = "templateEditNumeric2";
            this.editIVA.ReadOnly = false;
            this.editIVA.Required = false;
            this.editIVA.Size = new System.Drawing.Size(811, 30);
            this.editIVA.TabIndex = 11;
            this.editIVA.Value = null;
            // 
            // editTotale
            // 
            this.editTotale.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTotale.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTotale.BackColor = System.Drawing.Color.Transparent;
            this.editTotale.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTotale.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTotale.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTotale.Changed = true;
            this.editTotale.Editing = false;
            this.editTotale.Label = "Totale";
            this.editTotale.LabelWidth = 175;
            this.editTotale.Location = new System.Drawing.Point(25, 582);
            this.editTotale.Name = "templateEditNumeric3";
            this.editTotale.ReadOnly = false;
            this.editTotale.Required = false;
            this.editTotale.Size = new System.Drawing.Size(811, 30);
            this.editTotale.TabIndex = 12;
            this.editTotale.Value = null;
            // 
            // editDataRegistrazione
            // 
            this.editDataRegistrazione.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editDataRegistrazione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editDataRegistrazione.BackColor = System.Drawing.Color.Transparent;
            this.editDataRegistrazione.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editDataRegistrazione.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editDataRegistrazione.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editDataRegistrazione.Changed = true;
            this.editDataRegistrazione.Editing = false;
            this.editDataRegistrazione.Label = "Data registrazione";
            this.editDataRegistrazione.LabelWidth = 175;
            this.editDataRegistrazione.Location = new System.Drawing.Point(25, 625);
            this.editDataRegistrazione.Name = "templateEditDate1";
            this.editDataRegistrazione.ReadOnly = false;
            this.editDataRegistrazione.Required = false;
            this.editDataRegistrazione.Size = new System.Drawing.Size(811, 30);
            this.editDataRegistrazione.TabIndex = 13;
            this.editDataRegistrazione.Value = null;
            // 
            // DocumentoModel
            // 
            this.Size = new System.Drawing.Size(1024, 740);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.panelCommands.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditCombo editExport;
        private Library.Template.Controls.TemplateEditText editIDCliente;
        private Library.Template.Controls.TemplateEditText editIDMovimento;
        private Library.Template.Controls.TemplateEditText editIDCausale;
        private Library.Template.Controls.TemplateEditText editIDRegistroIVA;
        private Library.Template.Controls.TemplateEditText editIDIVA;
        private Library.Template.Controls.TemplateEditText editTipo;
        private Library.Template.Controls.TemplateEditText editIDConto;
        private Library.Template.Controls.TemplateEditText editNumero;
        private Library.Template.Controls.TemplateEditText editLocalita;
        private Library.Template.Controls.TemplateEditDate editData;
        private Library.Template.Controls.TemplateEditDate editDataRegistrazione;
        private Library.Template.Controls.TemplateEditDecimal editTotale;
        private Library.Template.Controls.TemplateEditDecimal editIVA;
        private Library.Template.Controls.TemplateEditDecimal editImponibile;


    }
}
