namespace UmbracoUpgradeHealthchecks.ObsoleteDataTypes
{
	public interface IObsoleteDataType
	{
		string Alias {get;}

		bool CanConvert {get;}
		void Convert(string name);
	}
}
