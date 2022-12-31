namespace Builder
{
    
    public class WebApplicationBuilder:IBuilder
    {
        private WebApplication _webApplication;

        public WebApplicationBuilder()
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
}
