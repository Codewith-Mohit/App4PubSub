using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPS
{
    public  class ExpatUser
    {
        //public string UserFName { get; set; }
        //public string UserLName { get; set; }
        //public string UserEmail { get; set; }

        //public string UserPhone { get; set; }
        //public string UserAddress { get; set; }
        //public string UserCity { get; set; }
        //public string UserState { get; set; }
        //public string UserZip { get; set; }
        //public string UserCountry { get; set; }
        //public string UserPassportNumber { get; set; }
        //public string UserVisaType { get; set; }

        //public string UserVisaNumber { get; set; }
        //public DateTime UserVisaExpiryDate { get; set; }
        //public string UserOccupation { get; set; }
        //public string UserEmployer { get; set; }
        //public string UserEmployerAddress { get; set; }
        //public string UserEmployerCity { get; set; }
        //public string UserEmployerState { get; set; }
        //public string UserEmployerZip { get; set; }
        //public string UserEmployerCountry { get; set; }
        //public string UserEmergencyContactName { get; set; }
        //public string UserEmergencyContactPhone { get; set; }
        //public string UserEmergencyContactEmail { get; set; }
        //public string UserEmergencyContactRelationship { get; set; }
        //public string UserHealthInsuranceProvider { get; set; }
        //public string UserHealthInsurancePolicyNumber { get; set; }
        //public DateTime UserHealthInsuranceExpiryDate { get; set; }
        //public string UserBankName { get; set; }
        //public string UserBankAccountNumber { get; set; }
        //public string UserBankRoutingNumber { get; set; }   
        //public string UserBankSwiftCode { get; set; }
        //public string UserBankAddress { get; set; }
        //public string UserBankCity { get; set; }
        //public string UserBankState { get; set; }
        //public string UserBankZip { get; set; }
        //public string UserBankCountry { get; set; }
        //public string UserTaxIdentificationNumber { get; set; }
        //public string UserSocialSecurityNumber { get; set; }
        //public string UserDrivingLicenseNumber { get; set; }
        //public DateTime UserDrivingLicenseExpiryDate { get; set; }
        //public string UserVehicleMake { get; set; }
        //public string UserVehicleModel { get; set; }
        //public string UserVehicleYear { get; set; }
        //public string UserVehicleVIN { get; set; }
        //public string UserVehicleLicensePlate { get; set; }
        //public string UserVehicleInsuranceProvider { get; set; }
        //public string UserVehicleInsurancePolicyNumber { get; set; }
        //public DateTime UserVehicleInsuranceExpiryDate { get; set; }
        //public string UserLanguageSpoken { get; set; }
        //public string UserPreferredLanguage { get; set; }
        //public string UserReligion { get; set; }
        //public string UserPoliticalAffiliation { get; set; }
        //public string UserHobbies { get; set; }
        //public string UserInterests { get; set; }
        //public string UserSkills { get; set; }
        //public string UserEducationLevel { get; set; }
        //public string UserDegree { get; set; }
        //public string UserUniversity { get; set; }
        //public string UserGraduationYear { get; set; }
        //public string UserProfessionalCertifications { get; set; }
        //public string UserMemberships { get; set; }
        //public string UserVolunteerExperience { get; set; }
        //public string UserPersonalWebsite { get; set; }
        //public string UserLinkedInProfile { get; set; }
        //public string UserGitHubProfile { get; set; }
        //public string UserTwitterHandle { get; set; }
        //public string UserFacebookProfile { get; set; }
        //public string UserInstagramProfile { get; set; }
        //public string UserYouTubeChannel { get; set; }
        //public string UserTikTokProfile { get; set; }
        //public string UserSnapchatProfile { get; set; }
        //public string UserPinterestProfile { get; set; }
        //public string UserRedditProfile { get; set; }
        //public string UserWhatsAppNumber { get; set; }
        //public string UserTelegramHandle { get; set; }
        //public string UserSignalHandle { get; set; }
        //public string UserWeChatID { get; set; }
        //public string UserLineID { get; set; }
        //public string UserViberNumber { get; set; }
        //public string UserSkypeID { get; set; }
        //public string UserZoomID { get; set; }
        //public string UserDiscordID { get; set; }
        //public string UserSlackID { get; set; }
        //public string UserGitLabProfile { get; set; }
        //public string UserBitbucketProfile { get; set; }
        //public string UserPersonalBlog { get; set; }
        //public string UserFavoriteBooks { get; set; }
        //public string UserFavoriteMovies { get; set; }
        //public string UserFavoriteTVShows { get; set; }
        //public string UserFavoriteMusic { get; set; }
            
        //public string UserFavoriteSports { get; set; }

        public event Action UserCreatedEvent;

        public void UserCreatedMethod()
        {
            Console.WriteLine("User Created Successfully!");
            UserCreatedEvent?.Invoke();          
        }

    }
}
