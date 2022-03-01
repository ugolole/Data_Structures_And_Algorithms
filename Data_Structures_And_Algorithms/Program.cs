
var myName = new Name("Ivan", "Richard", "Ugolole");

Console.WriteLine(myName.ToString());
Console.WriteLine(myName.Initials());


/// <summary>
/// This is a value type data type that represents a structure. There is a difference between a struct and a class which
/// is the a struct is a value type while a class is a reference type. Values are stored general in a stack while
/// Reference types are stored in a heap. You can't assign null to a value type nor can you derive directly from a
/// value type.
///
/// The variable of a value type contains an instance of a type, while the variable of a reference type contains
/// a reference of the instance to the type. Meaning a change to the value type does not affect
/// </summary>
internal struct Name
{
    private string _firstName, _middleName, _lastName;

    /// <summary>
    /// Constructor of a struct used to initialize the structs properties.
    /// </summary>
    /// <param name="first">First name for this struct.</param>
    /// <param name="middle">Middle name for this struct.</param>
    /// <param name="last">Last name for this struct.</param>
    public Name(string first, string middle, string last) =>
        (_firstName, _middleName, _lastName) = (first, middle, last);

    
    /// <summary>
    /// A public property that provides the first name of this struct.
    /// </summary>
    public string FirstName
    {
        get => _firstName;
        set
        {
            _firstName = value;
            _firstName = FirstName;
        }
    }

    /// <summary>
    /// A public property that provides the middle name of this struct.
    /// </summary>
    public string MiddleName
    {
        get => _middleName;
        set
        {
            _middleName = value;
            _middleName = MiddleName;
        }
    }

    /// <summary>
    /// A public property that provides the last name of this struct.
    /// </summary>
    public string LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;
            _lastName = LastName;
        }
    }
    
    /// <summary>
    /// Returns the complete name of this struct which includes first name, middle name, and last name.
    /// </summary>
    /// <returns>The complete name of the struct</returns>
    public override string ToString() => $"{_firstName} {_lastName} {_middleName}";

    /// <summary>
    /// Returns the initial of this struct which comprises of the first characters of each of the names. 
    /// </summary>
    /// <returns>The initial of the struct.</returns>
    public string Initials() =>
        $"{_firstName[..1]}{_middleName[..1]}{_lastName[..1]}";
}