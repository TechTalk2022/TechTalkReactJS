import React, { useEffect, useState } from 'react';

const ViewuseEffect_Demo = () => {

    const [userDetailsData, setUserDetailsData] = useState();
    console.log(userDetailsData)

    const handleInput = (event) => {
        debugger;
        setUserDetailsData({ ...userDetailsData, [event.target.name]: event.target.value })
    }

    const handleSubmit = async (e) => {
        e.preventDefault();
        console.log(userDetailsData)
        debugger;
        alert(userDetailsData.gender)
    }


    useEffect(() => {

        document.title = `Use Effect Demo`;

        setUserDetailsData({ firstName: "Justine", lastName: "Clement", dob: "01/01/1990", gender: "1" });

    });

    const [items, setItems] = React.useState([]);

    const GenderOptions = [
        { label: 'Male', value: '1' },
        { label: 'Female', value: '2' }
    ];


    return (
        <>
            <div className='container' >
                Welcoemt to UseEffect Demo


                <div className="col-md-6">
                    <label for="Tile">First Name:<span className="required_style">*</span></label>
                    <input name='firstName' onChange={e => handleInput(e)} value={userDetailsData?.firstName} type="text" tabindex="1" autocomplete="off" maxLength="30" className="form-control" placeholder="First Name" />
                </div>

                <div className="col-md-6">
                    <label for="Tile">Last Name:<span className="required_style">*</span></label>
                    <input name='lastName' onChange={e => handleInput(e)} value={userDetailsData?.lastName} type="text" tabindex="1" autocomplete="off" maxLength="30" className="form-control" placeholder="First Name" />
                </div>

                <div className="col-md-6">
                    <label for="Tile">Gender:<span className="required_style">*</span></label>
                    <select name='gender' onChange={e => handleInput(e)} value={userDetailsData?.gender} >
                        <option value="1"> Male</option>
                        <option select value="2"> female</option>
                    </select>
                </div>

                <div className="col-md-12">
                    <button className="btn btn-success filter-btn mr-1" onClick={(e) => handleSubmit(e)}>Save</button>
                </div>

            </div>
        </>
    );
}
export default ViewuseEffect_Demo;