namespace InheritanceAndPolymorphism.Interfaces
{
    /// <summary>
    /// Interface for classes capable of creating Offsite Courses
    /// </summary>
    public interface IOffsiteCourse
    {
        /// <summary>
        /// Location of Offsite Course
        /// </summary>
        string Town { get; }
    }
}