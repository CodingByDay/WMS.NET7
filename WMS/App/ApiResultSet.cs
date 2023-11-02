using System;
using System.Collections.Generic;

public class ApiResultSet
{
    public bool Success { get; set; }
    public string Error { get; set; }
    public int Results { get; set; }
    public List<Row> Rows { get; set; }
}




public class Row
{
    public Dictionary<string, object> Items { get; set; }
    public object GetProperty(string propertyName)
    {
        if (Items.TryGetValue(propertyName, out var value))
        {
            if (value is object)
            {
                return value;
            }
            else
            {
                // Handle if the property value is not of the expected type.
                throw null;
            }
        }
        else
        {
            // Handle if the property name is not found.
            return null;
        }
    }

    public string StringValue(string propertyName)
    {
        var objectValue = GetProperty(propertyName);
        try
        {
            return (string)objectValue;
        } catch
        {
            // prijavu v app center pa uporabniku return default value for type
            return null;
        }
    }

    public bool? BoolValue(string propertyName)
    {
        var objectValue = GetProperty(propertyName);
        try
        {
            return (bool?) objectValue;
        }
        catch
        {
            return null;
        }
    }

    public Int64? IntValue(string propertyName)
    {
        var objectValue = GetProperty(propertyName);


        var type = objectValue.GetType();
        try
        {
            return (Int64?)objectValue;
        }
        catch
        {
            return null;
        }
    }

    public double? DoubleValue(string propertyName)
    {
        var objectValue = GetProperty(propertyName);
        try
        {
            return (double?) objectValue;
        }
        catch
        {
            return null;
        }
    }
}


