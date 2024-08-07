

namespace TestePratico.Service
{
    internal class CsvReader
    {
        private StreamReader reader;
        private CsvHelper.Configuration.CsvConfiguration csvConfiguration;

        public CsvReader(StreamReader reader, CsvHelper.Configuration.CsvConfiguration csvConfiguration)
        {
            this.reader = reader;
            this.csvConfiguration = csvConfiguration;
        }

        internal object GetRecords<T>()
        {
            throw new NotImplementedException();
        }
    }
}