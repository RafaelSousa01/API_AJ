namespace API_AJ.Functions
{

    public class Functions
    {
        public static void CreateFile(string nameFile, string valueFile)
        {
            try
            {
                var directory = Path.Combine(Directory.GetCurrentDirectory(), "Files");

                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var file = Path.Combine(directory, nameFile);

                if (!Directory.Exists(file))
                {
                    File.Create(file).Dispose();

                    using (TextWriter tw = new StreamWriter(file))
                    {
                        tw.WriteLine(valueFile);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
    }
}
