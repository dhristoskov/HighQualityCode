namespace FurnitureManufacturer.Interfaces
{
    /// <summary>
    /// Interface for classes capable of creating Chairs
    /// </summary>
    public interface IChair : IFurniture
    {
        /// <summary>
        /// Chairs number of legs
        /// </summary>
        int NumberOfLegs { get; }
    }
}
