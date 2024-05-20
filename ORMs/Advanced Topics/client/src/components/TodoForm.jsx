import { useState } from "react";
import axios from "axios";
const TodoForm = props => {
    const [form, setForm] = useState({
        name: "",
	isComplete: false
    });
    const [errors, setErrors] = useState(null);
    const onChangeHandler = e => {
	setForm({...form, [e.target.name]: e.target.value})
    }
    // This empties the form after you submit
    const formReset = () => {
	setForm({
	    name: "",
	    isComplete: false
	})
    }
    const formHandler = async e => {
	e.preventDefault();
	// try to add the item, otherwise, get errors
	try {
	    const addItem = await axios({
	        url: "http://localhost:5133/api/todoitems",
	        method: "post",
	        data: form,
	        contentType: "application/json"
	    });
	    // Clears the form
	    formReset();
	    // Resets errors to null in case there had been some
	    setErrors(null);
	} catch (err) {
	    // Only Name is capable of getting an error
	    // Pull one layer back if you have multiple errors to watch out for
	    setErrors(err.response.data.errors.Name);
	}
    }
    return(
	<>
	    <h2>Add a Task</h2>
	    <form onSubmit={formHandler}>
	        <div>
	            <label htmlFor="name">Task:</label>
	            <input type="text" name="name" onChange={onChangeHandler} value={form.name} />
	            <div>
	                {errors ? <span className="text-danger">{errors}</span> : ""}
	            </div>
	        </div>
	        <div>
	            <input type="submit" value="Add Task" />
	        </div>
	    </form>
	</>
    );
}
export default TodoForm;