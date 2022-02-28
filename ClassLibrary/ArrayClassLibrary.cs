namespace MyArrayClassLibrary
{
    public class ArrayClassLibrary
    {
        public int[] ArrayWorker(int[] source)
        {
            int[] temp = new int[source.Length];
            Array.Copy(source, temp, source.Length);
            Array.Reverse(temp);

            return temp;
        }

        public int[] ArrayWorker(int[] source, int index, int newValue)
        {
            int[] temp = new int[source.Length + 1];
            Array.Copy(source, temp, index);
            temp[index] = newValue;
            Array.Copy(source, index, temp, index + 1, source.Length - index);

            return temp;
        }
    }
}