/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// NotificationRuleBase
    /// </summary>
    [DataContract]
    public partial class NotificationRuleBase :  IEquatable<NotificationRuleBase>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public TaskStatusType Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationRuleBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationRuleBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationRuleBase" /> class.
        /// </summary>
        /// <param name="orgID">the ID of the organization that owns this notification rule. (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="name">human-readable name describing the notification rule (required).</param>
        /// <param name="sleepUntil">sleepUntil.</param>
        /// <param name="every">notification repetition interval.</param>
        /// <param name="offset">Duration to delay after the schedule, before executing check..</param>
        /// <param name="cron">notification repetition interval in the form &#39;* * * * * *&#39;;.</param>
        /// <param name="runbookLink">runbookLink.</param>
        /// <param name="limitEvery">don&#39;t notify me more than &lt;limit&gt; times every &lt;limitEvery&gt; seconds. If set, limit cannot be empty..</param>
        /// <param name="limit">don&#39;t notify me more than &lt;limit&gt; times every &lt;limitEvery&gt; seconds. If set, limitEvery cannot be empty..</param>
        /// <param name="tagRules">list of tag rules the notification rule attempts to match (required).</param>
        /// <param name="description">An optional description of the notification rule.</param>
        /// <param name="statusRules">list of status rules the notification rule attempts to match (required).</param>
        /// <param name="labels">labels.</param>
        public NotificationRuleBase(string orgID = default(string), TaskStatusType status = default(TaskStatusType), string name = default(string), string sleepUntil = default(string), string every = default(string), string offset = default(string), string cron = default(string), string runbookLink = default(string), int? limitEvery = default(int?), int? limit = default(int?), List<TagRule> tagRules = default(List<TagRule>), string description = default(string), List<StatusRule> statusRules = default(List<StatusRule>), List<Label> labels = default(List<Label>))
        {
            // to ensure "orgID" is required (not null)
            if (orgID == null)
            {
                throw new InvalidDataException("orgID is a required property for NotificationRuleBase and cannot be null");
            }
            else
            {
                this.OrgID = orgID;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for NotificationRuleBase and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for NotificationRuleBase and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "tagRules" is required (not null)
            if (tagRules == null)
            {
                throw new InvalidDataException("tagRules is a required property for NotificationRuleBase and cannot be null");
            }
            else
            {
                this.TagRules = tagRules;
            }
            // to ensure "statusRules" is required (not null)
            if (statusRules == null)
            {
                throw new InvalidDataException("statusRules is a required property for NotificationRuleBase and cannot be null");
            }
            else
            {
                this.StatusRules = statusRules;
            }
            this.SleepUntil = sleepUntil;
            this.Every = every;
            this.Offset = offset;
            this.Cron = cron;
            this.RunbookLink = runbookLink;
            this.LimitEvery = limitEvery;
            this.Limit = limit;
            this.Description = description;
            this.Labels = labels;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets EndpointID
        /// </summary>
        [DataMember(Name="endpointID", EmitDefaultValue=false)]
        public string EndpointID { get; private set; }

        /// <summary>
        /// the ID of the organization that owns this notification rule.
        /// </summary>
        /// <value>the ID of the organization that owns this notification rule.</value>
        [DataMember(Name="orgID", EmitDefaultValue=false)]
        public string OrgID { get; set; }

        /// <summary>
        /// The ID of creator used to create this notification rule.
        /// </summary>
        /// <value>The ID of creator used to create this notification rule.</value>
        [DataMember(Name="ownerID", EmitDefaultValue=false)]
        public string OwnerID { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; private set; }


        /// <summary>
        /// human-readable name describing the notification rule
        /// </summary>
        /// <value>human-readable name describing the notification rule</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SleepUntil
        /// </summary>
        [DataMember(Name="sleepUntil", EmitDefaultValue=false)]
        public string SleepUntil { get; set; }

        /// <summary>
        /// notification repetition interval
        /// </summary>
        /// <value>notification repetition interval</value>
        [DataMember(Name="every", EmitDefaultValue=false)]
        public string Every { get; set; }

        /// <summary>
        /// Duration to delay after the schedule, before executing check.
        /// </summary>
        /// <value>Duration to delay after the schedule, before executing check.</value>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public string Offset { get; set; }

        /// <summary>
        /// notification repetition interval in the form &#39;* * * * * *&#39;;
        /// </summary>
        /// <value>notification repetition interval in the form &#39;* * * * * *&#39;;</value>
        [DataMember(Name="cron", EmitDefaultValue=false)]
        public string Cron { get; set; }

        /// <summary>
        /// Gets or Sets RunbookLink
        /// </summary>
        [DataMember(Name="runbookLink", EmitDefaultValue=false)]
        public string RunbookLink { get; set; }

        /// <summary>
        /// don&#39;t notify me more than &lt;limit&gt; times every &lt;limitEvery&gt; seconds. If set, limit cannot be empty.
        /// </summary>
        /// <value>don&#39;t notify me more than &lt;limit&gt; times every &lt;limitEvery&gt; seconds. If set, limit cannot be empty.</value>
        [DataMember(Name="limitEvery", EmitDefaultValue=false)]
        public int? LimitEvery { get; set; }

        /// <summary>
        /// don&#39;t notify me more than &lt;limit&gt; times every &lt;limitEvery&gt; seconds. If set, limitEvery cannot be empty.
        /// </summary>
        /// <value>don&#39;t notify me more than &lt;limit&gt; times every &lt;limitEvery&gt; seconds. If set, limitEvery cannot be empty.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// list of tag rules the notification rule attempts to match
        /// </summary>
        /// <value>list of tag rules the notification rule attempts to match</value>
        [DataMember(Name="tagRules", EmitDefaultValue=false)]
        public List<TagRule> TagRules { get; set; }

        /// <summary>
        /// An optional description of the notification rule
        /// </summary>
        /// <value>An optional description of the notification rule</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// list of status rules the notification rule attempts to match
        /// </summary>
        /// <value>list of status rules the notification rule attempts to match</value>
        [DataMember(Name="statusRules", EmitDefaultValue=false)]
        public List<StatusRule> StatusRules { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name="labels", EmitDefaultValue=false)]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotificationRuleBase {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EndpointID: ").Append(EndpointID).Append("\n");
            sb.Append("  OrgID: ").Append(OrgID).Append("\n");
            sb.Append("  OwnerID: ").Append(OwnerID).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SleepUntil: ").Append(SleepUntil).Append("\n");
            sb.Append("  Every: ").Append(Every).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Cron: ").Append(Cron).Append("\n");
            sb.Append("  RunbookLink: ").Append(RunbookLink).Append("\n");
            sb.Append("  LimitEvery: ").Append(LimitEvery).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  TagRules: ").Append(TagRules).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StatusRules: ").Append(StatusRules).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotificationRuleBase);
        }

        /// <summary>
        /// Returns true if NotificationRuleBase instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationRuleBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationRuleBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.EndpointID == input.EndpointID ||
                    (this.EndpointID != null &&
                    this.EndpointID.Equals(input.EndpointID))
                ) && 
                (
                    this.OrgID == input.OrgID ||
                    (this.OrgID != null &&
                    this.OrgID.Equals(input.OrgID))
                ) && 
                (
                    this.OwnerID == input.OwnerID ||
                    (this.OwnerID != null &&
                    this.OwnerID.Equals(input.OwnerID))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SleepUntil == input.SleepUntil ||
                    (this.SleepUntil != null &&
                    this.SleepUntil.Equals(input.SleepUntil))
                ) && 
                (
                    this.Every == input.Every ||
                    (this.Every != null &&
                    this.Every.Equals(input.Every))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Cron == input.Cron ||
                    (this.Cron != null &&
                    this.Cron.Equals(input.Cron))
                ) && 
                (
                    this.RunbookLink == input.RunbookLink ||
                    (this.RunbookLink != null &&
                    this.RunbookLink.Equals(input.RunbookLink))
                ) && 
                (
                    this.LimitEvery == input.LimitEvery ||
                    (this.LimitEvery != null &&
                    this.LimitEvery.Equals(input.LimitEvery))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.TagRules == input.TagRules ||
                    this.TagRules != null &&
                    this.TagRules.SequenceEqual(input.TagRules)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.StatusRules == input.StatusRules ||
                    this.StatusRules != null &&
                    this.StatusRules.SequenceEqual(input.StatusRules)
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EndpointID != null)
                    hashCode = hashCode * 59 + this.EndpointID.GetHashCode();
                if (this.OrgID != null)
                    hashCode = hashCode * 59 + this.OrgID.GetHashCode();
                if (this.OwnerID != null)
                    hashCode = hashCode * 59 + this.OwnerID.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SleepUntil != null)
                    hashCode = hashCode * 59 + this.SleepUntil.GetHashCode();
                if (this.Every != null)
                    hashCode = hashCode * 59 + this.Every.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Cron != null)
                    hashCode = hashCode * 59 + this.Cron.GetHashCode();
                if (this.RunbookLink != null)
                    hashCode = hashCode * 59 + this.RunbookLink.GetHashCode();
                if (this.LimitEvery != null)
                    hashCode = hashCode * 59 + this.LimitEvery.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.TagRules != null)
                    hashCode = hashCode * 59 + this.TagRules.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.StatusRules != null)
                    hashCode = hashCode * 59 + this.StatusRules.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                return hashCode;
            }
        }

    }

}
