using System;
using System.Collections.Generic;
using System.Text;

namespace VFS.Common.Models.Masters
{
    public partial class CountryOfOperation
    {
        public CountryOfOperation()
        {
            jurisdictionmap = new HashSet<JurisdictionMap>();
            CountryMap = new HashSet<CountryMap>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CountryId { get; set; }
        public Guid MissionId { get; set; }

        public Country Country { get; set; }
        public Mission Mission { get; set; }
        public ICollection<JurisdictionMap> jurisdictionmap { get; set; }
        public ICollection<CountryMap> CountryMap { get; set; }
    }
}
