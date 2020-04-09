using System;
using Xunit;

namespace GradeBook.Tests
{
    public delegate string WriteLogDelegate(string logMessage);
    public class TypeTest
    {
        int count = 0;
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {   
        WriteLogDelegate log = ReturnMessage;
        log += ReturnMessage;
        log += IncrementCount;

        var result = log("Hello!");
            
        Assert.Equal(3, count);
        }
        string IncrementCount(string message)
        {
            count++;
            return message.ToUpper();
        }
    
        string ReturnMessage(string message)
        {
            count++;
            return message;
        }
    }
}
    

