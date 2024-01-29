# Practice Assignment: Dojo Survey with Model

### Learning Objectives:

- Bind data to a model object to bundle data sent over a POST request.
- Render data using ViewModel.
##
### Directions
Update your previous Dojo Survey assignment (you will first want to recreate it using `dotnet new mvc`) to use a model for the form. Create a class to represent the data you're expecting from the form. Then update the form and controller accordingly to receive the proper input. Finally, update the results page to use ViewModel to render the data instead of ViewBag.

Note: It is still acceptable at this point to render the results on your post request, but we encourage you to think about how to get around this!

![](asset/1666364170__SurveyWithModel.png)

- [x] Create a model class called Survey

- [x] Update the form's name inputs to use attributes from Survey

- [x] Update the controller method to expect a Survey object

- [x] Update the results view to use a Survey ViewModel

- [ ] Extra: Don't forget a little CSS! You can use Bootstrap since it is included in MVC projects

- [ ] Bonus: If you couldn't figure out before how to store and render data outside a post request, can you figure it out now?
