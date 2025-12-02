/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-20
*/
PersonClass pc1 = new PersonClass();
System.Type t1 = pc1.GetType();
Console.WriteLine($"Type Name is: {t1.FullName}");
Console.WriteLine($"Type is Class: {t1.IsClass}");
Console.WriteLine($"Type Attribute:");
foreach (var item in System.Attribute.GetCustomAttributes(t1))
{
    if(item is AuthorAttribute)
    {
        AuthorAttribute a = (AuthorAttribute)item;
        Console.WriteLine($"   {a.Name} | {a.Version} | {a.ModifiedDate}");
    }
}
Console.WriteLine($"Fields:");
foreach (var item in t1.GetFields())
{
    Console.WriteLine($"Name: {item.Name} | Type: {item.FieldType.FullName} | IsPublic: {item.IsPublic} | IsPrivate: {item.IsPrivate}");
    Console.WriteLine($"Field Attributes:");
    foreach (var itemattr in System.Attribute.GetCustomAttributes(item))
    {
        if(itemattr is AuthorAttribute)
        {
            AuthorAttribute a = (AuthorAttribute)itemattr;
            Console.WriteLine($"   {a.Name} | {a.Version} | {a.ModifiedDate}");
        }
    }
}
Console.WriteLine($"Properties:");
foreach (var item in t1.GetProperties())
{
    Console.WriteLine($"Name: {item.Name} | Type: {item.PropertyType} | CanRead: {item.CanRead} | CanWrite: {item.CanWrite}");
    Console.WriteLine($"Property Attributes:");
    foreach (var itemattr in System.Attribute.GetCustomAttributes(item))
    {
        if(itemattr is AuthorAttribute)
        {
            AuthorAttribute a = (AuthorAttribute)itemattr;
            Console.WriteLine($"   {a.Name} | {a.Version} | {a.ModifiedDate}");
        }
    }
}
Console.WriteLine($"Method:");
foreach (var item in t1.GetMethods())
{
    Console.WriteLine($"Name: {item.Name} | Return Type: {item.ReturnType} | No. Parameter: {item.GetParameters().Length} | IsPublic: {item.IsPublic} | IsPrivate: {item.IsPrivate}");
    Console.WriteLine($"Method Attributes:");
    foreach (var itemattr in System.Attribute.GetCustomAttributes(item))
    {
        if(itemattr is AuthorAttribute)
        {
            AuthorAttribute a = (AuthorAttribute)itemattr;
            Console.WriteLine($"   {a.Name} | {a.Version} | {a.ModifiedDate}");
        }
    }
}
Console.WriteLine($"Constructor:");
foreach (var item in t1.GetConstructors())
{
    Console.WriteLine($"Name: {item.Name} | No. Parameter: {item.GetParameters().Length} | IsPublic: {item.IsPublic} | IsPrivate: {item.IsPrivate}");
    Console.WriteLine($"Constructor Attributes:");
    foreach (var itemattr in System.Attribute.GetCustomAttributes(item))
    {
        if(itemattr is AuthorAttribute)
        {
            AuthorAttribute a = (AuthorAttribute)itemattr;
            Console.WriteLine($"   {a.Name} | {a.Version} | {a.ModifiedDate}");
        }
    }
}
Console.WriteLine($"Event:");
foreach (var item in t1.GetEvents())
{
    Console.WriteLine($"Name: {item.Name} | EventHandlerType: {item.EventHandlerType}");
    Console.WriteLine($"Event Attributes:");
    foreach (var itemattr in System.Attribute.GetCustomAttributes(item))
    {
        if(itemattr is AuthorAttribute)
        {
            AuthorAttribute a = (AuthorAttribute)itemattr;
            Console.WriteLine($"   {a.Name} | {a.Version} | {a.ModifiedDate}");
        }
    }
}