/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-20
*/
[System.AttributeUsage(System.AttributeTargets.Property,AllowMultiple =true)]
public class StringNotEmplyAttribute: System.Attribute
{
    public ushort MinLength{get;set;}
    public string ErrorMessage{get;set;}
    public StringNotEmplyAttribute(){MinLength=0;ErrorMessage="String must not be empty";}
    public StringNotEmplyAttribute(ushort inputMinLength){MinLength=inputMinLength;ErrorMessage=$"String must has {MinLength} characters";}
}