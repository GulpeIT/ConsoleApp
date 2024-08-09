using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM: SS)

HH = hours, padded to 2 digits, range: 00 - 99
MM = minutes, padded to 2 digits, range: 00 - 59
SS = seconds, padded to 2 digits, range: 00 - 59
The maximum time never exceeds 359999 (99:59:59)

You can find some examples in the test fixtures.
*/


/* Test Case

[TestFixture]
public class HumanReadableTimeTest
{
    private void DoTest(int seconds, String expected)
    {
        String actual = TimeFormat.GetReadableTime(seconds);
        Assert.AreEqual(expected, actual, "for " + seconds + " seconds");
    }

    [Test]
    public void SampleTests()
    {
        DoTest(     0, "00:00:00");
        DoTest(    59, "00:00:59");
        DoTest(    60, "00:01:00");
        DoTest(    90, "00:01:30");
        DoTest(  3599, "00:59:59");
        DoTest(  3600, "01:00:00");
        DoTest( 45296, "12:34:56");
        DoTest( 86399, "23:59:59");
        DoTest( 86400, "24:00:00");
        DoTest(359999, "99:59:59");
    }
}

*/

namespace ConsoleApp
{
    internal class TimeFormat
    {
        public string GetReadableTime(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            string timeFormat = string.Format("{0:D2}:{1:D2}:{2:D2}",
                time.Hours + time.Days * 24,
                time.Minutes,
                time.Seconds);
            return timeFormat;
        }
    }
}
