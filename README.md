S/w for admin usage only. 
Will show the current state of parking lots.
Structure => Enterprise -> List(Parking Lots) -> Each lot having multiple floors -> Each Floor having multiple types of slots with current state of being empty / full.
UI -> Welcome Page -> Login -> List of lots -> select one lot to go to its page and find the details of it.
As the data is structured so we will use SQL database.
SQL Tables : Lots table [List of all current parking lots], Slots table [tells how many empty slots are present. PK (Lot no + Floor no)]
We should be able to add new entries through UI for new parking lots and new floors.
Also should be able to add new entries to slots as per availability.
UI should update in realtime if the slots are full for a particular parking and should give response accordingly.
Logs should be created for all the operations and we should have records of what happened how.
