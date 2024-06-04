namespace LoginCRUD.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class user
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name Is Required")]
        public string firstname { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name Is Required")]

        public string lastname { get; set; }

        [DisplayName("Gender")]
        [Required(ErrorMessage = "Gender Is Required")]

        public string gender { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email Is Required")]


        public string email { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = "Username Is Required")]


        public string username { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password Is Required")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Confirm Password Is Required")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Password and Confirm Password is not same")]
        public string confirm_password { get; set; }


    }
}