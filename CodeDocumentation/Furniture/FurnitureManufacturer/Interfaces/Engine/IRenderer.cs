namespace FurnitureManufacturer.Interfaces.Engine
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for classes capable to read input and output 
    /// from the console
    /// </summary>
    public interface IRenderer
    {
        /// <summary>
        /// Read console input
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> Input();

        /// <summary>
        /// Print the result
        /// </summary>
        /// <param name="output"></param>
        void Output(IEnumerable<string> output);
    }
}
