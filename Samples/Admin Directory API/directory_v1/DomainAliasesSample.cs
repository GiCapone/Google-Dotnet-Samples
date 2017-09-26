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
// Unoffical sample for the Directory directory_v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Admin SDK Directory API lets you view and manage enterprise resources such as users and groups, administrative notifications, security features, and more.
// API Documentation Link https://developers.google.com/admin-sdk/directory/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Directory/directory_v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Directory.directory_v1/ 
// Install Command: PM>  Install-Package Google.Apis.Directory.directory_v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Directory.directory_v1;
using Google.Apis.Directory.directory_v1.Data;
using System;

namespace GoogleSamplecSharpSample.Directorydirectory_v1.Methods
{
  
    public static class DomainAliasesSample
    {


        /// <summary>
        /// Deletes a Domain Alias of the customer. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/domainAliases/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        /// <param name="domainAliasName">Name of domain alias to be retrieved.</param>
        public static void Delete(DirectoryService service, string customer, string domainAliasName)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customer == null)
                    throw new ArgumentNullException(customer);
                if (domainAliasName == null)
                    throw new ArgumentNullException(domainAliasName);

                // Make the request.
                 service.DomainAliases.Delete(customer, domainAliasName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request DomainAliases.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves a domain alias of the customer. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/domainAliases/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        /// <param name="domainAliasName">Name of domain alias to be retrieved.</param>
        /// <returns>DomainAliasResponse</returns>
        public static DomainAlias Get(DirectoryService service, string customer, string domainAliasName)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customer == null)
                    throw new ArgumentNullException(customer);
                if (domainAliasName == null)
                    throw new ArgumentNullException(domainAliasName);

                // Make the request.
                return service.DomainAliases.Get(customer, domainAliasName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request DomainAliases.Get failed.", ex);
            }
        }

        /// <summary>
        /// Inserts a Domain alias of the customer. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/domainAliases/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        /// <param name="body">A valid Directory directory_v1 body.</param>
        /// <returns>DomainAliasResponse</returns>
        public static DomainAlias Insert(DirectoryService service, string customer, DomainAlias body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (customer == null)
                    throw new ArgumentNullException(customer);

                // Make the request.
                return service.DomainAliases.Insert(body, customer).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request DomainAliases.Insert failed.", ex);
            }
        }
        public class DomainAliasesListOptionalParms
        {
            /// Name of the parent domain for which domain aliases are to be fetched.
            public string ParentDomainName { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the domain aliases of the customer. 
        /// Documentation https://developers.google.com/directory/directory_v1/reference/domainAliases/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Directory service.</param>  
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>DomainAliasesResponse</returns>
        public static DomainAliases List(DirectoryService service, string customer, DomainAliasesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (customer == null)
                    throw new ArgumentNullException(customer);

                // Building the initial request.
                var request = service.DomainAliases.List(customer);

                // Applying optional parameters to the request.                
                request = (DomainAliasesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request DomainAliases.List failed.", ex);
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