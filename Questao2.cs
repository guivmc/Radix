class Program
    {

        static int RemoveDupicates( int[] vec )
        {
            List<int> fin = new List<int>();
           
            for( int i = 0; i < vec.Length; i++ )
            {
                if( fin.Contains( vec[i] ) == false )
                {
                    fin.Add(vec[i]);
                }
                else
                   return vec[i]);
            }
        }

        static void Main( string[] args )
        {
            int[] vec = { 1, 6, 3, 9, 45, 67, 98, 0, 3, 123 };

            int x = RemoveDupicates( vec );
            
            Console.WriteLine("Duplicado: {0}", x);

            Console.ReadLine();
        }
    }
