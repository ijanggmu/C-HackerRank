using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using HackerRank;
using HackerRank.UnitTesting;
using System.IO;

namespace HackerRankTest
{
    public class StringTest
    {
        [Fact]
        public void LoadFile_ValidNameShouldWork()
        {
            string actual = Strings.LoadTextFile("Hello file how are you");
            Assert.True(actual.Length > 0);
        }
        [Fact]
        public void LoadFile_InvalidNameShouldFaile()
        {
            Assert.Throws<ArgumentException>("file",() => Strings.LoadTextFile(""));
            //Assert.Throws<FileNotFoundException>(() => Strings.LoadTextFile(""));
        }
    }
}
