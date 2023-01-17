/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-15
*/
using System.Collections;

public class StudentClass
{
    //field
    private string _FirstName,_LastName;
    public string FirstName{get=>_FirstName;set=>_FirstName=value;}
    public string LastName{get=>_LastName;set=>_LastName=value;}
}

public class StudentClassEnum: IEnumerator<StudentClass>
{
    //field
    private StudentClass[] _StudentStorage;
    private int _currentPosition;

    //Constructor
    private StudentClassEnum(){}
    public StudentClassEnum(StudentClass[] input){_StudentStorage=input;_currentPosition=-1;}

    // Implement Interface
    public StudentClass Current => _StudentStorage[_currentPosition];

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

public class ManyStudentClass : IEnumerable<StudentClass>
{
    //field
    StudentClassEnum _InputEnum;
    
    //Constructor
    private ManyStudentClass(){}
    public ManyStudentClass(StudentClass[] input){_InputEnum = new StudentClassEnum(input);}

    //Implement interface
    public IEnumerator<StudentClass> GetEnumerator()
    {
        return _InputEnum;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}