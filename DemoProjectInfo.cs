using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DemoProject
{
    public class DemoProjectInfo : GH_AssemblyInfo
    {
        public override string Name => "DemoProject";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("337D1D46-0F29-45A4-A890-33BBEC24DF2B");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}