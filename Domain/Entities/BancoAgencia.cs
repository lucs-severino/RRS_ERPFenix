using Domain.Validation;

namespace Domain.Entities
{
    public sealed class BancoAgencia : Entity
    {
        public string Numero { get; private set; }
        public string Digito { get; private set; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Contato { get; private set; }
        public string Observacao { get; private set; }
        public string Gerente { get; private set; }
        public int BancoId { get;  set; }
        public Banco Banco { get;  set; }
        public ICollection<BancoContaCaixa> BancoContaCaixas { get; private set; }

        public BancoAgencia(int bancoId, string numero, string digito, string nome, string telefone, string contato, string observacao, string gerente)
        {
            ValidateDomain(bancoId, numero, digito, nome, telefone, contato, observacao, gerente);
            BancoId = bancoId;
            Numero = numero;
            Digito = digito;
            Nome = nome;
            Telefone = telefone;
            Contato = contato;
            Observacao = observacao;
            Gerente = gerente;
            BancoContaCaixas = new List<BancoContaCaixa>();
        }

        public void Update(int bancoId, string numero, string digito, string nome, string telefone, string contato, string observacao, string gerente)
        {
            ValidateDomain(bancoId ,numero, digito, nome, telefone, contato, observacao, gerente);
            BancoId = bancoId;
            Numero = numero;
            Digito = digito;
            Nome = nome;
            Telefone = telefone;
            Contato = contato;
            Observacao = observacao;
            Gerente = gerente;
        }

        private void ValidateDomain(int bancoId, string numero, string digito, string nome, string telefone, string contato, string observacao, string gerente)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(numero), "Número é obrigatório.");
            DomainExceptionValidation.When(bancoId <= 0, "BancoId é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(digito), "Dígito é obrigatório.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome é obrigatório.");
            DomainExceptionValidation.When(numero.Length < 1, "Número deve ter no mínimo 1 caractere.");
            DomainExceptionValidation.When(nome.Length < 3, "Nome deve ter no mínimo 3 caracteres.");
        }
    }

}

