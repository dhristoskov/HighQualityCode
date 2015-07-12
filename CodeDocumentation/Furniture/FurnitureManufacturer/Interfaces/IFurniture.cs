namespace FurnitureManufacturer.Interfaces
{
    /// <summary>
    /// Interface for classes capable of creating all Furniture
    /// classes Table,Chair
    /// </summary>
    public interface IFurniture
    {
        /// <summary>
        /// Furniture Model
        /// </summary>
        string Model { get; }

        /// <summary>
        /// Furniture Material
        /// </summary>
        string Material { get; }

        /// <summary>
        /// Furniture Price
        /// </summary>
        decimal Price { get; set; }

        /// <summary>
        /// Furniture Height
        /// </summary>
        decimal Height { get; }
    }
}
