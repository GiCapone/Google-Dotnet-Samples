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
// Unoffical sample for the Servicemanagement v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Google Service Management allows service producers to publish their services on Google Cloud Platform so that they can be discovered and used by service consumers.
// API Documentation Link https://cloud.google.com/service-management/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Servicemanagement/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Servicemanagement.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Servicemanagement.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Servicemanagement.v1;
using Google.Apis.Servicemanagement.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Servicemanagementv1.Methods
{
  
    public static class OperationsSample
    {


        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use thismethod to poll the operation result at intervals as recommended by the APIservice. 
        /// Documentation https://developers.google.com/servicemanagement/v1/reference/operations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Servicemanagement service.</param>  
        /// <param name="name">The name of the operation resource.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Get(ServicemanagementService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Operations.Get(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Operations.Get failed.", ex);
            }
        }
        public class OperationsListOptionalParms
        {
            /// A string for filtering Operations.  The following filter fields are supported&#58;  * serviceName&#58; Required. Only `=` operator is allowed.  * startTime&#58; The time this job was started, in ISO 8601 format.    Allowed operators are `>=`,  `>`, `<=`, and `<`.  * status&#58; Can be `done`, `in_progress`, or `failed`. Allowed    operators are `=`, and `!=`.  Filter expression supports conjunction (AND) and disjunction (OR)  logical operators. However, the serviceName restriction must be at the  top-level and can only be combined with other restrictions via the AND  logical operator.  Examples&#58;  * `serviceName={some-service}.googleapis.com`  * `serviceName={some-service}.googleapis.com AND startTime>="2017-02-01"`  * `serviceName={some-service}.googleapis.com AND status=done`  * `serviceName={some-service}.googleapis.com AND (status=done OR startTime>="2017-02-01")`
            public string Filter { get; set; }  
            /// The standard list page token.
            public string PageToken { get; set; }  
            /// Not used.
            public string Name { get; set; }  
            /// The maximum number of operations to return. If unspecified, defaults to50. The maximum value is 100.
            public int? PageSize { get; set; }  
        
        }
 
        /// <summary>
        /// Lists service operations that match the specified filter in the request. 
        /// Documentation https://developers.google.com/servicemanagement/v1/reference/operations/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Servicemanagement service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListOperationsResponseResponse</returns>
        public static ListOperationsResponse List(ServicemanagementService service, OperationsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Operations.List();

                // Applying optional parameters to the request.                
                request = (OperationsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Operations.List failed.", ex);
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