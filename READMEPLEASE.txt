WASD to move Pac-man
pacman is the sphere
The ghosts are the squares.
Hiting a ghost loses a life.
All lives lost (you have 3 lives) equal death.
Collect 10 pellets and you get win screen.

Object pooling was implemented with the ghosts by instantiating the ghost prefab at launch. The object pooling script I created lets the developer dictate, what to instantiate and how many.
The instantiated objects are stored in a list for future reference.

Command Pattern.
I wasn't able to get undo working, but I did implement command pattern with the pellets.
I created an interface called ICommand which had a execute and undo function.
I then created a Pellet eaten command. In the execute function, it requires a game object to be pass as a parameter. In the execute function, the gameobject (the pellet) is set active to false.
The game manager singleton is also called and the pellet score is updated.
When the player collides with a pellet, a new PelletEaten command is created within the TriggerEnter2D function and the PelletEaten command's execute function is called.
I managed to make a command manager script which contains a list of commands known as the command list. Every time a command is created and called it would be added to the command list. In order to undo the pellets eaten. I would iterate through the last 7 commands added to the list and call each command's undo function.
