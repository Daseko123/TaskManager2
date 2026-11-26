namespace TaskManager2
{
    // tehtävää kuvaava luokka
    public class TaskItem
    {
        // tehtävän nimi
        public string Name { get; set; }

        // kertoo onko tehtävä suoritettu
        public bool IsCompleted { get; set; }

        // alustaa uuden tyhjän tehtävän
        public TaskItem()
        {
            Name = "";
            IsCompleted = false;
        }

        // alustaa uuden tehtävän annetulla nimellä
        public TaskItem(string name)
        {
            Name = name;
            IsCompleted = false;
        }
    }
}