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

	#region Class: UsrCreateYachtRentalRecordsMethodsWrapper

	/// <exclude/>
	public class UsrCreateYachtRentalRecordsMethodsWrapper : ProcessModel
	{

		public UsrCreateYachtRentalRecordsMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			var endDate = Get<DateTime>("EndDate");
			
			Set<DateTime>("StartDate", endDate.AddDays(1));
			Set<DateTime>("EndDate", endDate.AddDays(7));
			
			var n = Get<int>("n");
			Set<int>("n", n - 1);
			
			return true;
		}

		#endregion

	}

	#endregion

}

