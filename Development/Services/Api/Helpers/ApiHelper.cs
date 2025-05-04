using Microsoft.Owin;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Linq;

namespace Api.Helpers
{
    public class XpoSafeContractResolver : DefaultContractResolver
    {
        private static readonly HashSet<string> IgnoredProperties = new HashSet<string>
        {
            "Session",
            "ClassInfo",
            "IsDeleted",
            "Loading",
            "IsLoading",
            "DelayedProperties",
            "GCRecord",
            "_Session"
        };

        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            IList<JsonProperty> props = base.CreateProperties(type, memberSerialization);
            return props
                .Where(p => !IgnoredProperties.Contains(p.PropertyName))
                .ToList();
        }
    }

}
