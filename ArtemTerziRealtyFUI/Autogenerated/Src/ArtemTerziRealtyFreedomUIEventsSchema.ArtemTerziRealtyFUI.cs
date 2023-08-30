namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ArtemTerziRealtyFreedomUIEventsSchema

	/// <exclude/>
	public class ArtemTerziRealtyFreedomUIEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ArtemTerziRealtyFreedomUIEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ArtemTerziRealtyFreedomUIEventsSchema(ArtemTerziRealtyFreedomUIEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cd7220e7-432d-417a-b3e1-e75db92ed2cd");
			Name = "ArtemTerziRealtyFreedomUIEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("727d454f-74e4-43bc-be3e-c57e5e690632");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,110,219,48,16,188,235,43,22,66,15,18,96,16,201,53,110,3,196,174,19,8,8,218,34,150,115,9,122,160,169,181,194,130,15,129,164,156,58,133,255,189,43,209,78,37,59,69,187,39,106,57,59,156,25,45,24,174,209,55,92,32,148,232,28,247,118,19,216,220,154,141,172,91,199,131,180,38,249,149,0,85,235,165,169,97,185,243,1,245,116,208,25,78,105,109,205,223,238,28,178,133,9,50,72,244,255,1,97,139,45,154,112,64,62,245,221,93,223,186,151,36,192,160,203,150,226,25,53,255,66,234,225,19,164,55,142,100,17,215,171,124,64,174,194,238,118,85,164,249,247,126,186,105,215,74,10,16,138,123,15,241,246,29,62,184,130,25,247,248,206,77,79,18,51,24,208,217,45,9,151,21,194,214,202,10,190,154,194,120,116,129,28,101,118,253,3,69,0,143,166,66,55,129,200,56,195,13,217,235,121,111,92,237,1,243,55,194,63,212,93,173,73,4,27,210,29,121,48,159,142,128,145,23,92,111,136,34,200,98,35,143,248,49,182,66,33,53,87,208,56,41,186,184,226,16,187,195,80,238,26,172,230,86,181,218,60,114,213,226,199,3,244,58,27,68,250,173,27,91,45,63,167,39,18,228,6,178,72,121,13,151,23,199,202,71,152,177,187,174,144,21,126,206,141,64,133,21,105,9,174,197,105,114,134,242,193,117,235,65,187,233,121,141,37,234,70,241,208,105,55,248,2,247,86,112,37,95,249,90,225,178,199,101,7,71,43,74,141,150,215,208,15,160,205,101,15,232,109,235,4,129,172,35,150,9,156,61,211,213,249,242,56,196,202,234,85,17,151,48,157,64,122,246,162,103,125,94,133,47,173,157,201,58,126,165,57,43,237,65,81,254,79,83,100,38,54,216,173,117,154,135,236,196,44,61,123,201,46,102,31,78,99,239,42,60,59,251,210,103,177,248,41,176,233,220,30,199,79,208,251,100,124,218,39,251,223,116,127,220,20,244,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("39eafa1b-abfd-ad1d-72e0-a48ec3fe3533"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("727d454f-74e4-43bc-be3e-c57e5e690632"),
				CreatedInSchemaUId = new Guid("cd7220e7-432d-417a-b3e1-e75db92ed2cd"),
				ModifiedInSchemaUId = new Guid("cd7220e7-432d-417a-b3e1-e75db92ed2cd")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd7220e7-432d-417a-b3e1-e75db92ed2cd"));
		}

		#endregion

	}

	#endregion

}

