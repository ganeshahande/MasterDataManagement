using System;
using System.Collections.Generic;
using System.Text;

namespace VFS.Common.Models.Masters
{
    public partial class Mission
    {
        public Mission()
        {
            CountryOfOperation = new HashSet<CountryOfOperation>();
            CountryMap = new HashSet<CountryMap>();
            NationalityMap = new HashSet<NationalityMap>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public ICollection<CountryOfOperation> CountryOfOperation { get; set; }
        public ICollection<CountryMap> CountryMap { get; set; }
        public ICollection<NationalityMap> NationalityMap { get; set; }
    }
}
