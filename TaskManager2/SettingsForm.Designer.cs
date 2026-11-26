namespace TaskManager2
{
    partial class SettingsForm
    {
        // säilyttää lomakkeen komponentit
        private System.ComponentModel.IContainer components = null;

        // asetukset ikkunan tekstikentät ja painikkeet
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;

        // vapauttaa lomakkeen käyttämät resurssit
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // luo ja määrittää asetukset ikkunan käyttöliittymän
        private void InitializeComponent()
        {
            // luodaan käyttöliittymän komponentit
            labelTitle = new System.Windows.Forms.Label();
            labelInfo = new System.Windows.Forms.Label();
            buttonClear = new System.Windows.Forms.Button();
            buttonClose = new System.Windows.Forms.Button();

            // valmistellaan lomake
            SuspendLayout();

            // määrittää otsikon ulkoasun ja sijainnin
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                18F,
                System.Drawing.FontStyle.Bold);

            labelTitle.Location =
                new System.Drawing.Point(30, 25);

            labelTitle.Name = "labelTitle";
            labelTitle.Text = "Settings";

            // määrittää lisätietotekstin
            labelInfo.AutoSize = true;
            labelInfo.Location =
                new System.Drawing.Point(30, 80);

            labelInfo.Name = "labelInfo";
            labelInfo.Text =
                "Manage your Task Manager application.";

            // määrittää tyhjennä painikkeen
            buttonClear.Location =
                new System.Drawing.Point(30, 120);

            buttonClear.Name = "buttonClear";
            buttonClear.Size =
                new System.Drawing.Size(160, 35);

            buttonClear.Text = "Clear all tasks";
            buttonClear.UseVisualStyleBackColor = true;

            // yhdistää painikkeen tehtävien tyhjennystoimintoon
            buttonClear.Click += buttonClear_Click;

            // määrittää sulje painikkeen
            buttonClose.Location =
                new System.Drawing.Point(210, 120);

            buttonClose.Name = "buttonClose";
            buttonClose.Size =
                new System.Drawing.Size(100, 35);

            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;

            // yhdistää painikkeen sulkemistoimintoon
            buttonClose.Click += buttonClose_Click;

            // määrittää lomakkeen skaalausasetukset
            AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            // määrittää ikkunan koon
            ClientSize =
                new System.Drawing.Size(350, 200);

            // lisää komponentit lomakkeelle
            Controls.Add(labelTitle);
            Controls.Add(labelInfo);
            Controls.Add(buttonClear);
            Controls.Add(buttonClose);

            // estää ikkunan koon muuttamisen
            FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            // piilottaa suurennuspainikkeen
            MaximizeBox = false;

            // määrittää lomakkeen nimen
            Name = "SettingsForm";

            // avaa ikkunan pääikkunan keskelle
            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;

            // määrittää ikkunan otsikon
            Text = "Settings";

            // viimeistelee lomakkeen asettelun
            ResumeLayout(false);
            PerformLayout();
        }
    }
}