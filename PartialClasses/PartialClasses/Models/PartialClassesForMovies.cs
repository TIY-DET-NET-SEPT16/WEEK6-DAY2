using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartialClasses
{
    [MetadataType(typeof(CustomerMetaData))]
    public partial class Customer
    {
    }

    public class CustomerMetaData
    {
        [DisplayName("Customer")]
        public int CustomerID { get; set; }

        [DisplayName("Customer")]
        public string CustomerName { get; set; }

        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(DataFormatString = "{0:###-###-####}", ApplyFormatInEditMode = true)]
        public string CustomerPhoneNum { get; set; }

        public virtual ICollection<RentalRecord> RentalRecords { get; set; }
    }
    [MetadataType(typeof(MovyMetaData))]
    public partial class Movy
    {

    }

    public class MovyMetaData
    {
        [DisplayName("Movie")]
        public int MovieID { get; set; }

        [DisplayName("Movie Name")]
        [Required(ErrorMessage = "You must enter a movie name")]
        [MaxLength(50, ErrorMessage = "Movie name must be 50 character or less")]
        public string MovieName { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "The description is required")]
        public string MovieDescription { get; set; }

        [DisplayName("Genre")]
        public Nullable<int> MovieGenre { get; set; }
    }

    [MetadataType(typeof(GenreMetaData))]
    public partial class Genre
    {

    }

    public class GenreMetaData
    {
        [DisplayName("Genre")]
        public string GenreName { get; set; }
    }

    [MetadataType(typeof(RentalRecordMetaData))]
    public partial class RentalRecord
    {

    }

    public class RentalRecordMetaData
    {
        [DisplayName("Movie Name")]
        public int MovieID { get; set; }

        [DisplayName("Customer")]
        public int CustomerID { get; set; }

        [DisplayName("Date Rented")]
        //[PlaceHolder("01/01/2016")]
        [Required(ErrorMessage = "You must enter a rental date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public System.DateTime RentalDate { get; set; }

        [DisplayName("Date Due")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public System.DateTime DueDate { get; set; }

        [DisplayName("Date Returned")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public Nullable<System.DateTime> ReturnDate { get; set; }
    }

    //public class PlaceHolderAttribute : Attribute, IMetadataAware
    //{
    //    private readonly string _placeholder;
    //    public PlaceHolderAttribute(string placeholder)
    //    {
    //        _placeholder = placeholder;
    //    }

    //    public void OnMetadataCreated(ModelMetadata metadata)
    //    {
    //        metadata.AdditionalValues["placeholder"] = _placeholder;
    //    }
    //}
}