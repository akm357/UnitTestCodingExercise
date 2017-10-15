using System.Collections.Generic;

namespace Core
{
    /// <summary>
    /// Generic interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISequence<T>
    {
        List<T> CreateSequence(int number);
    }
}
