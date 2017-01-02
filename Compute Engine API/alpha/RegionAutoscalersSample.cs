﻿// Copyright 2017 DAIMTO :  www.daimto.com
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
//     Template File Name:  Methodtemplate.tt
//     Build date: 01/02/2017 22:32:16
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the compute alpha API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and runs virtual machines on Google Cloud Platform.
// API Documentation Link https://developers.google.com/compute/docs/reference/latest/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/compute/alpha/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.compute.alpha/ 
// Install Command: PM>  Install-Package Google.Apis.compute.alpha
//
//------------------------------------------------------------------------------  
using Google.Apis.compute.alpha;
using Google.Apis.compute.alpha.Data;
using System;

namespace GoogleSamplecSharpSample.computealpha.Methods
{
  
    public static class RegionAutoscalersSample
    {


        /// <summary>
        /// Deletes the specified autoscaler. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionAutoscalers/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="autoscaler">Name of the autoscaler to delete.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Delete(computeService service, string project, string region, string autoscaler)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (autoscaler == null)
                    throw new ArgumentNullException(autoscaler);

                // Make the request.
                return service.RegionAutoscalers.Delete(project, region, autoscaler).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionAutoscalers.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Returns the specified autoscaler. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionAutoscalers/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="autoscaler">Name of the autoscaler to return.</param>
        /// <returns>AutoscalerResponse</returns>
        public static Autoscaler Get(computeService service, string project, string region, string autoscaler)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (autoscaler == null)
                    throw new ArgumentNullException(autoscaler);

                // Make the request.
                return service.RegionAutoscalers.Get(project, region, autoscaler).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionAutoscalers.Get failed.", ex);
            }
        }


        /// <summary>
        /// Creates an autoscaler in the specified project using the data included in the request. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionAutoscalers/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="body">A valid compute alpha body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Insert(computeService service, string project, string region, Autoscaler body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);

                // Make the request.
                return service.RegionAutoscalers.Insert(body, project, region).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionAutoscalers.Insert failed.", ex);
            }
        }

        public class RegionAutoscalersListOptionalParms
        {
            /// Sets a filter expression for filtering listed resources, in the form filter={expression}. Your {expression} must be in the format: field_name comparison_string literal_string.

The field_name is the name of the field you want to compare. Only atomic field types are supported (string, number, boolean). The comparison_string must be either eq (equals) or ne (not equals). The literal_string is the string value to filter to. The literal value must be valid for the type of field you are filtering by (string, number, boolean). For string fields, the literal value is interpreted as a regular expression using RE2 syntax. The literal value must match the entire field.

For example, to filter for instances that do not have a name of example-instance, you would use filter=name ne example-instance.

You can filter on nested fields. For example, you could filter on instances that have set the scheduling.automaticRestart field to true. Use filtering on nested fields to take advantage of labels to organize and search for results based on label values.

To filter on multiple expressions, provide each separate expression within parentheses. For example, (scheduling.automaticRestart eq true) (zone eq us-central1-f). Multiple expressions are treated as AND expressions, meaning that resources must match all expressions to pass the filters.
            public string Filter { get; set; }  
            /// The maximum number of results per page that should be returned. If the number of available results is larger than maxResults, Compute Engine returns a nextPageToken that can be used to get the next page of results in subsequent list requests.
            public int MaxResults { get; set; }  
            /// Sorts list results by a certain order. By default, results are returned in alphanumerical order based on the resource name.

You can also sort results in descending order based on the creation timestamp using orderBy="creationTimestamp desc". This sorts results based on the creationTimestamp field in reverse chronological order (newest result first). Use this to sort resources like operations so that the newest operation is returned first.

Currently, only sorting by name or creationTimestamp desc is supported.
            public string OrderBy { get; set; }  
            /// Specifies a page token to use. Set pageToken to the nextPageToken returned by a previous list request to get the next page of results.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of autoscalers contained within the specified region. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionAutoscalers/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>RegionAutoscalerListResponse</returns>
        public static RegionAutoscalerList List(computeService service, string project, string region, RegionAutoscalersListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);

                // Building the initial request.
                var request = service.RegionAutoscalers.List(project, region);

                // Applying optional parameters to the request.                
                request = (RegionAutoscalersResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionAutoscalers.List failed.", ex);
            }
        }


        /// <summary>
        /// Updates an autoscaler in the specified project using the data included in the request. This method supports patch semantics. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionAutoscalers/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="autoscaler">Name of the autoscaler to update.</param>
        /// <param name="body">A valid compute alpha body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Patch(computeService service, string project, string region, string autoscaler, Autoscaler body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (autoscaler == null)
                    throw new ArgumentNullException(autoscaler);

                // Make the request.
                return service.RegionAutoscalers.Patch(body, project, region, autoscaler).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionAutoscalers.Patch failed.", ex);
            }
        }


        /// <summary>
        /// Returns permissions that a caller has on the specified resource. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionAutoscalers/testIamPermissions
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">The name of the region for this request.</param>
        /// <param name="resource">Name of the resource for this request.</param>
        /// <param name="body">A valid compute alpha body.</param>
        /// <returns>TestPermissionsResponseResponse</returns>
        public static TestPermissionsResponse TestIamPermissions(computeService service, string project, string region, string resource, TestPermissionsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.RegionAutoscalers.TestIamPermissions(body, project, region, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionAutoscalers.TestIamPermissions failed.", ex);
            }
        }

        public class RegionAutoscalersUpdateOptionalParms
        {
            /// Name of the autoscaler to update.
            public string Autoscaler { get; set; }  
        
        }
 
        /// <summary>
        /// Updates an autoscaler in the specified project using the data included in the request. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionAutoscalers/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region scoping this request.</param>
        /// <param name="body">A valid compute alpha body.</param>
        /// <param name="optional">Optional paramaters.</param>        /// <returns>OperationResponse</returns>
        public static Operation Update(computeService service, string project, string region, Autoscaler body, RegionAutoscalersUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);

                // Building the initial request.
                var request = service.RegionAutoscalers.Update(body, project, region);

                // Applying optional parameters to the request.                
                request = (RegionAutoscalersResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionAutoscalers.Update failed.", ex);
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