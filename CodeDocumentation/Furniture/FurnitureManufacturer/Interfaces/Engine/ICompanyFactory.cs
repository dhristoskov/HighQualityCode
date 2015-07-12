namespace FurnitureManufacturer.Interfaces.Engine
{
    /// <summary>
    /// Interface for classes capable to create class Company
    /// </summary>
    public interface ICompanyFactory
    {
        /// <summary>
        /// Create object of type ICompany
        /// </summary>
        /// <param name="name"></param>
        /// <param name="registrationNumber"></param>
        /// <returns>Company</returns>
        ICompany CreateCompany(string name, string registrationNumber);
    }
}
