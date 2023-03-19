namespace MicroRabbit.MVC.Models.DTO
{
    public class TransferDto
    {
        public int FromType { get; set; }

        public int ToType { get; set; }

        public decimal TransferAmount { get; set; }
    }
}
