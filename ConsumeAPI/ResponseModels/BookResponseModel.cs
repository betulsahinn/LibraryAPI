namespace ConsumeAPI.ResponseModels
{
    public class BookResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public int pageSize { get; set; }
        public int Price { get; set; }
    }
}
