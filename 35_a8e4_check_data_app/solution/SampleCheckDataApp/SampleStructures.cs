/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-20
*/
public struct PersonStructure
{
    [StringNotEmply(3,ErrorMessage = "FirstName must have 3 character")]
    public string FirstName{get;set;}
    [StringNotEmply(4,ErrorMessage = "LastName must have 4 character")]
    public string LastName{get;set;}
}