namespace software_solution.models
{
    class Item
    {
        public string Id { get; private set; }

        public bool IsLoad { get; private set; }
        
        public Item(string newId, bool newIsLoad)
        {
            Id = newId;
            IsLoad = newIsLoad;
        }

        public bool InvertLoad() {
            IsLoad = !IsLoad;
            return IsLoad;
        }
    }
}
