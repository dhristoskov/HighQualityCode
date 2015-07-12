namespace FurnitureManufacturer.Interfaces.Engine
{
    /// <summary>
    /// Interface for classes capable to create other classes
    /// </summary>
    public interface IFurnitureFactory
    {
        /// <summary>
        /// Create object of type ITable
        /// </summary>
        /// <param name="model"></param>
        /// <param name="materialType"></param>
        /// <param name="price"></param>
        /// <param name="height"></param>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <returns>Table</returns>
        ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width);

        /// <summary>
        /// Create object of type Chair
        /// </summary>
        /// <param name="model"></param>
        /// <param name="materialType"></param>
        /// <param name="price"></param>
        /// <param name="height"></param>
        /// <param name="numberOfLegs"></param>
        /// <returns>Chair</returns>
        IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs);


        /// <summary>
        /// Create object of type Adjustable Chair
        /// </summary>
        /// <param name="model"></param>
        /// <param name="materialType"></param>
        /// <param name="price"></param>
        /// <param name="height"></param>
        /// <param name="numberOfLegs"></param>
        /// <returns>AdjustableChair</returns>
        IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs);

        /// <summary>
        /// Create object of type Convertible Chair
        /// </summary>
        /// <param name="model"></param>
        /// <param name="materialType"></param>
        /// <param name="price"></param>
        /// <param name="height"></param>
        /// <param name="numberOfLegs"></param>
        /// <returns>ConvertibleChair</returns>
        IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs);
    }
}
