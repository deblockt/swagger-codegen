/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// OuterComposite
    /// </summary>
    [DataContract]
    public partial class OuterComposite :  IEquatable<OuterComposite>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OuterComposite" /> class.
        /// </summary>
        /// <param name="MyNumber">MyNumber.</param>
        /// <param name="MyString">MyString.</param>
        /// <param name="MyBoolean">MyBoolean.</param>
        public OuterComposite(OuterNumber MyNumber = default(OuterNumber), OuterString MyString = default(OuterString), OuterBoolean MyBoolean = default(OuterBoolean))
        {
            this.MyNumber = MyNumber;
            this.MyString = MyString;
            this.MyBoolean = MyBoolean;
        }
        
        /// <summary>
        /// Gets or Sets MyNumber
        /// </summary>
        [DataMember(Name="my_number", EmitDefaultValue=false)]
        public OuterNumber MyNumber { get; set; }

        /// <summary>
        /// Gets or Sets MyString
        /// </summary>
        [DataMember(Name="my_string", EmitDefaultValue=false)]
        public OuterString MyString { get; set; }

        /// <summary>
        /// Gets or Sets MyBoolean
        /// </summary>
        [DataMember(Name="my_boolean", EmitDefaultValue=false)]
        public OuterBoolean MyBoolean { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OuterComposite {\n");
            sb.Append("  MyNumber: ").Append(MyNumber).Append("\n");
            sb.Append("  MyString: ").Append(MyString).Append("\n");
            sb.Append("  MyBoolean: ").Append(MyBoolean).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OuterComposite);
        }

        /// <summary>
        /// Returns true if OuterComposite instances are equal
        /// </summary>
        /// <param name="other">Instance of OuterComposite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OuterComposite other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MyNumber == other.MyNumber ||
                    this.MyNumber != null &&
                    this.MyNumber.Equals(other.MyNumber)
                ) && 
                (
                    this.MyString == other.MyString ||
                    this.MyString != null &&
                    this.MyString.Equals(other.MyString)
                ) && 
                (
                    this.MyBoolean == other.MyBoolean ||
                    this.MyBoolean != null &&
                    this.MyBoolean.Equals(other.MyBoolean)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.MyNumber != null)
                    hash = hash * 59 + this.MyNumber.GetHashCode();
                if (this.MyString != null)
                    hash = hash * 59 + this.MyString.GetHashCode();
                if (this.MyBoolean != null)
                    hash = hash * 59 + this.MyBoolean.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
