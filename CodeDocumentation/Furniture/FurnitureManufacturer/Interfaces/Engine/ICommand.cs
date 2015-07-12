namespace FurnitureManufacturer.Interfaces.Engine
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for classes capable of creating Commands
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Command name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Collection of commands
        /// </summary>
        IList<string> Parameters { get; }
    }
}
