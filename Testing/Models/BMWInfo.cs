namespace Testing.Models
{
    public class BMWInfo
    {

        public string ModelName { get; set; }
        public string EngineType { get; set; }

        public BMWInfo()
        {
            ModelName = "BMW X6";
            EngineType = "V6";
        }

        public override string ToString()
        {
            return $"Model: {ModelName}, Engine: {EngineType}";
        }
    }
}
