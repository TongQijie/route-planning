using System.IO;

namespace RoutePlanning.DataProvider.Metadata
{
    public class StationHandler : IStationHandler
    {
        private const string InputFilename = "";

        private const string OutputFilename = "";

        public void Execute()
        {
            using (var inputStream = new FileStream(InputFilename, FileMode.Open, FileAccess.Read))
            {
                using (var outputStream = new FileStream(OutputFilename, FileMode.Create, FileAccess.Write))
                {
                    using (var writer = new StreamWriter(outputStream))
                    {
                        using (var reader = new StreamReader(inputStream))
                        {
                            string line = null;
                            while ((line = reader.ReadLine()) != null)
                            {
                                var fields = line.Split('\t');
                                if (fields.Length >= 3)
                                {
                                    writer.WriteLine($"S{fields[1].Trim()}|{fields[2].Trim()}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}