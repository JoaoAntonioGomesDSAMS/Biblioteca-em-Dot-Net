namespace Biblioteca.Models


{
    public class EmprestimoModel
    {
        public int Id { get; set; }
        string Recebedor { get; set; }
        string Fornecedor { get; set; }
        string LivroEmprestado { get; set; }
        DateTime DataEmprestimo { get; set; } = DateTime.Now;
    }
}
