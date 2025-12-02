/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-20
*/
public class PersonClass
{
    [StringNotEmply(3,ErrorMessage = "FirstName must have 3 character")]
    public string FirstName{get;set;}
    [StringNotEmply(4,ErrorMessage = "LastName must have 4 character")]
    public string LastName{get;set;}
}

public static class CheckObject<T>
{
    public static (bool,System.Collections.Generic.List<string>) CheckData(T ObjectData)
    {
        bool IsValid = true;
        System.Collections.Generic.List<string> ErrorMessages = new List<string>();
        System.Type a1 = ObjectData.GetType();
        foreach (var prop in a1.GetProperties())
        {
            foreach (var att in System.Attribute.GetCustomAttributes(prop))
            {
                var sne1 = (StringNotEmplyAttribute)att;
                if(prop.PropertyType.Name=="String")
                {
                    string StringPropValue = (string)prop.GetValue(ObjectData);
                    if(StringPropValue.Length < sne1.MinLength){IsValid=false; ErrorMessages.Add(sne1.ErrorMessage);}
                }
            }
        }
        return (IsValid,ErrorMessages);
    }
}