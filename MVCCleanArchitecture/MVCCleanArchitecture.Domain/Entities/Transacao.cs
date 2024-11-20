namespace MVCCleanArchitecture.Domain.Entities
{
    public class Transacao
    {
        public int TransacaoID { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Status> Status { get; set; }
    }
}
