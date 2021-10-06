using System;

namespace Day19_REGEX_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********REGULAR EXPRESSION**********\n\n");

            //UC1_FirstName pattern1 = new UC1_FirstName();
            //Console.WriteLine(pattern1.ValidateFirstName("Siba"));
            //Console.WriteLine(pattern1.ValidateFirstName("siba"));




            //UC2_Lastname pattern2 = new UC2_Lastname();
            //Console.WriteLine(pattern2.ValidateLastName("Patro"));




            //#region UC3 and UC9
            //UC3_9_Email pattern3 = new UC3_9_Email();
            //Console.WriteLine(pattern3.ValidateEmail("abc.xyz@bl.co.in"));
            //Console.WriteLine(pattern3.ValidateEmail("abc-100@yahoo.com"));
            //Console.WriteLine(pattern3.ValidateEmail("abc..2002@gmail.com"));
            //Console.WriteLine(pattern3.ValidateEmail("abc()*@gmail.com"));
            //Console.WriteLine(pattern3.ValidateEmail("abc+100@gmail.com"));
            //Console.WriteLine(pattern3.ValidateEmail("abc@1.com"));
            //Console.WriteLine(pattern3.ValidateEmail("abc.100@abc.com.au"));
            //Console.WriteLine(pattern3.ValidateEmail("abc111@abc.com"));
            //Console.WriteLine(pattern3.ValidateEmail("abc-100@abc.net"));
            //Console.WriteLine(pattern3.ValidateEmail("abc@gmail.com.1a"));
            //Console.WriteLine(pattern3.ValidateEmail("abc@%*.com"));
            //Console.WriteLine(pattern3.ValidateEmail("abc@abc@gmail.com"));
            //#endregion




            //UC4_MobileNumber pattern4 = new UC4_MobileNumber();
            //Console.WriteLine(pattern4.ValidatePhoneNumber("91 7504832115"));
            //Console.WriteLine(pattern4.ValidatePhoneNumber("1441 7504832115")); //Bermuda
            //Console.WriteLine(pattern4.ValidatePhoneNumber("91 750483211511"));




            #region UC5 , UC6 , UC7 , UC8
            UC5_6_7_8_Password pattern5 = new UC5_6_7_8_Password();
            Console.WriteLine(pattern5.ValidatePassword("T0&Uskwib7"));
            #endregion
        }
    }
}
