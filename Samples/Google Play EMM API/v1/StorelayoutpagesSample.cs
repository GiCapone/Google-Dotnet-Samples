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
// Unoffical sample for the Androidenterprise v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages the deployment of apps to Android for Work users.
// API Documentation Link https://developers.google.com/android/work/play/emm-api
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Androidenterprise/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Androidenterprise.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Androidenterprise.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Androidenterprise.v1;
using Google.Apis.Androidenterprise.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Androidenterprisev1.Methods
{
  
    public static class StorelayoutpagesSample
    {


        /// <summary>
        /// Deletes a store page. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/storelayoutpages/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="pageId">The ID of the page.</param>
        public static void Delete(AndroidenterpriseService service, string enterpriseId, string pageId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (pageId == null)
                    throw new ArgumentNullException(pageId);

                // Make the request.
                 service.Storelayoutpages.Delete(enterpriseId, pageId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Storelayoutpages.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves details of a store page. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/storelayoutpages/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <returns>StorePageResponse</returns>
        public static StorePage Get(AndroidenterpriseService service, string enterpriseId, string pageId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (pageId == null)
                    throw new ArgumentNullException(pageId);

                // Make the request.
                return service.Storelayoutpages.Get(enterpriseId, pageId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Storelayoutpages.Get failed.", ex);
            }
        }

        /// <summary>
        /// Inserts a new store page. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/storelayoutpages/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="body">A valid Androidenterprise v1 body.</param>
        /// <returns>StorePageResponse</returns>
        public static StorePage Insert(AndroidenterpriseService service, string enterpriseId, StorePage body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);

                // Make the request.
                return service.Storelayoutpages.Insert(body, enterpriseId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Storelayoutpages.Insert failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves the details of all pages in the store. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/storelayoutpages/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <returns>StoreLayoutPagesListResponseResponse</returns>
        public static StoreLayoutPagesListResponse List(AndroidenterpriseService service, string enterpriseId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);

                // Make the request.
                return service.Storelayoutpages.List(enterpriseId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Storelayoutpages.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates the content of a store page. This method supports patch semantics. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/storelayoutpages/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <param name="body">A valid Androidenterprise v1 body.</param>
        /// <returns>StorePageResponse</returns>
        public static StorePage Patch(AndroidenterpriseService service, string enterpriseId, string pageId, StorePage body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (pageId == null)
                    throw new ArgumentNullException(pageId);

                // Make the request.
                return service.Storelayoutpages.Patch(body, enterpriseId, pageId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Storelayoutpages.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Updates the content of a store page. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/storelayoutpages/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="pageId">The ID of the page.</param>
        /// <param name="body">A valid Androidenterprise v1 body.</param>
        /// <returns>StorePageResponse</returns>
        public static StorePage Update(AndroidenterpriseService service, string enterpriseId, string pageId, StorePage body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (pageId == null)
                    throw new ArgumentNullException(pageId);

                // Make the request.
                return service.Storelayoutpages.Update(body, enterpriseId, pageId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Storelayoutpages.Update failed.", ex);
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