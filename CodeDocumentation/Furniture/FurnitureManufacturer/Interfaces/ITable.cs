namespace FurnitureManufacturer.Interfaces
{
    /// <summary>
    /// Interface for classes capable of creating Table
    /// </summary>
    public interface ITable : IFurniture
    {
        /// <summary>
        /// Table length
        /// </summary>
        decimal Length { get; }

        /// <summary>
        /// Table Width
        /// </summary>
        decimal Width { get; }

        /// <summary>
        /// Table Area equale
        /// to length*width
        /// </summary>
        decimal Area { get; }
    }
}
