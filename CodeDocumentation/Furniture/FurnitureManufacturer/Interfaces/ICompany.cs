namespace FurnitureManufacturer.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for classes capable of creating Company
    /// </summary>
    public interface ICompany
    {
        /// <summary>
        /// Company Name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Company Registration Number
        /// </summary>
        string RegistrationNumber { get; }

        /// <summary>
        /// Company collection of Furnitures
        /// </summary>
        ICollection<IFurniture> Furnitures { get; }

        /// <summary>
        /// Add new Furniture in the 
        /// company collection
        /// </summary>
        /// <param name="furniture">inputted new furniture</param>
        void Add(IFurniture furniture);

        /// <summary>
        /// Remove existing Furniture from the 
        /// company collection
        /// </summary>
        /// <param name="furniture">searched furniture</param>
        void Remove(IFurniture furniture);

        /// <summary>
        /// Check if given furniture is 
        /// part of the company collection
        /// </summary>
        /// <param name="model">searched furniture model</param>
        /// <returns></returns>
        IFurniture Find(string model);

        /// <summary>
        /// Company catalog of furnitures 
        /// </summary>
        /// <returns></returns>
        string Catalog();
    }
}
