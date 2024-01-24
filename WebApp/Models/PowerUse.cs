namespace WebApp.Models
{
    public class PowerUse
    {
        public DateTime Period { get; set; }

        public int UsedkWh {  get; set; }

        public int ProducedkWh { get; set; }

        public PowerUse(DateTime period, int usedkWh, int producedkWk)
        {
            this.Period = period;
            this.UsedkWh = usedkWh;
            this.ProducedkWh = producedkWk;
        }

    }
}
