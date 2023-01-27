/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-11
*/
public struct PeopleStructure
{
    //field
    private string _FullName;
    private double _Income;
    private GenderEnum _Gender;
    private MaritalStatusEnum _MaritalStatus;
    
    //property
    public string FullName{get=>_FullName;set=>_FullName=value;}
    public double Income{get=>_Income;set=>_Income=value;}
    public GenderEnum Gender{get=>_Gender;set=>_Gender=value;}
    public MaritalStatusEnum MaritalStatus{get=>_MaritalStatus;set=>_MaritalStatus=value;}

    //constructure
    public PeopleStructure(){_FullName="";_Income=0;_Gender=GenderEnum.NoSpecific;_MaritalStatus=MaritalStatusEnum.Single;}
}