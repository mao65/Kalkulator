namespace Kalkulator
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
            this.zero = new System.Windows.Forms.Button();
            this.jeden = new System.Windows.Forms.Button();
            this.dwa = new System.Windows.Forms.Button();
            this.trzy = new System.Windows.Forms.Button();
            this.cztery = new System.Windows.Forms.Button();
            this.piec = new System.Windows.Forms.Button();
            this.szesc = new System.Windows.Forms.Button();
            this.siedem = new System.Windows.Forms.Button();
            this.osiem = new System.Windows.Forms.Button();
            this.dziewiec = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.RichTextBox();
            this.dodawanie = new System.Windows.Forms.Button();
            this.odejmowanie = new System.Windows.Forms.Button();
            this.mnozenie = new System.Windows.Forms.Button();
            this.dzielenie = new System.Windows.Forms.Button();
            this.kasuj = new System.Windows.Forms.Button();
            this.wyn1 = new System.Windows.Forms.Button();
            this.kropka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(157, 432);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(60, 60);
            this.zero.TabIndex = 0;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // jeden
            // 
            this.jeden.Location = new System.Drawing.Point(31, 348);
            this.jeden.Name = "jeden";
            this.jeden.Size = new System.Drawing.Size(60, 60);
            this.jeden.TabIndex = 1;
            this.jeden.Text = "1";
            this.jeden.UseVisualStyleBackColor = true;
            this.jeden.Click += new System.EventHandler(this.jeden_Click);
            // 
            // dwa
            // 
            this.dwa.Location = new System.Drawing.Point(157, 348);
            this.dwa.Name = "dwa";
            this.dwa.Size = new System.Drawing.Size(60, 60);
            this.dwa.TabIndex = 2;
            this.dwa.Text = "2";
            this.dwa.UseVisualStyleBackColor = true;
            this.dwa.Click += new System.EventHandler(this.dwa_Click);
            // 
            // trzy
            // 
            this.trzy.Location = new System.Drawing.Point(281, 348);
            this.trzy.Name = "trzy";
            this.trzy.Size = new System.Drawing.Size(60, 60);
            this.trzy.TabIndex = 3;
            this.trzy.Text = "3";
            this.trzy.UseVisualStyleBackColor = true;
            this.trzy.Click += new System.EventHandler(this.trzy_Click);
            // 
            // cztery
            // 
            this.cztery.Location = new System.Drawing.Point(31, 255);
            this.cztery.Name = "cztery";
            this.cztery.Size = new System.Drawing.Size(60, 60);
            this.cztery.TabIndex = 4;
            this.cztery.Text = "4";
            this.cztery.UseVisualStyleBackColor = true;
            this.cztery.Click += new System.EventHandler(this.cztery_Click);
            // 
            // piec
            // 
            this.piec.Location = new System.Drawing.Point(157, 255);
            this.piec.Name = "piec";
            this.piec.Size = new System.Drawing.Size(60, 60);
            this.piec.TabIndex = 5;
            this.piec.Text = "5";
            this.piec.UseVisualStyleBackColor = true;
            this.piec.Click += new System.EventHandler(this.piec_Click);
            // 
            // szesc
            // 
            this.szesc.Location = new System.Drawing.Point(281, 255);
            this.szesc.Name = "szesc";
            this.szesc.Size = new System.Drawing.Size(60, 60);
            this.szesc.TabIndex = 6;
            this.szesc.Text = "6";
            this.szesc.UseVisualStyleBackColor = true;
            this.szesc.Click += new System.EventHandler(this.szesc_Click);
            // 
            // siedem
            // 
            this.siedem.Location = new System.Drawing.Point(31, 162);
            this.siedem.Name = "siedem";
            this.siedem.Size = new System.Drawing.Size(60, 60);
            this.siedem.TabIndex = 7;
            this.siedem.Text = "7";
            this.siedem.UseVisualStyleBackColor = true;
            this.siedem.Click += new System.EventHandler(this.siedem_Click);
            // 
            // osiem
            // 
            this.osiem.Location = new System.Drawing.Point(157, 162);
            this.osiem.Name = "osiem";
            this.osiem.Size = new System.Drawing.Size(60, 60);
            this.osiem.TabIndex = 8;
            this.osiem.Text = "8";
            this.osiem.UseVisualStyleBackColor = true;
            this.osiem.Click += new System.EventHandler(this.osiem_Click);
            // 
            // dziewiec
            // 
            this.dziewiec.Location = new System.Drawing.Point(281, 162);
            this.dziewiec.Name = "dziewiec";
            this.dziewiec.Size = new System.Drawing.Size(60, 60);
            this.dziewiec.TabIndex = 9;
            this.dziewiec.Text = "9";
            this.dziewiec.UseVisualStyleBackColor = true;
            this.dziewiec.Click += new System.EventHandler(this.dziewiec_Click);
            // 
            // wynik
            // 
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(31, 13);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(310, 55);
            this.wynik.TabIndex = 10;
            this.wynik.Text = "0";
            // 
            // dodawanie
            // 
            this.dodawanie.Location = new System.Drawing.Point(31, 95);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(40, 40);
            this.dodawanie.TabIndex = 11;
            this.dodawanie.Text = "+";
            this.dodawanie.UseVisualStyleBackColor = true;
            this.dodawanie.Click += new System.EventHandler(this.dodawanie_Click);
            // 
            // odejmowanie
            // 
            this.odejmowanie.Location = new System.Drawing.Point(98, 95);
            this.odejmowanie.Name = "odejmowanie";
            this.odejmowanie.Size = new System.Drawing.Size(40, 40);
            this.odejmowanie.TabIndex = 12;
            this.odejmowanie.Text = "-";
            this.odejmowanie.UseVisualStyleBackColor = true;
            this.odejmowanie.Click += new System.EventHandler(this.odejmowanie_Click);
            // 
            // mnozenie
            // 
            this.mnozenie.Location = new System.Drawing.Point(167, 95);
            this.mnozenie.Name = "mnozenie";
            this.mnozenie.Size = new System.Drawing.Size(40, 40);
            this.mnozenie.TabIndex = 13;
            this.mnozenie.Text = "X";
            this.mnozenie.UseVisualStyleBackColor = true;
            this.mnozenie.Click += new System.EventHandler(this.mnozenie_Click);
            // 
            // dzielenie
            // 
            this.dzielenie.Location = new System.Drawing.Point(227, 95);
            this.dzielenie.Name = "dzielenie";
            this.dzielenie.Size = new System.Drawing.Size(40, 40);
            this.dzielenie.TabIndex = 14;
            this.dzielenie.Text = "/";
            this.dzielenie.UseVisualStyleBackColor = true;
            this.dzielenie.Click += new System.EventHandler(this.dzielenie_Click);
            // 
            // kasuj
            // 
            this.kasuj.Location = new System.Drawing.Point(301, 95);
            this.kasuj.Name = "kasuj";
            this.kasuj.Size = new System.Drawing.Size(40, 40);
            this.kasuj.TabIndex = 15;
            this.kasuj.Text = "C";
            this.kasuj.UseVisualStyleBackColor = true;
            this.kasuj.Click += new System.EventHandler(this.kasuj_Click);
            // 
            // wyn1
            // 
            this.wyn1.Location = new System.Drawing.Point(227, 432);
            this.wyn1.Name = "wyn1";
            this.wyn1.Size = new System.Drawing.Size(144, 60);
            this.wyn1.TabIndex = 16;
            this.wyn1.Text = "=";
            this.wyn1.UseVisualStyleBackColor = true;
            this.wyn1.Click += new System.EventHandler(this.wyn1_Click);
            // 
            // kropka
            // 
            this.kropka.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.kropka.Location = new System.Drawing.Point(31, 432);
            this.kropka.Name = "kropka";
            this.kropka.Size = new System.Drawing.Size(60, 60);
            this.kropka.TabIndex = 17;
            this.kropka.Text = ".";
            this.kropka.UseVisualStyleBackColor = true;
            this.kropka.Click += new System.EventHandler(this.kropka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 507);
            this.Controls.Add(this.kropka);
            this.Controls.Add(this.wyn1);
            this.Controls.Add(this.kasuj);
            this.Controls.Add(this.dzielenie);
            this.Controls.Add(this.mnozenie);
            this.Controls.Add(this.odejmowanie);
            this.Controls.Add(this.dodawanie);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.dziewiec);
            this.Controls.Add(this.osiem);
            this.Controls.Add(this.siedem);
            this.Controls.Add(this.szesc);
            this.Controls.Add(this.piec);
            this.Controls.Add(this.cztery);
            this.Controls.Add(this.trzy);
            this.Controls.Add(this.dwa);
            this.Controls.Add(this.jeden);
            this.Controls.Add(this.zero);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button jeden;
        private System.Windows.Forms.Button dwa;
        private System.Windows.Forms.Button trzy;
        private System.Windows.Forms.Button cztery;
        private System.Windows.Forms.Button piec;
        private System.Windows.Forms.Button szesc;
        private System.Windows.Forms.Button siedem;
        private System.Windows.Forms.Button osiem;
        private System.Windows.Forms.Button dziewiec;
        private System.Windows.Forms.RichTextBox wynik;
        private System.Windows.Forms.Button dodawanie;
        private System.Windows.Forms.Button odejmowanie;
        private System.Windows.Forms.Button mnozenie;
        private System.Windows.Forms.Button dzielenie;
        private System.Windows.Forms.Button kasuj;
        private System.Windows.Forms.Button wyn1;
        private System.Windows.Forms.Button kropka;
    }
}

