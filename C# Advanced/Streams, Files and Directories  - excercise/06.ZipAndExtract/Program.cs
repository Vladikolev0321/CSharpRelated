using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ZipFile.CreateFromDirectory(".","myArchive.zip");
                // ZipFile.ExtractToDirectory() 
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
