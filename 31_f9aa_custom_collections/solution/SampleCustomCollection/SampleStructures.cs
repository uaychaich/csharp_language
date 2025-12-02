/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-15
*/
using System.Collections;

public struct StudentStructure
{
    //field
    private string _FirstName,_LastName;
    public string FirstName{get=>_FirstName;set=>_FirstName=value;}
    public string LastName{get=>_LastName;set=>_LastName=value;}
}

public struct StudentStructureEnum: IEnumerator<StudentStructure>
{
    //field
    private StudentStructure[] _StudentStorage;
    private int _currentPosition;

    //Constructor
    public StudentStructureEnum(){}
    public StudentStructureEnum(StudentStructure[] input){_StudentStorage=input;_currentPosition=-1;}

    // Implement Interface
    public StudentStructure Current => _StudentStorage[_currentPosition];

    object IEnumerator.Current => Current;

    public void Dispose(){}

    public bool MoveNext()
    {
        _currentPosition++;
        return _currentPosition < _StudentStorage.Length;
    }

    public void Reset()
    {
        _currentPosition = -1;
    }
}

public struct ManyStudentStructure : IEnumerable<StudentStructure>
{
    //field
    StudentStructureEnum _InputEnum;
    
    //Constructor
    public ManyStudentStructure(){}
    public ManyStudentStructure(StudentStructure[] input){_InputEnum = new StudentStructureEnum(input);}

    //Implement interface
    public IEnumerator<StudentStructure> GetEnumerator()
    {
        return _InputEnum;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}