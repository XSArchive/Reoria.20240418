using Godot;
using System;

namespace Reoria.Nodes.Engine;

/// <summary>
/// Defines functionality of the game's root <see cref="Node"/>.
/// </summary>
public partial class GameContainer : Node
{
    /// <summary>
    /// The reference to the root <see cref="Node"/>.
    /// </summary>
    private static GameContainer? instance;

    /// <summary>
    /// The reference to the root <see cref="Node"/>.
    /// </summary>
    public static GameContainer? Instance
    {
        get
        {
            // Check to see if the root node is assigned, and return it if it has, if it has not then close the game.
            return instance is not null ? instance
                : throw new NullReferenceException("The game's root node has been lost, the game will now close.");
        }
    }

    /// <summary>
    /// Constructs a new <see cref="GameContainer"/> instance and assignes the reference to it to <see cref="Instance"/>.
    /// </summary>
    public GameContainer()
    {
        // Check to see if the root node has already been created.
        if (instance is not null)
        {
            // Yes it has, we can not allow "Dave" to do this.
            throw new InvalidOperationException("The game can not load more then one root node, the game will now close.");
        }

        // Assign this instance of the root node to the instance variable.
        instance = this;
    }

    /// <summary>
    /// Called when the node is "ready", i.e. when both the node and its children have
    /// entered the scene tree. If the node has children, their <see cref="Node._Ready"/> 
    /// callbacks get triggered first, and the parent node will receive the ready 
    /// notification afterwards.
    /// </summary>
    public override void _Ready()
    {
        // Fetch and assign the child node variables if they have not been assigned yet.

        // Pass to the base class' function.
        base._Ready();
    }
}
