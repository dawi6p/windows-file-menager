
namespace listaH5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.okno12 = new System.Windows.Forms.Button();
            this.Otworz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.scierzka = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.dane = new System.Windows.Forms.RichTextBox();
            this.nazwa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ikony = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.UtworzFolder = new System.Windows.Forms.Button();
            this.Usun = new System.Windows.Forms.Button();
            this.ZmianaNazwy = new System.Windows.Forms.Button();
            this.Kopiuj = new System.Windows.Forms.Button();
            this.Przenies = new System.Windows.Forms.Button();
            this.Przeszukaj = new System.Windows.Forms.Button();
            this.UtworzPlik = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okno12
            // 
            this.okno12.Location = new System.Drawing.Point(103, 15);
            this.okno12.Name = "okno12";
            this.okno12.Size = new System.Drawing.Size(85, 34);
            this.okno12.TabIndex = 2;
            this.okno12.Text = "Okno 1";
            this.okno12.UseVisualStyleBackColor = true;
            this.okno12.Click += new System.EventHandler(this.okno12_Click);
            // 
            // Otworz
            // 
            this.Otworz.Location = new System.Drawing.Point(194, 15);
            this.Otworz.Name = "Otworz";
            this.Otworz.Size = new System.Drawing.Size(122, 34);
            this.Otworz.TabIndex = 3;
            this.Otworz.Text = "Wybierz Folder";
            this.Otworz.UseVisualStyleBackColor = true;
            this.Otworz.Click += new System.EventHandler(this.Otworz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scieżka:";
            // 
            // scierzka
            // 
            this.scierzka.AutoSize = true;
            this.scierzka.BackColor = System.Drawing.SystemColors.Info;
            this.scierzka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.scierzka.Location = new System.Drawing.Point(97, 103);
            this.scierzka.Name = "scierzka";
            this.scierzka.Size = new System.Drawing.Size(0, 20);
            this.scierzka.TabIndex = 5;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.back.Location = new System.Drawing.Point(12, 15);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(85, 34);
            this.back.TabIndex = 6;
            this.back.Text = "<<<";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dane
            // 
            this.dane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dane.Location = new System.Drawing.Point(772, 135);
            this.dane.Name = "dane";
            this.dane.ReadOnly = true;
            this.dane.Size = new System.Drawing.Size(250, 399);
            this.dane.TabIndex = 7;
            this.dane.Text = "";
            // 
            // nazwa
            // 
            this.nazwa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nazwa.Location = new System.Drawing.Point(194, 61);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(188, 22);
            this.nazwa.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(123, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nazwa:";
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Enabled = false;
            this.listView2.HideSelection = false;
            this.listView2.LargeImageList = this.ikony;
            this.listView2.Location = new System.Drawing.Point(391, 135);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(375, 399);
            this.listView2.SmallImageList = this.ikony;
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.SmallIcon;
            this.listView2.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView2_ItemSelectionChanged);
            this.listView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
            // 
            // ikony
            // 
            this.ikony.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ikony.ImageStream")));
            this.ikony.TransparentColor = System.Drawing.Color.Transparent;
            this.ikony.Images.SetKeyName(0, "folder.png");
            this.ikony.Images.SetKeyName(1, "folder2.png");
            this.ikony.Images.SetKeyName(2, "file.png");
            this.ikony.Images.SetKeyName(3, "doc.png");
            this.ikony.Images.SetKeyName(4, "pdf.png");
            this.ikony.Images.SetKeyName(5, "mp3.png");
            this.ikony.Images.SetKeyName(6, "exe.png");
            this.ikony.Images.SetKeyName(7, "mp4.png");
            this.ikony.Images.SetKeyName(8, "file (1).png");
            this.ikony.Images.SetKeyName(9, "png-file-format-symbol.png");
            this.ikony.Images.SetKeyName(10, "txt-file.png");
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.ikony;
            this.listView1.Location = new System.Drawing.Point(14, 135);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(371, 399);
            this.listView1.SmallImageList = this.ikony;
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // UtworzFolder
            // 
            this.UtworzFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UtworzFolder.Location = new System.Drawing.Point(388, 55);
            this.UtworzFolder.Name = "UtworzFolder";
            this.UtworzFolder.Size = new System.Drawing.Size(122, 34);
            this.UtworzFolder.TabIndex = 15;
            this.UtworzFolder.Text = "Utwórz Folder";
            this.UtworzFolder.UseVisualStyleBackColor = true;
            this.UtworzFolder.Click += new System.EventHandler(this.UtworzFolder_Click);
            // 
            // Usun
            // 
            this.Usun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Usun.Location = new System.Drawing.Point(388, 15);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(122, 34);
            this.Usun.TabIndex = 16;
            this.Usun.Text = "Usuń";
            this.Usun.UseVisualStyleBackColor = true;
            this.Usun.Click += new System.EventHandler(this.Usun_Click);
            // 
            // ZmianaNazwy
            // 
            this.ZmianaNazwy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZmianaNazwy.Location = new System.Drawing.Point(644, 55);
            this.ZmianaNazwy.Name = "ZmianaNazwy";
            this.ZmianaNazwy.Size = new System.Drawing.Size(122, 34);
            this.ZmianaNazwy.TabIndex = 17;
            this.ZmianaNazwy.Text = "Zmiana Nazwy";
            this.ZmianaNazwy.UseVisualStyleBackColor = true;
            this.ZmianaNazwy.Click += new System.EventHandler(this.ZmianaNazwy_Click);
            // 
            // Kopiuj
            // 
            this.Kopiuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Kopiuj.Location = new System.Drawing.Point(516, 15);
            this.Kopiuj.Name = "Kopiuj";
            this.Kopiuj.Size = new System.Drawing.Size(122, 34);
            this.Kopiuj.TabIndex = 18;
            this.Kopiuj.Text = "Kopiuj do";
            this.Kopiuj.UseVisualStyleBackColor = true;
            this.Kopiuj.Click += new System.EventHandler(this.Kopiuj_Click);
            // 
            // Przenies
            // 
            this.Przenies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Przenies.Location = new System.Drawing.Point(644, 15);
            this.Przenies.Name = "Przenies";
            this.Przenies.Size = new System.Drawing.Size(122, 34);
            this.Przenies.TabIndex = 19;
            this.Przenies.Text = "Przenies do";
            this.Przenies.UseVisualStyleBackColor = true;
            this.Przenies.Click += new System.EventHandler(this.Przenies_Click);
            // 
            // Przeszukaj
            // 
            this.Przeszukaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Przeszukaj.Location = new System.Drawing.Point(772, 55);
            this.Przeszukaj.Name = "Przeszukaj";
            this.Przeszukaj.Size = new System.Drawing.Size(250, 34);
            this.Przeszukaj.TabIndex = 20;
            this.Przeszukaj.Text = "Znajdź Po Nazwie";
            this.Przeszukaj.UseVisualStyleBackColor = true;
            this.Przeszukaj.Click += new System.EventHandler(this.Przeszukaj_Click);
            // 
            // UtworzPlik
            // 
            this.UtworzPlik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UtworzPlik.Location = new System.Drawing.Point(516, 55);
            this.UtworzPlik.Name = "UtworzPlik";
            this.UtworzPlik.Size = new System.Drawing.Size(122, 34);
            this.UtworzPlik.TabIndex = 21;
            this.UtworzPlik.Text = "Utwórz Plik";
            this.UtworzPlik.UseVisualStyleBackColor = true;
            this.UtworzPlik.Click += new System.EventHandler(this.UtworzPlik_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(772, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Informacje o Dyskach";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UtworzPlik);
            this.Controls.Add(this.Przeszukaj);
            this.Controls.Add(this.Przenies);
            this.Controls.Add(this.Kopiuj);
            this.Controls.Add(this.ZmianaNazwy);
            this.Controls.Add(this.Usun);
            this.Controls.Add(this.UtworzFolder);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nazwa);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.back);
            this.Controls.Add(this.scierzka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Otworz);
            this.Controls.Add(this.okno12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okno12;
        private System.Windows.Forms.Button Otworz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scierzka;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.RichTextBox dane;
        private System.Windows.Forms.TextBox nazwa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList ikony;
        private System.Windows.Forms.Button UtworzFolder;
        private System.Windows.Forms.Button Usun;
        private System.Windows.Forms.Button ZmianaNazwy;
        private System.Windows.Forms.Button Kopiuj;
        private System.Windows.Forms.Button Przenies;
        private System.Windows.Forms.Button Przeszukaj;
        private System.Windows.Forms.Button UtworzPlik;
        private System.Windows.Forms.Button button1;
    }
}

