//-----------------------------------------------------------------------
// <copyright file="CarFacade.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// The 'Facade' Class
    /// </summary>
    public class CarFacade
    {
        /// <summary>
        /// The model
        /// </summary>
        private CarModel model;

        /// <summary>
        /// The engine
        /// </summary>
        private CarEngine engine;

        /// <summary>
        /// The body
        /// </summary>
        private CarBody body;

        /// <summary>
        /// The accessories
        /// </summary>
        private CarAccessories accessories;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarFacade"/> class.
        /// </summary>
        public CarFacade()
        {
            this.model = new CarModel();
            this.engine = new CarEngine();
            this.body = new CarBody();
            this.accessories = new CarAccessories();
        }

        /// <summary>
        /// Creates the complete car.
        /// </summary>
        public void CreateCompleteCar()
        {
            Console.WriteLine("********************Creating a Car********************");
            this.model.SetModel();
            this.engine.SetEngine();
            this.body.SetBody();
            this.accessories.SetAccessories();
            Console.WriteLine("*****************Car Creation Complete****************");
        }
    }
}