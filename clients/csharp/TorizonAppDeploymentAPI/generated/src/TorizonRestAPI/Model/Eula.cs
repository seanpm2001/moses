/*
 * Torizon IDE-backend API
 *
 * Toradex API to build and deploy applications running as containers on Torizon
 *
 * The version of the OpenAPI document: 1.1.6
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TorizonRestAPI.Client.OpenAPIDateConverter;

namespace TorizonRestAPI.Model
{
    /// <summary>
    /// Eula
    /// </summary>
    [DataContract]
    public partial class Eula :  IEquatable<Eula>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Eula" /> class.
        /// </summary>
        /// <param name="visualized">true if license has been shown at least once to user.</param>
        /// <param name="accepted">true if user accepted the license.</param>
        public Eula(bool visualized = default(bool), bool accepted = default(bool))
        {
            this.Visualized = visualized;
            this.Accepted = accepted;
        }

        /// <summary>
        /// Unique name (should be filesystem-compatible)
        /// </summary>
        /// <value>Unique name (should be filesystem-compatible)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// eula title
        /// </summary>
        /// <value>eula title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; private set; }

        /// <summary>
        /// message shown to the user to accept/decline license
        /// </summary>
        /// <value>message shown to the user to accept/decline license</value>
        [DataMember(Name="question", EmitDefaultValue=false)]
        public string Question { get; private set; }

        /// <summary>
        /// full path of the file containing the license text
        /// </summary>
        /// <value>full path of the file containing the license text</value>
        [DataMember(Name="filepath", EmitDefaultValue=false)]
        public string Filepath { get; private set; }

        /// <summary>
        /// true if license has been shown at least once to user
        /// </summary>
        /// <value>true if license has been shown at least once to user</value>
        [DataMember(Name="visualized", EmitDefaultValue=false)]
        public bool Visualized { get; set; }

        /// <summary>
        /// true if user accepted the license
        /// </summary>
        /// <value>true if user accepted the license</value>
        [DataMember(Name="accepted", EmitDefaultValue=false)]
        public bool Accepted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Eula {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Question: ").Append(Question).Append("\n");
            sb.Append("  Filepath: ").Append(Filepath).Append("\n");
            sb.Append("  Visualized: ").Append(Visualized).Append("\n");
            sb.Append("  Accepted: ").Append(Accepted).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Eula);
        }

        /// <summary>
        /// Returns true if Eula instances are equal
        /// </summary>
        /// <param name="input">Instance of Eula to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Eula input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Question == input.Question ||
                    (this.Question != null &&
                    this.Question.Equals(input.Question))
                ) && 
                (
                    this.Filepath == input.Filepath ||
                    (this.Filepath != null &&
                    this.Filepath.Equals(input.Filepath))
                ) && 
                (
                    this.Visualized == input.Visualized ||
                    (this.Visualized != null &&
                    this.Visualized.Equals(input.Visualized))
                ) && 
                (
                    this.Accepted == input.Accepted ||
                    (this.Accepted != null &&
                    this.Accepted.Equals(input.Accepted))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Question != null)
                    hashCode = hashCode * 59 + this.Question.GetHashCode();
                if (this.Filepath != null)
                    hashCode = hashCode * 59 + this.Filepath.GetHashCode();
                if (this.Visualized != null)
                    hashCode = hashCode * 59 + this.Visualized.GetHashCode();
                if (this.Accepted != null)
                    hashCode = hashCode * 59 + this.Accepted.GetHashCode();
                return hashCode;
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
