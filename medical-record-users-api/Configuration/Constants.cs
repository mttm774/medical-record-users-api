using System;

namespace medical_record_users_api.Configuration
{
      public static class Constants
    {
        public static string ENVIRONMENT = String.IsNullOrEmpty(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")) ? "Development" : Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
    }
}