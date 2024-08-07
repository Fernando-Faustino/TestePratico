using System.Globalization;

namespace CsvHelper
{
    internal class Configuration
    {
        internal class CsvConfiguration
        {
            private CultureInfo invariantCulture;

            public CsvConfiguration(CultureInfo invariantCulture)
            {
                this.invariantCulture = invariantCulture;
            }
        }
    }
}