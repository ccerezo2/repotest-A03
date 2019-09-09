using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSReview
{
    //by default all classes are private
    //for this class to be used by an outside user(anything but this class)
    //you must alter the permission for this class 
    //you must use public class
    public class FencePanel
    {
        //properties
        //A propert is associated with a signle piece of data
        //a property has 2 subcomponents
        //get: returns a value to the calling client ( usually from another class )
        //set: receives a value from the calling client 
        //     A keyword "Value" is used to hold the incoming data to the property
        //     the property has a return data type(rdt) which specifies 
        //     the type of data allowed
        //The proper syntax does NOT allow for a parameter.

        //Auto implemented property: 
        //This style doesn't need a private data member.
        //the system will create an internal data member of the
        //  rdt specified in the property definition 
        //-------------------------------------------------------
        //----------------Auto Implemented Property--------------
        //-------------------------------------------------------
        //public double Height { get; set; } Doesn't cover negative numbers
        //Assuming you wish to validate data You should be 
        //using a fully implemented property.
        //ex; Height must have a positive non-0 value R    T    C    O
        //    Height must not be greater than 8 feet.   E    R    T    N 
        //                                                S    I    I    .
        private double _Height;

        public double Height
        {
            get
            {
                return _Height;
            }
            set
            {
                //Validation of data
                //Throw exception is invalid
                if( value > 0.0 && value <=8.0)
                {
                    _Height = value;
                }
                else
                {
                    throw new Exception("Invalid Height :( must be greater than 0 with a maximum of 8 feet");
                }
            }
        }
        public double Width { get; set; }

        //Fully Implemented property:
        //This style NEEDS a private data member 
        // the private data member will store the incoming data value
        //usually, this form of property is used when
        //         additional coding is required for the incoming data
        //          Such as validation of data

        //Example: the string data can't be an empty string
        private string _Style;
        public string Style
        {
            // the keyword value holds the incoming data to 
            // the property
            get
            {
                //returns the stored data value
                return _Style;
            }
            set
            {
                //stores the incoming value in "value" to the
                // private data member for storage.
                if(string.IsNullOrEmpty(value))
                {
                    _Style = null;
                }
                else
                {
                    _Style = value;
                }
            }
        }
        //nullable numeric property for a double.
        //there are ONLY two possibilities 
        //  a) Data is missin:Null
        //  b) Data is present and is of the right datatype
        public double? Price { get; set; }
    }
}
