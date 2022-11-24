#nullable enable
using System.Linq;


namespace DefaultNamespace
{
    public class ImperativeVsDeclarative
    {
        public int MaxImperative(int[] array)
        {
            var current = int.MinValue;
            for (var i = 0; i < array.Length; i++)
            {
                if (current < array[i])
                {
                    current = array[i];
                }
            }

            return current;
        }


        public int MaxDeclarative(int[] array)
        {
            return array.Max();
        }
    }
}