﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  methodTemplate.tt
//     Build date: 2017-09-26
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Adsensehost v4.1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Generates performance reports, generates ad codes, and provides publisher management capabilities for AdSense Hosts.
// API Documentation Link https://developers.google.com/adsense/host/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Adsensehost/v4_1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Adsensehost.v4_1/ 
// Install Command: PM>  Install-Package Google.Apis.Adsensehost.v4_1
//
//------------------------------------------------------------------------------  
using Google.Apis.Adsensehost.v4_1;
using Google.Apis.Adsensehost.v4_1.Data;
using System;

namespace GoogleSamplecSharpSample.Adsensehostv4_1.Methods
{
  
    public static class ReportsSample
    {

        public class ReportsGenerateOptionalParms
        {
            /// Dimensions to base the report on.
            public string Dimension { get; set; }  
            /// Filters to be run on the report.
            public string Filter { get; set; }  
            /// Optional locale to use for translating report output to a local language. Defaults to "en_US" if not specified.
            public string Locale { get; set; }  
            /// The maximum number of rows of report data to return.
            public int? MaxResults { get; set; }  
            /// Numeric columns to include in the report.
            public string Metric { get; set; }  
            /// The name of a dimension or metric to sort the resulting report on, optionally prefixed with "+" to sort ascending or "-" to sort descending. If no prefix is specified, the column is sorted ascending.
            public string Sort { get; set; }  
            /// Index of the first row of report data to return.
            public int? StartIndex { get; set; }  
        
        }
 
        /// <summary>
        /// Generate an AdSense report based on the report request sent in the query parameters. Returns the result as JSON; to retrieve output in CSV format specify "alt=csv" as a query parameter. 
        /// Documentation https://developers.google.com/adsensehost/v4.1/reference/reports/generate
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adsensehost service.</param>  
        /// <param name="startDate">Start of the date range to report on in "YYYY-MM-DD" format, inclusive.</param>
        /// <param name="endDate">End of the date range to report on in "YYYY-MM-DD" format, inclusive.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ReportResponse</returns>
        public static Report Generate(AdsensehostService service, string startDate, string endDate, ReportsGenerateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (startDate == null)
                    throw new ArgumentNullException(startDate);
                if (endDate == null)
                    throw new ArgumentNullException(endDate);

                // Building the initial request.
                var request = service.Reports.Generate(startDate, endDate);

                // Applying optional parameters to the request.                
                request = (ReportsResource.GenerateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Reports.Generate failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}