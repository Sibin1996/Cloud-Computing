using System;
using System.IO;
using net.openstack.Core.Domain;
using net.openstack.Providers.Rackspace;
using Rackspace.CloudNetworks;
using Rackspace.RackConnect;
namespace CSharpProgram1
{
    class Program
    {
       static void Main(string[] args)
        {
                        
                DirectoryInfo directory = new DirectoryInfo("C:\\Users\\user\\Desktop\\Directory1");
                try
                {
                    directory.Delete();
                    Console.WriteLine("The directory Deleted successfully.");

                }
                catch (Exception e)
                {
                    Console.WriteLine(" Something went wrong in the code: {0}", e.ToString());
                }
            
        }
    }
}
