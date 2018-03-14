using System;
using System.IO;
using net.openstack.Core.Domain;
using net.openstack.Providers.Rackspace;
using Rackspace.CloudNetworks;
using Rackspace.RackConnect;

namespace CSharpProgram2
{
    public class DirectoryRoot
    {
        public static void Main()
        {

            string dir = "C:\\Users\\user\\Desktop\\Directory";
            try
            {
                //Set the current directory.
                Directory.SetCurrentDirectory(dir);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The specified directory does not exist. {0}", e);
            }
            
            Console.WriteLine("Root directory: {0}", Directory.GetDirectoryRoot(dir));
            Console.WriteLine("Current directory: {0}", Directory.GetCurrentDirectory());
        }
    }
}

