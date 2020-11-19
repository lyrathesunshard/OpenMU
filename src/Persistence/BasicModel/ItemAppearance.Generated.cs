// <copyright file="ItemAppearance.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

        //------------------------------------------------------------------------------
        // <auto-generated>
        //     This source code was auto-generated by a roslyn code generator.
        // </auto-generated>
        //------------------------------------------------------------------------------

        // ReSharper disable All

namespace MUnique.OpenMU.Persistence.BasicModel
{
    using System;
    using System.Collections.Generic;
    using MUnique.OpenMU.Persistence.Json;
    
    /// <summary>
    /// A plain implementation of <see cref="ItemAppearance"/>.
    /// </summary>
    public partial class ItemAppearance : MUnique.OpenMU.DataModel.Entities.ItemAppearance, IIdentifiable, IConvertibleTo<ItemAppearance>
    {
        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets the raw collection of <see cref="VisibleOptions" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("visibleOptions")]
        [System.Text.Json.Serialization.JsonPropertyName("visibleOptions")]
        public ICollection<ItemOptionType> RawVisibleOptions { get; } = new List<ItemOptionType>();
        
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override ICollection<MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionType> VisibleOptions
        {
            get => base.VisibleOptions ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionType, ItemOptionType>(this.RawVisibleOptions);
            protected set
            {
                this.VisibleOptions.Clear();
                foreach (var item in value)
                {
                    this.VisibleOptions.Add(item);
                }
            }
        }

        /// <summary>
        /// Gets the raw object of <see cref="Definition" />.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("definition")]
        [System.Text.Json.Serialization.JsonPropertyName("definition")]
        public ItemDefinition RawDefinition
        {
            get => base.Definition as ItemDefinition;
            set => base.Definition = value;
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override MUnique.OpenMU.DataModel.Configuration.Items.ItemDefinition Definition
        {
            get => base.Definition;
            set => base.Definition = value;
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

        /// <inheritdoc/>
        public ItemAppearance Convert() => this;
    }
}