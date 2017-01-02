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
//     Template File Name:  APIKey.tt
//     Build date: 01/02/2017 22:33:32
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the YouTube Reporting v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Schedules reporting jobs containing your YouTube Analytics data and downloads the resulting bulk data reports in the form of CSV files.
// API Documentation Link https://developers.google.com/youtube/reporting/v1/reports/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/YouTube Reporting/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.YouTube Reporting.v1/ 
// Install Command: PM>  Install-Package Google.Apis.YouTube Reporting.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.YouTube Reporting.v1;
using Google.Apis.Services;
using System;

namespace GoogleSamplecSharpSample.YouTube Reportingv1.Auth
{
    public static class ApiKeyExample
    {
        public static YouTube ReportingService GetService(string apiKey)
        {
            try
            {
                if (string.IsNullOrEmpty(apiKey))
                    throw new ArgumentNullException("api Key");

                return new YouTube ReportingService(new BaseClientService.Initializer()
                {
                    ApiKey = apiKey,
                    ApplicationName = "YouTube Reporting API key example",
                });
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create new YouTube Reporting Service", ex);
            }
        }
    }
}