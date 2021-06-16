/* 
 * Influx OSS API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 2.0.0
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
    /// BuilderTagsType
    /// </summary>
    [DataContract]
    public partial class BuilderTagsType :  IEquatable<BuilderTagsType>
    {
        /// <summary>
        /// Gets or Sets AggregateFunctionType
        /// </summary>
        [DataMember(Name="aggregateFunctionType", EmitDefaultValue=false)]
        public BuilderAggregateFunctionType? AggregateFunctionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BuilderTagsType" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="values">values.</param>
        /// <param name="aggregateFunctionType">aggregateFunctionType.</param>
        public BuilderTagsType(string key = default(string), List<string> values = default(List<string>), BuilderAggregateFunctionType? aggregateFunctionType = default(BuilderAggregateFunctionType?))
        {
            this.Key = key;
            this.Values = values;
            this.AggregateFunctionType = aggregateFunctionType;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuilderTagsType {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  AggregateFunctionType: ").Append(AggregateFunctionType).Append("\n");
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
            return this.Equals(input as BuilderTagsType);
        }

        /// <summary>
        /// Returns true if BuilderTagsType instances are equal
        /// </summary>
        /// <param name="input">Instance of BuilderTagsType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuilderTagsType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.AggregateFunctionType == input.AggregateFunctionType ||
                    (this.AggregateFunctionType != null &&
                    this.AggregateFunctionType.Equals(input.AggregateFunctionType))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.AggregateFunctionType != null)
                    hashCode = hashCode * 59 + this.AggregateFunctionType.GetHashCode();
                return hashCode;
            }
        }

    }

}
