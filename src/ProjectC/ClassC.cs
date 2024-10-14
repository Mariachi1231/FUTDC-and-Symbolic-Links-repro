using ProjectA;

using ProjectB;

namespace ProjectC
{
    /// <summary>
    /// ClassC
    /// </summary>
    public class ClassC
    {
        private readonly ClassA _rClassA;
        private readonly ClassB _rClassB;

        /// <summary>
        /// Ctr
        /// </summary>
        /// <param name="classA">classA</param>
        /// <param name="classB">classB</param>
        public ClassC(ClassA classA, ClassB classB)
        {
            _rClassA = classA;
            _rClassB = classB;
        }
    }
}
