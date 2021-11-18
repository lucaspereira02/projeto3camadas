namespace Projeto3Camadas.Code.DTO
{
    class NetflixDTO
    {
        //Propriedades privadas
        private int _id;
        private string _filme;
        private string _categoria;

        public int Id { get => _id; set => _id = value; }
        public string Filme { get => _filme; set => _filme = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
    }
}
