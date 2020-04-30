using GobiernoApiTransporteSharp.API.Versions;
using GobiernoApiTransporteSharp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;

namespace GobiernoApiTransporteSharp.API
{
    internal class GobiernoApiVersionList
    {
        public static GobiernoApiVersionList GetApiVersionList() => new GobiernoApiVersionList();

        public Dictionary<GobiernoApiVersionType, GobiernoApiVersion> ApiVersions()
        {
            return new Dictionary<GobiernoApiVersionType, GobiernoApiVersion>
            {
                {
                    GobiernoApiVersionType.v0,
                    new GobiernoApiVersion
                    {
                         AppApiVersionCode = "95414346",
                         AppVersion = "35.0.0.20.96",

                    }
                },
                {
                    GobiernoApiVersionType.v1,
                    new GobiernoApiVersion
                    {
                         AppApiVersionCode = "107092322",
                         AppVersion = "44.0.0.9.93",
                         //Capabilities = "3brTPw==",
                         //SignatureKey = "25f955cc0c8f080a0592aa1fd2572d60afacd5f3c03090cf47ca409068b0d2e1"
                    }
                },
                {
                    GobiernoApiVersionType.v2,
                    new GobiernoApiVersion
                    {
                         AppApiVersionCode = "107092322",
                         AppVersion = "61.0.0.19.86",

                    }
                }
                };
        }


        public GobiernoApiVersion GetApiVersion(GobiernoApiVersionType versionType)
        {
            return (from apiVer in ApiVersions()
                    where apiVer.Key == versionType
                    select apiVer.Value).FirstOrDefault();
        }
    }
}
