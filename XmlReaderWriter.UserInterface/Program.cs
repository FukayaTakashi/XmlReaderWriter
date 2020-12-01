using System.Linq;
using XmlReaderWriter.UserInterface.Controllers;

namespace XmlReaderWriter
{
    class Program
    {
        private static string[] _parameters = { "-name", "-sample", "-update" };

        private static SampleController _sampleController = new SampleController();

        static void Main(string[] args)
        {
            args = args.Concat(new string[] { "" }).ToArray();
            var parameterOptions = _parameters.ToDictionary(x => x, x => args.SkipWhile(y => y != x).Skip(1).FirstOrDefault());
            _sampleController.Run(parameterOptions["-name"], parameterOptions["-sample"], parameterOptions["-update"]);
        }
    }
}
