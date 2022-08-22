namespace Terrasoft.Core.Process
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UsrMyUpdateRealtyTypeMethodsWrapper

	/// <exclude/>
	public class UsrMyUpdateRealtyTypeMethodsWrapper : ProcessModel
	{

		public UsrMyUpdateRealtyTypeMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			string Ids = Get<string>("RealtyCommaSeparatedIdsParameter");
			// todo get selected type id
			Guid selectedTypeId = Get<Guid>("SelectedTypeIdParameter");
			var IdsArray = Ids.Split(',');
			foreach (string realtyId in IdsArray) {
				var update = new Update(UserConnection, "UsrRealty")
					.Set("UsrTypeId", Column.Parameter(selectedTypeId))
					.Where("Id")
					.IsEqual(Column.Parameter(realtyId));
				update.Execute();
			}
			
			
			return true;
		}

		#endregion

	}

	#endregion

}

