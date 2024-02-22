# Core Assignment: Login and Registration

### Learning Objectives:

- Construct fully featured login and registration forms.
- Hash or verify hashed passwords on post requests.
- Verify unique emails by querying the database using LINQ and conditionals.
- Implement session for user authentication.

##
### Directions

Start a new project with a Login and Registration feature. It will be helpful to have a solid working Login/Reg that you may modify/add to future projects.

**Register validations**

- All fields are required
- First name must be at least 2 characters
- Last name must be at least 2 characters
- Email must be a valid email format
- Email must be unique to the database
- Password must be at least 8 characters
- Password confirm must match password

**Login validations**

- All fields required
- Email must be a valid email format
- Email must exist in the database
- Password must match with a hashed password in the database to the user with the provided email

**Success**

- Redirect to the success page upon successful login or registration
- Only logged-in users should be able to access the success page
- If someone tries to access this page and is not a logged-in user, redirect them to the login page

**Logout**

- When a user selects "logout", clear session and redirect the user back to the login/register page. They should now be unable to access the success page after logging out unless they successfully log back in


![](asset/1663083063__LoginRegister.png)

- [x] Create a working registration form.

- [x] Create a working login form.

- [x] Successfully implement session.

- [x] Apply security checks to the success page.

- [x] Clear session upon logging out of the success page.