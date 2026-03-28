S/w for admin usage only. 
Will show the current state of parking lots.
Structure => Enterprise -> List(Parking Lots) -> Each lot having multiple floors -> Each Floor having multiple types of slots with current state of being empty / full.
UI -> Welcome Page -> Login -> List of lots -> select one lot to go to its page and find the details of it.
As the data is structured so we will use SQL database.
SQL Tables : Lots table [List of all current parking lots], Slots table [tells how many empty slots are present. PK (Lot no + Floor no)]
