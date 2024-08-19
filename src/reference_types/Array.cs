namespace console_app.src.reference_types
{
    internal class Array
    {
        void Method()
        {
            // One Dimension
            int[] integers = new int[1]; // uninitialized
            int[] some = { 1, 2, 3 }; // initialized
            integers[0] = 1;

            // Two Dimension
            int[,] twoDimension = new int[1, 1]; // uninitialized
            int[,] lot = new int[,]
            {
                { 1, 2 },
                { 3, 4 }
            }; // initialized
            twoDimension[0, 0] = 1;

            // Three Dimension
            int[,,] threeDimension = new int[1, 1, 1]; // uninitialized
            int[,,] few = new int[,,]
            {
                {
                    { 1, 2 },
                    { 3, 4 }
                },
                {
                    { 5, 6 },
                    { 7, 8 }
                }
            }; // initialized
            threeDimension[0, 0, 0] = 1;

            Console.WriteLine(some.Length + lot.Length + few.Length);
        }
    }
}
