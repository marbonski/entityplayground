namespace entityplayground.Entites
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UserEntity Owner { get; set; }
    }
}
