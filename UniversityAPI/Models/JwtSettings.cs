namespace UniversityAPI.Models
{
    public class JwtSettings
    {
        public bool ValidateIsUserSigning { get;set; }
        public string IsUserSigningKey { get;set; } = string.Empty;
        public bool ValidateIsUser { get; set; } = true;
        public string? ValidIsUser { get; set; }
        public bool ValidateAudience { get; set; } = true;
        public string? ValidAudience { get; set; }
        public bool RequiredExperitationTime { get; set; } 
        public bool ValidateLifetime { get; set; } = true;


    }
}
