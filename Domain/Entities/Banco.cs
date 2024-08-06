using Domain.Validation;

namespace Domain.Entities

{
    public sealed class Banco : Entity
    {
        public string Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Url { get; private set; }
        public ICollection<BancoAgencia> BancoAgencias { get; private set; }

        public Banco(string codigo, string nome, string url)
        {
            ValidateDomain(codigo, nome, url);
            Codigo = codigo;
            Nome = nome;
            Url = url;
            BancoAgencias = new List<BancoAgencia>();
        }

        public void Update(string codigo, string nome, string url)
        {
            ValidateDomain(codigo, nome, url);
            Codigo = codigo;
            Nome = nome;
            Url = url;
        }

        private void ValidateDomain(string codigo, string nome, string url)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(codigo), "Código é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(url), "URL é obrigatória.");
            DomainExceptionValidation.When(nome.Length < 3, "Nome deve ter no mínimo 3 caracteres.");
        }
    }


}
