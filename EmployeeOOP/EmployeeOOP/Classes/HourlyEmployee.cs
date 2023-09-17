namespace EmployeeOOP.Classes
{
    public class HourlyEmployee : Employee
    {
        #region Properties

        public decimal HourV { get; set; }

        public int Hours { get; set; }

        #endregion

        #region Methods

        public HourlyEmployee() { }

        public override decimal GetValueToPay()
        {
            return HourV * Hours;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"El valor a pagar es: {HourV * Hours:C2}\n\t";
        }

        #endregion
    }
}
