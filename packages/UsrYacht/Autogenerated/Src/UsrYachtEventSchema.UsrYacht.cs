namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventSchema

	/// <exclude/>
	public class UsrYachtEventSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventSchema(UsrYachtEventSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3215ee34-a26e-4529-8929-17467f41722c");
			Name = "UsrYachtEvent";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("25fb0067-571d-4c32-b6d6-11b55c074490");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,77,111,19,49,16,134,239,149,250,31,70,123,218,149,170,45,92,9,84,162,85,64,149,42,64,77,130,132,16,7,199,158,236,26,188,158,149,237,77,8,168,255,157,177,189,105,243,81,4,190,100,109,79,158,121,231,29,143,21,29,250,94,72,132,57,58,39,60,173,66,125,67,118,165,155,193,137,160,201,158,159,253,62,63,3,94,131,215,182,129,217,214,7,236,38,251,71,251,127,236,58,178,127,189,116,88,79,109,208,65,163,255,159,152,122,186,70,27,118,161,95,211,241,54,157,221,105,22,97,209,149,51,217,98,39,62,112,13,240,6,138,133,119,95,132,108,67,81,125,131,203,75,80,40,137,107,32,7,1,141,1,29,60,8,11,24,1,102,4,64,43,214,81,129,79,28,176,17,180,112,62,81,114,218,126,88,26,45,65,26,225,61,164,243,103,116,192,43,184,22,30,159,185,201,144,209,193,61,30,173,185,102,173,16,214,164,21,124,180,179,164,163,164,229,119,148,1,60,90,133,238,2,50,240,26,87,108,75,194,190,117,141,7,172,158,112,123,228,184,150,172,162,126,164,237,48,88,77,162,31,186,235,13,118,76,73,97,236,133,130,208,162,5,55,88,32,254,114,96,180,69,127,72,204,18,96,27,43,103,143,203,188,175,50,58,97,21,109,44,72,225,3,140,234,3,1,166,168,67,18,183,67,119,194,64,239,180,140,237,74,200,250,61,134,249,182,71,117,67,102,232,236,103,97,6,124,61,70,94,149,177,163,159,98,120,145,42,104,48,140,66,184,71,233,252,48,131,94,65,153,233,87,240,242,69,92,213,97,192,145,91,113,97,125,235,111,132,149,104,80,177,168,224,6,140,169,188,54,209,40,153,110,210,28,0,173,128,122,204,67,1,150,2,168,37,24,126,77,230,252,236,20,235,131,139,239,138,103,203,139,6,231,200,214,139,16,171,182,184,129,59,146,194,232,95,98,105,112,150,226,202,236,197,194,163,227,217,179,108,34,231,168,239,209,211,224,36,199,240,51,110,240,130,101,73,26,47,163,154,14,131,80,34,136,212,73,233,91,225,122,144,164,56,208,228,4,92,209,40,128,59,251,3,97,131,160,248,181,105,11,107,190,86,227,120,31,75,143,235,113,148,242,8,22,23,80,156,136,246,117,234,214,173,159,19,93,235,38,239,138,170,158,211,88,84,53,249,183,51,236,72,62,168,223,145,235,68,40,143,28,227,196,220,73,224,86,194,116,113,95,84,147,83,96,104,29,109,146,175,211,159,18,251,88,212,142,114,28,254,240,180,29,63,249,231,225,15,103,110,95,118,3,5,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2695eba1-b0a8-2bdb-9bd8-d24e93d2bfa3"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("25fb0067-571d-4c32-b6d6-11b55c074490"),
				CreatedInSchemaUId = new Guid("3215ee34-a26e-4529-8929-17467f41722c"),
				ModifiedInSchemaUId = new Guid("3215ee34-a26e-4529-8929-17467f41722c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3215ee34-a26e-4529-8929-17467f41722c"));
		}

		#endregion

	}

	#endregion

}

