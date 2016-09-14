using PayrollSystem.Models;

namespace PayrollSystem.Helpers
{
    internal static class ModelFinder
    {
        public static Employee GetEmployee(int id)
        {
            var model = new Employee();
            model.Read(id);
            return model;
        }

        public static PayrollPeriod GetPayrollPeriod(int id)
        {
            var model = new PayrollPeriod();
            model.Read(id);
            return model;
        }

        public static Detachment GetDetachment(int id)
        {
            var model = new Detachment();
            model.Read(id);
            return model;
        }
    }
}
