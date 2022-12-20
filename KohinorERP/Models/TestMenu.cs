namespace KohinorERP.Models
{
    public class TestMenu
    {
        public List<Menu> MenuList { get; set; }
    }
    public class Menu
    {
        public int id { get; set; }
        public string nameMenu { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
    }
}
