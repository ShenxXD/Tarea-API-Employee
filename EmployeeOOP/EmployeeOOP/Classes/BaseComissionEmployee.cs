namespace EmployeeOOP.Classes
{
    public class BaseComissionEmployee : ComissionEmployee
    {
        #region Properties

        public decimal BaseC { get; set; }

        #endregion

        #region Methods

        public BaseComissionEmployee() { }

        public override decimal GetValueToPay()
        {
            return ((ComissionPercentaje / 100) * Sales) + BaseC;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"El valor a pagar es: {((ComissionPercentaje / 100) * Sales) + BaseC:C2}\n\t";
        }

        #endregion
    }
}
