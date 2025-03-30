# *C#-arpenters*
### ***First Impression***
Upon running the program, I found no errors. I like that the schedules can be exported and the hangman game. One thing that I found that I would do differently is clear at least the password textbox after the user successfully logs in

### ***Form1 Code***
I found that everything was well-documented. I did notice that the ValidateLogin method does not have any try-catches, nor is one used when calling it. I also think that the method could be moved into a class library .

### ***Sports Form Code***
I find the code for this form to be well-documented. The LoadUserData method lacks try-catches. The statsBtn click event could use a string that is assigned a new value when the user clicks the basketball, lacrosse, or basketball buttons instead of checking the background color.

### ***Create Form Code***
I found this form to be well-documented. I like the CreateDatabase method, but as with other methods which use SQL, it does not have a try-catch. The same goes for the UpdateFavoriteSport method.<br> 
After testing, I found that there is a missing comma in the CREATE TABLE query in the CreateDatabase method, which causes the program to crash if the debug folder has been deleted.

### ***Data Form Code***
I found the code for this form to be well-documented. I did not notice any problems with the code.
 
### ***HangMan Form Code***
I found this form to be well-documented. One thing I would do differently is check if the entered char is a letter.

### ***Testing***
In all forms, the user can type data into the data grid view, though any changes will not be saved. In the create form, after deleting the debug folder, the program crashed when creating an account due to the CREATE TABLE query missing a comma.
Deleting the debug folder also causes the program to crash after logging in. This can be fixed by saving images as resources or storing them in a project folder.

### ***Comparing solutions***
In my group’s project, we displayed a selection of teams/players and the stats for whichever team/player was selected. We used labels to display data as opposed to data grid views. Another difference is that we have filtering player/team filtering by stat. 


