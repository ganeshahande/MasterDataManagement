using System;

namespace VFS.Common.Models.Masters
{
    public partial class NationalityMap
    {
        public int Id { get; set; }
        public int NationalityId { get; set; }
        public Guid? MissionId { get; set; }
        public Guid? CountryOpsId { get; set; }
        public Guid? UnitOpsId { get; set; }

        public CountryOfOperation CountryOps { get; set; }
        public Mission Mission { get; set; }
        public Country Nationality { get; set; }
        public UnitOps UnitOps { get; set; }
    }
}

