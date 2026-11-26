using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TaskManager2
{
    partial class Form1
    {
        // säilyttää lomakkeen komponentit
        private System.ComponentModel.IContainer components = null;

        // lomakkeen tekstikentät ja painikkeet
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Label labelTaskCount;

        // vapauttaa lomakkeen käyttämät resurssit
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // luo ja määrittää lomakkeen käyttöliittymän
        private void InitializeComponent()
        {
            // luodaan käyttöliittymän komponentit
            labelTitle = new System.Windows.Forms.Label();
            labelTask = new System.Windows.Forms.Label();
            textBoxTask = new System.Windows.Forms.TextBox();
            buttonAdd = new System.Windows.Forms.Button();
            buttonRemove = new System.Windows.Forms.Button();
            buttonComplete = new System.Windows.Forms.Button();
            buttonSettings = new System.Windows.Forms.Button();
            listBoxTasks = new System.Windows.Forms.ListBox();
            labelTaskCount = new System.Windows.Forms.Label();

            // valmistellaan lomake
            SuspendLayout();

            // määrittää otsikon ulkoasun ja sijainnin
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font(
                "Segoe UI",
                20F,
                System.Drawing.FontStyle.Bold);
            labelTitle.Location = new System.Drawing.Point(30, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Text = "Task Manager";

            // määrittää tehtävätekstin
            labelTask.AutoSize = true;
            labelTask.Location = new System.Drawing.Point(30, 85);
            labelTask.Name = "labelTask";
            labelTask.Text = "New task:";

            // määrittää tehtävän syöttökentän
            textBoxTask.Location = new System.Drawing.Point(30, 110);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new System.Drawing.Size(350, 23);

            // käynnistää toiminnon kun enteriä painetaan
            textBoxTask.KeyDown += textBoxTask_KeyDown;

            // määrittää lisää painikkeen
            buttonAdd.Location = new System.Drawing.Point(400, 109);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(100, 25);
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;

            // yhdistää painikkeen lisää toiminnon
            buttonAdd.Click += buttonAdd_Click;

            // määrittää tehtävälistan ulkoasun
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 15;
            listBoxTasks.Location = new System.Drawing.Point(30, 155);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new System.Drawing.Size(470, 184);

            // määrittää valmis painikkeen
            buttonComplete.Location = new System.Drawing.Point(30, 355);
            buttonComplete.Name = "buttonComplete";
            buttonComplete.Size = new System.Drawing.Size(110, 30);
            buttonComplete.Text = "Complete";
            buttonComplete.UseVisualStyleBackColor = true;

            // yhdistää painikkeen valmis toiminnon
            buttonComplete.Click += buttonComplete_Click;

            // määrittää poista painikkeen
            buttonRemove.Location = new System.Drawing.Point(150, 355);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new System.Drawing.Size(110, 30);
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;

            // yhdistää painikkeen poista toiminnon
            buttonRemove.Click += buttonRemove_Click;

            // määrittää asetukset painikkeen
            buttonSettings.Location = new System.Drawing.Point(390, 355);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new System.Drawing.Size(110, 30);
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = true;

            // yhdistää painikkeen asetukset toiminnon
            buttonSettings.Click += buttonSettings_Click;

            // näyttää tehtävien kokonaismäärän
            labelTaskCount.AutoSize = true;
            labelTaskCount.Location = new System.Drawing.Point(30, 405);
            labelTaskCount.Name = "labelTaskCount";
            labelTaskCount.Text = "Tasks: 0";

            // määrittää lomakkeen skaalausasetukset
            AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            // määrittää ikkunan koon
            ClientSize = new System.Drawing.Size(540, 450);

            // lisää komponentit lomakkeelle
            Controls.Add(labelTitle);
            Controls.Add(labelTask);
            Controls.Add(textBoxTask);
            Controls.Add(buttonAdd);
            Controls.Add(buttonRemove);
            Controls.Add(buttonComplete);
            Controls.Add(buttonSettings);
            Controls.Add(listBoxTasks);
            Controls.Add(labelTaskCount);

            // estää ikkunan koon muuttamisen
            FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            // piilottaa suurennuspainikkeen
            MaximizeBox = false;

            // määrittää lomakkeen nimen
            Name = "Form1";

            // avaa ikkunan näytön keskelle
            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            // määrittää ikkunan otsikon
            Text = "Task Manager";

            // viimeistelee lomakkeen asettelun
            ResumeLayout(false);
            PerformLayout();
        }
    }
}