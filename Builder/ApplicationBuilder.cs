using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    
    public class ApplicationBuilder:IBuilder
    {
        private WebApplication _webApplication;

        public ApplicationBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            this._webApplication = new WebApplication();
        }
        public void AddSecurity()
        {
            this._webApplication.Add("Security system");
        }

        public void AddServeStaticFile()
        {
            this._webApplication.Add("Serve Static files");
        }

        public void AddLocalDatabase()
        {
            this._webApplication.Add("has local database");
        }

        public WebApplication GetProduct()
        {
            WebApplication result = this._webApplication;

            this.Reset();

            return result;
        }
    }

    public class WebApplication
    {
        public List<string> FunctionList { get; set; } = new List<string>();

        public void Add(string f)
        {
            this.FunctionList.Add(f);
        }

        public void Show()
        {
            foreach (string s in this.FunctionList)
            {
                Console.WriteLine(s);
            }
        }

    }
}
