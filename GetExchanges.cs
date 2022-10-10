using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace DemoProject
{
    public class GetExchanges : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the GetExchanges class.
        /// </summary>
        public GetExchanges()
          : base("GetExchanges", "GetExchange",
              "Description",
              "DataExchange", "DataManagemnet")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddBoxParameter("Account", "Accountdetails", "Enter Account Details", GH_ParamAccess.item);
            pManager.AddBoxParameter("Excahnge", "Exchange Details", "Provide Exchange Data", GH_ParamAccess.item);
            
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddBoxParameter("Result", "View Excahnge Data", "Exchange Data Details", GH_ParamAccess.item);
            
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
        protected override System.Drawing.Bitmap Icon => Properties.Resources.GetExchanges;
       

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("0762A8BF-737B-492A-8541-E63EFD45047F"); }
        }
    }
}