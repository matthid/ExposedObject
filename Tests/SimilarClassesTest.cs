using System;
using TestSubjects;
using Xunit;

namespace Tests;


public class SimilarClassTest
{
    [Fact]
    public void TestSimilarClassesInstances()
    {
        dynamic exposed1 = Exposed.New(Type.GetType("TestSubjects.SimilarClass1, TestSubjects"));
        string result1 = exposed1.InstanceMethod(1);
        
        dynamic exposed2 = Exposed.New(Type.GetType("TestSubjects.SimilarClass2, TestSubjects"));
        string result2 = exposed2.InstanceMethod(2);
        
        // No failure
        
        Assert.Equal(nameof(SimilarClass1), result1);
        Assert.Equal(nameof(SimilarClass2), result2);
    }

    [Fact]
    public void TestSimilarClassesStatic()
    {
        dynamic exposed1 = Exposed.From(Type.GetType("TestSubjects.SimilarClass1, ExposedObject.TestSubjects"));
        string result1 = exposed1.SimilarMethod(1);

        dynamic exposed2 = Exposed.From(Type.GetType("TestSubjects.SimilarClass2, TestSubjects"));
        string result2 = exposed2.SimilarMethod(2);
        
        // No failure
        
        Assert.Equal(nameof(SimilarClass1), result1);
        Assert.Equal(nameof(SimilarClass2), result2);
    }
}