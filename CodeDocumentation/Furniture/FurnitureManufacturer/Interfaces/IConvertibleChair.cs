namespace FurnitureManufacturer.Interfaces
{
    /// <summary>
    /// Interface for classes capable of
    ///  creating Covertiable Chair
    /// </summary>
    public interface IConvertibleChair : IChair
    {
        /// <summary>
        /// Check if the chair is converted
        /// or is in normal position
        /// </summary>
        bool IsConverted { get; }

        /// <summary>
        /// Set position to normal 
        /// or converted
        /// </summary>
        void Convert();
    }
}
