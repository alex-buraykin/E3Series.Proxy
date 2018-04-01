namespace E3Series.Proxy.Interfaces
{
    public interface IAttributed
    {
        int AddAttributeValue(string name, string value);
        int DeleteAttribute(string name);
        int GetAttributeCount();
        int GetAttributeIds(ref object ids, string attnam = null);
        string GetAttributeValue(string name);
        int HasAttribute(string name);
        int SetAttributeValue(string name, string value);
    }
}