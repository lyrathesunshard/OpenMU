// <copyright file="ItemDefinition.Generated.cs" company="MUnique">
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
    /// The Entity Framework Core implementation of <see cref="MUnique.OpenMU.DataModel.Configuration.Items.ItemDefinition"/>.
    /// </summary>
    [Table(nameof(ItemDefinition), Schema = "config")]
    internal partial class ItemDefinition : MUnique.OpenMU.DataModel.Configuration.Items.ItemDefinition, IIdentifiable
    {
        /// <inheritdoc />
        public ItemDefinition()
        {
            this.InitJoinCollections();
        }

        
        /// <summary>
        /// Gets or sets the identifier of this instance.
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// Gets the raw collection of <see cref="Requirements" />.
        /// </summary>
        public ICollection<AttributeRequirement> RawRequirements { get; } = new List<AttributeRequirement>();
        
        /// <inheritdoc/>
        [NotMapped]
        public override ICollection<MUnique.OpenMU.DataModel.Configuration.Items.AttributeRequirement> Requirements => base.Requirements ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.Items.AttributeRequirement, AttributeRequirement>(this.RawRequirements);

        /// <summary>
        /// Gets the raw collection of <see cref="BasePowerUpAttributes" />.
        /// </summary>
        public ICollection<ItemBasePowerUpDefinition> RawBasePowerUpAttributes { get; } = new List<ItemBasePowerUpDefinition>();
        
        /// <inheritdoc/>
        [NotMapped]
        public override ICollection<MUnique.OpenMU.DataModel.Configuration.Items.ItemBasePowerUpDefinition> BasePowerUpAttributes => base.BasePowerUpAttributes ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.Items.ItemBasePowerUpDefinition, ItemBasePowerUpDefinition>(this.RawBasePowerUpAttributes);

        /// <summary>
        /// Gets or sets the identifier of <see cref="ItemSlot"/>.
        /// </summary>
        public Guid? ItemSlotId { get; set; }

        /// <summary>
        /// Gets the raw object of <see cref="ItemSlot" />.
        /// </summary>
        [ForeignKey(nameof(ItemSlotId))]
        public ItemSlotType RawItemSlot
        {
            get => base.ItemSlot as ItemSlotType;
            set => base.ItemSlot = value;
        }

        /// <inheritdoc/>
        [NotMapped]
        public override MUnique.OpenMU.DataModel.Configuration.Items.ItemSlotType ItemSlot
        {
            get => base.ItemSlot;set
            {
                base.ItemSlot = value;
                this.ItemSlotId = this.RawItemSlot?.Id;
            }
        }

        /// <summary>
        /// Gets or sets the identifier of <see cref="Skill"/>.
        /// </summary>
        public Guid? SkillId { get; set; }

        /// <summary>
        /// Gets the raw object of <see cref="Skill" />.
        /// </summary>
        [ForeignKey(nameof(SkillId))]
        public Skill RawSkill
        {
            get => base.Skill as Skill;
            set => base.Skill = value;
        }

        /// <inheritdoc/>
        [NotMapped]
        public override MUnique.OpenMU.DataModel.Configuration.Skill Skill
        {
            get => base.Skill;set
            {
                base.Skill = value;
                this.SkillId = this.RawSkill?.Id;
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

        protected void InitJoinCollections()
        {
            this.QualifiedCharacters = new ManyToManyCollectionAdapter<MUnique.OpenMU.DataModel.Configuration.CharacterClass, ItemDefinitionCharacterClass>(this.JoinedQualifiedCharacters, joinEntity => joinEntity.CharacterClass, entity => new ItemDefinitionCharacterClass { ItemDefinition = this, ItemDefinitionId = this.Id, CharacterClass = (CharacterClass)entity, CharacterClassId = ((CharacterClass)entity).Id});
            this.PossibleItemSetGroups = new ManyToManyCollectionAdapter<MUnique.OpenMU.DataModel.Configuration.Items.ItemSetGroup, ItemDefinitionItemSetGroup>(this.JoinedPossibleItemSetGroups, joinEntity => joinEntity.ItemSetGroup, entity => new ItemDefinitionItemSetGroup { ItemDefinition = this, ItemDefinitionId = this.Id, ItemSetGroup = (ItemSetGroup)entity, ItemSetGroupId = ((ItemSetGroup)entity).Id});
            this.PossibleItemOptions = new ManyToManyCollectionAdapter<MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionDefinition, ItemDefinitionItemOptionDefinition>(this.JoinedPossibleItemOptions, joinEntity => joinEntity.ItemOptionDefinition, entity => new ItemDefinitionItemOptionDefinition { ItemDefinition = this, ItemDefinitionId = this.Id, ItemOptionDefinition = (ItemOptionDefinition)entity, ItemOptionDefinitionId = ((ItemOptionDefinition)entity).Id});
        }
    }
}