namespace JPennacchi.Domain.Entities
{
    public class Documento
    {
        public Guid Id { get; set; }
        public TipoDocumento Tipo { get; set; }
        public string Numero { get; set; }
        public string Proprietario { get; set; }
    }
    public enum TipoDocumento
    {
        RG = 0,
        CPF = 1,
        CNPJ = 2
    }
}
