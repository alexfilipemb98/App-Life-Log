using DevExpress.Xpo;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Xml.Serialization;

namespace Data.Bases
{
    /// <summary>
    /// Base object
    /// </summary>
    [NonPersistent]
    public class DataEntityBase
    {
        private Guid fId;
        [System.ComponentModel.DataAnnotations.Key]
        [DevExpress.Xpo.Key]
        [XmlElement("Id")]
        [Nullable(false)]
        public Guid Id
        {
            get => fId;
            set => fId = value;
        }

        private DateTime fCreatedAt;
        [DataType(DataType.Date)]
        [XmlElement("CreatedAt")]
        public DateTime CreatedAt
        {
            get => fCreatedAt;
            set => fCreatedAt = value;
        }

        private DateTime fUpdatedAt;
        [DataType(DataType.Date)]
        [XmlElement("UpdatedAt")]
        public DateTime UpdatedAt
        {
            get => fUpdatedAt;
            set => fUpdatedAt = value;
        }

        private bool fEditingMode;
        [NotMapped]
        [NonPersistent]
        public bool EditingMode
        {
            get => fEditingMode;
            set => fEditingMode = value;
        }
    }
}
