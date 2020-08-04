using System;

namespace Objects2
{
    public class EmployeePayroll
    {

        public EmployeePayroll()
        {
        }

        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }

        public string EmployeeEmail { get; set; } // TODO: Add email address validation
        
        public double EmployeePayRate { get; set; } // TODO: Only allow integers

        public double TaskQty { get; set; } // TODO: Only allow integers

        public double EmployeeExtraPay { get; set; } // TODO: Only allow integers

        public double EmployeeTotalPay { get; set; } // TODO: Only allow integers

        public string EmployeeComments { get; set; }

    }
}
