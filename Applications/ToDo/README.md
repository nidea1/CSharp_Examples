## ToDo Console Application from Patika.DEV

Write a TODO application that consists of three columns in a new console application. The features that must be in the application are as follows:

- Add Card
- Update Card
- Delete Card
- Move Card
- List Board

Card Contents:

- Title
- Content
- Assigned Person (Should be one of the team members)
- Size (XS, S, M, L, XL)

##Description

- The board should consist of TODO - IN PROGRESS - DONE columns.

- By default, a board should be defined and contain three cards. (The cards can be in any line, i.e., any column.)

- Cards can only be assigned to someone from the team. Team members should be predefined. Team members can be held by using a Dictionary as key-value pairs or through a class. When assigning cards, team members will be assigned with their IDs. So the structure to be used must contain an ID.

- When the application first starts, the user is asked to choose the operation he/she wants to perform.

```console
Please select the operation you want to perform :)
******************************************* (1) List Board (2) Add Card to Board (3) Delete Card from Board (4) Move Card
```

### (1) List Board

```
TODO Line

Title :
Content :
Assigned Person :
Size :

Title :
Content :
Assigned Person :
Size :

IN PROGRESS Line

Title :
Content :
Assigned Person :
Size :

Title :
Content :
Assigned Person :
Size :

DONE Line

~ EMPTY ~
```

### (2) Add Card to Board

```
Enter the Title :
Enter the Content :
Select the Size -> XS(1),S(2),M(3),L(4),XL(5) :
Select the Person :
```

**Sizes should be stored as Enum. It should be shown as XS on the card. When entering, 1 should be taken from the user.**

**Team members should already be defined in a current list. (There is no need to define it dynamically in the program.) When defining the card, the ID of the team member should be requested. If it is not a defined ID, the process can be canceled with the warning "You have made incorrect entries!".**

### (3) Delete Card from Board

```
First, you need to select the card you want to delete.
Please write the title of the card:
```

If the card cannot be found:

```
The card that matches your search criteria could not be found on the board. Please make a selection.

To end the deletion : (1)
To try again : (2)
```
**If there are more than one card with the same name, both can be deleted.**

### (4) Move Card

```
First, you need to select the card you want to move.
Please write the title of the card:
```

If the card cannot be found:

```
The card that matches your search criteria could not be found on the board. Please make a selection.

To end the process : (1)
To try again : (2)
```

If the card is found:

```
Found Card Information:
************************************** Title : Content : Assigned Person : Size : Line : Please select the Line you want to move: (1) TODO (2) IN PROGRESS (3) DONE
```

**If a correct selection is made, the board is listed and shown to the user using (1) List Board. If the selection is not correct, the process can be ended with the information "You have made an incorrect selection!".**

#### NOTE: The structure of the application should generally be as follows

- Board consists of 3 lines.
- Each line holds a list of cards
- Sizes of the cards are held in a pre-defined enum.
- A card can only be assigned to one of the team members.
- Team members should already be in a predefined list. A Struct, class or a collection can be used.
