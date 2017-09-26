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
// Unoffical sample for the Adexchangebuyer v1.3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Accesses your bidding-account information, submits creatives for validation, finds available direct deals, and retrieves performance reports.
// API Documentation Link https://developers.google.com/ad-exchange/buyer-rest
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Adexchangebuyer/v1_3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Adexchangebuyer.v1_3/ 
// Install Command: PM>  Install-Package Google.Apis.Adexchangebuyer.v1_3
//
//------------------------------------------------------------------------------  
using Google.Apis.Adexchangebuyer.v1_3;
using Google.Apis.Adexchangebuyer.v1_3.Data;
using System;

namespace GoogleSamplecSharpSample.Adexchangebuyerv1_3.Methods
{
  
    public static class CreativesSample
    {


        /// <summary>
        /// Gets the status for a single creative. A creative will be available 30-40 minutes after submission. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.3/reference/creatives/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adexchangebuyer service.</param>  
        /// <param name="accountId">The id for the account that will serve this creative.</param>
        /// <param name="buyerCreativeId">The buyer-specific id for this creative.</param>
        /// <returns>CreativeResponse</returns>
        public static Creative Get(AdexchangebuyerService service, int? accountId, string buyerCreativeId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (buyerCreativeId == null)
                    throw new ArgumentNullException(buyerCreativeId);

                // Make the request.
                return service.Creatives.Get(accountId, buyerCreativeId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Creatives.Get failed.", ex);
            }
        }

        /// <summary>
        /// Submit a new creative. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.3/reference/creatives/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adexchangebuyer service.</param>  
        /// <param name="body">A valid Adexchangebuyer v1.3 body.</param>
        /// <returns>CreativeResponse</returns>
        public static Creative Insert(AdexchangebuyerService service, Creative body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Creatives.Insert(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Creatives.Insert failed.", ex);
            }
        }
        public class CreativesListOptionalParms
        {
            /// When specified, only creatives for the given account ids are returned.
            public int? AccountId { get; set; }  
            /// When specified, only creatives for the given buyer creative ids are returned.
            public string BuyerCreativeId { get; set; }  
            /// Maximum number of entries returned on one result page. If not set, the default is 100. Optional.
            public int? MaxResults { get; set; }  
            /// A continuation token, used to page through ad clients. To retrieve the next page, set this parameter to the value of "nextPageToken" from the previous response. Optional.
            public string PageToken { get; set; }  
            /// When specified, only creatives having the given status are returned.
            public string StatusFilter { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of the authenticated user's active creatives. A creative will be available 30-40 minutes after submission. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.3/reference/creatives/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adexchangebuyer service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>CreativesListResponse</returns>
        public static CreativesList List(AdexchangebuyerService service, CreativesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Creatives.List();

                // Applying optional parameters to the request.                
                request = (CreativesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Creatives.List failed.", ex);
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