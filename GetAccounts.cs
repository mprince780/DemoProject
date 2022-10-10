using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace DemoProject
{
    public class GetAccounts : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the MyComponent1 class.
        /// </summary>
        public GetAccounts()
          : base("GetAccounts", " GetAccountDetails",
              "Enter User Id and Password",
              "DataExchange", "DataManagemnet")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddBoxParameter("ID", "Email-Id", "Enter Email Id", GH_ParamAccess.item);
            pManager.AddBoxParameter("Password", "Password", "Enter Password", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddBoxParameter("Login", "Children's Hospital", "Details", GH_ParamAccess.item);
            pManager.AddBoxParameter("Login", "Architectual Design\\Bld-12", "Details", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon => Properties.Resources.GetAccounts;
         

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("F5F2A714-205E-4C28-ACF4-1AEB9E96D972"); }
        }
    }
}