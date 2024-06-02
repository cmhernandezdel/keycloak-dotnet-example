using System.Reflection;
using api.Attributes;

namespace api.Http;

public static class FormUrlEncodedContentConverter
{
    public static FormUrlEncodedContent ToFormUrlEncodedContent<T>(this T content) where T : class
    {
        var retValue = new List<KeyValuePair<string, string?>>();
        var properties = typeof(T).GetProperties();
        foreach (var property in properties)
        {
            var attribute = property.GetCustomAttribute<FormUrlEncodedContentKeyAttribute>();
            if (attribute is not null)
            {
                var key = attribute.Key;
                var value = property.GetValue(content);
                retValue.Add(new KeyValuePair<string, string?>(key, value?.ToString()));
            }
        }
        return new FormUrlEncodedContent(retValue);
    }
}
