using System;
using System.Collections.Generic;
using System.Text;

namespace VFS.Common.Models.Masters
{
    public class Country
    {
        public Country()
        {
            CountryOfOperation = new HashSet<CountryOfOperation>();
            CountryMap = new HashSet<CountryMap>();
            NationalityMap = new HashSet<NationalityMap>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Isocode2 { get; set; }
        public string Isocode3 { get; set; }
        public string DialCode { get; set; }
        public string Nationality { get; set; }
        public int CreatedBy { get; set; }

        public User CreatedByNavigation { get; set; }
        public ICollection<CountryOfOperation> CountryOfOperation { get; set; }
        public ICollection<CountryMap> CountryMap { get; set; }
        public ICollection<NationalityMap> NationalityMap { get; set; }

    }
}
