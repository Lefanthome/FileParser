using Tools.Parser;

namespace ConsoleFileParser
{
    public class CsvModel
    {
        [MappingCol("ID")]
        public int Id { get; set; }
        [MappingCol("NAME")]
        public string Name { get; set; }
        [MappingCol("Company")]
        public string Company { get; set; }
    }
}
