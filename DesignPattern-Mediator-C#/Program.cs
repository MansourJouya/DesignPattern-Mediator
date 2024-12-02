using System;
using System.Collections.Generic;

/// <summary>
/// Interface for handling communication between objects in a mediator pattern.
/// </summary>
public interface IMediator
{
    void RegisterColleague(IColleague colleague);
    void Notify(string message, IColleague sender);
}

/// <summary>
/// Abstract base class for colleagues that participate in the mediator pattern.
/// </summary>
public abstract class IColleague
{
    protected IMediator _mediator;

    /// <summary>
    /// Initializes a new instance of the IColleague class.
    /// </summary>
    /// <param name="mediator">The mediator instance that the colleague communicates with.</param>
    public IColleague(IMediator mediator)
    {
        _mediator = mediator;
        _mediator.RegisterColleague(this);
    }

    /// <summary>
    /// Abstract method to send a message through the mediator.
    /// </summary>
    /// <param name="message">The message to be sent.</param>
    public abstract void SendMessage(string message);

    /// <summary>
    /// Abstract method to receive a message from the mediator.
    /// </summary>
    /// <param name="message">The received message.</param>
    public abstract void ReceiveMessage(string message);
}

/// <summary>
/// Concrete implementation of the mediator interface that coordinates communication between colleagues.
/// </summary>
public class Mediator : IMediator
{
    private List<IColleague> _colleagues = new List<IColleague>();

    /// <summary>
    /// Registers a colleague to the mediator.
    /// </summary>
    /// <param name="colleague">The colleague to be registered.</param>
    public void RegisterColleague(IColleague colleague)
    {
        _colleagues.Add(colleague);
    }

    /// <summary>
    /// Notifies all registered colleagues except the sender.
    /// </summary>
    /// <param name="message">The message to be broadcasted.</param>
    /// <param name="sender">The sender of the message.</param>
    public void Notify(string message, IColleague sender)
    {
        foreach (var colleague in _colleagues)
        {
            if (colleague != sender)
            {
                colleague.ReceiveMessage(message);
            }
        }
    }
}

/// <summary>
/// Concrete implementation of a colleague in the mediator pattern.
/// </summary>
public class ConcreteColleagueA : IColleague
{
    public ConcreteColleagueA(IMediator mediator) : base(mediator) { }

    /// <summary>
    /// Sends a message to all other colleagues through the mediator.
    /// </summary>
    /// <param name="message">The message to be sent.</param>
    public override void SendMessage(string message)
    {
        Console.WriteLine("Colleague A sending message: " + message);
        _mediator.Notify(message, this);
    }

    /// <summary>
    /// Receives a message from the mediator.
    /// </summary>
    /// <param name="message">The received message.</param>
    public override void ReceiveMessage(string message)
    {
        Console.WriteLine("Colleague A received message: " + message);
    }
}

/// <summary>
/// Another concrete implementation of a colleague in the mediator pattern.
/// </summary>
public class ConcreteColleagueB : IColleague
{
    public ConcreteColleagueB(IMediator mediator) : base(mediator) { }

    /// <summary>
    /// Sends a message to all other colleagues through the mediator.
    /// </summary>
    /// <param name="message">The message to be sent.</param>
    public override void SendMessage(string message)
    {
        Console.WriteLine("Colleague B sending message: " + message);
        _mediator.Notify(message, this);
    }

    /// <summary>
    /// Receives a message from the mediator.
    /// </summary>
    /// <param name="message">The received message.</param>
    public override void ReceiveMessage(string message)
    {
        Console.WriteLine("Colleague B received message: " + message);
    }
}

/// <summary>
/// Client code to demonstrate the Mediator pattern.
/// </summary>
public class Program
{
    /// <summary>
    /// The main entry point of the program.
    /// </summary>
    public static void Main()
    {
        // Create the mediator instance.
        Mediator mediator = new Mediator();

        // Create colleagues and register them with the mediator.
        ConcreteColleagueA colleagueA = new ConcreteColleagueA(mediator);
        ConcreteColleagueB colleagueB = new ConcreteColleagueB(mediator);

        // Simulate communication between colleagues through the mediator.
        colleagueA.SendMessage("Hello, Colleague B!");
        colleagueB.SendMessage("Hi, Colleague A! How are you?");
    }
}
