using ProjectA;

namespace ProjectB
{
    /// <summary>
    /// ClassB
    /// </summary>
    public class ClassB
    {
        private readonly ClassA _rClassA;

        /// <summary>
        /// Ctr
        /// </summary>
        /// <param name="classA">classA</param>
        public ClassB(ClassA classA)
        {
            _rClassA = classA;
        }
    }
}
