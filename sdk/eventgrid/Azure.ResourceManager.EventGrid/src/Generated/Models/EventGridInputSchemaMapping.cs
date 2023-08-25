// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary>
    /// By default, Event Grid expects events to be in the Event Grid event schema. Specifying an input schema mapping enables publishing to Event Grid using a custom input schema. Currently, the only supported type of InputSchemaMapping is 'JsonInputSchemaMapping'.
    /// Please note <see cref="EventGridInputSchemaMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="EventGridJsonInputSchemaMapping"/>.
    /// </summary>
    public abstract partial class EventGridInputSchemaMapping
    {
        /// <summary> Initializes a new instance of EventGridInputSchemaMapping. </summary>
        protected EventGridInputSchemaMapping()
        {
        }

        /// <summary> Initializes a new instance of EventGridInputSchemaMapping. </summary>
        /// <param name="inputSchemaMappingType"> Type of the custom mapping. </param>
        internal EventGridInputSchemaMapping(InputSchemaMappingType inputSchemaMappingType)
        {
            InputSchemaMappingType = inputSchemaMappingType;
        }

        /// <summary> Type of the custom mapping. </summary>
        internal InputSchemaMappingType InputSchemaMappingType { get; set; }
    }
}
