using Umbraco.Core;

namespace UmbracoUpgradeHealthchecks.ObsoleteDataTypes
{
	public class ArchetypeObsoleteDataType : IObsoleteDataType
	{
		public string Alias => "Imulus.Archetype";

		public bool CanConvert => true;

		public void Convert(string name)
		{
			new ConvertArchetypeToNestedContent(ApplicationContext.Current.Services).Convert(name);
		}
	}
}