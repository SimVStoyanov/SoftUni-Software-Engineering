using System;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Collections.Generic;

using NUnit.Framework;

using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        //Arrange
        string sender = "Ivan";
        string massage = "Do you watch F1?";
        string expexted = "Chat Room Messages:"
                           + Environment.NewLine
                           + "Ivan: Do you watch F1?";

        //Act
        _chatRoom.SendMessage(sender, massage);

        //Assert
        Assert.That(_chatRoom.DisplayChat(), Is.EqualTo(expexted));

    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        //Arrange
        string expected = string.Empty;

        //Act
        string result = _chatRoom.DisplayChat();

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        //Arrange
        _chatRoom.SendMessage("Petar", "Let`s go to Italy!");
        _chatRoom.SendMessage("Alex", "Let`s go!");
        string expected = "Chat Room Messages:"
                            + Environment.NewLine
                            + "Petar: Let`s go to Italy!"
                            + Environment.NewLine
                            + "Alex: Let`s go!";

        //Act
        string result = _chatRoom.DisplayChat();

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
