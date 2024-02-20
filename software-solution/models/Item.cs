namespace software_solution.models
{
    class Item
    {
        public string Id { get; private set; }
        public string Name { get; private set;  }
        public bool IsLoad { get; private set; }

        public Item(string newId)
        {
            Id = newId;
            IsLoad = true;
            Name = "n/d";
        }

        public Item(string newId, bool newIsLoad, string newName)
        {
            Id = newId;
            IsLoad = newIsLoad;
            Name = newName;            
        }

        public Item()
        {
            Id = null;
            IsLoad = true;
            Name = "n/d";
        }

        public void ReverseLoadUnload()
        {
            if (IsLoad)
            {
                IsLoad = false;
            }
            else
            {
                IsLoad = true;
            }
        }
    }
}
