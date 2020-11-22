using System;

namespace UmbracoUpgradeHealthchecks.ObsoleteDataTypes
{
	public class RelatedLinksObsoleteDataType : IObsoleteDataType
	{
		public string Alias => "Umbraco.RelatedLinks";

		public bool CanConvert => false;

		public void Convert(string name)
		{
			throw new NotImplementedException();
		}
	}
}
