# Practice Assignment: Date Validator

### Learning Objectives:

- Create a custom validation.
- Apply your custom validation to a form that will render errors on unsuccessful attempts.
##
### Directions
This will be another research assignment! Try your hand at creating a custom validation attribute! Create a FutureDateAttribute that prevents a user from submitting a date that is after the present moment (think like a birthday field).

Create a quick project to test the validation works or add it to an existing project.

Here is some code to get you started:
```md
public class FutureDateAttribute : ValidationAttribute
{    
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)    
    {        
        // You first may want to unbox "value" here and cast to to a DateTime variable!    
    }
}
````
If you need extra assistance in getting started, consider these prompts:

- What do I need to set up to begin this project? (i.e. an MVC project, a form, a custom validation, etc)
- How do I create a form input that takes in a date? (Look this up if you need to.)
- Once my form data is passed over to my custom validation, what do I want to do with it?
- How can I tell that the date that was given is a date in the future? (You may need to consider how you get what today's date is and how you compare two dates.)
- Hint: If you completed the Countdown assignment from earlier in the course, that assignment could be a great reference!

- [ ] Make an MVC project with a form that takes a date, or add a date input to an existing project.

- [ ] Create a custom validation to verify that the submitted date is in the past.

- [ ] Render an error on unsuccessful submission.

- [ ] Render a success page on successful submission.
