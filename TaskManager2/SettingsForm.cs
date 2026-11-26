using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskManager2
{
    public partial class SettingsForm : Form
    {
        // lista johon tehtävät tallennetaan
        private List<TaskItem> tasks;

        // alustaa asetukset ikkunan ja vastaanottaa tehtävälistan
        public SettingsForm(List<TaskItem> taskList)
        {
            InitializeComponent();

            // yhdistää tehtävälistan asetukset ikkunaan
            tasks = taskList;
        }

        // poistaa kaikki tehtävät listasta
        private void ClearTasks()
        {
            // pyytää käyttäjältä vahvistuksen poistamiseen
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete all tasks?",
                "Confirm",
                MessageBoxButtons.YesNo);

            // tarkistaa käyttäjän valinnan
            if (result == DialogResult.Yes)
            {
                tasks.Clear();

                // ilmoittaa tehtävien poistamisesta
                MessageBox.Show("All tasks were deleted.");
            }
        }

        // tyhjennä painikkeen tapahtumakäsittelijä
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearTasks();
        }

        // sulje painikkeen tapahtumakäsittelijä
        private void buttonClose_Click(object sender, EventArgs e)
        {
            // sulkee asetukset ikkunan
            Close();
        }
    }
}