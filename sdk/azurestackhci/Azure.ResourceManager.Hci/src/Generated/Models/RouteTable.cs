// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Route table resource. </summary>
    public partial class RouteTable
    {
        /// <summary> Initializes a new instance of <see cref="RouteTable"/>. </summary>
        public RouteTable()
        {
            Routes = new ChangeTrackingList<Route>();
        }

        /// <summary> Initializes a new instance of <see cref="RouteTable"/>. </summary>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="routeTableType"> Resource type. </param>
        /// <param name="routes"> Collection of routes contained within a route table. </param>
        internal RouteTable(string etag, string name, string routeTableType, IList<Route> routes)
        {
            ETag = etag;
            Name = name;
            RouteTableType = routeTableType;
            Routes = routes;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string ETag { get; }
        /// <summary> Resource name. </summary>
        public string Name { get; }
        /// <summary> Resource type. </summary>
        public string RouteTableType { get; }
        /// <summary> Collection of routes contained within a route table. </summary>
        public IList<Route> Routes { get; }
    }
}
