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
  
    public static class PretargetingConfigSample
    {


        /// <summary>
        /// Deletes an existing pretargeting config. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.3/reference/pretargetingConfig/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adexchangebuyer service.</param>  
        /// <param name="accountId">The account id to delete the pretargeting config for.</param>
        /// <param name="configId">The specific id of the configuration to delete.</param>
        public static void Delete(AdexchangebuyerService service, string accountId, string configId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (configId == null)
                    throw new ArgumentNullException(configId);

                // Make the request.
                 service.PretargetingConfig.Delete(accountId, configId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request PretargetingConfig.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Gets a specific pretargeting configuration 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.3/reference/pretargetingConfig/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adexchangebuyer service.</param>  
        /// <param name="accountId">The account id to get the pretargeting config for.</param>
        /// <param name="configId">The specific id of the configuration to retrieve.</param>
        /// <returns>PretargetingConfigResponse</returns>
        public static PretargetingConfig Get(AdexchangebuyerService service, string accountId, string configId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (configId == null)
                    throw new ArgumentNullException(configId);

                // Make the request.
                return service.PretargetingConfig.Get(accountId, configId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request PretargetingConfig.Get failed.", ex);
            }
        }

        /// <summary>
        /// Inserts a new pretargeting configuration. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.3/reference/pretargetingConfig/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adexchangebuyer service.</param>  
        /// <param name="accountId">The account id to insert the pretargeting config for.</param>
        /// <param name="body">A valid Adexchangebuyer v1.3 body.</param>
        /// <returns>PretargetingConfigResponse</returns>
        public static PretargetingConfig Insert(AdexchangebuyerService service, string accountId, PretargetingConfig body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);

                // Make the request.
                return service.PretargetingConfig.Insert(body, accountId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request PretargetingConfig.Insert failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves a list of the authenticated user's pretargeting configurations. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.3/reference/pretargetingConfig/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adexchangebuyer service.</param>  
        /// <param name="accountId">The account id to get the pretargeting configs for.</param>
        /// <returns>PretargetingConfigListResponse</returns>
        public static PretargetingConfigList List(AdexchangebuyerService service, string accountId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);

                // Make the request.
                return service.PretargetingConfig.List(accountId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request PretargetingConfig.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing pretargeting config. This method supports patch semantics. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.3/reference/pretargetingConfig/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adexchangebuyer service.</param>  
        /// <param name="accountId">The account id to update the pretargeting config for.</param>
        /// <param name="configId">The specific id of the configuration to update.</param>
        /// <param name="body">A valid Adexchangebuyer v1.3 body.</param>
        /// <returns>PretargetingConfigResponse</returns>
        public static PretargetingConfig Patch(AdexchangebuyerService service, string accountId, string configId, PretargetingConfig body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (configId == null)
                    throw new ArgumentNullException(configId);

                // Make the request.
                return service.PretargetingConfig.Patch(body, accountId, configId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request PretargetingConfig.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing pretargeting config. 
        /// Documentation https://developers.google.com/adexchangebuyer/v1.3/reference/pretargetingConfig/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adexchangebuyer service.</param>  
        /// <param name="accountId">The account id to update the pretargeting config for.</param>
        /// <param name="configId">The specific id of the configuration to update.</param>
        /// <param name="body">A valid Adexchangebuyer v1.3 body.</param>
        /// <returns>PretargetingConfigResponse</returns>
        public static PretargetingConfig Update(AdexchangebuyerService service, string accountId, string configId, PretargetingConfig body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (accountId == null)
                    throw new ArgumentNullException(accountId);
                if (configId == null)
                    throw new ArgumentNullException(configId);

                // Make the request.
                return service.PretargetingConfig.Update(body, accountId, configId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request PretargetingConfig.Update failed.", ex);
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