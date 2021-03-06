﻿using CatFactory.Mapping;

namespace CatFactory.SqlServer
{
    /// <summary>
    /// Represents an entity result (Definition for entity)
    /// </summary>
    /// <typeparam name="TModel">Anonymous type</typeparam>
    public class EntityResult<TModel> where TModel : class
    {
        /// <summary>
        /// Initializes a new instance of <see cref="EntityHelper"/> class
        /// </summary>
        public EntityResult()
        {
        }

        /// <summary>
        /// Gets or sets the table associated with current entity result
        /// </summary>
        public Table Table { get; set; }

        /// <summary>
        /// Gets or sets the model associated with current entity result
        /// </summary>
        public TModel Model { get; set; }
    }
}
