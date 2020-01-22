//-----------------------------------------------------------------------
// <copyright file="ChatClient.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// Class for testing Mediator Design Pattern
    /// </summary>
    public class ChatClient
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            IChatMediator mediator = new ChatMediatorImplementation();
            User user1 = new UserImplementation(mediator, "Saad");
            User user2 = new UserImplementation(mediator, "Mayank");
            User user3 = new UserImplementation(mediator, "Amit");
            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);

            user1.Send("Hi Everyone!!!");
        }
    }
}