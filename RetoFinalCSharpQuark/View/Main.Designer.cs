
namespace RetoFinalCSharpQuark.View
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.SecondText = new System.Windows.Forms.Panel();
            this.lblSellerNameAndCode = new System.Windows.Forms.Label();
            this.btnQuotes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtShirt = new System.Windows.Forms.RadioButton();
            this.rbtJean = new System.Windows.Forms.RadioButton();
            this.cbxShort = new System.Windows.Forms.CheckBox();
            this.cbxMaoNeck = new System.Windows.Forms.CheckBox();
            this.cbxSlim = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtStandar = new System.Windows.Forms.RadioButton();
            this.rbtPremium = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMakeQuote = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuoteValue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SecondText.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 90);
            this.panel1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(316, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(166, 39);
            this.Title.TabIndex = 0;
            this.Title.Text = "Cotizador";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondText
            // 
            this.SecondText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SecondText.Controls.Add(this.btnQuotes);
            this.SecondText.Controls.Add(this.lblSellerNameAndCode);
            this.SecondText.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondText.Location = new System.Drawing.Point(0, 90);
            this.SecondText.Name = "SecondText";
            this.SecondText.Size = new System.Drawing.Size(800, 35);
            this.SecondText.TabIndex = 1;
            // 
            // lblSellerNameAndCode
            // 
            this.lblSellerNameAndCode.AutoSize = true;
            this.lblSellerNameAndCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerNameAndCode.Location = new System.Drawing.Point(12, 6);
            this.lblSellerNameAndCode.Name = "lblSellerNameAndCode";
            this.lblSellerNameAndCode.Size = new System.Drawing.Size(80, 16);
            this.lblSellerNameAndCode.TabIndex = 0;
            this.lblSellerNameAndCode.Text = "Seller name";
            // 
            // btnQuotes
            // 
            this.btnQuotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuotes.Location = new System.Drawing.Point(634, 3);
            this.btnQuotes.Name = "btnQuotes";
            this.btnQuotes.Size = new System.Drawing.Size(144, 23);
            this.btnQuotes.TabIndex = 1;
            this.btnQuotes.Text = "Historial de cotizaciones";
            this.btnQuotes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxSlim);
            this.groupBox1.Controls.Add(this.cbxMaoNeck);
            this.groupBox1.Controls.Add(this.cbxShort);
            this.groupBox1.Controls.Add(this.rbtJean);
            this.groupBox1.Controls.Add(this.rbtShirt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda";
            // 
            // rbtShirt
            // 
            this.rbtShirt.AutoSize = true;
            this.rbtShirt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtShirt.Location = new System.Drawing.Point(25, 30);
            this.rbtShirt.Name = "rbtShirt";
            this.rbtShirt.Size = new System.Drawing.Size(102, 29);
            this.rbtShirt.TabIndex = 0;
            this.rbtShirt.TabStop = true;
            this.rbtShirt.Text = "Camisa";
            this.rbtShirt.UseVisualStyleBackColor = true;
            // 
            // rbtJean
            // 
            this.rbtJean.AutoSize = true;
            this.rbtJean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtJean.Location = new System.Drawing.Point(25, 117);
            this.rbtJean.Name = "rbtJean";
            this.rbtJean.Size = new System.Drawing.Size(115, 29);
            this.rbtJean.TabIndex = 1;
            this.rbtJean.TabStop = true;
            this.rbtJean.Text = "Pantalón";
            this.rbtJean.UseVisualStyleBackColor = true;
            // 
            // cbxShort
            // 
            this.cbxShort.AutoSize = true;
            this.cbxShort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxShort.Location = new System.Drawing.Point(259, 30);
            this.cbxShort.Name = "cbxShort";
            this.cbxShort.Size = new System.Drawing.Size(151, 29);
            this.cbxShort.TabIndex = 2;
            this.cbxShort.Text = "Manga corta";
            this.cbxShort.UseVisualStyleBackColor = true;
            // 
            // cbxMaoNeck
            // 
            this.cbxMaoNeck.AutoSize = true;
            this.cbxMaoNeck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxMaoNeck.Location = new System.Drawing.Point(507, 30);
            this.cbxMaoNeck.Name = "cbxMaoNeck";
            this.cbxMaoNeck.Size = new System.Drawing.Size(139, 29);
            this.cbxMaoNeck.TabIndex = 3;
            this.cbxMaoNeck.Text = "Cuello mao";
            this.cbxMaoNeck.UseVisualStyleBackColor = true;
            // 
            // cbxSlim
            // 
            this.cbxSlim.AutoSize = true;
            this.cbxSlim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSlim.Location = new System.Drawing.Point(259, 117);
            this.cbxSlim.Name = "cbxSlim";
            this.cbxSlim.Size = new System.Drawing.Size(99, 29);
            this.cbxSlim.TabIndex = 4;
            this.cbxSlim.Text = "Chupín";
            this.cbxSlim.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblStock);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(25, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 46);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidades de stock disponibles:\r\n";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(237, 12);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(45, 20);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "____";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtPremium);
            this.groupBox2.Controls.Add(this.rbtStandar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad de prenda";
            // 
            // rbtStandar
            // 
            this.rbtStandar.AutoSize = true;
            this.rbtStandar.Location = new System.Drawing.Point(25, 45);
            this.rbtStandar.Name = "rbtStandar";
            this.rbtStandar.Size = new System.Drawing.Size(110, 29);
            this.rbtStandar.TabIndex = 0;
            this.rbtStandar.TabStop = true;
            this.rbtStandar.Text = "Standard";
            this.rbtStandar.UseVisualStyleBackColor = true;
            // 
            // rbtPremium
            // 
            this.rbtPremium.AutoSize = true;
            this.rbtPremium.Location = new System.Drawing.Point(204, 45);
            this.rbtPremium.Name = "rbtPremium";
            this.rbtPremium.Size = new System.Drawing.Size(107, 29);
            this.rbtPremium.TabIndex = 1;
            this.rbtPremium.TabStop = true;
            this.rbtPremium.Text = "Premium";
            this.rbtPremium.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbxAmount);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbxPrice);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(473, 400);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 83);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio unitario y cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "$";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(35, 39);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(86, 30);
            this.tbxPrice.TabIndex = 1;
            this.tbxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(224, 39);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(76, 30);
            this.tbxAmount.TabIndex = 3;
            this.tbxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAmount_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblQuoteValue);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnMakeQuote);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 507);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 128);
            this.panel3.TabIndex = 6;
            // 
            // btnMakeQuote
            // 
            this.btnMakeQuote.BackColor = System.Drawing.Color.DarkViolet;
            this.btnMakeQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeQuote.Location = new System.Drawing.Point(50, 39);
            this.btnMakeQuote.Name = "btnMakeQuote";
            this.btnMakeQuote.Size = new System.Drawing.Size(174, 52);
            this.btnMakeQuote.TabIndex = 0;
            this.btnMakeQuote.Text = "Cotizar";
            this.btnMakeQuote.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "$";
            // 
            // lblQuoteValue
            // 
            this.lblQuoteValue.AutoSize = true;
            this.lblQuoteValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoteValue.Location = new System.Drawing.Point(476, 44);
            this.lblQuoteValue.Name = "lblQuoteValue";
            this.lblQuoteValue.Size = new System.Drawing.Size(0, 37);
            this.lblQuoteValue.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SecondText);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SecondText.ResumeLayout(false);
            this.SecondText.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel SecondText;
        private System.Windows.Forms.Button btnQuotes;
        private System.Windows.Forms.Label lblSellerNameAndCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxSlim;
        private System.Windows.Forms.CheckBox cbxMaoNeck;
        private System.Windows.Forms.CheckBox cbxShort;
        private System.Windows.Forms.RadioButton rbtJean;
        private System.Windows.Forms.RadioButton rbtShirt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtPremium;
        private System.Windows.Forms.RadioButton rbtStandar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblQuoteValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMakeQuote;
    }
}