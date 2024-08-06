using Domain.Validation;

namespace Domain.Entities
{
    public sealed class BancoContaCaixa : Entity
    {
        public string Numero { get; private set; }
        public string Digito { get; private set; }
        public string Nome { get; private set; }
        public string Tipo { get; private set; }
        public string Descricao { get; private set; }

        public int BancoAgenciaId { get; set; }
        public BancoAgencia BancoAgencia { get; set; }

        public BancoContaCaixa( int bancoAgenciaId,  string numero, string digito, string nome, string tipo, string descricao)
        {
            ValidateDomain(bancoAgenciaId, numero, digito, nome, tipo, descricao);
            BancoAgenciaId = bancoAgenciaId;
            Numero = numero;
            Digito = digito;
            Nome = nome;
            Tipo = tipo;
            Descricao = descricao;
        }

        public void Update(int bancoAgenciaId, string numero, string digito, string nome, string tipo, string descricao)
        {
            ValidateDomain(bancoAgenciaId, numero, digito, nome, tipo, descricao);
            Numero = numero;
            Digito = digito;
            Nome = nome;
            Tipo = tipo;
            Descricao = descricao;
        }

        private void ValidateDomain(int bancoAgenciaId, string numero, string digito, string nome, string tipo, string descricao)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(numero), "Número é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(digito), "Dígito é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(tipo), "Tipo é obrigatório.");
            DomainExceptionValidation.When(numero.Length < 1, "Número deve ter no mínimo 1 caractere.");
            DomainExceptionValidation.When(nome.Length < 3, "Nome deve ter no mínimo 3 caracteres.");
            DomainExceptionValidation.When(bancoAgenciaId <= 0, "BancoId é obrigatório.");
        }
    }
}
