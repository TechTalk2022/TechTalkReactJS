import React, { useState } from 'react';
import { Link } from 'react-router-dom';

const ViewUseState_Demo = () => {

    const [count, setCount] = useState(0);


    const [car, setCar] = useState({
        brand: "Ford",
        model: "Mustang",
        year: "1964",
        color: "red"
    });

    const updateColor = () => {
        setCar(previousState => {
            return { ...previousState, color: "RED" }
        });
    }

    const updateYear = () => {
        setCar(previousState => {
            return { ...previousState, year: "2002" }
        });
    }

    const [userDetailsData, setUserDetailsData] = useState({ firstName: "Justine", lastName: "Clement", dob: "01/01/1990", address: "YH" });
    console.log(userDetailsData)

    const handleInput = (event) => {
        setUserDetailsData({ ...userDetailsData, [event.target.name]: event.target.value })
    }

    const handleSubmit = async (e) => {
        e.preventDefault();
        console.log(userDetailsData)
        debugger;
        alert(userDetailsData.firstName)
    }


    return (
        <>
            <div className='container' >
                Welcoemt to UseState Demo

                <br></br>

                Count: {count} <br></br>

                <button onClick={() => setCount(0)}>Reset</button> <br></br> <br></br>

                <button onClick={() => setCount(prevCount => prevCount - 1)}>-</button>

                <button onClick={() => setCount(prevCount => prevCount + 1)}>+</button>




                <h1>My {car.brand}</h1>
                <p>
                    It is a {car.color} {car.model} from {car.year}.
                </p>
                <button type="button" onClick={updateColor}  >Blue</button>
                <button type="button" onClick={updateYear}  >Year</button>
                <br></br> <br></br>
                <label for="Tile">First Name:<span className="required_style">*</span></label>
                <input name='firstName' onChange={e => handleInput(e)} value={userDetailsData?.firstName} type="text" tabindex="1" autocomplete="off" maxLength="30" className="form-control" placeholder="First Name" />
                <br></br> <br></br>
                <label for="Tile">Last Name:<span className="required_style">*</span></label>
                <input name='lastName' onChange={e => handleInput(e)} value={userDetailsData?.lastName} type="text" tabindex="1" autocomplete="off" maxLength="30" className="form-control" placeholder="First Name" />


                <div className="col-xl-12 btnbottom_align">
                    <button className="btn btn-success filter-btn mr-1" onClick={(e) => handleSubmit(e)}>Save</button>
                    <Link to='/user-details' className="btn btn-secondary filter-btn">Cancel</Link>
                </div>


            </div>
        </>
    );
}
export default ViewUseState_Demo;