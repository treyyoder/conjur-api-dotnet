﻿// <copyright file="ResourceMetadata.cs" company="Conjur Inc.">
//     Copyright (c) 2016 Conjur Inc. All rights reserved.
// </copyright>
// <summary>
//     Class representing resource metadata returned from web request.
// </summary>

namespace Conjur
{
    using System.Runtime.Serialization;

    [DataContract]
<<<<<<< HEAD
    public class ResourceMetadataֿ
=======
    public class ResourceMetadata
>>>>>>> 9b1fc3a577d209f9dc2470af980fdd7e44a95d22
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "policy")]
        public string Policy { get; set; }
        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }
        [DataMember(Name = "owner")]
        public string Owner { get; set; }
        [DataMember(Name = "permissions")]
        public Permission[] Permissions { get; set; }
        [DataMember(Name = "annotations")]
        public Annotation[] Annotations { get; set; }
        [DataMember(Name = "secrets")]
        public Secrets[] Secrets { get; set; }
    }

    [DataContract]
    public class Permission
    {
        [DataMember(Name = "privilege")]
        public string Privilege { get; set; }
        [DataMember(Name = "grant_option")]
        public string GrantOption { get; set; }
        [DataMember(Name = "resource")]
        public string Resource { get; set; }
        [DataMember(Name = "role")]
        public string Role { get; set; }
        [DataMember(Name = "grantor")]
        public string Grantor { get; set; }
    }

    [DataContract]
    public class Annotation
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "value")]
        public string Value { get; set; }
        [DataMember(Name = "policy")]
        public string Policy { get; set; }
    }

    [DataContract]
    public class Secrets
    {
        [DataMember(Name = "version")]
        public string Version { get; set; }
        [DataMember(Name = "expires_at")]
        public string ExpiresAt { get; set; }
    }
}