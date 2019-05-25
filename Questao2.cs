class Program
    {

        static void RemoveDupicates( int[] vec )
        {
            List<int> fin = new List<int>();
           
            for( int i = 0; i < vec.Length; i++ )
            {
                if( fin.Contains( vec[i] ) == false )
                {
                    fin.Add(vec[i]);
                }
                else
                    Console.WriteLine( "Duplicado: {0}", vec[i]);
            }
        }

        static void Main( string[] args )
        {
            int[] vec = { 1, 6, 3, 9, 45, 67, 98, 0, 3, 123 };

            RemoveDupicates( vec );

            Console.ReadLine();
        }
    }
