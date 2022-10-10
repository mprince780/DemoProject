using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace DemoProject
{
    public class FilterExchanges : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the FilterExchanges class.
        /// </summary>
        public FilterExchanges()
          : base("FilterExchanges", "FilterExchange",
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
        protected override System.Drawing.Bitmap Icon => Properties.Resources.FilterExchanges;
        
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("F84CF780-8345-4F71-A66E-2C6F60630092"); }
        }
    }
}