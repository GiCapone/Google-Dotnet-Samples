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
//     Build date: 2017-09-22
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Drive v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages files in Drive including uploading, downloading, searching, detecting changes, and updating sharing permissions.
// API Documentation Link https://developers.google.com/drive/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Drive/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Drive.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Drive.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Drivev2.Methods
{
  
    public static class RealtimeSample
    {

        public class RealtimeGetOptionalParms
        {
            /// The revision of the Realtime API data model to export. Revisions start at 1 (the initial empty data model) and are incremented with each change. If this parameter is excluded, the most recent data model will be returned.
            public int? Revision { get; set; }  
        
        }
 
        /// <summary>
        /// Exports the contents of the Realtime API data model associated with this file as JSON. 
        /// Documentation https://developers.google.com/drive/v2/reference/realtime/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file that the Realtime API data model is associated with.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Get(DriveService service, string fileId, RealtimeGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Building the initial request.
                var request = service.Realtime.Get(fileId);

                // Applying optional parameters to the request.                
                request = (RealtimeResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Realtime.Get failed.", ex);
            }
        }
        public class RealtimeUpdateOptionalParms
        {
            /// The revision of the model to diff the uploaded model against. If set, the uploaded model is diffed against the provided revision and those differences are merged with any changes made to the model after the provided revision. If not set, the uploaded model replaces the current model on the server.
            public string BaseRevision { get; set; }  
        
        }
 
        /// <summary>
        /// Overwrites the Realtime API data model associated with this file with the provided JSON data model. 
        /// Documentation https://developers.google.com/drive/v2/reference/realtime/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file that the Realtime API data model is associated with.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Update(DriveService service, string fileId, RealtimeUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Building the initial request.
                var request = service.Realtime.Update(fileId);

                // Applying optional parameters to the request.                
                request = (RealtimeResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Realtime.Update failed.", ex);
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