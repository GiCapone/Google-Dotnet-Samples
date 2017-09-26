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
// Unoffical sample for the Prediction v1.4 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Lets you access a cloud hosted machine learning service that makes it easy to build smart apps
// API Documentation Link https://developers.google.com/prediction/docs/developer-guide
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Prediction/v1_4/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Prediction.v1_4/ 
// Install Command: PM>  Install-Package Google.Apis.Prediction.v1_4
//
//------------------------------------------------------------------------------  
using Google.Apis.Prediction.v1_4;
using Google.Apis.Prediction.v1_4.Data;
using System;

namespace GoogleSamplecSharpSample.Predictionv1_4.Methods
{
  
    public static class TrainedmodelsSample
    {


        /// <summary>
        /// Delete a trained model. 
        /// Documentation https://developers.google.com/prediction/v1.4/reference/trainedmodels/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Prediction service.</param>  
        /// <param name="id">The unique name for the predictive model.</param>
        public static void Delete(PredictionService service, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                 service.Trainedmodels.Delete(id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Trainedmodels.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Check training status of your model. 
        /// Documentation https://developers.google.com/prediction/v1.4/reference/trainedmodels/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Prediction service.</param>  
        /// <param name="id">The unique name for the predictive model.</param>
        /// <returns>TrainingResponse</returns>
        public static Training Get(PredictionService service, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.Trainedmodels.Get(id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Trainedmodels.Get failed.", ex);
            }
        }

        /// <summary>
        /// Begin training your model. 
        /// Documentation https://developers.google.com/prediction/v1.4/reference/trainedmodels/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Prediction service.</param>  
        /// <param name="body">A valid Prediction v1.4 body.</param>
        /// <returns>TrainingResponse</returns>
        public static Training Insert(PredictionService service, Training body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Trainedmodels.Insert(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Trainedmodels.Insert failed.", ex);
            }
        }

        /// <summary>
        /// Submit model id and request a prediction 
        /// Documentation https://developers.google.com/prediction/v1.4/reference/trainedmodels/predict
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Prediction service.</param>  
        /// <param name="id">The unique name for the predictive model.</param>
        /// <param name="body">A valid Prediction v1.4 body.</param>
        /// <returns>OutputResponse</returns>
        public static Output Predict(PredictionService service, string id, Input body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.Trainedmodels.Predict(body, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Trainedmodels.Predict failed.", ex);
            }
        }

        /// <summary>
        /// Add new data to a trained model. 
        /// Documentation https://developers.google.com/prediction/v1.4/reference/trainedmodels/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Prediction service.</param>  
        /// <param name="id">The unique name for the predictive model.</param>
        /// <param name="body">A valid Prediction v1.4 body.</param>
        /// <returns>TrainingResponse</returns>
        public static Training Update(PredictionService service, string id, Update body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.Trainedmodels.Update(body, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Trainedmodels.Update failed.", ex);
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