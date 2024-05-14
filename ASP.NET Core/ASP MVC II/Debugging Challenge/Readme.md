# Practice Assignment: Debugging Challenge

### Learning Objectives:

- Analyze prewritten code for errors.
- Summarize why certain errors occurred in the code.
##
### Directions
Programming is rarely a solitary endeavor. In the industry, it is common to work alongside a team of other programmers who you have to communicate with to complete a project.

Sometimes, your fellow programmers will hit a snag on their part of the project, and they will ask you "Hey, can you take a look at my code and tell me what I'm doing wrong?"

This is the moment that you become a debugger. And not just a debugger for your own code, but a debugger of someone else's code. The ability to read, understand, and--most importantly right now--debug someone else's code is vital in the working world. You will commonly find yourself reading other people's code, whether they're examples online or your coworker's files. Reading and debugging code are everyday parts of being a programmer.

This assignment will have you debugging someone else's code. Your coworker is working on a project where a client is able to put their name and location into a form, and after successful submission, they are taken to a page that generates a random 14-character passcode for them. The user is then able to either generate another passcode or log out of the application.
Download [this zip file](asset/1667502059__DebuggingChallenge.zip) to access the code. Unzip the contents and save your own version of the project. You may need to run `dotnet restore` in the project terminal after saving the files to make sure everything is up to date.

Now that you have the files, it's time to start debugging. Below is a list of all the actions you should be able to successfully complete. Test every one of these features to make sure they work before you call this assignment complete!

You should also take the time to leave comments in the code explaining what was broken and how you fixed it so your coworker is up to speed on the changes and you get to practice verbalizing your knowledge.

To call the project fully functional, you must be able to:

- See a validation error on Name if a Name is not given for the form on the first page
- Be redirected to the Generate page upon successful completion of the User form
- A person should NOT be able to get to the Generate page if they did not use the User form
    - You can test this feature by typing "localhost:5XXX/generator" into the URL to navigate to the internal page
- A random passcode should automatically generate upon landing on the Generate page
- The top of the Generate page should read "Welcome, [User's Name] from [User's Location unless Undisclosed]!"
- Clicking the "Log out" button should redirect the user to the Index page. At that point, they should be unable to go back to the Generate page (try typing "localhost:5XXX/generator" in the URL again) unless they fill out the User form again.
This log-out feature must be done with a POST request
- Clicking the "New code" button should generate a new passcode to display on the page
- All data should be properly stored in session

Don't forget to leave comments in the code about what you fixed and where it was fixed. If you get stuck trying to solve an error, grab another coworker (your classmate) and see if they can help you spot the problems. Sometimes an extra set of eyes is all you need.

Once you are able to make the application fully functional, zip it up and turn it in. Congrats! You can read and debug other people's code!

- [x] See a validation error on Name if a Name is not given for the form on the first page

- [x] Be redirected to the Generate page upon successful completion of the User form

- [x] A person should NOT be able to get to the Generate page if they did not use the User form

- [x] A random passcode should automatically generate upon landing on the Generate page

- [x] The top of the Generate page should read "Welcome, [User's Name] from [User's Location unless Undisclosed]!"

- [x] Clicking the "Log out" button should redirect the user to the Index page

- [x] After logging out, the user should be unable to go back to the Generate page unless they fill out the User form again

- [x] The log-out feature must be done with a POST request

- [x] Clicking the "New code" button should generate a new passcode to display on the page

- [x] All data should be properly stored in session