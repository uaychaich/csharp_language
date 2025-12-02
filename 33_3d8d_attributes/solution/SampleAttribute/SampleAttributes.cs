/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-19
    https://github.com/dotnet/csharpstandard/blob/standard-v6/standard/attributes.md
*/

[System.AttributeUsage(System.AttributeTargets.All,AllowMultiple = true)]
public class AuthorAttribute : System.Attribute
{
    public string Name{get;set;}
    public string Version{get;set;}
    public string ModifiedDate{get;set;}
    public AuthorAttribute(string inputName)
    {
        Name = inputName;
    }
}