using System;

namespace UmbracoUpgradeHealthchecks.ObsoleteDataTypes
{
	public class MemberPickerObsoleteDataType : IObsoleteDataType
	{
		public string Alias => "Umbraco.MemberPicker";

		public bool CanConvert => false;

		public void Convert(string name)
		{
			throw new NotImplementedException();
		}
	}
}