using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace CISample
{
    public class CISampleInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "CISample";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("488eb0b8-6671-44fd-a0c9-db45ec3f1b3b");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
