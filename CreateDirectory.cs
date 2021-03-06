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
            DirectoryInfo directory = new DirectoryInfo("C:\\Users\\user\\Desktop\\Directory");
            try
            {
                if (directory.Exists)
                {
                    Console.WriteLine("Directory already exist.");
                    return;
                }

                directory.Create();
                Console.WriteLine("The directory Created successfully.");

            }
            catch (Exception e)
            {
                Console.WriteLine("Directory is not created: {0}", e.ToString());
            }

        }
    }
}
