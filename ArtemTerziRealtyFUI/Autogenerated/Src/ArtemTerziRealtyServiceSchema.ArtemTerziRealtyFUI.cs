namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ArtemTerziRealtyServiceSchema

	/// <exclude/>
	public class ArtemTerziRealtyServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ArtemTerziRealtyServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ArtemTerziRealtyServiceSchema(ArtemTerziRealtyServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b07aaace-8929-456e-a878-d4fd7ec8d12f");
			Name = "ArtemTerziRealtyService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("727d454f-74e4-43bc-be3e-c57e5e690632");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,208,215,87,240,72,45,74,85,200,84,40,207,204,201,81,40,47,202,44,73,85,200,173,84,112,86,86,72,206,79,73,5,0,252,219,133,51,32,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b07aaace-8929-456e-a878-d4fd7ec8d12f"));
		}

		#endregion

	}

	#endregion

}

