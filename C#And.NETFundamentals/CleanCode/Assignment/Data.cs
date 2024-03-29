namespace Assignment
{
    public  class Data
    {
        //var nt = new List<string> {"MVC4", "Node.js", "CouchDB", "KendoUI", "Dapper", "Angular"};
        private readonly List<string> _ot;

        //DEFECT #5274 DA 12/10/2012
        //We weren't filtering out the prodigy domain so I added it.
        private readonly List<string> _domains;

        private readonly List<string> _employers;

        public Data()
        {
            _ot = new List<string>() { "Cobol", "Punch Cards", "Commodore", "VBScript" };
            _domains = new List<string>() { "aol.com", "hotmail.com", "prodigy.com", "CompuServe.com" };
            _employers = new List<string>() { "Microsoft", "Google", "Fog Creek Software", "37Signals" };
        }

        public IReadOnlyList<string> Ot => _ot.AsReadOnly();

        public IReadOnlyList<string> Domains => _domains.AsReadOnly();

        public IReadOnlyList<string> Employees => _employers.AsReadOnly();
    }
}
