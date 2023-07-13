## Phone Book Console Application from Patika.DEV

Please write a phone directory application by opening a new console application. The features that should be in the application are as follows:

Save Phone Number
Delete Phone Number
Update Phone Number
List Directory (selectable A-Z, Z-A)
Search in Directory
Description:

Start by adding the numbers of 5 people as default.

When the application first starts, the user is asked to select the operation they want to do.

```markdown
Copy code
Please select the operation you want to perform :) 
******************************************* 
(1) Save New Number 
(2) Delete Existing Number 
(3) Update Existing Number 
(4) List Directory 
(5) Search in Directory
(1) Save New Number
```

```yaml
Copy code
Please enter the name            : 
Please enter the surname         :
Please enter the phone number   :
```

(2) Delete Existing Number

Search by name and surname is sufficient.

```arduino
Copy code
Please enter the name or surname of the person whose number you want to delete:
If no person is found in the directory according to the user's input:
```

```vbnet
Copy code
No data was found in the directory that meets your criteria. Please make a selection.
* To end deletion: (1)
* To try again   : (2)
If suitable data is found in the directory:
```

```sql
Copy code
Are you sure you want to delete the person named {} from the directory? (y/n)
Note: If the directory finds more than one person suitable for the criteria, the first one found should be deleted.
```

(3) Update Existing Number

```css
Copy code
Please enter the name or surname of the person whose number you want to update:
If no person is found in the directory according to the user's input:
```

```vbnet
Copy code
No data was found in the directory that meets your criteria. Please make a selection.
* To end the update : (1)
* To try again      : (2)
If suitable data is found in the directory, the update process is performed.
```

Note: If the directory finds more than one person suitable for the criteria, the first one found should be updated.

(4) List Directory

The entire directory is listed on the console in the following format.

markdown
Copy code
Telephone Directory
**********************************************
Name: {} Surname: {} Phone Number: {} 
- Name: {} Surname: {} Phone Number: {} ..
(5) Search in Directory

markdown
Copy code
Choose the type you want to search for.
**********************************************
To search by name or surname: (1) 
To search by phone number: (2)
The data found according to the search result should be displayed in the following format.

markdown
Copy code
Your Search Results:
**********************************************
Name: {} Surname: {} Phone Number: {} 
- Name: {} Surname: {} Phone Number: {} ..
** Each feature should be done using separate class/method. Responsibilities should be fragmented as much as possible and the code should be readable.

Please let me know if you have any other requests or need further assistance!
