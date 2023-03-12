using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System;

namespace NNH.XrmToolBox.DeleteRecordRecovery.Models
{
    internal class AuditHistories
    {
        /// <summary>
        /// Gets or sets the audit identifier.
        /// </summary>
        /// <value>
        /// The audit identifier.
        /// </value>
        public Guid AuditId { get; set; }

        /// <summary>
        /// Gets or sets the record identifier.
        /// </summary>
        /// <value>
        /// The record identifier.
        /// </value>
        public Guid RecordId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the entity.
        /// </summary>
        /// <value>
        /// The entity.
        /// </value>
        public string Entity { get; set; }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        /// <value>
        /// The metadata.
        /// </value>
        public EntityMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or sets the deletion date.
        /// </summary>
        /// <value>
        /// The deletion date.
        /// </value>
        public DateTime DeletionDate { get; set; }

        /// <summary>
        /// Gets or sets the deleted by date in string format.
        /// </summary>
        /// <value>
        /// The deleted by.
        /// </value>
        public string DeletedBy { get; set; }

        /// <summary>
        /// Gets or sets the audit detail.
        /// </summary>
        /// <value>
        /// The audit detail.
        /// </value>
        public AttributeAuditDetail AuditDetail { get; set; }
    }
}
