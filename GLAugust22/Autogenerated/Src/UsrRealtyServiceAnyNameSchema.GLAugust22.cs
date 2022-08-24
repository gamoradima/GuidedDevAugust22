namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyServiceAnyNameSchema

	/// <exclude/>
	public class UsrRealtyServiceAnyNameSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyServiceAnyNameSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyServiceAnyNameSchema(UsrRealtyServiceAnyNameSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("962f00b5-06a8-43ca-9741-188cb5b61098");
			Name = "UsrRealtyServiceAnyName";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("42e6ec1c-340a-4acf-9836-601427a4f146");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,83,208,211,227,4,0,64,170,126,193,4,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("962f00b5-06a8-43ca-9741-188cb5b61098"));
		}

		#endregion

	}

	#endregion

}

