using TestePratico.Models;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;


namespace TestePratico.Service
{
    public class PopulationService
    {
        private readonly string _csvFilePath;

        public PopulationService(string csvFilePath)
        {
            _csvFilePath = csvFilePath;
        }

        public List<PopulationData> GetPopulationData()
        {
            using var reader = new StreamReader(_csvFilePath);
            
        }
    }
}
