namespace WebApp.Models
{
    public class PowerUse
    {
        public int Use_Id { get; set; }
        public DateTime Period { get; set; }

        public int UsedkWh {  get; set; }

        public int ProducedkWh { get; set; }

        public PowerUse(DateTime period, int usedkWh, int producedkWk)
        {
            this.Period = period;
            this.UsedkWh = usedkWh;
            this.ProducedkWh = producedkWk;
        }
        public PowerUse()
        {
            
        }

    }
}
