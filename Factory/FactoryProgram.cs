//-----------------------------------------------------------------------
// <copyright file="Factoryprogram.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// Class for Testing Factory Design pattern
    /// </summary>
    public class FactoryProgram
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            ComputerFactory factory = new Computer();

            IFactory pc = factory.GetDevice("PC");
            pc.getDetails("2 GB", "1 TB", "2.2 GHz");

            IFactory server = factory.GetDevice("Server");
            server.getDetails("4 GB", "5 TB", "4 GHz");
        }
    }
}