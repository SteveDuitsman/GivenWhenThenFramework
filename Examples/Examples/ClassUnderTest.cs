using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GivenWhenThenExamples
{
    public interface ISomeDependency
    {
        double CalculateStuff();
    }

    public interface IWebServiceDependency
    {
        string GetWebServiceDataAsJSON();
    }

    public class ClassUnderTest
    {
        private IWebServiceDependency _webServiceRepository;
        private ISomeDependency _someRepository;

        public ClassUnderTest(ISomeDependency someRepository, IWebServiceDependency webServiceRepository)
        {
            _someRepository = someRepository;
            _webServiceRepository = webServiceRepository;
        }

        public double DisplayCalculatedStuff()
        {
            return _someRepository.CalculateStuff();
        }

        public string DisplayWebData()
        {
            return _webServiceRepository.GetWebServiceDataAsJSON();
        }
    }
}
