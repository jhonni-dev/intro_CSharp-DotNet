namespace Interface
{
    interface Ianimal
    {
        void Nome(string nome);
        void Dono(string nomeDono);
        void Especie(string especie);
    }

    class Animal : Ianimal
    {
        public string Nome { get; set; }
        public string NomeDono { get; set; }
        public string Especie { get; set; }


        void Ianimal.Nome(string nome)
        {
            this.Nome = nome;
        }
        void Ianimal.Dono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }
        void Ianimal.Especie(string especie)
        {
            this.Especie = especie;
        }
    }
}
