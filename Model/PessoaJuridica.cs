using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios.Model;

    public class PessoaJuridica : Cliente
{

    public string CNPJ { get; set; }
    public string RazaoSocial { get; set; }
  
    public DateTime DataAbertura { get; set; }

    public PessoaJuridica(string email, string telefone, string endereco, int numeroConta, List<Transacao> extrato, string cnpj, string razaoSocial, DateTime dataAbertura) : base(email, telefone, endereco, numeroConta, extrato)
    {
        Email = email;
        Telefone = telefone;
        Endereco = endereco;
        NumeroConta = numeroConta;
        Extrato = extrato;
        CNPJ = cnpj;
        RazaoSocial = razaoSocial;
        DataAbertura = dataAbertura;
    }
    
    public override string ResumoCliente()
    {

        string resumo = $"{NumeroConta}  |  {RazaoSocial}   |  {CNPJ}";
        
        return resumo;
       
    }

}