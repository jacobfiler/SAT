using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAT.DATA//Metadata
{
    #region Courses
    [MetadataType(typeof(CoursMetadata))]
    public partial class Cours { }

    public class CoursMetadata
    {
        //public int CourseID { get; set; }
        [Required(ErrorMessage ="* Course Name is Required *")]
        [StringLength(20, ErrorMessage ="* Maximum 20 Characters")]
        [Display(Name ="Course")]
        public string CourseName { get; set; }

        [StringLength(100, ErrorMessage ="* Maximum 100 Characters")]
        [Display(Name ="Course Description")]
        public string CourseDescription { get; set; }

        [Required(ErrorMessage ="* Credit Hours is Required *")]
        [Range(0, 4, ErrorMessage ="* Must be between 0 and 4")]
        [Display(Name ="Credit Hours")]
        public int CreditHours { get; set; }

        [StringLength(100, ErrorMessage ="* Maximum 100 Characters")]
        public string Notes { get; set; }

        [Display(Name ="Active")]
        public bool IsActive { get; set; }

    }
    #endregion

    #region Enrollment
    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment { }

    public class EnrollmentMetadata
    {
        //public int EnrollmentID { get; set; }
        [Required(ErrorMessage ="* Student ID is Required *")]
        [Range(0, double.MaxValue, ErrorMessage ="* Must be greater than zero")]
        public int StudentID { get; set; }

        [Required(ErrorMessage ="* Scheduled class ID is Required *")]
        [Range(0, double.MaxValue, ErrorMessage ="* Must be greater than zero")]
        [Display(Name ="Scheduled Class ID")]
        public int ScheduledClassID { get; set; }

        [Required(ErrorMessage ="* Enrollment Date is Required *")]
        [Display(Name ="Enrollment Date")]
        public System.DateTime EnrollmentDate { get; set; }
    }

    #endregion

    #region ScheduledClasses
    [MetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass { }

    public class ScheduledClassMetadata
    {
        //public int ScheduledClassID { get; set; }

        [Required(ErrorMessage = "* Course ID is Required *")]
        [Range(0, double.MaxValue, ErrorMessage = "* Must be Greater Than 0")]
        public int CourseID { get; set; }

        [Required(ErrorMessage = "* Start Date is Required *")]
        [Display(Name = "Start Date")]
        public System.DateTime StartDate { get; set; }

        [Required(ErrorMessage = "* End Date is Required *")]
        [Display(Name = "End Date")]
        public System.DateTime EndDate { get; set; }

        [Required(ErrorMessage = "* Instructor Name is Required *")]
        [StringLength(30, ErrorMessage = "* Maximum 30 Characters")]
        [Display(Name = "Instructor Name")]
        public string InstructorName { get; set; }

        [Required(ErrorMessage = "* Location is Required *")]
        [StringLength(40, ErrorMessage = "* Maximum 40 Characters")]
        public string Location { get; set; }

        [Required(ErrorMessage ="* SCID is Required *")]
        [Range(0, double.MaxValue, ErrorMessage ="* Must be Greater Than 0")]
        public int SCID { get; set; }
    }
    #endregion

    #region ScheduledClassStats
    [MetadataType(typeof(ScheduledClassStatuMetadata))]
    public partial class ScheduledClassStatu { }

    public class ScheduledClassStatuMetadata
    {
        //public int SCID { get; set; }

        [Required(ErrorMessage ="* Scheduled Class Name is Required *")]
        [StringLength(30, ErrorMessage ="* Maximum 30 Characters")]
        [Display(Name ="Scheduled Class name")]
        public string SCName { get; set; }

        [Required(ErrorMessage ="* Scheduled Class Description is Required *")]
        [StringLength(40, ErrorMessage ="* Maximum 40 Characters")]
        [Display(Name ="Scheduled Class Description")]
        public string SCDescription { get; set; }
    }
    #endregion

    #region Students
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student { }

    public class StudentMetadata
    {
        //public int StudentID { get; set; }

        [Required(ErrorMessage ="* First Name is Required *")]
        [StringLength(15, ErrorMessage ="* Maximum 15 Characters")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="* Last Name is Required *")]
        [StringLength(15, ErrorMessage = "* Maximum 15 Characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="* Date of Birth is Required *")]
        public System.DateTime DOB { get; set; }

        [Range(0, 4, ErrorMessage ="* Must be Between 0 and 4")]
        public Nullable<double> GPA { get; set; }

        [Required(ErrorMessage ="* Address is Required *")]
        [StringLength(50, ErrorMessage ="* Maximum 50 Characters")]
        public string Address { get; set; }

        [Required(ErrorMessage ="* City is Required *")]
        [StringLength(25, ErrorMessage ="* Maximum 25 Characters")]
        public string City { get; set; }

        [Required(ErrorMessage ="* State is Required *")]
        [StringLength(2, ErrorMessage ="Maximum 2 Characters")]
        public string State { get; set; }

        [Required(ErrorMessage ="* Zip is Required *")]
        [Range(10000, 99999, ErrorMessage ="* Must be Between 10000 and 99999")]
        public int Zip { get; set; }

        [EmailAddress(ErrorMessage ="* Not a Valid Email Address")]
        public string Email { get; set; }

        [StringLength(12, ErrorMessage ="* Maximum 12 Characters")]
        public string Phone { get; set; }

        public Nullable<System.DateTime> StartDate { get; set; }

        [StringLength(50, ErrorMessage ="* Maximum 50 Characters")]
        public string PhotoURL { get; set; }

        [StringLength(25, ErrorMessage ="* Maximum 25 Characters")]
        public string Major { get; set; }

        [Required(ErrorMessage ="* SSID is Required *")]
        public int SSID { get; set; }
    }
    #endregion

    #region StudentStatus
    [MetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }

    public class StudentStatusMetadata
    {
        //public int SSID { get; set; }

        [Required(ErrorMessage ="* SSName is Required *")]
        [StringLength(30, ErrorMessage ="* Maximum 30 Characters")]
        public string SSName { get; set; }

        [Required(ErrorMessage ="* SSDescription is Required *")]
        [StringLength(50, ErrorMessage ="* Maximum 50 Chacracters")]
        public string SSDescription { get; set; }
    }
    #endregion
}
