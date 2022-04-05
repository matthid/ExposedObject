using System.Diagnostics.CodeAnalysis;
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedParameter.Global
// ReSharper disable UnusedParameter.Local

namespace TestSubjects;

[SuppressMessage("Performance", "CA1822:Mark members as static")]
public class SimilarClass1
{
    public static string SimilarMethod(int arg)
    {
        return nameof(SimilarClass1);
    }

    private string InstanceMethod(int arg)
    {
        return nameof(SimilarClass1);
    }
}


[SuppressMessage("Performance", "CA1822:Mark members as static")]
public class SimilarClass2
{
    public static string SimilarMethod(int arg)
    {
        return nameof(SimilarClass2);
    }
    
    private string InstanceMethod(int arg)
    {
        return nameof(SimilarClass2);
    }
}