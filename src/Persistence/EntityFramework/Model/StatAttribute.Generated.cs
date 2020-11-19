// <copyright file="StatAttribute.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

        //------------------------------------------------------------------------------
        // <auto-generated>
        //     This source code was auto-generated by a roslyn code generator.
        // </auto-generated>
        //------------------------------------------------------------------------------

        // ReSharper disable All

namespace MUnique.OpenMU.Persistence.EntityFramework.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using MUnique.OpenMU.Persistence;
    
    /// <summary>
    /// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.AttributeSystem.StatAttribute"/>.
    /// </summary>
    [Table(nameof(StatAttribute), Schema = "data")]
    internal partial class StatAttribute : MUnique.OpenMU.AttributeSystem.StatAttribute, IIdentifiable
    {
        /// <inheritdoc />
        public StatAttribute()
        {

        }

        /// <inheritdoc />
        public StatAttribute(MUnique.OpenMU.AttributeSystem.AttributeDefinition definition, System.Single baseValue)
            : base(definition, baseValue)
        {

        }


        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets or sets the identifier of <see cref="Definition"/>.
        /// </summary>
        public Guid? DefinitionId { get; set; }

        /// <summary>
        /// Gets the raw object of <see cref="Definition" />.
        /// </summary>
        [ForeignKey(nameof(DefinitionId))]
        public AttributeDefinition RawDefinition
        {
            get => base.Definition as AttributeDefinition;
            set => base.Definition = value;
        }

        /// <inheritdoc/>
        [NotMapped]
        public override MUnique.OpenMU.AttributeSystem.AttributeDefinition Definition
        {
            get => base.Definition;protected set
            {
                base.Definition = value;
                this.DefinitionId = this.RawDefinition?.Id;
            }
        }


        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            var baseObject = obj as IIdentifiable;
            if (baseObject != null)
            {
                return baseObject.Id == this.Id;
            }

            return base.Equals(obj);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        
    }
}