namespace FurnitureManufacturer.Interfaces
{
    /// <summary>
    /// Interface for classes capable of creating Adjustable Chairs
    /// </summary>
    public interface IAdjustableChair : IChair
    {
        /// <summary>
        /// Ste Height to normal or
        /// to adjusted 0.10 cm higher
        /// </summary>
        /// <param name="height"></param>
        void SetHeight(decimal height);
    }
}
