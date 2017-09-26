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
  
    public static class UsersSample
    {


        /// <summary>
        /// Deleted an EMM-managed user. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/users/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        public static void Delete(AndroidenterpriseService service, string enterpriseId, string userId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                 service.Users.Delete(enterpriseId, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Generates an authentication token which the device policy client can use to provision the given EMM-managed user account on a device. The generated token is single-use and expires after a few minutes.This call only works with EMM-managed accounts. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/users/generateAuthenticationToken
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>AuthenticationTokenResponse</returns>
        public static AuthenticationToken GenerateAuthenticationToken(AndroidenterpriseService service, string enterpriseId, string userId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.Users.GenerateAuthenticationToken(enterpriseId, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.GenerateAuthenticationToken failed.", ex);
            }
        }

        /// <summary>
        /// Generates a token (activation code) to allow this user to configure their managed account in the Android Setup Wizard. Revokes any previously generated token.This call only works with Google managed accounts. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/users/generateToken
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>UserTokenResponse</returns>
        public static UserToken GenerateToken(AndroidenterpriseService service, string enterpriseId, string userId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.Users.GenerateToken(enterpriseId, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.GenerateToken failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves a user's details. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/users/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>UserResponse</returns>
        public static User Get(AndroidenterpriseService service, string enterpriseId, string userId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.Users.Get(enterpriseId, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.Get failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves the set of products a user is entitled to access. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/users/getAvailableProductSet
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>ProductSetResponse</returns>
        public static ProductSet GetAvailableProductSet(AndroidenterpriseService service, string enterpriseId, string userId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.Users.GetAvailableProductSet(enterpriseId, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.GetAvailableProductSet failed.", ex);
            }
        }

        /// <summary>
        /// Creates a new EMM-managed user.The Users resource passed in the body of the request should include an accountIdentifier and an accountType.If a corresponding user already exists with the same account identifier, the user will be updated with the resource. In this case only the displayName field can be changed. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/users/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="body">A valid Androidenterprise v1 body.</param>
        /// <returns>UserResponse</returns>
        public static User Insert(AndroidenterpriseService service, string enterpriseId, User body)
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
                return service.Users.Insert(body, enterpriseId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.Insert failed.", ex);
            }
        }

        /// <summary>
        /// Looks up a user by primary email address. This is only supported for Google-managed users. Lookup of the id is not needed for EMM-managed users because the id is already returned in the result of the Users.insert call. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/users/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="email">The exact primary email address of the user to look up.</param>
        /// <returns>UsersListResponseResponse</returns>
        public static UsersListResponse List(AndroidenterpriseService service, string enterpriseId, string email)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (email == null)
                    throw new ArgumentNullException(email);

                // Make the request.
                return service.Users.List(enterpriseId, email).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates the details of an EMM-managed user.Can be used with EMM-managed users only (not Google managed users). Pass the new details in the Users resource in the request body. Only the displayName field can be changed. Other fields must either be unset or have the currently active value. This method supports patch semantics. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/users/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="body">A valid Androidenterprise v1 body.</param>
        /// <returns>UserResponse</returns>
        public static User Patch(AndroidenterpriseService service, string enterpriseId, string userId, User body)
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
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.Users.Patch(body, enterpriseId, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Revokes a previously generated token (activation code) for the user. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/users/revokeToken
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        public static void RevokeToken(AndroidenterpriseService service, string enterpriseId, string userId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (enterpriseId == null)
                    throw new ArgumentNullException(enterpriseId);
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                 service.Users.RevokeToken(enterpriseId, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.RevokeToken failed.", ex);
            }
        }

        /// <summary>
        /// Modifies the set of products that a user is entitled to access (referred to as whitelisted products). Only products that are approved or products that were previously approved (products with revoked approval) can be whitelisted. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/users/setAvailableProductSet
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="body">A valid Androidenterprise v1 body.</param>
        /// <returns>ProductSetResponse</returns>
        public static ProductSet SetAvailableProductSet(AndroidenterpriseService service, string enterpriseId, string userId, ProductSet body)
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
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.Users.SetAvailableProductSet(body, enterpriseId, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.SetAvailableProductSet failed.", ex);
            }
        }

        /// <summary>
        /// Updates the details of an EMM-managed user.Can be used with EMM-managed users only (not Google managed users). Pass the new details in the Users resource in the request body. Only the displayName field can be changed. Other fields must either be unset or have the currently active value. 
        /// Documentation https://developers.google.com/androidenterprise/v1/reference/users/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidenterprise service.</param>  
        /// <param name="enterpriseId">The ID of the enterprise.</param>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="body">A valid Androidenterprise v1 body.</param>
        /// <returns>UserResponse</returns>
        public static User Update(AndroidenterpriseService service, string enterpriseId, string userId, User body)
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
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.Users.Update(body, enterpriseId, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.Update failed.", ex);
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