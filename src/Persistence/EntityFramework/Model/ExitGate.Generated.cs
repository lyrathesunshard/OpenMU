// <copyright file="ExitGate.Generated.cs" company="MUnique">
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
    /// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.ExitGate"/>.
    /// </summary>
    [Table(nameof(ExitGate), Schema = "config")]
    internal partial class ExitGate : MUnique.OpenMU.DataModel.Configuration.ExitGate, IIdentifiable
    {
        
        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets or sets the identifier of <see cref="Map"/>.
        /// </summary>
        public Guid? MapId { get; set; }

        /// <summary>
        /// Gets the raw object of <see cref="Map" />.
        /// </summary>
        [ForeignKey(nameof(MapId))]
        public GameMapDefinition RawMap
        {
            get => base.Map as GameMapDefinition;
            set => base.Map = value;
        }

        /// <inheritdoc/>
        [NotMapped]
        public override MUnique.OpenMU.DataModel.Configuration.GameMapDefinition Map
        {
            get => base.Map;set
            {
                base.Map = value;
                this.MapId = this.RawMap?.Id;
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