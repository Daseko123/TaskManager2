using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager2;
using System.IO;
using System.Text.Json;

namespace TaskManager2
{
    public partial class Form1 : Form
    {
        // lista johon kaikki tehtävät tallennetaan
        private List<TaskItem> tasks = new List<TaskItem>();

        // json tiedoston nimi
        private string fileName = "tasks.json";

        public Form1()
        {
            InitializeComponent();

            // lataa tallennetut tehtävät ja päivittää listan
            LoadTasks();
            UpdateTaskList();
        }

        // lisää uuden tehtävän listaan
        private void AddTask()
        {
            string taskName = textBoxTask.Text.Trim();

            // tarkistaa ettei tehtävän nimi ole tyhjä
            if (string.IsNullOrWhiteSpace(taskName))
            {
                MessageBox.Show("Enter a task first.");
                return;
            }

            TaskItem newTask = new TaskItem(taskName);
            tasks.Add(newTask);

            textBoxTask.Clear();

            UpdateTaskList();
            SaveTasks();
        }

        // poistaa valitun tehtävän
        private void RemoveTask()
        {
            int selectedIndex = listBoxTasks.SelectedIndex;

            // tarkistaa onko tehtävä valittu
            if (selectedIndex < 0)
            {
                MessageBox.Show("Select a task first.");
                return;
            }

            tasks.RemoveAt(selectedIndex);

            UpdateTaskList();
            SaveTasks();
        }

        // merkitsee valitun tehtävän suoritetuksi
        private void CompleteTask()
        {
            int selectedIndex = listBoxTasks.SelectedIndex;

            // tarkistaa onko tehtävä valittu
            if (selectedIndex < 0)
            {
                MessageBox.Show("Select a task first.");
                return;
            }

            tasks[selectedIndex].IsCompleted = true;

            UpdateTaskList();
            SaveTasks();
        }

        // tallentaa tehtävät json tiedostoon
        private void SaveTasks()
        {
            try
            {
                string json = JsonSerializer.Serialize(
                    tasks,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                File.WriteAllText(fileName, json);
            }
            catch
            {
                // näyttää virheilmoituksen jos tallennus epäonnistuu
                MessageBox.Show("Could not save tasks.");
            }
        }

        // lataa tehtävät json tiedostosta
        private void LoadTasks()
        {
            try
            {
                // tarkistaa löytyykö tallennustiedosto
                if (!File.Exists(fileName))
                {
                    tasks = new List<TaskItem>();
                    return;
                }

                string json = File.ReadAllText(fileName);

                List<TaskItem> loadedTasks =
                    JsonSerializer.Deserialize<List<TaskItem>>(json);

                // siirtää ladatut tehtävät listaan
                if (loadedTasks != null)
                {
                    tasks = loadedTasks;
                }
            }
            catch
            {
                tasks = new List<TaskItem>();

                // näyttää virheilmoituksen jos lataaminen epäonnistuu
                MessageBox.Show("Could not load tasks.");
            }
        }

        // päivittää näytöllä näkyvän tehtävälistan
        private void UpdateTaskList()
        {
            listBoxTasks.Items.Clear();

            // käy kaikki tehtävät läpi
            for (int i = 0; i < tasks.Count; i++)
            {
                string status;

                // tarkistaa tehtävän suorittamisen tilan
                if (tasks[i].IsCompleted)
                {
                    status = "Completed";
                }
                else
                {
                    status = "Not completed";
                }

                listBoxTasks.Items.Add(
                    tasks[i].Name + " - " + status);
            }

            // päivittää tehtävien kokonaismäärän
            labelTaskCount.Text = "Tasks: " + tasks.Count;
        }

        // avaa asetukset ikkunan
        private void OpenSettings()
        {
            SettingsForm settingsForm = new SettingsForm(tasks);

            settingsForm.ShowDialog();

            UpdateTaskList();
            SaveTasks();
        }

        // lisää painikkeen tapahtumakäsittelijä
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTask();
        }

        // poista painikkeen tapahtumakäsittelijä
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveTask();
        }

        // valmis painikkeen tapahtumakäsittelijä
        private void buttonComplete_Click(object sender, EventArgs e)
        {
            CompleteTask();
        }

        // asetukset painikkeen tapahtumakäsittelijä
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }

        // lisää tehtävän myös enter näppäintä painamalla
        private void textBoxTask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddTask();
                e.SuppressKeyPress = true;
            }
        }
    }
}
