using System;

namespace UmbracoUpgradeHealthchecks.ObsoleteDataTypes
{
	public class MultiNodeTreePickerObsoleteDataType : IObsoleteDataType
	{
		public string Alias => "Umbraco.MultiNodeTreePicker";

		public bool CanConvert => false;

		public void Convert(string name)
		{
			throw new NotImplementedException();
		}
	}
}