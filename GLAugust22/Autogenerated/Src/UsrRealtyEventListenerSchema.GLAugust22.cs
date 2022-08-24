namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventListenerSchema

	/// <exclude/>
	public class UsrRealtyEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventListenerSchema(UsrRealtyEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a539f6cf-03fb-4a66-a7dd-1840ae5169ae");
			Name = "UsrRealtyEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("42e6ec1c-340a-4acf-9836-601427a4f146");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,193,142,211,48,16,61,147,175,24,69,28,18,169,178,118,175,20,86,162,165,139,42,173,0,209,150,11,226,48,117,166,169,145,99,71,30,167,165,160,254,59,227,100,203,182,221,61,48,39,107,252,252,230,189,231,113,216,16,183,168,9,150,20,2,178,223,68,53,245,110,99,234,46,96,52,222,101,127,50,144,234,216,184,26,22,7,142,212,140,207,58,231,175,2,169,153,139,38,26,226,255,128,168,217,142,92,124,68,126,239,187,135,190,245,96,100,136,163,80,44,244,150,26,252,36,10,225,29,228,43,14,95,9,109,60,228,229,143,254,77,219,173,173,209,160,45,50,195,112,245,2,11,188,129,9,50,189,112,211,147,12,238,206,232,252,78,228,154,138,96,231,77,5,159,221,220,49,133,40,62,10,191,254,73,58,2,147,171,40,140,96,96,156,208,70,76,245,188,239,67,205,64,229,63,194,39,234,84,107,17,161,206,233,78,60,84,142,47,128,3,47,132,222,144,24,47,134,70,57,224,47,177,21,105,211,160,133,54,24,157,66,26,30,169,143,20,151,135,150,170,169,183,93,227,190,161,237,232,237,35,244,174,72,65,126,73,248,213,226,67,126,53,219,108,160,24,184,238,224,246,230,84,229,149,149,84,164,230,60,69,167,201,82,37,131,99,232,104,156,189,58,213,14,3,200,94,49,214,180,164,166,181,24,69,221,233,122,37,9,200,138,57,9,83,246,43,137,125,240,26,173,249,141,107,75,139,24,82,56,79,191,125,241,101,249,8,242,222,206,156,151,222,79,76,157,12,60,27,41,122,184,167,81,247,62,52,24,139,43,41,35,144,63,107,58,139,67,62,172,238,77,224,88,148,42,173,154,16,62,51,27,183,193,239,193,209,30,102,191,52,181,73,118,145,247,25,50,172,77,93,203,150,197,45,58,184,85,55,147,215,128,129,192,249,8,104,173,223,83,165,174,67,62,102,151,167,99,118,252,11,128,41,149,55,134,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a50ae304-3f8d-dd8c-31ea-d0a6c1f8c912"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("42e6ec1c-340a-4acf-9836-601427a4f146"),
				CreatedInSchemaUId = new Guid("a539f6cf-03fb-4a66-a7dd-1840ae5169ae"),
				ModifiedInSchemaUId = new Guid("a539f6cf-03fb-4a66-a7dd-1840ae5169ae")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a539f6cf-03fb-4a66-a7dd-1840ae5169ae"));
		}

		#endregion

	}

	#endregion

}

