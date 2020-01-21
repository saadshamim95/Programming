//-----------------------------------------------------------------------
// <copyright file="FacadeMain.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// Class for testing Facade Design Pattern
    /// </summary>
    public class FacadeMain
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            CarFacade carFacade = new CarFacade();
            carFacade.CreateCompleteCar();
        }
    }
}