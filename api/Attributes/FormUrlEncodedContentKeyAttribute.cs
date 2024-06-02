namespace api.Attributes;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class FormUrlEncodedContentKeyAttribute : Attribute
{
    public string Key { get; }

    public FormUrlEncodedContentKeyAttribute(string key)
    {
        Key = key;
    }
}
