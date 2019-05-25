    class Program
    {

        static string File(string[] files, string fileName)
        {
            //Chave = a pos do arquivo em files
            Dictionary<int, DateTime> dates = new Dictionary<int, DateTime>();

            for( int i = 0; i < files.Length; i++ )
            {
                string[] tokens = files[i].Split( '-' );

                //Pos 0 sempre será considerado o nome do arquivo.
                //Pos 1 sempre será considerado o dia do arquivo.
                //Pos 2 sempre será considerado o mês do arquivo.
                //Pos 3 sempre será considerado o ano do arquivo.

                if( tokens.Length > 4)
                {
                    Console.WriteLine("Arquivo {0} com formato errado! Não será considerado.", files[i] );
                    continue;
                }
                else if( !tokens[0].Equals( fileName ) )
                    continue;

                dates.Add( i ,new DateTime( Int32.Parse( tokens[3].Substring(0, 4) ), Int32.Parse( tokens[2] ), Int32.Parse( tokens[1] ) ));
            }

            int pos = dates.FirstOrDefault( x => x.Value == dates.Values.Max() ).Key;

            return files[pos];
        }


        static void Main( string[] args )
        {
            string[] test = { "processamento-13-04-2019.xls", "processamento-18-05-2019.xls", "transformacao-19-06-2017.xls", "transformacao-19-06-2019.xls" };

            Console.WriteLine( File(test, "processamento" ) );

            Console.ReadLine();
        }
    }
